namespace TCC.Forms.FormAdmin.AdminOption
{
    partial class FormAdminAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminAlterarSenha));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAlterar = new MetroFramework.Controls.MetroButton();
            this.txtNovaSenhaConfirmar = new MetroFramework.Controls.MetroTextBox();
            this.txtNovaSenha = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Confirma Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nova Senha";
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(94, 307);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(100, 33);
            this.BtnAlterar.TabIndex = 12;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseSelectable = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // txtNovaSenhaConfirmar
            // 
            // 
            // 
            // 
            this.txtNovaSenhaConfirmar.CustomButton.Image = null;
            this.txtNovaSenhaConfirmar.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtNovaSenhaConfirmar.CustomButton.Name = "";
            this.txtNovaSenhaConfirmar.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNovaSenhaConfirmar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNovaSenhaConfirmar.CustomButton.TabIndex = 1;
            this.txtNovaSenhaConfirmar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNovaSenhaConfirmar.CustomButton.UseSelectable = true;
            this.txtNovaSenhaConfirmar.CustomButton.Visible = false;
            this.txtNovaSenhaConfirmar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNovaSenhaConfirmar.Lines = new string[0];
            this.txtNovaSenhaConfirmar.Location = new System.Drawing.Point(17, 258);
            this.txtNovaSenhaConfirmar.MaxLength = 32767;
            this.txtNovaSenhaConfirmar.Name = "txtNovaSenhaConfirmar";
            this.txtNovaSenhaConfirmar.PasswordChar = '*';
            this.txtNovaSenhaConfirmar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNovaSenhaConfirmar.SelectedText = "";
            this.txtNovaSenhaConfirmar.SelectionLength = 0;
            this.txtNovaSenhaConfirmar.SelectionStart = 0;
            this.txtNovaSenhaConfirmar.ShortcutsEnabled = true;
            this.txtNovaSenhaConfirmar.Size = new System.Drawing.Size(257, 29);
            this.txtNovaSenhaConfirmar.TabIndex = 11;
            this.txtNovaSenhaConfirmar.UseSelectable = true;
            this.txtNovaSenhaConfirmar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNovaSenhaConfirmar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNovaSenha
            // 
            // 
            // 
            // 
            this.txtNovaSenha.CustomButton.Image = null;
            this.txtNovaSenha.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.txtNovaSenha.CustomButton.Name = "";
            this.txtNovaSenha.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNovaSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNovaSenha.CustomButton.TabIndex = 1;
            this.txtNovaSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNovaSenha.CustomButton.UseSelectable = true;
            this.txtNovaSenha.CustomButton.Visible = false;
            this.txtNovaSenha.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNovaSenha.Lines = new string[0];
            this.txtNovaSenha.Location = new System.Drawing.Point(17, 194);
            this.txtNovaSenha.MaxLength = 32767;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNovaSenha.SelectedText = "";
            this.txtNovaSenha.SelectionLength = 0;
            this.txtNovaSenha.SelectionStart = 0;
            this.txtNovaSenha.ShortcutsEnabled = true;
            this.txtNovaSenha.Size = new System.Drawing.Size(260, 29);
            this.txtNovaSenha.TabIndex = 10;
            this.txtNovaSenha.UseSelectable = true;
            this.txtNovaSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNovaSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormAdminAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(300, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.txtNovaSenhaConfirmar);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormAdminAlterarSenha";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Alterar Senha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton BtnAlterar;
        private MetroFramework.Controls.MetroTextBox txtNovaSenhaConfirmar;
        private MetroFramework.Controls.MetroTextBox txtNovaSenha;
    }
}