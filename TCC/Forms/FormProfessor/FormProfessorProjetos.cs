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

namespace TCC.Forms.FormProfessor
{
    public partial class FormProfessorProjetos : MetroForm
    {
        private int ID_Professor;
        private Conexao c;
        public FormProfessorProjetos(int id)
        {
            InitializeComponent();
            ID_Professor = id;
            setListProjetos();
            setText();
        }
        private void setText()
        {
            using( c = new Conexao()) { 
            Text = Text + " - " + c.Professores.Find(ID_Professor).Nome;
            }
        }
        private void setListProjetos()
        {
                using( c = new Conexao())
            {
                listProjeto.DataSource = null;
                listProjeto.DataSource = c.Professores.Find(ID_Professor).Cursos.ToList();
                listProjeto.DisplayMember = "Nome";
            }
        }
        private void setListProjetos(string name)
        {
            try { 
            using (c = new Conexao())
            {
                if (rdaNiniciado.Checked)
                {
                        listProjeto.DataSource = null;
                        listProjeto.DataSource = c.Cursos.Where(p => p.Nome.StartsWith(name) && p.Data_Inicio > DateTime.Today).ToList();
                        listProjeto.DisplayMember = "Nome";
                        return;
                    }
                else if(rdaAndamento.Checked)
                {
                        listProjeto.DataSource = null;
                        listProjeto.DataSource = c.Cursos.Where(p => p.Nome.StartsWith(name) && DateTime.Today >= p.Data_Inicio && DateTime.Today <= p.Data_Final).ToList();
                        listProjeto.DisplayMember = "Nome";
                        return;
                   }
                else if (rdaFinalizado.Checked)
                {
                        listProjeto.DataSource = null;
                        listProjeto.DataSource = c.Cursos.Where(p => p.Nome.StartsWith(name) && p.Data_Final < DateTime.Today).ToList();
                        listProjeto.DisplayMember = "Nome";
                        return;
                    }

                    

            }
                }
            catch {
                return;
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void rdaNiniciado_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void rdaAndamento_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void rdaFinalizado_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void Pesquisar()
        {
            if (txtPesquisa.Text != "")
            {
                setListProjetos(txtPesquisa.Text);
            }
            else
            {
                setListProjetos();
            }

        }
        private void setDgvAulas(List<Aula> aulas)
        {
            dgvAulas.DataSource = null;
            dgvAulas.DataSource = aulas;
            dgvAulas.Columns[0].Visible = false;
        }
        private void setDgvResponsaveis( List<Responsavel> responsaveis)
        {
            dgvResponsaveis.DataSource = null;
            dgvResponsaveis.DataSource = responsaveis;
            dgvResponsaveis.Columns[0].Visible = false;
            dgvResponsaveis.Columns[3].Visible = false;
            dgvResponsaveis.Columns[4].Visible = false;
            dgvResponsaveis.Columns[5].Visible = false;
            dgvResponsaveis.Columns[6].Visible = false;
            dgvResponsaveis.Columns[7].Visible = false;
            dgvResponsaveis.Columns[8].Visible = false;

            dgvResponsaveis.Columns[9].HeaderText = "Data de Nascimento";
            dgvResponsaveis.Columns[10].HeaderText = "Data de Cadastro";


        }
        private void setDgvDependentes(List<Dependente> dependentes)
        {
            dgvDependentes.DataSource = null;
            dgvDependentes.DataSource = dependentes;
            dgvDependentes.Columns[0].Visible = false;
            dgvDependentes.Columns[4].Visible = false;
            dgvDependentes.Columns[3].HeaderText = "Data de Nascimento";
        }
        private void setForm(Curso curso)
        {
            if (curso == null)
            {
                return;
            }

     
            txtNome.Text = curso.Nome;
            txtDescricao.Text = curso.Descricao;
            txtInicio.Text = curso.Data_Inicio.ToShortDateString();
            txtFinal.Text = curso.Data_Final.ToShortDateString();

            setDgvAulas((curso.Aulas.Count()==0)? new List<Aula>(): curso.Aulas);
            setDgvDependentes((curso.Depentes.Count() == 0) ? new List<Dependente>() : curso.Depentes);
            setDgvResponsaveis((curso.Responsavel.Count() == 0) ? new List<Responsavel>() : curso.Responsavel);
        }
        private void listProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            setForm((Curso)listProjeto.SelectedItem);
        }
        private void ClearForm()
        {
            ClearForm();
            dgvAulas.DataSource = dgvDependentes.DataSource = dgvResponsaveis = null;
            txtDescricao.Text = txtFinal.Text = txtInicio.Text = txtNome.Text = "";
        }

    }
}
