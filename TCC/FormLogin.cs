using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using TCC.Model;
using System.Net.Mail;
using TCC.Forms.FormAdmin;
using TCC.Forms.FormProfessor;
using MetroFramework;
using System.Threading;

namespace TCC
{
    public partial class FormLogin : MetroForm
    {
        private Conexao c;
        public FormLogin()
        {
            InitializeComponent();
            InitDB();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
        
            if (IsValidFormEmailandPassword() && TipoConta.SelectedItem.Equals("Administrador"))
            {
                LoginAdm();
            }
            else if (IsValidFormEmailandPassword() && TipoConta.SelectedItem.Equals("Professor"))
            {
                LoginProfessor();
            }
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
        private bool IsValidFormEmailandPassword()
        {
            if (txtEmail.Text != "" && txtSenha.Text != "" && IsEmail(txtEmail.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void LoginAdm()
        {
            using(c = new Conexao()) { 
            var adm = c.Admins.Where(p => p.Email.Equals(txtEmail.Text) && p.Senha.Equals(txtSenha.Text));
            if (adm.Count() == 1) {
                    Hide();
                    new FormAdminPrincipal(adm.First(),this).Show();
                    
            }
            else
            {
                MetroMessageBox.Show(this,"Dados Invalidos ou Não Correspondente");
                    setFocus();
            }
          }
        }
        private void LoginProfessor()
        {
            using (c = new Conexao())
            {
                var prof = c.Professores.Where(p => p.Email.Equals(txtEmail.Text) && p.Senha.Equals(txtSenha.Text));
                if (prof.Count() == 1)
                {
                    new FormProfessorPrincipal(prof.First()).Show();
                    Hide();
                }
                else
                {
                    MetroMessageBox.Show(this, "Dados Invalidos ou Não Correspondente");
                    setFocus();
                }
            }
        }
        private void InitDB()
        {
            using (c = new Conexao()) {
                try {
                    if (c.Admins.Count() == 0) {
                        c.Admins.Add(new Admin { Nome = "Administrador", Email = "adm@adm.com", Senha = "adm" });
                        c.SaveChanges();
                    } 
                }
                catch {
                    return;
                }
            }

        }
        private void setFocus()
        {
            Focus();
            txtEmail.Select();
        }
        public void ClearForm() {
            txtEmail.Text = txtSenha.Text = "";
        }
    }
}
