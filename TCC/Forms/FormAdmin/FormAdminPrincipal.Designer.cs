namespace TCC.Forms.FormAdmin
{
    partial class FormAdminPrincipal
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
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhaContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exclusãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exclusãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuPesquisarProjetos = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuCadastroProjetos = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuExclusaoProjetos = new System.Windows.Forms.ToolStripMenuItem();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripContas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.professorToolStripMenuItem,
            this.professoresToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem6,
            this.relatoriosToolStripMenuItem,
            this.menuStripContas});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minhaContaToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.exclusãoToolStripMenuItem,
            this.stripMenuSair});
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.professorToolStripMenuItem.Text = "Administradores";
            // 
            // minhaContaToolStripMenuItem
            // 
            this.minhaContaToolStripMenuItem.Name = "minhaContaToolStripMenuItem";
            this.minhaContaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.minhaContaToolStripMenuItem.Text = "Alterar Senha";
            this.minhaContaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // exclusãoToolStripMenuItem
            // 
            this.exclusãoToolStripMenuItem.Name = "exclusãoToolStripMenuItem";
            this.exclusãoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exclusãoToolStripMenuItem.Text = "Exclusão";
            this.exclusãoToolStripMenuItem.Click += new System.EventHandler(this.exclusãoToolStripMenuItem_Click);
            // 
            // stripMenuSair
            // 
            this.stripMenuSair.Name = "stripMenuSair";
            this.stripMenuSair.Size = new System.Drawing.Size(144, 22);
            this.stripMenuSair.Text = "Sair";
            this.stripMenuSair.Click += new System.EventHandler(this.stripMenuSair_Click);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1,
            this.exclusãoToolStripMenuItem1,
            this.atualizarDadosToolStripMenuItem});
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.professoresToolStripMenuItem.Text = "Professores";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // exclusãoToolStripMenuItem1
            // 
            this.exclusãoToolStripMenuItem1.Name = "exclusãoToolStripMenuItem1";
            this.exclusãoToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.exclusãoToolStripMenuItem1.Text = "Exclusão";
            this.exclusãoToolStripMenuItem1.Click += new System.EventHandler(this.exclusãoToolStripMenuItem1_Click);
            // 
            // atualizarDadosToolStripMenuItem
            // 
            this.atualizarDadosToolStripMenuItem.Name = "atualizarDadosToolStripMenuItem";
            this.atualizarDadosToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.atualizarDadosToolStripMenuItem.Text = "Atualizar Dados";
            this.atualizarDadosToolStripMenuItem.Click += new System.EventHandler(this.atualizarDadosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(89, 20);
            this.toolStripMenuItem1.Text = "Responsávies";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem3.Text = "Cadastro";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem5.Text = "Atualizar Dados";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuPesquisarProjetos,
            this.stripMenuCadastroProjetos,
            this.stripMenuExclusaoProjetos,
            this.matriculaToolStripMenuItem});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem6.Text = "Projetos";
            // 
            // stripMenuPesquisarProjetos
            // 
            this.stripMenuPesquisarProjetos.Name = "stripMenuPesquisarProjetos";
            this.stripMenuPesquisarProjetos.Size = new System.Drawing.Size(152, 22);
            this.stripMenuPesquisarProjetos.Text = "Pesquisar";
            this.stripMenuPesquisarProjetos.Click += new System.EventHandler(this.stripMenuPesquisarProjetos_Click);
            // 
            // stripMenuCadastroProjetos
            // 
            this.stripMenuCadastroProjetos.Name = "stripMenuCadastroProjetos";
            this.stripMenuCadastroProjetos.Size = new System.Drawing.Size(152, 22);
            this.stripMenuCadastroProjetos.Text = "Cadastro";
            this.stripMenuCadastroProjetos.Click += new System.EventHandler(this.stripMenuCadastroProjetos_Click);
            // 
            // stripMenuExclusaoProjetos
            // 
            this.stripMenuExclusaoProjetos.Name = "stripMenuExclusaoProjetos";
            this.stripMenuExclusaoProjetos.Size = new System.Drawing.Size(152, 22);
            this.stripMenuExclusaoProjetos.Text = "Exclusão";
            this.stripMenuExclusaoProjetos.Click += new System.EventHandler(this.stripMenuExclusaoProjetos_Click);
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.matriculaToolStripMenuItem.Text = "Matricula";
            this.matriculaToolStripMenuItem.Click += new System.EventHandler(this.matriculaToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.relatoriosToolStripMenuItem.Text = "Frequencia";
            this.relatoriosToolStripMenuItem.Click += new System.EventHandler(this.relatoriosToolStripMenuItem_Click);
            // 
            // menuStripContas
            // 
            this.menuStripContas.Name = "menuStripContas";
            this.menuStripContas.Size = new System.Drawing.Size(56, 20);
            this.menuStripContas.Text = "Contas";
            this.menuStripContas.Click += new System.EventHandler(this.menuStripContas_Click);
            // 
            // FormAdminPrincipal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(802, 603);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "FormAdminPrincipal";
            this.Resizable = false;
            this.Text = "Bem-Vindo";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdminPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripContas;
        private System.Windows.Forms.ToolStripMenuItem minhaContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exclusãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exclusãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atualizarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem stripMenuPesquisarProjetos;
        private System.Windows.Forms.ToolStripMenuItem stripMenuCadastroProjetos;
        private System.Windows.Forms.ToolStripMenuItem stripMenuExclusaoProjetos;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripMenuSair;
    }
}