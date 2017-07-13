namespace TCC.Forms.FormAdmin.ProfessorOption
{
    partial class FormProfessorExclusao
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
            this.BtnExcluirProfessor = new MetroFramework.Controls.MetroButton();
            this.dgvProfessores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExcluirProfessor
            // 
            this.BtnExcluirProfessor.Location = new System.Drawing.Point(469, 328);
            this.BtnExcluirProfessor.Name = "BtnExcluirProfessor";
            this.BtnExcluirProfessor.Size = new System.Drawing.Size(106, 33);
            this.BtnExcluirProfessor.TabIndex = 20;
            this.BtnExcluirProfessor.Text = "Excluir";
            this.BtnExcluirProfessor.UseSelectable = true;
            this.BtnExcluirProfessor.Click += new System.EventHandler(this.BtnExcluirProfessor_Click);
            // 
            // dgvProfessores
            // 
            this.dgvProfessores.AllowUserToAddRows = false;
            this.dgvProfessores.AllowUserToDeleteRows = false;
            this.dgvProfessores.AllowUserToOrderColumns = true;
            this.dgvProfessores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfessores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProfessores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProfessores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvProfessores.Location = new System.Drawing.Point(23, 63);
            this.dgvProfessores.MultiSelect = false;
            this.dgvProfessores.Name = "dgvProfessores";
            this.dgvProfessores.ReadOnly = true;
            this.dgvProfessores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProfessores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProfessores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfessores.Size = new System.Drawing.Size(552, 259);
            this.dgvProfessores.TabIndex = 21;
            // 
            // FormProfessorExclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 373);
            this.Controls.Add(this.dgvProfessores);
            this.Controls.Add(this.BtnExcluirProfessor);
            this.Name = "FormProfessorExclusao";
            this.Text = "Excluir Professores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton BtnExcluirProfessor;
        private System.Windows.Forms.DataGridView dgvProfessores;
    }
}