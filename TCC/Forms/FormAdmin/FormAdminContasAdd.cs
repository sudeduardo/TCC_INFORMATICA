using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Model;

namespace TCC.Forms.FormAdmin
{
    public partial class FormAdminContasAdd : MetroForm
    {
        private Conexao c;
        public FormAdminContasAdd()
        {
            InitializeComponent();
        }
        private void BtnSalvarLancamento_Click(object sender, EventArgs e)
        {
            int valor;
            if (isFormValid() && int.TryParse(txtValor.Text, out valor)) {
                try {
                    using (c = new Conexao()) {
                        c.Contas.Add(new Contas { Data_Lancamento = DateTime.Today, Data_Contribuicao = dataLancamento.Value, Descricao = txtDescricao.Text, Valor = valor });
                        c.SaveChanges();
                        MetroMessageBox.Show(this, "Lançamento Efetudado com Sucesso!");
                        Close();
                    }
                } catch {
                    MetroMessageBox.Show(this, "Erro ao Fazer Lançamento");
                }
            }
        }
        private bool isFormValid() {
            if (txtDescricao.Text != "" && txtValor.Text != "" && dataLancamento.Value != null) {
                return true;
            }
            else
            {
                return false;
            }
        }
     
        
    }
}
