﻿namespace TCC
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.TipoConta = new MetroFramework.Controls.MetroComboBox();
            this.BtnLogin = new MetroFramework.Controls.MetroButton();
            this.btnSenha = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(20, 176);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(260, 29);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(20, 240);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(257, 29);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TipoConta
            // 
            this.TipoConta.FormattingEnabled = true;
            this.TipoConta.ItemHeight = 23;
            this.TipoConta.Items.AddRange(new object[] {
            "Professor",
            "Administrador"});
            this.TipoConta.Location = new System.Drawing.Point(20, 305);
            this.TipoConta.Name = "TipoConta";
            this.TipoConta.Size = new System.Drawing.Size(254, 29);
            this.TipoConta.TabIndex = 5;
            this.TipoConta.UseSelectable = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(155, 362);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(119, 33);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseSelectable = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnSenha
            // 
            this.btnSenha.Location = new System.Drawing.Point(20, 362);
            this.btnSenha.Name = "btnSenha";
            this.btnSenha.Size = new System.Drawing.Size(119, 33);
            this.btnSenha.TabIndex = 7;
            this.btnSenha.Text = "Esqueci minha Senha";
            this.btnSenha.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de Usuario";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSenha);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TipoConta);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "FormLogin";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroComboBox TipoConta;
        private MetroFramework.Controls.MetroButton BtnLogin;
        private MetroFramework.Controls.MetroButton btnSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

