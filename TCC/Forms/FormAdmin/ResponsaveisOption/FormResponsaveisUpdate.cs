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
using TCC.Forms.FormAdmin;
using TCC.Forms.FormAdmin.ResponsaveisOption.DependetesOption;
using TCC.Model;

namespace TCC
{
    public partial class FormResponsaveisUpdate : MetroForm
    {
        private Conexao c;
        private Responsavel responsavel;
        public FormResponsaveisUpdate()
        {
            InitializeComponent();
            setListProjeto();
        }
        private void btnAlterDependente_Click(object sender, EventArgs e)
        {
            try { 
            if(dgvDependentes.SelectedRows[0].DataBoundItem != null)
            {
                Dependente dep = (Dependente)dgvDependentes.SelectedRows[0].DataBoundItem;

                FormDependenteUpdate frm_dep = new FormDependenteUpdate(dep);
                   frm_dep.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormDependente_FormClosed);
                 var frm = (FormAdminPrincipal)this.MdiParent;
                    frm.OpenMdiForm(frm_dep);
                }
            }
            catch
            {

            }

        }
        private void btnExcluirDependentes_Click(object sender, EventArgs e)
        {
            if (MenssagenDependentesExcluir())
            {
                Dependente dep = (Dependente)dgvDependentes.SelectedRows[0].DataBoundItem;
                try {
                    using( c = new Conexao())
                    {
                        dep = c.Dependentes.Find(dep.Id);
                        c.Dependentes.Remove(dep);
                        c.SaveChanges();
                        MetroMessageBox.Show(this, dep.Nome + " Excluido com Sucesso!");
                        setListProjeto();
                        setDGV();
                    }
                } catch {
                    MetroMessageBox.Show(this, "Erro ao excluir o dependente" + dep.Nome + "!");
                }
            }
        }
        private void btnAddDepentne_Click(object sender, EventArgs e)
        {
            FormDepententesCadastroInner frm_dep = new FormDepententesCadastroInner(responsavel.Id);
            frm_dep.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormDependente_FormClosed);
            var frm = (FormAdminPrincipal)this.MdiParent;
            frm.OpenMdiForm(frm_dep);
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (isValidForm() && MenssagenResponsaveisExcluir())
            {
                try {
               using(c = new Conexao())
                    {
                        responsavel = c.Responsaveis.Find(responsavel.Id);

                        responsavel.Bairro = txtBairro.Text;
                        responsavel.Celular = txtCelular.Text;
                        responsavel.Cidade = txtCidade.Text;
                        responsavel.Numero = txtN.Text;
                        responsavel.Rua = txtRua.Text;
                        responsavel.Email = txtEmail.Text;
                        responsavel.CPF = txtCpf.Text;
                        responsavel.Nome = txtNome.Text;

                        c.Entry(responsavel).State = System.Data.Entity.EntityState.Modified;
                        c.SaveChanges();
                        setListProjeto();
                        setDGV();
                        MetroMessageBox.Show(this, "Dados Alterados com Sucesso!", "Sucesso");

                    }
                } catch(Exception ex) {
                    MetroMessageBox.Show(this, "Erro aos tentar alterar dados!", "Erro");
                }   
            }
        }
        private void FormDependente_FormClosed(object sender, FormClosedEventArgs e)
        {
            setListProjeto();
            setDGV();
        }   
        private void listResponsaveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listResponsaveis.SelectedItem != null)
            {
                Responsavel p = (Responsavel)listResponsaveis.SelectedItem;
                responsavel = p;
                setFormResonsavel();
            }
        }
        private void setListProjeto()
        {
            try
            {
                using (c = new Conexao())
                {
                    listResponsaveis.DataSource = null;
                    listResponsaveis.DataSource = c.Responsaveis.ToList();
                    listResponsaveis.DisplayMember = "Nome";
                }
            }
            catch
            {

            }
        }
        private void setFormResonsavel()
        {
            txtBairro.Text = responsavel.Bairro;
            txtCelular.Text = responsavel.Celular;
            txtCidade.Text = responsavel.Cidade;
            txtN.Text = responsavel.Numero;
            txtRua.Text = responsavel.Rua;
            txtEmail.Text = responsavel.Email;
            txtCpf.Text = responsavel.CPF;
            txtNome.Text = responsavel.Nome;
            setDGV();
        }
        private void setDGV()
        {
            dgvDependentes.DataSource = responsavel.Dependentes;
            dgvDependentes.Columns[0].Visible = false;
            dgvDependentes.Columns[4].Visible = false;
            dgvDependentes.Columns[3].HeaderText = "Nascimento";

        }
        private void ClearForm()
        {
            txtBairro.Text = "";
            txtCelular.Text = "";
            txtCidade.Text = "";
            txtN.Text = "";
            txtRua.Text = "";
            txtEmail.Text = "";
            txtCpf.Text = "";
            txtNome.Text = "";
            dgvDependentes.DataSource = null;
        }
        private bool MenssagenDependentesExcluir()
        {
            DialogResult msg = MetroMessageBox.Show(this, "Ao excluir este Dependentes todos os dados relacionados a ele, será excluido como chamadas, e a matricula de responsaveis e projetos que estejam frequentando este Projeto!", "Atenção", MessageBoxButtons.OKCancel);
            if (msg == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
        private bool MenssagenResponsaveisExcluir()
        {
            DialogResult msg = MetroMessageBox.Show(this, "Ao mudar os dados referentes aqui exposto, não havera maneira voltar aos dados originais, Quer mesmo finalizar?", "Atenção", MessageBoxButtons.OKCancel);
            if (msg == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
        private bool isValidForm()
        {
            double cpf, n;
           if(
            txtBairro.Text != ""  &&
            txtCelular.Text != "" &&
            txtCidade.Text != ""  &&
            txtN.Text != ""       &&
            txtRua.Text != ""     &&
            txtEmail.Text != ""   &&
            txtCpf.Text != ""     &&
            txtNome.Text != ""    &&
            double.TryParse(txtCpf.Text, out cpf)&&
            double.TryParse(txtN.Text, out n)&& 
            txtCpf.Text.Length ==11)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

    }
 }

