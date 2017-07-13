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

namespace TCC.Forms.FormAdmin.ProfessorOption
{
    public partial class FormProfessorExclusao : MetroForm
    {
        private Conexao c;
        public FormProfessorExclusao()
        {
            InitializeComponent();
            setDGV();
        }
        private void setDGV()
        {
            using (c = new Conexao())
            {
                dgvProfessores.DataSource = null;
                dgvProfessores.DataSource = c.Professores.ToList();
                dgvProfessores.Columns[0].Visible = false;
                dgvProfessores.Columns[3].Visible = false;
                dgvProfessores.Columns[2].Visible = false;
                dgvProfessores.Columns[4].Visible = false;
                dgvProfessores.Columns[8].Visible = false;
            }
        }

        private void BtnExcluirProfessor_Click(object sender, EventArgs e)
        {
            if (dgvProfessores.CurrentRow != null)
            {
                Professor prof = (Professor)dgvProfessores.SelectedRows[0].DataBoundItem;
                DialogResult result = MetroMessageBox.Show(MdiParent, "Você que mesmo excluir o Professor " + prof.Nome + "! Depois da Exclusão ele não tera mais acesso ao sistema!", "Atenção", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    ExcluirProfessor(prof);
                }
                else
                {
                    MetroMessageBox.Show(MdiParent, "Operação Cancelada, Professor não Excluido");
                }
            }
            else
            {
                MetroMessageBox.Show(MdiParent, "Nenhum Professor Selecionado!");
            }
        }

        private void ExcluirProfessor(Professor prof)
        {
           
            try
            {
                using (c = new Conexao())
                {
                    if (c.Professores.Find(prof.Id).Cursos.Count()== 0)
                    {
                        c.Entry(c.Professores.Find(prof.Id)).State = System.Data.Entity.EntityState.Deleted;
                        c.SaveChanges();
                        MetroMessageBox.Show(MdiParent, "Professor Excluido com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setDGV();
                    }
                    else
                    {
                        MetroMessageBox.Show(MdiParent, "Professor Não Pode ser  Excluido, Pois ele esta associado a algum Projetos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
            catch
            {
                MetroMessageBox.Show(MdiParent, "Erro no Banco de Dados!");

            }
        }
    }
}
