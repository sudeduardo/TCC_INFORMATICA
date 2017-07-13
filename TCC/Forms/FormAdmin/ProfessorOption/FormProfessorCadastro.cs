using MetroFramework;
using MetroFramework.Forms;
using RestSharp;
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

namespace TCC.Forms.FormAdmin.ProfessorOption
{
    public partial class FormProfessorCadastro : MetroForm
    {
        private Conexao c;
        public FormProfessorCadastro()
        {
            InitializeComponent();
            setMaxDate();
        }

        private bool isValidForm()
        {
            double CPF,n,numero;
            if(
                txtNomeProfessor.Text != "" && txtEmailProfessor.Text != "" &&
                txtCpfProfessor.Text !="" && double.TryParse(txtCpfProfessor.Text,out CPF) &&
                txtCpfProfessor.Text.Length ==11 && txtCelularProfessor.Text != "" && 
                double.TryParse(txtCelularProfessor.Text,out n)&& txtRuaProfessor.Text !="" && 
                txtEnderecoNProfessor.Text!="" && txtBairroProfessor.Text !="" 
                && txtCidadeProfessor.Text != "" && double.TryParse(txtEnderecoNProfessor.Text,out numero))
            {
                return true;
            }else
            {
                return false;
            }

        }
        private string getEndereco()
        {
            if (isValidForm()) {
                return txtRuaProfessor.Text +" - "+txtEnderecoNProfessor.Text+" - "+txtBairroProfessor.Text+" - "+txtCidadeProfessor.Text;
            }
            else
            {
                return "";
            }
        }
        private void setMaxDate()
        {
            DataNascimento.MaxDate = DateTime.Today;
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
        private void BtnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            CadastrarProfessor(txtNomeProfessor.Text,txtEmailProfessor.Text,txtCpfProfessor.Text, txtCelularProfessor.Text,getEndereco(),DataNascimento.Value);
        }
        private void CadastrarProfessor(string Nome, string Email, string CPF, string Celular, string Endereco,DateTime dataNasc) {
            if (isValidForm())
            {
                using (c = new Conexao())
                {
                    if (Internet() && isValidEmailOnline(Email).IsValid == 1)
                    {
                        Professor p = new Professor { Nome = Nome, Email= Email, CPF = CPF, Celular = Celular, Endereco = Endereco, Data_Nascimento = dataNasc, Data_Cadastro = DateTime.Now,Senha = RandomString(6)};
                        try
                        {
                            c.Professores.Add(p);
                            c.SaveChanges();
                            sendEmail(p);
                            Close();
                        }
                        catch
                        {
                            MetroMessageBox.Show(MdiParent, "Erro ao Cadastrar o Novo Professor!");
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(MdiParent, "Sem Acesso a Internet ou Email não é valido!");
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(MdiParent, "Dados Invalidos ou não Preenchido Corretamente");
            }
        }
        private void sendEmail(Professor prof)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("EmailRementente");
                mail.To.Add(prof.Email);
                mail.IsBodyHtml = true;
                mail.Subject = "Bem Vindo - " + prof.Nome;
                mail.Body = "Você foi cadastrado em nosso Sistema<br>" +
                             "Seu Dados<br>" +
                             "Login: " + prof.Email + "<br>" +
                             "Senha: " + prof.Senha + "<br>" +
                             "<hr><br>Use esse dados para acesar o programa!";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("login", "senhaEmail");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MetroMessageBox.Show(this, "Professor Cadastrado com Sucesso! Um email com mais informações foi enviado a ele!");
            }
            catch
            {
                MetroMessageBox.Show(this,"Erro ao enviar E-mail, verifique se o Email existe ou se você esta conectado a Internet");
            }
        }
    }
}
