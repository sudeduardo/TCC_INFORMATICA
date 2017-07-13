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
    public partial class FormProjetoMatricula : MetroForm
    {
        private Conexao c;
        public FormProjetoMatricula()
        {
            InitializeComponent();
            setCbmProjetos();
        }
        private bool isSet(Dependente dep, Curso curso)
        {
            try
            {
               
                    if (c.Dependentes.Find(dep.Id).Cursos.Find(p => p.Id == curso.Id) == null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            catch
            {
                return true;
            }
        }
        private bool isSet(Responsavel res, Curso curso)
        {
            try
            {
                if (c.Responsaveis.Find(res.Id).Cursos.Find(p=>p.Id == curso.Id) == null) {
                        return false;
                    } else {
                        return true;
                    }
            }
            catch
            {
                return true;
            }
        }
        private void setCbmUser(List<Dependente> list)
        {

            cmbUser.DataSource = null;
            cmbUser.DataSource = list;
            cmbUser.DisplayMember = "Nome";

        }
        private void setCbmUser(List<Responsavel> list)
        {

            cmbUser.DataSource = null;
            cmbUser.DataSource = list;
            cmbUser.DisplayMember = "Nome";

        }
        private void setCbmProjetos()
        {
            using (c = new Conexao())
            {
                cmbProjetos.DataSource = null;
                cmbProjetos.DataSource = c.Cursos.ToList();
                cmbProjetos.DisplayMember = "Nome";

            }
        }
        private void BtnMatricular_Click(object sender, EventArgs e)
        {
            if (isValidForm()) {
                Curso curso = (Curso)cmbProjetos.SelectedItem;
              
                using (c = new Conexao()) {
                    try {
                        if (rdaDependentes.Checked) {
                            Dependente depen = (Dependente)cmbUser.SelectedItem;
                            if (!isSet(depen, curso)) {
                                c.Dependentes.Find(depen.Id).Cursos.Add(c.Cursos.Find(curso.Id));
                                c.SaveChanges();
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "Aluno  já Matriculado no projeto "+curso.Nome+" !");
                                return;
                            }
                        } else if (rdaResponsavel.Checked) {
                            Responsavel resp = (Responsavel)cmbUser.SelectedItem;
                            if (!isSet(resp, curso)){
                            c.Responsaveis.Find(resp.Id).Cursos.Add(c.Cursos.Find(curso.Id));
                            c.SaveChanges();
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "Aluno  já Matriculado no projeto " + curso.Nome + " !");
                                return;
                            }
                    }
                        ClearForm();
                        MetroMessageBox.Show(this, "Aluno Matriculado com Sucesso!");    
                    }
                    catch
                    {
                        ClearForm();
                        MetroMessageBox.Show(this, "Erro ao tentar Matricular Aluno no curso");
                    }
            }
          }
        }
        private bool isValidForm()
        {
            if(cmbProjetos.SelectedItem != null && cmbUser.SelectedItem != null && (rdaDependentes.Checked || rdaResponsavel.Checked))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void rdaDependentes_CheckedChanged(object sender, EventArgs e)
        {
            using(c = new Conexao())
            {
        
                setCbmUser(c.Dependentes.ToList());

            }
        }
        private void rdaResponsavel_CheckedChanged(object sender, EventArgs e)
        {
            using (c = new Conexao())
            {
                setCbmUser(c.Responsaveis.ToList()); 
            }
        }
        private void ClearForm()
        {
            cmbUser.SelectedIndex =  cmbProjetos.SelectedIndex = -1;
            rdaDependentes.Checked = rdaResponsavel.Checked = false;

        }
    }
}
