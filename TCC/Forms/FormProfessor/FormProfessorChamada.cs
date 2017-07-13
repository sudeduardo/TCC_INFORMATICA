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
using TCC.Model;

namespace TCC.Forms.FormProfessor
{
    public partial class FormProfessorChamada : MetroForm
    {
        private Conexao c;
        private Professor prof;
        public FormProfessorChamada(int id)
        {
            InitializeComponent();
            setProfessor(id);
            setCbmProfessor();
        }
        private void setCbmProfessor()
        {
            using (c = new Conexao())
            {
                cmbProjetos.DataSource = null;
                cmbProjetos.DataSource = c.Professores.Find(prof.Id).Cursos;
                cmbProjetos.DisplayMember = "Nome";
            }
        }
        private void setProfessor(int id ) {
            using( c = new Conexao())
            {
                prof = c.Professores.Find(id);
            }
        }

        private void cmbProjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbProjetos.SelectedItem != null)
            {
                Curso curso = (Curso)cmbProjetos.SelectedItem;
                using(c = new Conexao())
                {
                    cmbAulas.DataSource = null;
                    List<Aula> aulas = c.Cursos.Find(curso.Id).Aulas.Where(p => p.Data <= DateTime.Today).ToList();
                    cmbAulas.DataSource = aulas;
                    cmbAulas.DisplayMember = "Data";
                }
            }
        }

        private void cmbAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAulas.SelectedItem != null)
            {
                setDgvDependentes();
                setDgvResponsaveis();
            }
        }

        private void BtnChamada_Click(object sender, EventArgs e)
        {
            List<ChamadaDependente> chm_dep_atualizada = (List<ChamadaDependente>) dgvFrequenciaDependentes.DataSource;
            chm_dep_atualizada[0].SaveChamada(chm_dep_atualizada,txtResumo.Text);
            Aula aula = (Aula)cmbAulas.SelectedItem;
            ChamadaDependente chm_dep = new ChamadaDependente(aula.Id);
            MetroMessageBox.Show(owner: this, buttons: MessageBoxButtons.OK, title: "sucesso", message: "Chamada de Dependentes feita/atualizada com sucesso");
            setDgvDependentes();
        }

        private void setDgvDependentes()
        {
            Aula aula = (Aula)cmbAulas.SelectedItem;
            txtResumo.Text = aula.Resumo;
            ChamadaDependente chm_dep = new ChamadaDependente(aula.Id);
            dgvFrequenciaDependentes.DataSource = null;
            dgvFrequenciaDependentes.DataSource = chm_dep.Chamada();
            dgvFrequenciaDependentes.Columns[0].Visible = dgvFrequenciaDependentes.Columns[1].Visible = false;
        }

        private void setDgvResponsaveis()
        {
            Aula aula = (Aula)cmbAulas.SelectedItem;
            txtResumo.Text = aula.Resumo;
            ChamadaResponsavel chm_dep = new ChamadaResponsavel(aula.Id);
            dgvFrequenciaResponsaveis.DataSource = null;
            dgvFrequenciaResponsaveis.DataSource = chm_dep.Chamada();
            dgvFrequenciaResponsaveis.Columns[0].Visible = dgvFrequenciaResponsaveis.Columns[1].Visible = false;
        }

        private void btnSalvarResponsaveis_Click(object sender, EventArgs e)
        {
            List<ChamadaResponsavel> chm_dep_atualizada = (List<ChamadaResponsavel>)dgvFrequenciaResponsaveis.DataSource;
            chm_dep_atualizada[0].SaveChamada(chm_dep_atualizada, txtResumo.Text);
            Aula aula = (Aula)cmbAulas.SelectedItem;
            ChamadaResponsavel chm_dep = new ChamadaResponsavel(aula.Id);
            MetroMessageBox.Show(owner: this, buttons: MessageBoxButtons.OK, title: "sucesso", message: "Chamada de Responsaveis feita/atualizada com sucesso");

            setDgvResponsaveis();
        }
    }
}
