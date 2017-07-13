namespace TCC.Forms.FormAdmin
{
    partial class FormAdminFrequencia
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
            this.listProjeto = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.dgvFrequenciaDependentes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.txtProfessor = new MetroFramework.Controls.MetroTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFreqDependentes = new System.Windows.Forms.TabPage();
            this.tabFreqResponsaveis = new System.Windows.Forms.TabPage();
            this.dgvFrequenciaResponsaveis = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAulas = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResumo = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequenciaDependentes)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabFreqDependentes.SuspendLayout();
            this.tabFreqResponsaveis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequenciaResponsaveis)).BeginInit();
            this.SuspendLayout();
            // 
            // listProjeto
            // 
            this.listProjeto.FormattingEnabled = true;
            this.listProjeto.Location = new System.Drawing.Point(20, 111);
            this.listProjeto.Name = "listProjeto";
            this.listProjeto.Size = new System.Drawing.Size(138, 368);
            this.listProjeto.TabIndex = 1;
            this.listProjeto.SelectedIndexChanged += new System.EventHandler(this.listProjeto_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Lista de Projetos";
            // 
            // txtPesquisa
            // 
            // 
            // 
            // 
            this.txtPesquisa.CustomButton.Image = null;
            this.txtPesquisa.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtPesquisa.CustomButton.Name = "";
            this.txtPesquisa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPesquisa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisa.CustomButton.TabIndex = 1;
            this.txtPesquisa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisa.CustomButton.UseSelectable = true;
            this.txtPesquisa.CustomButton.Visible = false;
            this.txtPesquisa.Lines = new string[0];
            this.txtPesquisa.Location = new System.Drawing.Point(20, 84);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.ShortcutsEnabled = true;
            this.txtPesquisa.Size = new System.Drawing.Size(138, 23);
            this.txtPesquisa.TabIndex = 55;
            this.txtPesquisa.UseSelectable = true;
            this.txtPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dgvFrequenciaDependentes
            // 
            this.dgvFrequenciaDependentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrequenciaDependentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFrequenciaDependentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrequenciaDependentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFrequenciaDependentes.Location = new System.Drawing.Point(3, 3);
            this.dgvFrequenciaDependentes.MultiSelect = false;
            this.dgvFrequenciaDependentes.Name = "dgvFrequenciaDependentes";
            this.dgvFrequenciaDependentes.ReadOnly = true;
            this.dgvFrequenciaDependentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFrequenciaDependentes.Size = new System.Drawing.Size(448, 183);
            this.dgvFrequenciaDependentes.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Final";
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/MM/yyyy";
            this.dtInicio.Enabled = false;
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(216, 120);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(166, 20);
            this.dtInicio.TabIndex = 60;
            // 
            // dtFinal
            // 
            this.dtFinal.CustomFormat = "dd/MM/yyyy";
            this.dtFinal.Enabled = false;
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFinal.Location = new System.Drawing.Point(437, 120);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(189, 20);
            this.dtFinal.TabIndex = 61;
            // 
            // txtProfessor
            // 
            // 
            // 
            // 
            this.txtProfessor.CustomButton.Image = null;
            this.txtProfessor.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtProfessor.CustomButton.Name = "";
            this.txtProfessor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProfessor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProfessor.CustomButton.TabIndex = 1;
            this.txtProfessor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProfessor.CustomButton.UseSelectable = true;
            this.txtProfessor.CustomButton.Visible = false;
            this.txtProfessor.Enabled = false;
            this.txtProfessor.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProfessor.Lines = new string[0];
            this.txtProfessor.Location = new System.Drawing.Point(243, 83);
            this.txtProfessor.MaxLength = 32767;
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.PasswordChar = '\0';
            this.txtProfessor.ReadOnly = true;
            this.txtProfessor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProfessor.SelectedText = "";
            this.txtProfessor.SelectionLength = 0;
            this.txtProfessor.SelectionStart = 0;
            this.txtProfessor.ShortcutsEnabled = true;
            this.txtProfessor.Size = new System.Drawing.Size(139, 23);
            this.txtProfessor.TabIndex = 63;
            this.txtProfessor.UseSelectable = true;
            this.txtProfessor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProfessor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFreqDependentes);
            this.tabControl1.Controls.Add(this.tabFreqResponsaveis);
            this.tabControl1.Location = new System.Drawing.Point(164, 264);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 215);
            this.tabControl1.TabIndex = 64;
            // 
            // tabFreqDependentes
            // 
            this.tabFreqDependentes.Controls.Add(this.dgvFrequenciaDependentes);
            this.tabFreqDependentes.Location = new System.Drawing.Point(4, 22);
            this.tabFreqDependentes.Name = "tabFreqDependentes";
            this.tabFreqDependentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabFreqDependentes.Size = new System.Drawing.Size(454, 189);
            this.tabFreqDependentes.TabIndex = 0;
            this.tabFreqDependentes.Text = "Dependentes";
            this.tabFreqDependentes.UseVisualStyleBackColor = true;
            // 
            // tabFreqResponsaveis
            // 
            this.tabFreqResponsaveis.Controls.Add(this.dgvFrequenciaResponsaveis);
            this.tabFreqResponsaveis.Location = new System.Drawing.Point(4, 22);
            this.tabFreqResponsaveis.Name = "tabFreqResponsaveis";
            this.tabFreqResponsaveis.Padding = new System.Windows.Forms.Padding(3);
            this.tabFreqResponsaveis.Size = new System.Drawing.Size(454, 189);
            this.tabFreqResponsaveis.TabIndex = 1;
            this.tabFreqResponsaveis.Text = "Responsaveis";
            this.tabFreqResponsaveis.UseVisualStyleBackColor = true;
            // 
            // dgvFrequenciaResponsaveis
            // 
            this.dgvFrequenciaResponsaveis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrequenciaResponsaveis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFrequenciaResponsaveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrequenciaResponsaveis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFrequenciaResponsaveis.Location = new System.Drawing.Point(3, 3);
            this.dgvFrequenciaResponsaveis.MultiSelect = false;
            this.dgvFrequenciaResponsaveis.Name = "dgvFrequenciaResponsaveis";
            this.dgvFrequenciaResponsaveis.ReadOnly = true;
            this.dgvFrequenciaResponsaveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFrequenciaResponsaveis.Size = new System.Drawing.Size(448, 183);
            this.dgvFrequenciaResponsaveis.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Aula";
            // 
            // cmbAulas
            // 
            this.cmbAulas.FormattingEnabled = true;
            this.cmbAulas.ItemHeight = 23;
            this.cmbAulas.Location = new System.Drawing.Point(437, 83);
            this.cmbAulas.Name = "cmbAulas";
            this.cmbAulas.Size = new System.Drawing.Size(189, 29);
            this.cmbAulas.TabIndex = 65;
            this.cmbAulas.UseSelectable = true;
            this.cmbAulas.SelectedIndexChanged += new System.EventHandler(this.cmbAulas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "Resumo";
            // 
            // txtResumo
            // 
            // 
            // 
            // 
            this.txtResumo.CustomButton.Image = null;
            this.txtResumo.CustomButton.Location = new System.Drawing.Point(369, 1);
            this.txtResumo.CustomButton.Name = "";
            this.txtResumo.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.txtResumo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtResumo.CustomButton.TabIndex = 1;
            this.txtResumo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtResumo.CustomButton.UseSelectable = true;
            this.txtResumo.CustomButton.Visible = false;
            this.txtResumo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtResumo.Lines = new string[0];
            this.txtResumo.Location = new System.Drawing.Point(164, 171);
            this.txtResumo.MaxLength = 300;
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.PasswordChar = '\0';
            this.txtResumo.ReadOnly = true;
            this.txtResumo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtResumo.SelectedText = "";
            this.txtResumo.SelectionLength = 0;
            this.txtResumo.SelectionStart = 0;
            this.txtResumo.ShortcutsEnabled = true;
            this.txtResumo.ShowClearButton = true;
            this.txtResumo.Size = new System.Drawing.Size(455, 87);
            this.txtResumo.TabIndex = 68;
            this.txtResumo.UseSelectable = true;
            this.txtResumo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtResumo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormAdminFrequencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbAulas);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listProjeto);
            this.MinimizeBox = false;
            this.Name = "FormAdminFrequencia";
            this.Text = "Frequencias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequenciaDependentes)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabFreqDependentes.ResumeLayout(false);
            this.tabFreqResponsaveis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequenciaResponsaveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listProjeto;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvFrequenciaDependentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private MetroFramework.Controls.MetroTextBox txtProfessor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFreqDependentes;
        private System.Windows.Forms.TabPage tabFreqResponsaveis;
        private System.Windows.Forms.DataGridView dgvFrequenciaResponsaveis;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox cmbAulas;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtResumo;
    }
}