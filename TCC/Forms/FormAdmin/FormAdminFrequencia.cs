using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Forms.FormAdmin;
using TCC.Model;

namespace TCC.Forms.FormAdmin
{
    public partial class FormAdminFrequencia : MetroForm
    {
        private Conexao c;
        public FormAdminFrequencia()
        {
            InitializeComponent();
            setListProjeto();
        }
        private void setListProjeto()
        {
            using (c = new Conexao())
            {
                listProjeto.DataSource = null;
                listProjeto.DataSource = c.Cursos.ToList();
                listProjeto.DisplayMember = "Nome";

            }
        }
        private void setListProjeto(string pesq)
        {
            using (c = new Conexao())
            {
                listProjeto.DataSource = null;
                listProjeto.DataSource = c.Cursos.Where(p=>p.Nome.StartsWith(pesq)).ToList();
                listProjeto.DisplayMember = "Nome";

            }
        }

        private void listProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listProjeto.SelectedItem != null)
            {
                Curso curso = (Curso)listProjeto.SelectedItem;
                setForm(curso);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != null)
                setListProjeto(txtPesquisa.Text);
            else
                setListProjeto();
                
        }
        private void ClearForm()
        {
            dtFinal.Text =
            dtInicio.Text = "";
            txtProfessor.Text = "";
            dgvFrequenciaDependentes.DataSource = null;
        }
        private void setForm(Curso curso)
        {
            ClearForm();
            dtFinal.Value = curso.Data_Final;
            dtInicio.Value = curso.Data_Inicio;
            txtProfessor.Text = getNameProfessor(curso);
            setList(curso);
        }
        private string getNameProfessor(Curso curso)
        {
            string str;
            try
            {
                using (Conexao k = new Conexao())
                {
                    str = k.Professores.Where(p => p.Cursos.Where(j => j.Id == curso.Id).Count() == 1).First().Nome;
                }
            }
            catch (Exception ex)
            {
                str ="";
            }
            return str;
        }
        private void setList(Curso curso)
        {
            using ( c = new Conexao())
            {   
                curso = c.Cursos.Find(curso.Id);
                cmbAulas.DataSource = curso.Aulas;
                cmbAulas.DisplayMember = "Data";
            }

        }

        private void cmbAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAulas.SelectedItem != null) {
            Aula aula = (Aula)cmbAulas.SelectedItem;
                txtResumo.Text = aula.Resumo;
                setDgvDependente(aula);
                setDgvResponsaveis(aula);
           }
        }
        private void setDgvDependente(Aula aula)
        {
            ChamadaDependente chm = new ChamadaDependente(id_aula:aula.Id);
            dgvFrequenciaDependentes.DataSource = null;
            dgvFrequenciaDependentes.DataSource = chm.Chamada();
            dgvFrequenciaDependentes.Columns[0].Visible = dgvFrequenciaDependentes.Columns[1].Visible = false;
            dgvFrequenciaDependentes.Columns[3].HeaderText = "Presença";
        }
        private void setDgvResponsaveis(Aula aula)
        {
            ChamadaResponsavel chm = new ChamadaResponsavel(id_aula: aula.Id);
            dgvFrequenciaResponsaveis.DataSource = null;
            dgvFrequenciaResponsaveis.DataSource = chm.Chamada();
            dgvFrequenciaResponsaveis.Columns[0].Visible = dgvFrequenciaResponsaveis.Columns[1].Visible = false;
            dgvFrequenciaResponsaveis.Columns[3].HeaderText = "Presença";
        }
    }
}
