namespace TCC.Forms.FormProfessor
{
    partial class FormProfessorChamada
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
            this.cmbAulas = new MetroFramework.Controls.MetroComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFreqDependentes = new System.Windows.Forms.TabPage();
            this.BtnChamada = new MetroFramework.Controls.MetroButton();
            this.dgvFrequenciaDependentes = new System.Windows.Forms.DataGridView();
            this.tabFreqResponsaveis = new System.Windows.Forms.TabPage();
            this.btnSalvarResponsaveis = new MetroFramework.Controls.MetroButton();
            this.dgvFrequenciaResponsaveis = new System.Windows.Forms.DataGridView();
            this.txtResumo = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabFreqDependentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequenciaDependentes)).BeginInit();
            this.tabFreqResponsaveis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequenciaResponsaveis)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Projetos";
            // 
            // cmbProjetos
            // 
            this.cmbProjetos.FormattingEnabled = true;
            this.cmbProjetos.ItemHeight = 23;
            this.cmbProjetos.Location = new System.Drawing.Point(23, 85);
            this.cmbProjetos.Name = "cmbProjetos";
            this.cmbProjetos.Size = new System.Drawing.Size(197, 29);
            this.cmbProjetos.TabIndex = 13;
            this.cmbProjetos.UseSelectable = true;
            this.cmbProjetos.SelectedIndexChanged += new System.EventHandler(this.cmbProjetos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Aula";
            // 
            // cmbAulas
            // 
            this.cmbAulas.FormattingEnabled = true;
            this.cmbAulas.ItemHeight = 23;
            this.cmbAulas.Location = new System.Drawing.Point(255, 85);
            this.cmbAulas.Name = "cmbAulas";
            this.cmbAulas.Size = new System.Drawing.Size(197, 29);
            this.cmbAulas.TabIndex = 15;
            this.cmbAulas.UseSelectable = true;
            this.cmbAulas.SelectedIndexChanged += new System.EventHandler(this.cmbAulas_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFreqDependentes);
            this.tabControl1.Controls.Add(this.tabFreqResponsaveis);
            this.tabControl1.Location = new System.Drawing.Point(23, 270);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 367);
            this.tabControl1.TabIndex = 65;
            // 
            // tabFreqDependentes
            // 
            this.tabFreqDependentes.Controls.Add(this.BtnChamada);
            this.tabFreqDependentes.Controls.Add(this.dgvFrequenciaDependentes);
            this.tabFreqDependentes.Location = new System.Drawing.Point(4, 22);
            this.tabFreqDependentes.Name = "tabFreqDependentes";
            this.tabFreqDependentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabFreqDependentes.Size = new System.Drawing.Size(421, 341);
            this.tabFreqDependentes.TabIndex = 0;
            this.tabFreqDependentes.Text = "Dependentes";
            this.tabFreqDependentes.UseVisualStyleBackColor = true;
            // 
            // BtnChamada
            // 
            this.BtnChamada.Location = new System.Drawing.Point(309, 300);
            this.BtnChamada.Name = "BtnChamada";
            this.BtnChamada.Size = new System.Drawing.Size(106, 33);
            this.BtnChamada.TabIndex = 66;
            this.BtnChamada.TabStop = false;
            this.BtnChamada.Text = "Salvar";
            this.BtnChamada.UseSelectable = true;
            this.BtnChamada.Click += new System.EventHandler(this.BtnChamada_Click);
            // 
            // dgvFrequenciaDependentes
            // 
            this.dgvFrequenciaDependentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrequenciaDependentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFrequenciaDependentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrequenciaDependentes.Location = new System.Drawing.Point(3, 3);
            this.dgvFrequenciaDependentes.Name = "dgvFrequenciaDependentes";
            this.dgvFrequenciaDependentes.Size = new System.Drawing.Size(415, 291);
            this.dgvFrequenciaDependentes.TabIndex = 56;
            // 
            // tabFreqResponsaveis
            // 
            this.tabFreqResponsaveis.Controls.Add(this.btnSalvarResponsaveis);
            this.tabFreqResponsaveis.Controls.Add(this.dgvFrequenciaResponsaveis);
            this.tabFreqResponsaveis.Location = new System.Drawing.Point(4, 22);
            this.tabFreqResponsaveis.Name = "tabFreqResponsaveis";
            this.tabFreqResponsaveis.Padding = new System.Windows.Forms.Padding(3);
            this.tabFreqResponsaveis.Size = new System.Drawing.Size(421, 341);
            this.tabFreqResponsaveis.TabIndex = 1;
            this.tabFreqResponsaveis.Text = "Responsaveis";
            this.tabFreqResponsaveis.UseVisualStyleBackColor = true;
            // 
            // btnSalvarResponsaveis
            // 
            this.btnSalvarResponsaveis.Location = new System.Drawing.Point(309, 300);
            this.btnSalvarResponsaveis.Name = "btnSalvarResponsaveis";
            this.btnSalvarResponsaveis.Size = new System.Drawing.Size(106, 33);
            this.btnSalvarResponsaveis.TabIndex = 67;
            this.btnSalvarResponsaveis.TabStop = false;
            this.btnSalvarResponsaveis.Text = "Salvar";
            this.btnSalvarResponsaveis.UseSelectable = true;
            this.btnSalvarResponsaveis.Click += new System.EventHandler(this.btnSalvarResponsaveis_Click);
            // 
            // dgvFrequenciaResponsaveis
            // 
            this.dgvFrequenciaResponsaveis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrequenciaResponsaveis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFrequenciaResponsaveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrequenciaResponsaveis.Location = new System.Drawing.Point(3, 3);
            this.dgvFrequenciaResponsaveis.Name = "dgvFrequenciaResponsaveis";
            this.dgvFrequenciaResponsaveis.Size = new System.Drawing.Size(415, 291);
            this.dgvFrequenciaResponsaveis.TabIndex = 57;
            // 
            // txtResumo
            // 
            // 
            // 
            // 
            this.txtResumo.CustomButton.Image = null;
            this.txtResumo.CustomButton.Location = new System.Drawing.Point(307, 2);
            this.txtResumo.CustomButton.Name = "";
            this.txtResumo.CustomButton.Size = new System.Drawing.Size(119, 119);
            this.txtResumo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtResumo.CustomButton.TabIndex = 1;
            this.txtResumo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtResumo.CustomButton.UseSelectable = true;
            this.txtResumo.CustomButton.Visible = false;
            this.txtResumo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtResumo.Lines = new string[0];
            this.txtResumo.Location = new System.Drawing.Point(23, 140);
            this.txtResumo.MaxLength = 300;
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.PasswordChar = '\0';
            this.txtResumo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtResumo.SelectedText = "";
            this.txtResumo.SelectionLength = 0;
            this.txtResumo.SelectionStart = 0;
            this.txtResumo.ShortcutsEnabled = true;
            this.txtResumo.ShowClearButton = true;
            this.txtResumo.Size = new System.Drawing.Size(429, 124);
            this.txtResumo.TabIndex = 66;
            this.txtResumo.UseSelectable = true;
            this.txtResumo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtResumo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Resumo";
            // 
            // FormProfessorChamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 660);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAulas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProjetos);
            this.Name = "FormProfessorChamada";
            this.Text = "Chamada";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.tabControl1.ResumeLayout(false);
            this.tabFreqDependentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequenciaDependentes)).EndInit();
            this.tabFreqResponsaveis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequenciaResponsaveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cmbProjetos;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cmbAulas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFreqDependentes;
        private System.Windows.Forms.DataGridView dgvFrequenciaDependentes;
        private System.Windows.Forms.TabPage tabFreqResponsaveis;
        private System.Windows.Forms.DataGridView dgvFrequenciaResponsaveis;
        private MetroFramework.Controls.MetroButton BtnChamada;
        private MetroFramework.Controls.MetroButton btnSalvarResponsaveis;
        private MetroFramework.Controls.MetroTextBox txtResumo;
        private System.Windows.Forms.Label label2;
    }
}