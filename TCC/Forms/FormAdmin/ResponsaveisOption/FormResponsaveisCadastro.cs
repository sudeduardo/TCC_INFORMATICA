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
using TCC.Forms.FormAdmin;
using TCC.Forms.FormAdmin.ResponsaveisOption.DependetesOption;
using TCC.Model;

namespace TCC
{
    public partial class FormResponsaveisCadastro : MetroForm
    {
        private Conexao c;
        private List<Dependente> Dependentes = new List<Dependente>();
        public FormResponsaveisCadastro()
        {
            InitializeComponent();
            setMaxDate();
        }
        private void btnAddDependentes_Click(object sender, EventArgs e)
        {
           FormAdminPrincipal frm = (FormAdminPrincipal)MdiParent;
            FormDepententesCadastro frmCadastroDep = new FormDepententesCadastro(Dependentes);
            frmCadastroDep.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDepententesCadastro_FormClosing);
            frm.OpenMdiForm(frmCadastroDep);
        }
        private void FormDepententesCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            setDgvDependentes();
        }

        private void setDgvDependentes()
        {
            dgvDependentes.DataSource = null;
            dgvDependentes.DataSource = Dependentes;
            dgvDependentes.Columns[0].Visible = false;
            dgvDependentes.Columns[3].HeaderText = "Data de Nascimento";
        }
        private void setMaxDate()
        {
            DataNascimento.MaxDate = DateTime.Today;
        }
        private bool isValidForm()
        {
            double cpf, n, numero;
            if (txtNome.Text !="" && txtEmail.Text !="" && IsEmail(txtEmail.Text) && double.TryParse(txtCpf.Text,out cpf) && txtCpf.Text!="" && txtCelular.Text !="" && double.TryParse(txtCelular.Text, out numero) && txtRua.Text !="" && txtN.Text !="" && double.TryParse(txtN.Text,out n) && txtBairro.Text !="" && txtCidade.Text !="")
            {
                return true;
            }
            return false;
        }
        private bool IsEmail(string email)
        {
            try
            {
                var mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnExcluirDependentes_Click(object sender, EventArgs e)
        {
            if(dgvDependentes.SelectedRows[0].DataBoundItem != null)
            {
                Dependente dep = (Dependente)dgvDependentes.SelectedRows[0].DataBoundItem;
                Dependentes.Remove(dep);
                setDgvDependentes();
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (isValidForm())
            {
                try {
                    using( c = new Conexao())
                    {
                        c.Responsaveis.Add(new Responsavel { Dependentes =Dependentes, Nome = txtNome.Text, Email = txtEmail.Text, CPF = txtCpf.Text, Cidade = txtCidade.Text, Numero =txtN.Text,  Rua = txtRua.Text, Data_Nascimento = DataNascimento.Value, Celular = txtCelular.Text, Data_Associacao = DateTime.Today, Bairro = txtBairro.Text });
                        c.SaveChanges();
                        MetroMessageBox.Show(MdiParent, "Responsavel Cadastrado com Sucesso!");
                        Close();
                    }
                } catch {
                    MetroMessageBox.Show(MdiParent, "Erro ao Cadastrar o Novo Responsavel");
                }
            }else
            {
                MetroMessageBox.Show(MdiParent, "Dados Invalidos!");
            }
        }
    }

}
