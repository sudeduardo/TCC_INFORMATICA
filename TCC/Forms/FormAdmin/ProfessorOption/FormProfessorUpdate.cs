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
    public partial class FormProfessorUpdate : MetroForm
    {
        private Conexao c;
        public FormProfessorUpdate()
        {
            InitializeComponent();
            setListBox();
            setMaxDate();
        }
        private void setListBox() {
            using (c = new Conexao()) {
                listProfessores.DataSource = c.Professores.ToList();
                listProfessores.DisplayMember = "Nome";
            }
        }
        private void setFormProfessor(Professor prof) {
            txtNome.Text =  prof.Nome;
            txtEmail.Text = prof.Email;
            txtCpf.Text = prof.CPF;
            txtCelular.Text = prof.Celular;
            DataNascimento.Value = prof.Data_Nascimento;

            string[] endereco = Endereco(prof.Endereco);
            txtRua.Text = endereco[0];
            txtN.Text = endereco[1];
            txtBairro.Text = endereco[2];
            txtCidade.Text = endereco[3];

        }
     
        private string[] Endereco(string str)
        {
            return str.Split('-');
        }

        private void listProfessores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProfessores.SelectedItem != null) {
                Professor p = (Professor)listProfessores.SelectedItem;
                setFormProfessor(p);
            }
        }


        private void BtnAlterar_Click(object sender, EventArgs e)
        {

            if (isValidForm() && Internet() && isValidEmailOnline(txtEmail.Text).IsValid == 1 && listProfessores.SelectedItem != null)
            {
                Professor prof = (Professor)listProfessores.SelectedItem;
                using (c = new Conexao())
                {
                    try
                    {
                        prof.Celular = txtCelular.Text;
                        prof.CPF = txtCpf.Text;
                        prof.Data_Nascimento = DataNascimento.Value;
                        prof.Email = txtEmail.Text;
                        prof.Nome = txtNome.Text;
                        prof.Endereco = getEndereco();
                        c.Entry(prof).State = System.Data.Entity.EntityState.Modified;
                        c.SaveChanges();
                        MetroMessageBox.Show(MdiParent, "Professor atualizado com Sucesso!");
                        setListBox();
                    }
                    catch
                    {
                        MetroMessageBox.Show(MdiParent, "Erro ao Atualizar o  Professor!");
                    }
                }
            }
            else {
                MetroMessageBox.Show(MdiParent, "Dados Preenchido Incorretamente ou Sem Acesso a Internet");
            }
             
        }
        private static Email isValidEmailOnline(string email)
        {
            var client = new RestClient("http://api.emailvalidator.co/");
            var request = new RestRequest("?AccessKey=ae8c91a6.c9a5.4dc7.bf34.d6d39dc17da0&EmailAddress=" + email + "&VerificationLevel=3");
            var result = client.Execute(request);
            return new JsonDeserializer().Deserialize<Email>(result);
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
        private bool isValidForm()
        {
            double CPF, n, numero;
            if (
                txtNome.Text != "" && txtEmail.Text != "" &&
                txtCpf.Text != "" && double.TryParse(txtCpf.Text, out CPF) &&
                txtCpf.Text.Length == 11 && txtCelular.Text != "" &&
                double.TryParse(txtCelular.Text, out n) && txtRua.Text != "" &&
                txtN.Text != "" && txtBairro.Text != ""
                && txtCidade.Text != "" && double.TryParse(txtN.Text, out numero) && IsEmail(txtEmail.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private string getEndereco()
        {
            if (isValidForm())
            {
                return txtRua.Text + " - " + txtN.Text + " - " + txtBairro.Text + " - " + txtCidade.Text;
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
        private bool Internet()
        {
            if (NetworkInterface.GetIsNetworkAvailable() == true)
                return true;
            else
                return false;
        }
    }
}
