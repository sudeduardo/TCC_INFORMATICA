namespace TCC.Forms.FormAdmin.ProjetosOption
{
    partial class FormProjetosCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProjeto = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProfessor = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExclurAula = new MetroFramework.Controls.MetroButton();
            this.btnAddAula = new MetroFramework.Controls.MetroButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dateAula = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateInicia = new System.Windows.Forms.DateTimePicker();
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.btnConcluir = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome do Projeto";
            // 
            // txtNomeProjeto
            // 
            // 
            // 
            // 
            this.txtNomeProjeto.CustomButton.Image = null;
            this.txtNomeProjeto.CustomButton.Location = new System.Drawing.Point(264, 1);
            this.txtNomeProjeto.CustomButton.Name = "";
            this.txtNomeProjeto.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNomeProjeto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeProjeto.CustomButton.TabIndex = 1;
            this.txtNomeProjeto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeProjeto.CustomButton.UseSelectable = true;
            this.txtNomeProjeto.CustomButton.Visible = false;
            this.txtNomeProjeto.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNomeProjeto.Lines = new string[0];
            this.txtNomeProjeto.Location = new System.Drawing.Point(23, 86);
            this.txtNomeProjeto.MaxLength = 32767;
            this.txtNomeProjeto.Name = "txtNomeProjeto";
            this.txtNomeProjeto.PasswordChar = '\0';
            this.txtNomeProjeto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeProjeto.SelectedText = "";
            this.txtNomeProjeto.SelectionLength = 0;
            this.txtNomeProjeto.SelectionStart = 0;
            this.txtNomeProjeto.ShortcutsEnabled = true;
            this.txtNomeProjeto.Size = new System.Drawing.Size(292, 29);
            this.txtNomeProjeto.TabIndex = 1;
            this.txtNomeProjeto.UseSelectable = true;
            this.txtNomeProjeto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeProjeto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Professor";
            // 
            // txtDescricao
            // 
            // 
            // 
            // 
            this.txtDescricao.CustomButton.Image = null;
            this.txtDescricao.CustomButton.Location = new System.Drawing.Point(348, 2);
            this.txtDescricao.CustomButton.Name = "";
            this.txtDescricao.CustomButton.Size = new System.Drawing.Size(163, 163);
            this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescricao.CustomButton.TabIndex = 1;
            this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.CustomButton.UseSelectable = true;
            this.txtDescricao.CustomButton.Visible = false;
            this.txtDescricao.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(23, 141);
            this.txtDescricao.MaxLength = 600;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.ShowClearButton = true;
            this.txtDescricao.Size = new System.Drawing.Size(514, 168);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descrição do Projeto";
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.ItemHeight = 23;
            this.cmbProfessor.Items.AddRange(new object[] {
            "Professor",
            "Administrador"});
            this.cmbProfessor.Location = new System.Drawing.Point(325, 86);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(212, 29);
            this.cmbProfessor.TabIndex = 2;
            this.cmbProfessor.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExclurAula);
            this.groupBox1.Controls.Add(this.btnAddAula);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateAula);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateFinal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateInicia);
            this.groupBox1.Controls.Add(this.dgvAulas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(23, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 216);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dias de Aula";
            // 
            // btnExclurAula
            // 
            this.btnExclurAula.Location = new System.Drawing.Point(114, 166);
            this.btnExclurAula.Name = "btnExclurAula";
            this.btnExclurAula.Size = new System.Drawing.Size(90, 35);
            this.btnExclurAula.TabIndex = 31;
            this.btnExclurAula.Text = "Excluir";
            this.btnExclurAula.UseSelectable = true;
            this.btnExclurAula.Click += new System.EventHandler(this.btnExclurAula_Click);
            // 
            // btnAddAula
            // 
            this.btnAddAula.Location = new System.Drawing.Point(7, 166);
            this.btnAddAula.Name = "btnAddAula";
            this.btnAddAula.Size = new System.Drawing.Size(90, 35);
            this.btnAddAula.TabIndex = 30;
            this.btnAddAula.Text = "Adcionar";
            this.btnAddAula.UseSelectable = true;
            this.btnAddAula.Click += new System.EventHandler(this.btnAddAula_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Dia de Aula";
            // 
            // dateAula
            // 
            this.dateAula.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAula.Location = new System.Drawing.Point(6, 112);
            this.dateAula.Name = "dateAula";
            this.dateAula.Size = new System.Drawing.Size(198, 26);
            this.dateAula.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Aulas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Data Final";
            // 
            // dateFinal
            // 
            this.dateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFinal.Location = new System.Drawing.Point(266, 53);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(234, 26);
            this.dateFinal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Data Inicial";
            // 
            // dateInicia
            // 
            this.dateInicia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInicia.Location = new System.Drawing.Point(6, 53);
            this.dateInicia.Name = "dateInicia";
            this.dateInicia.Size = new System.Drawing.Size(234, 26);
            this.dateInicia.TabIndex = 4;
            // 
            // dgvAulas
            // 
            this.dgvAulas.AllowUserToAddRows = false;
            this.dgvAulas.AllowUserToDeleteRows = false;
            this.dgvAulas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAulas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulas.Location = new System.Drawing.Point(223, 112);
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAulas.Size = new System.Drawing.Size(268, 89);
            this.dgvAulas.TabIndex = 0;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(439, 538);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(90, 35);
            this.btnConcluir.TabIndex = 32;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseSelectable = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // FormProjetosCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 578);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbProfessor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeProjeto);
            this.Name = "FormProjetosCadastro";
            this.Text = "Cadastro de Projetos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtNomeProjeto;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cmbProfessor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAulas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateInicia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateAula;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroButton btnExclurAula;
        private MetroFramework.Controls.MetroButton btnAddAula;
        private MetroFramework.Controls.MetroButton btnConcluir;
    }
}