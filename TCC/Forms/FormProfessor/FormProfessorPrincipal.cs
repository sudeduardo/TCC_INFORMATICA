using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Model;

namespace TCC.Forms.FormProfessor
{
    public partial class FormProfessorPrincipal : MetroForm
    {
        private Professor professor;
        public FormProfessorPrincipal(Professor prof)
        {
            InitializeComponent();
            professor = prof;
            ColorBackMdi();
        }
        //Cor do fundo do Mdi
        private void ColorBackMdi()
        {
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    Debug.Print(exc.Message);
                }
            }
        }

        //Abre no modo Mdi veridicando se já esta aberto ou nao
        public void OpenMdiForm(MetroForm frm)
        {
            frm.Resizable = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.BorderStyle = MetroFormBorderStyle.FixedSingle;
            var f = FormOpened(frm);
            if (f != null)
            {

                f.BringToFront();
                f.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        //Verifica se Já esta aberto algum formulario
        public Form FormOpened(Form f)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == f.GetType())
                {
                    return OpenForm;
                }
            }

            return null;
        }

        private void meusProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormProfessorProjetos(professor.Id));
        }

        private void chamadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMdiForm(new FormProfessorChamada(professor.Id));
        }

    }
}
