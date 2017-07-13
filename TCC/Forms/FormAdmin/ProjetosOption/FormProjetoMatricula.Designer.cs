namespace TCC.Forms.FormAdmin.ProjetosOption
{
    partial class FormProjetoMatricula
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProjetos = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUser = new MetroFramework.Controls.MetroComboBox();
            this.rdaResponsavel = new MetroFramework.Controls.MetroRadioButton();
            this.rdaDependentes = new MetroFramework.Controls.MetroRadioButton();
            this.BtnMatricular = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Projetos";
            // 
            // cmbProjetos
            // 
            this.cmbProjetos.FormattingEnabled = true;
            this.cmbProjetos.ItemHeight = 23;
            this.cmbProjetos.Location = new System.Drawing.Point(23, 81);
            this.cmbProjetos.Name = "cmbProjetos";
            this.cmbProjetos.Size = new System.Drawing.Size(254, 29);
            this.cmbProjetos.TabIndex = 11;
            this.cmbProjetos.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario";
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.ItemHeight = 23;
            this.cmbUser.Location = new System.Drawing.Point(23, 137);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(254, 29);
            this.cmbUser.TabIndex = 13;
            this.cmbUser.UseSelectable = true;
            // 
            // rdaResponsavel
            // 
            this.rdaResponsavel.AutoSize = true;
            this.rdaResponsavel.Location = new System.Drawing.Point(191, 116);
            this.rdaResponsavel.Name = "rdaResponsavel";
            this.rdaResponsavel.Size = new System.Drawing.Size(88, 15);
            this.rdaResponsavel.TabIndex = 59;
            this.rdaResponsavel.Text = "Responsavel";
            this.rdaResponsavel.UseSelectable = true;
            this.rdaResponsavel.CheckedChanged += new System.EventHandler(this.rdaResponsavel_CheckedChanged);
            // 
            // rdaDependentes
            // 
            this.rdaDependentes.AutoSize = true;
            this.rdaDependentes.Location = new System.Drawing.Point(98, 116);
            this.rdaDependentes.Name = "rdaDependentes";
            this.rdaDependentes.Size = new System.Drawing.Size(87, 15);
            this.rdaDependentes.TabIndex = 58;
            this.rdaDependentes.Text = "Dependente";
            this.rdaDependentes.UseSelectable = true;
            this.rdaDependentes.CheckedChanged += new System.EventHandler(this.rdaDependentes_CheckedChanged);
            // 
            // BtnMatricular
            // 
            this.BtnMatricular.Location = new System.Drawing.Point(175, 172);
            this.BtnMatricular.Name = "BtnMatricular";
            this.BtnMatricular.Size = new System.Drawing.Size(100, 33);
            this.BtnMatricular.TabIndex = 60;
            this.BtnMatricular.Text = "Matricular";
            this.BtnMatricular.UseSelectable = true;
            this.BtnMatricular.Click += new System.EventHandler(this.BtnMatricular_Click);
            // 
            // FormProjetoMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 223);
            this.Controls.Add(this.BtnMatricular);
            this.Controls.Add(this.rdaResponsavel);
            this.Controls.Add(this.rdaDependentes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProjetos);
            this.Name = "FormProjetoMatricula";
            this.Text = "Matricula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cmbProjetos;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cmbUser;
        private MetroFramework.Controls.MetroRadioButton rdaResponsavel;
        private MetroFramework.Controls.MetroRadioButton rdaDependentes;
        private MetroFramework.Controls.MetroButton BtnMatricular;
    }
}