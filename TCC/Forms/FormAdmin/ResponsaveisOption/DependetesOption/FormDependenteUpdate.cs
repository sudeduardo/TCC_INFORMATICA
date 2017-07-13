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

namespace TCC.Forms.FormAdmin.ResponsaveisOption.DependetesOption
{
    public partial class FormDependenteUpdate : MetroForm
    {
        private Conexao c;
        private Dependente Dependente;
        public FormDependenteUpdate(Dependente dep)
        {
            InitializeComponent();
            dateNasc.MaxDate = DateTime.Today;
            Dependente = dep;
            setForm();
        }
        private void setForm()
        {
            txtCelular.Text = Dependente.Telefone;
            txtCPF.Text = Dependente.CPF;
            txtNomeDependentes.Text = Dependente.Nome;
            dateNasc.Value = Dependente.Data_Nascimento;
        }
        private bool isValidForm()
        {
            double CPF, N;
            if (txtCelular.Text != "" && txtNomeDependentes.Text != "" && txtCPF.Text != "" && double.TryParse(txtCPF.Text, out CPF) && double.TryParse(txtCelular.Text, out N))
                return true;
            else
                return false;
        }
        private void Atulizar()
        {
            if (isValidForm())
            {
                try { 
                using(c =new Conexao()) {
                Dependente = c.Dependentes.Find(Dependente.Id);
                Dependente.Telefone = txtCelular.Text;
                Dependente.CPF = txtCPF.Text;
                Dependente.Nome= txtNomeDependentes.Text;
                Dependente.Data_Nascimento = dateNasc.Value;
                c.Entry(Dependente).State = System.Data.Entity.EntityState.Modified;
                c.SaveChanges();
                Close();
                }
              }
                catch
                {

                }
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atulizar();
        }  
    }
}
