using MetroFramework;
using MetroFramework.Forms;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Model;

namespace TCC.Forms.FormAdmin.AdminOption
{
    public partial class FormAdminCadastro : MetroForm
    {
        public FormAdminCadastro()
        {
            InitializeComponent();
        }
        private void sendEmail(Admin adm)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("EmailRemetende");
                mail.To.Add(adm.Email);
                mail.IsBodyHtml = true;
                mail.Subject = "Bem Vindo - " + adm.Nome;
                mail.Body = "Você foi cadastrado em nosso Sistema<br>" +
                             "Seu Dados<br>" +
                             "Login: " + adm.Email + "<br>" +
                             "Senha: " + adm.Senha + "<br>" +
                             "<hr><br>Use esse dados para acesar o programa!";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("email", "SenhaEmail");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MetroMessageBox.Show(this, "Administrador Cadastrado com Sucesso! Um email com mais informações foi enviado a ele!");
            }
            catch
            {
                MessageBox.Show("Erro ao enviar E-mail, verifique se o Email existe ou se você esta conectado a Internet");
            }
        }
        private void CadastrarAdmin(string Email, string Nome)
        {
            using (Conexao c = new Conexao())
            {
                if (Internet() && isValidEmailOnline(Email).IsValid == 1)
                {
                    Admin adm = new Admin { Email = Email, Nome = Nome, Senha = RandomString(6) };
                    try
                    {
                        c.Admins.Add(adm);
                        c.SaveChanges();
                        sendEmail(adm);
                    }
                    catch
                    {
                        MetroMessageBox.Show(MdiParent, "Erro ao Cadastrar o Novo Administrador");
                    }
                }
                else
                {
                    MetroMessageBox.Show(MdiParent, "Sem Acesso a Internet ou Email não é valido!");
                }
            }
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

            if (isFormValid())
            {
                CadastrarAdmin(txtAdminEmail.Text, txtAdminNome.Text);
            }
        }
        private bool isFormValid()
        {
            if (txtAdminEmail.Text != "" && txtAdminNome.Text != "" && IsEmail(txtAdminEmail.Text))
            {
                return true;
            }
            else
            {
                return false;
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
        private static string RandomString(int Size)
        {
            Random random = new Random();
            string input = "abcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, Size)
                                   .Select(x => input[random.Next(0, input.Length)]);
            return new string(chars.ToArray());
        }
        private static Email isValidEmailOnline(string email)
        {
            var client = new RestClient("http://api.emailvalidator.co/");
            var request = new RestRequest("?AccessKey=ae8c91a6.c9a5.4dc7.bf34.d6d39dc17da0&EmailAddress=" + email + "&VerificationLevel=3");
            var result = client.Execute(request);
            return new JsonDeserializer().Deserialize<Email>(result);
        }
        private bool Internet()
        {
            if (NetworkInterface.GetIsNetworkAvailable() == true)
                return true;
            else
                return false;
        }
    }
}
