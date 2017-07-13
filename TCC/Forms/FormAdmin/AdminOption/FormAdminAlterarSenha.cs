using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Model;

namespace TCC.Forms.FormAdmin.AdminOption
{
    public partial class FormAdminAlterarSenha : MetroForm
    {
        private int ID;
        private Conexao c;
        public FormAdminAlterarSenha(int id)
        {
            ID = id;
            InitializeComponent();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            using(c =new Conexao())
            {
                try {
                    if (txtNovaSenha.Text == txtNovaSenhaConfirmar.Text && txtNovaSenha.Text.Length > 6 && txtNovaSenhaConfirmar.Text.Length > 6)
                    {
                        Admin adm = c.Admins.Find(ID);
                        adm.Senha = txtNovaSenha.Text;
                        c.Entry(adm).State = System.Data.Entity.EntityState.Modified;
                        c.SaveChanges();
                        MetroMessageBox.Show(this, "Senha Alterada com Sucesso!");
                        Close();
                    }else{
                        MetroMessageBox.Show(this, "Campos de Senhas Vazios ou Menor do que 6 Digitos");
                    }
                    }catch{
                    MetroMessageBox.Show(this, "Erro ao Alerar a Senha");
                }

                }
            }
        }
    }

