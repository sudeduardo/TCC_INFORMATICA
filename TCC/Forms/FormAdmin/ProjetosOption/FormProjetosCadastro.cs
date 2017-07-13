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

namespace TCC.Forms.FormAdmin.ProjetosOption
{
    public partial class FormProjetosCadastro : MetroForm
    {
        private Conexao c;
        private List<Aula> Aulas = new List<Aula>();
        public FormProjetosCadastro()
        {
            InitializeComponent();
            setCmb();
            setMinDate();
        }
        private void setCmb()
        {
            using (c = new Conexao())
            {
                cmbProfessor.DataSource = c.Professores.ToList();
                cmbProfessor.DisplayMember = "Nome";
            }
        }
        private bool isValidForm()
        {
            if (txtNomeProjeto.Text != "" && txtDescricao.Text != "" && cmbProfessor.SelectedItem != null && (dateInicia.Value < dateFinal.Value) && dateInicia.Value != dateFinal.Value && Aulas.Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void setDgvAulas()
        {
            try
            {
            dgvAulas.DataSource = null;
            dgvAulas.DataSource = Aulas;
            dgvAulas.Columns[0].Visible = false;
            dgvAulas.Columns[2].Visible = false;
            dgvAulas.Columns[3].Visible = false;
            
                dgvAulas.Columns[4].Visible = false;
                dgvAulas.Columns[5].Visible = false;
            }
            catch
            {

            }
        }
        private void ClearDgv()
        {
            dgvAulas.DataSource = null;
        }
        private bool isValidDate()
        {
            if (dateAula.Value != null && dateAula.Value > DateTime.Today)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void setMinDate()
        {
            dateAula.MinDate = DateTime.Today;
            dateInicia.MinDate = DateTime.Today;
        }
        private void ClearForm()
        {
            dateInicia.Value = dateInicia.Value  = DateTime.Today;
            ClearDgv();
            txtDescricao.Text= txtNomeProjeto.Text="";
        }
        private bool isDateInsert(DateTime date)
        {

            if (Aulas.Where(p => p.Data == date).Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnAddAula_Click(object sender, EventArgs e)
        {
            if (isValidDate())
            {
                DateTime value = DateTime.Parse(dateAula.Value.ToShortDateString());
                if (isDateInsert(value))
                {
                    Aulas.Add(new Aula { Data = (value) });
                    setDgvAulas();
                }
                else
                {
                    MetroMessageBox.Show(MdiParent, "Data " + value.ToString("dd/MM/yyyy") + " já Cadastrada!");
                }
            }
            else
            {
                MetroMessageBox.Show(MdiParent, "Dados Invalidos");
            }
        }

        private void btnExclurAula_Click(object sender, EventArgs e)
        {
            if (dgvAulas.CurrentRow != null)
            {
                Aula aula = (Aula)dgvAulas.SelectedRows[0].DataBoundItem;
                Aulas.Remove(aula);
                setDgvAulas();
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (isValidForm())
            {
                using (c = new Conexao())
                {
                    Professor prof = (Professor)cmbProfessor.SelectedItem;
                    try
                    {
                      Curso curso=  new Curso { Aulas = Aulas, Data_Final = dateFinal.Value, Data_Inicio = dateInicia.Value, Descricao = txtDescricao.Text, Nome = txtNomeProjeto.Text, };
                        c.Professores.Find(prof.Id).Cursos.Add(curso);
                        c.SaveChanges();
                        MetroMessageBox.Show(MdiParent, "Projeto Cadastro com Sucesso!");
                        Close();
                    }
                    catch
                    {
                        MetroMessageBox.Show(MdiParent, "Erro no Banco de Dados!, Projeto Não Cadastrado");
                    }
                }
            }
        }
    }
}
