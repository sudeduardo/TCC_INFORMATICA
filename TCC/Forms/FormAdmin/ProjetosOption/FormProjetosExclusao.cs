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
using System.Runtime.Serialization;

namespace TCC.Forms.FormAdmin.ProjetosOption
{
    public partial class FormProjetosExclusao : MetroForm
    {
        private Conexao c;
        public FormProjetosExclusao()
        {
            InitializeComponent();
            setListProjetos();
        }
        private void setListProjetos() {
            using( c = new Conexao())
            {
                listProjeto.DataSource = null;
                listProjeto.DataSource = c.Cursos.ToList();
                listProjeto.DisplayMember = "Nome";
            }
            
        }
        private void FormProjeto(Curso curso)
        {
            lblNome.Text = curso.Nome;
            try { lblProfessor.Text = c.Professores.Where(p => p.Cursos.Where(j => j.Id == curso.Id).Count() == 1).First().Nome; } catch { lblProfessor.Text = ""; }
               
            txtDesc.Text = curso.Descricao;
            lblFinal.Text = curso.Data_Final.ToString("dd/MM/yyyy");
            llblInicial.Text = curso.Data_Inicio.ToString("dd/MM/yyyy");
            setDgv(curso.Aulas);

        }
        private void  setDgv(List<Aula> aulas)
        {
            dgvAulas.DataSource = null;
            dgvAulas.DataSource = aulas;
            dgvAulas.Columns[0].Visible = false;
            dgvAulas.Columns[2].Visible = false;
        }

        private void listProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listProjeto.SelectedItem != null)
            {
                Curso p =(Curso) listProjeto.SelectedItem;
                FormProjeto(p);
            }
        }

        private void BtnExcliuirProjeto_Click(object sender, EventArgs e)
        {
            if (isValidForm() && Message())
            {
                try { 
                using (c = new Conexao()) { 

                    Curso curso = c.Cursos.Find(((Curso)(listProjeto.SelectedItem)).Id);
                    curso.Depentes.Clear();
                    curso.Responsavel.Clear();
                    curso.Aulas.Clear();

                    c.Entry(curso).State = System.Data.Entity.EntityState.Modified;
                    c.SaveChanges();

                    c.Entry(curso).State = System.Data.Entity.EntityState.Deleted;
                    c.SaveChanges();

                    MetroMessageBox.Show(this, "Sucesso Projeto Excluido");
                  }
                }
                catch(Exception ex)
                {
                    MetroMessageBox.Show(this, "Erro no banco de dados!");
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Operação Cancelada, Projeto não Excluido");
            }
           
        }
        private  bool isValidForm()
        {
            if(listProjeto.SelectedItem != null)
            {
                return true;
            }
            return false;
        }
        private bool Message(){
           DialogResult msg =  MetroMessageBox.Show(this, "Ao excluir este projeto todos os dados relacionados a ele, será excluido como chamadas, e a matricula de responsaveis e dependetes que estejam frequentando este Projeto!","Atenção", MessageBoxButtons.OKCancel);
            if(msg == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
    }
}
