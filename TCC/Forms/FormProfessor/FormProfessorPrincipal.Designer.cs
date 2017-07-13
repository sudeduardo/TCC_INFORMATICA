namespace TCC.Forms.FormProfessor
{
    partial class FormProfessorPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meusProjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meusProjetosToolStripMenuItem,
            this.chamadaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meusProjetosToolStripMenuItem
            // 
            this.meusProjetosToolStripMenuItem.Name = "meusProjetosToolStripMenuItem";
            this.meusProjetosToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.meusProjetosToolStripMenuItem.Text = "Meus Projetos";
            this.meusProjetosToolStripMenuItem.Click += new System.EventHandler(this.meusProjetosToolStripMenuItem_Click);
            // 
            // chamadaToolStripMenuItem
            // 
            this.chamadaToolStripMenuItem.Name = "chamadaToolStripMenuItem";
            this.chamadaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.chamadaToolStripMenuItem.Text = "Chamadas";
            this.chamadaToolStripMenuItem.Click += new System.EventHandler(this.chamadaToolStripMenuItem_Click);
            // 
            // FormProfessorPrincipal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 498);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormProfessorPrincipal";
            this.Text = "Bem Vindo -";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meusProjetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamadaToolStripMenuItem;
    }
}