namespace TCC.Forms.FormAdmin
{
    partial class FormAdminContas
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
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.btnAddLancamentos = new MetroFramework.Controls.MetroButton();
            this.btnImprimirLancamentos = new MetroFramework.Controls.MetroButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.btnExcluirLancamento = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            this.dgvContas.AllowUserToOrderColumns = true;
            this.dgvContas.AllowUserToResizeColumns = false;
            this.dgvContas.AllowUserToResizeRows = false;
            this.dgvContas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContas.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Location = new System.Drawing.Point(23, 86);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.ReadOnly = true;
            this.dgvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContas.Size = new System.Drawing.Size(566, 399);
            this.dgvContas.TabIndex = 0;
            // 
            // btnAddLancamentos
            // 
            this.btnAddLancamentos.Location = new System.Drawing.Point(290, 491);
            this.btnAddLancamentos.Name = "btnAddLancamentos";
            this.btnAddLancamentos.Size = new System.Drawing.Size(96, 33);
            this.btnAddLancamentos.TabIndex = 55;
            this.btnAddLancamentos.Text = "Adicionar";
            this.btnAddLancamentos.UseSelectable = true;
            this.btnAddLancamentos.Click += new System.EventHandler(this.AddLancamentos_Click);
            // 
            // btnImprimirLancamentos
            // 
            this.btnImprimirLancamentos.Location = new System.Drawing.Point(494, 491);
            this.btnImprimirLancamentos.Name = "btnImprimirLancamentos";
            this.btnImprimirLancamentos.Size = new System.Drawing.Size(96, 33);
            this.btnImprimirLancamentos.TabIndex = 56;
            this.btnImprimirLancamentos.Text = "Exportar";
            this.btnImprimirLancamentos.UseSelectable = true;
            this.btnImprimirLancamentos.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Data Inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Data final";
            // 
            // dateInicial
            // 
            this.dateInicial.CustomFormat = "dd/MM/yyyy";
            this.dateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInicial.Location = new System.Drawing.Point(113, 60);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(160, 20);
            this.dateInicial.TabIndex = 60;
            this.dateInicial.Value = new System.DateTime(2017, 5, 27, 0, 0, 0, 0);
            this.dateInicial.ValueChanged += new System.EventHandler(this.dateInicial_ValueChanged);
            // 
            // dateFinal
            // 
            this.dateFinal.CustomFormat = "dd/MM/yyyy";
            this.dateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFinal.Location = new System.Drawing.Point(384, 60);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(200, 20);
            this.dateFinal.TabIndex = 61;
            this.dateFinal.ValueChanged += new System.EventHandler(this.dateFinal_ValueChanged);
            // 
            // btnExcluirLancamento
            // 
            this.btnExcluirLancamento.Location = new System.Drawing.Point(392, 491);
            this.btnExcluirLancamento.Name = "btnExcluirLancamento";
            this.btnExcluirLancamento.Size = new System.Drawing.Size(96, 33);
            this.btnExcluirLancamento.TabIndex = 62;
            this.btnExcluirLancamento.Text = "Excluir";
            this.btnExcluirLancamento.UseSelectable = true;
            this.btnExcluirLancamento.Click += new System.EventHandler(this.btnExcluirLancamento_Click);
            // 
            // FormAdminContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 539);
            this.Controls.Add(this.btnExcluirLancamento);
            this.Controls.Add(this.dateFinal);
            this.Controls.Add(this.dateInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnImprimirLancamentos);
            this.Controls.Add(this.btnAddLancamentos);
            this.Controls.Add(this.dgvContas);
            this.Name = "FormAdminContas";
            this.Text = "Lançamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContas;
        private MetroFramework.Controls.MetroButton btnAddLancamentos;
        private MetroFramework.Controls.MetroButton btnImprimirLancamentos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private MetroFramework.Controls.MetroButton btnExcluirLancamento;
    }
}