using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Model;

namespace TCC.Forms.FormAdmin.ResponsaveisOption.DependetesOption
{
    public partial class FormDepententesCadastroInner : MetroForm
    { private Conexao c;
        private int id;
        public FormDepententesCadastroInner(int id)
        {
            InitializeComponent();
            this.id = id;
            setDateMax();
        }
       
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (isValidForm())
            {
                using (c= new Conexao())
                {
                    Responsavel resp= c.Responsaveis.Find(id);
                    resp.Dependentes.Add(new Dependente { CPF = txtCPF.Text, Nome = txtNome.Text, Telefone = txtCelular.Text, Data_Nascimento = dtaNasc.Value });
               
                    c.Entry(resp).State = System.Data.Entity.EntityState.Modified;
                    c.SaveChanges();
                    MetroMessageBox.Show(this, "Dependente "+txtNome.Text+" adicionado ao Resonsavel "+ resp.Nome+"!");
                    Close();
                }
                
            }
            else
            {
                MetroMessageBox.Show(this, "Dados Invalidos");
            }
        }
        private bool isValidForm()
        {
            double cpf, n;
            if (txtNome.Text != ""  && double.TryParse(txtCPF.Text, out cpf) && txtCPF.Text.Length == 11 && txtCelular.Text != "" && double.TryParse(txtCelular.Text, out n) && dtaNasc.Value<DateTime.Today)
            {
                return true;
            }
            return false;
        }
        private void setDateMax()
        {
            dtaNasc.MaxDate = DateTime.Today;
        }

        
    }
}
