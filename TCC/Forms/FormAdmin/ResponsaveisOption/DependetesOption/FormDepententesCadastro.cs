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
    public partial class FormDepententesCadastro : MetroForm
    {
        private List<Dependente> Dependentes;
        public FormDepententesCadastro(List<Dependente> dep)
        {
            InitializeComponent();
            Dependentes = dep;
            setDateMax();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (isValidForm())
            {
                Dependentes.Add(new Dependente { CPF = txtCPF.Text, Nome = txtNome.Text, Telefone = txtCelular.Text, Data_Nascimento = dtaNasc.Value });
                Close();
            }
            else
            {
                MetroMessageBox.Show(MdiParent, "Dados Invalidos");
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
