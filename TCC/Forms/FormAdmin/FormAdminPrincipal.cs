using MetroFramework.Forms;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Forms.FormAdmin.AdminOption;
using TCC.Forms.FormAdmin.ProfessorOption;
using TCC.Forms.FormAdmin.ProjetosOption;
using TCC.Model;

namespace TCC.Forms.FormAdmin
{
    public partial class FormAdminPrincipal : MetroForm
    {
        #region FormAdmin
        public Admin adm;
        private FormLogin login;
        public FormAdminPrincipal(Admin administrador, FormLogin f)
        {
            InitializeComponent();
            //Adm Form
            setAdmin(administrador);
            setFormLogin(f);
            //Cor do Backgroud do MDi
            ColorBackMdi();

        }
        //Define o Login do Form Principal
        private void setFormLogin(FormLogin f) {
            login = f;
        }
        //Define o Adm do Form Principal
        private void setAdmin(Admin a)
        {
            adm = a;
            Text = "Bem Vindo - " + a.Nome;
        }
        //Form Contas
        private void menuStripContas_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormAdminContas());
        }
        //Form Frequencia
        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           OpenMdiForm(new FormAdminFrequencia());
        }
        #endregion

        #region Mdi do Formulario Principal

        //Cor do fundo do Mdi
        private void ColorBackMdi()
        {
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc) {
                    Debug.Print(exc.Message);
                }
            }
        }

        //Abre no modo Mdi veridicando se já esta aberto ou nao
        public void OpenMdiForm(MetroForm frm)
        {
            frm.Resizable = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.BorderStyle = MetroFormBorderStyle.FixedSingle;
            var f = FormOpened(frm);
            if (f != null)
            {

                f.BringToFront();
                f.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        //Verifica se Já esta aberto algum formulario
        public Form FormOpened(Form f)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == f.GetType())
                {
                    return OpenForm;
                }
            }

            return null;
        }

        #endregion

        #region Formularios Menu Strip

        #region Admin

        //Form para Alterar Senha
        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormAdminAlterarSenha(adm.Id));
        }

        //Form para Cadastrar Admin
        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormAdminCadastro());
        }
        //Form para Excluir Admin
        private void exclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormAdminExclusao(adm.Id));
        }
        private void stripMenuSair_Click(object sender, EventArgs e)
        {
            login.ClearForm();
            login.Show();
            Close(); 
        }
        #endregion

        #region Professor
        //Form Cadastrar Professor
        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormProfessorCadastro());
        }

        //Form Exclusao Professor
        private void exclusãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormProfessorExclusao());
        }
        //Form Alterar Professor
        private void atualizarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormProfessorUpdate());
        }
        #endregion

        #region Responsaveis

        //Form Responsavel Cadastro
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormResponsaveisCadastro());
        }
        //Form Responsavel Update
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormResponsaveisUpdate());
        }

        #endregion

        #region Projetos

        //Form Pesquisar Projetos
        private void stripMenuPesquisarProjetos_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormProjetosPesquisa());
        }
        //Form Cadastro Projetos
        private void stripMenuCadastroProjetos_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormProjetosCadastro());
        }
       
        //Form Exclusao Projetos
        private void stripMenuExclusaoProjetos_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormProjetosExclusao());
        }
        //Form Matricula Projetos
        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormProjetoMatricula());
        }


        #endregion

        #endregion

        private void FormAdminPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
