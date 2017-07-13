namespace TCC.Forms.FormAdmin.ProjetosOption
{
    partial class FormProjetosPesquisa
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
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listProjeto = new System.Windows.Forms.ListBox();
            this.txtPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.rdaNiniciado = new MetroFramework.Controls.MetroRadioButton();
            this.rdaFinalizado = new MetroFramework.Controls.MetroRadioButton();
            this.rdaAndamento = new MetroFramework.Controls.MetroRadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Dependentes = new System.Windows.Forms.TabPage();
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvResponsaveis = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvDependentes = new System.Windows.Forms.DataGridView();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtProfessor = new MetroFramework.Controls.MetroTextBox();
            this.txtInicio = new MetroFramework.Controls.MetroTextBox();
            this.txtFinal = new MetroFramework.Controls.MetroTextBox();
            this.tabControl1.SuspendLayout();
            this.Dependentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsaveis)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependentes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            // 
            // 
            // 
            this.txtDescricao.CustomButton.Image = null;
            this.txtDescricao.CustomButton.Location = new System.Drawing.Point(281, 2);
            this.txtDescricao.CustomButton.Name = "";
            this.txtDescricao.CustomButton.Size = new System.Drawing.Size(107, 107);
            this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescricao.CustomButton.TabIndex = 1;
            this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.CustomButton.UseSelectable = true;
            this.txtDescricao.CustomButton.Visible = false;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(191, 158);
            this.txtDescricao.MaxLength = 600;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.ShowClearButton = true;
            this.txtDescricao.Size = new System.Drawing.Size(391, 112);
            this.txtDescricao.TabIndex = 53;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Incio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Professor Responsavel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nome do Projeto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Pesquisa";
            // 
            // listProjeto
            // 
            this.listProjeto.FormattingEnabled = true;
            this.listProjeto.Location = new System.Drawing.Point(18, 179);
            this.listProjeto.Name = "listProjeto";
            this.listProjeto.Size = new System.Drawing.Size(163, 329);
            this.listProjeto.TabIndex = 45;
            this.listProjeto.SelectedIndexChanged += new System.EventHandler(this.listProjeto_SelectedIndexChanged);
            // 
            // txtPesquisa
            // 
            // 
            // 
            // 
            this.txtPesquisa.CustomButton.Image = null;
            this.txtPesquisa.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtPesquisa.CustomButton.Name = "";
            this.txtPesquisa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPesquisa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisa.CustomButton.TabIndex = 1;
            this.txtPesquisa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisa.CustomButton.UseSelectable = true;
            this.txtPesquisa.CustomButton.Visible = false;
            this.txtPesquisa.Lines = new string[0];
            this.txtPesquisa.Location = new System.Drawing.Point(18, 86);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.ShortcutsEnabled = true;
            this.txtPesquisa.Size = new System.Drawing.Size(163, 23);
            this.txtPesquisa.TabIndex = 54;
            this.txtPesquisa.UseSelectable = true;
            this.txtPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // rdaNiniciado
            // 
            this.rdaNiniciado.AutoSize = true;
            this.rdaNiniciado.Location = new System.Drawing.Point(36, 115);
            this.rdaNiniciado.Name = "rdaNiniciado";
            this.rdaNiniciado.Size = new System.Drawing.Size(90, 15);
            this.rdaNiniciado.TabIndex = 55;
            this.rdaNiniciado.Text = "Não Iniciado";
            this.rdaNiniciado.UseSelectable = true;
            this.rdaNiniciado.CheckedChanged += new System.EventHandler(this.rdaNiniciado_CheckedChanged);
            // 
            // rdaFinalizado
            // 
            this.rdaFinalizado.AutoSize = true;
            this.rdaFinalizado.Location = new System.Drawing.Point(36, 157);
            this.rdaFinalizado.Name = "rdaFinalizado";
            this.rdaFinalizado.Size = new System.Drawing.Size(76, 15);
            this.rdaFinalizado.TabIndex = 56;
            this.rdaFinalizado.Text = "Finalizado";
            this.rdaFinalizado.UseSelectable = true;
            this.rdaFinalizado.CheckedChanged += new System.EventHandler(this.rdaFinalizado_CheckedChanged);
            // 
            // rdaAndamento
            // 
            this.rdaAndamento.AutoSize = true;
            this.rdaAndamento.Location = new System.Drawing.Point(36, 136);
            this.rdaAndamento.Name = "rdaAndamento";
            this.rdaAndamento.Size = new System.Drawing.Size(104, 15);
            this.rdaAndamento.TabIndex = 57;
            this.rdaAndamento.Text = "Em andamento";
            this.rdaAndamento.UseSelectable = true;
            this.rdaAndamento.CheckedChanged += new System.EventHandler(this.rdaAndamento_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Dependentes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(191, 316);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(391, 192);
            this.tabControl1.TabIndex = 58;
            // 
            // Dependentes
            // 
            this.Dependentes.Controls.Add(this.dgvAulas);
            this.Dependentes.Location = new System.Drawing.Point(4, 22);
            this.Dependentes.Name = "Dependentes";
            this.Dependentes.Padding = new System.Windows.Forms.Padding(3);
            this.Dependentes.Size = new System.Drawing.Size(383, 166);
            this.Dependentes.TabIndex = 0;
            this.Dependentes.Text = "Aulas";
            this.Dependentes.UseVisualStyleBackColor = true;
            // 
            // dgvAulas
            // 
            this.dgvAulas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAulas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulas.Location = new System.Drawing.Point(6, 8);
            this.dgvAulas.MultiSelect = false;
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.ReadOnly = true;
            this.dgvAulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAulas.Size = new System.Drawing.Size(370, 150);
            this.dgvAulas.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvResponsaveis);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(383, 166);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Responsaveis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvResponsaveis
            // 
            this.dgvResponsaveis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResponsaveis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvResponsaveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsaveis.Location = new System.Drawing.Point(6, 8);
            this.dgvResponsaveis.MultiSelect = false;
            this.dgvResponsaveis.Name = "dgvResponsaveis";
            this.dgvResponsaveis.ReadOnly = true;
            this.dgvResponsaveis.Size = new System.Drawing.Size(370, 150);
            this.dgvResponsaveis.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvDependentes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(383, 166);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dependentes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvDependentes
            // 
            this.dgvDependentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDependentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDependentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependentes.Location = new System.Drawing.Point(6, 8);
            this.dgvDependentes.Name = "dgvDependentes";
            this.dgvDependentes.ReadOnly = true;
            this.dgvDependentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDependentes.Size = new System.Drawing.Size(370, 150);
            this.dgvDependentes.TabIndex = 1;
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Enabled = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(370, 60);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ReadOnly = true;
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(212, 23);
            this.txtNome.TabIndex = 59;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProfessor
            // 
            // 
            // 
            // 
            this.txtProfessor.CustomButton.Image = null;
            this.txtProfessor.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtProfessor.CustomButton.Name = "";
            this.txtProfessor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProfessor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProfessor.CustomButton.TabIndex = 1;
            this.txtProfessor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProfessor.CustomButton.UseSelectable = true;
            this.txtProfessor.CustomButton.Visible = false;
            this.txtProfessor.Enabled = false;
            this.txtProfessor.Lines = new string[0];
            this.txtProfessor.Location = new System.Drawing.Point(370, 94);
            this.txtProfessor.MaxLength = 32767;
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.PasswordChar = '\0';
            this.txtProfessor.ReadOnly = true;
            this.txtProfessor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProfessor.SelectedText = "";
            this.txtProfessor.SelectionLength = 0;
            this.txtProfessor.SelectionStart = 0;
            this.txtProfessor.ShortcutsEnabled = true;
            this.txtProfessor.Size = new System.Drawing.Size(212, 23);
            this.txtProfessor.TabIndex = 60;
            this.txtProfessor.UseSelectable = true;
            this.txtProfessor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProfessor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInicio
            // 
            // 
            // 
            // 
            this.txtInicio.CustomButton.Image = null;
            this.txtInicio.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtInicio.CustomButton.Name = "";
            this.txtInicio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInicio.CustomButton.TabIndex = 1;
            this.txtInicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInicio.CustomButton.UseSelectable = true;
            this.txtInicio.CustomButton.Visible = false;
            this.txtInicio.Enabled = false;
            this.txtInicio.Lines = new string[0];
            this.txtInicio.Location = new System.Drawing.Point(248, 278);
            this.txtInicio.MaxLength = 32767;
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.PasswordChar = '\0';
            this.txtInicio.ReadOnly = true;
            this.txtInicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInicio.SelectedText = "";
            this.txtInicio.SelectionLength = 0;
            this.txtInicio.SelectionStart = 0;
            this.txtInicio.ShortcutsEnabled = true;
            this.txtInicio.Size = new System.Drawing.Size(125, 23);
            this.txtInicio.TabIndex = 63;
            this.txtInicio.UseSelectable = true;
            this.txtInicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFinal
            // 
            // 
            // 
            // 
            this.txtFinal.CustomButton.Image = null;
            this.txtFinal.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtFinal.CustomButton.Name = "";
            this.txtFinal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFinal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFinal.CustomButton.TabIndex = 1;
            this.txtFinal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFinal.CustomButton.UseSelectable = true;
            this.txtFinal.CustomButton.Visible = false;
            this.txtFinal.Enabled = false;
            this.txtFinal.Lines = new string[0];
            this.txtFinal.Location = new System.Drawing.Point(428, 278);
            this.txtFinal.MaxLength = 32767;
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.PasswordChar = '\0';
            this.txtFinal.ReadOnly = true;
            this.txtFinal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFinal.SelectedText = "";
            this.txtFinal.SelectionLength = 0;
            this.txtFinal.SelectionStart = 0;
            this.txtFinal.ShortcutsEnabled = true;
            this.txtFinal.Size = new System.Drawing.Size(125, 23);
            this.txtFinal.TabIndex = 64;
            this.txtFinal.UseSelectable = true;
            this.txtFinal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFinal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormProjetosPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 526);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rdaAndamento);
            this.Controls.Add(this.rdaFinalizado);
            this.Controls.Add(this.rdaNiniciado);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listProjeto);
            this.Name = "FormProjetosPesquisa";
            this.Text = "Pesquisar Projetos";
            this.tabControl1.ResumeLayout(false);
            this.Dependentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsaveis)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listProjeto;
        private MetroFramework.Controls.MetroTextBox txtPesquisa;
        private MetroFramework.Controls.MetroRadioButton rdaNiniciado;
        private MetroFramework.Controls.MetroRadioButton rdaFinalizado;
        private MetroFramework.Controls.MetroRadioButton rdaAndamento;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Dependentes;
        private System.Windows.Forms.DataGridView dgvAulas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvResponsaveis;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvDependentes;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtProfessor;
        private MetroFramework.Controls.MetroTextBox txtInicio;
        private MetroFramework.Controls.MetroTextBox txtFinal;
    }
}