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
    public partial class FormAdminExclusao : MetroForm
    {
        private Conexao c;
        private int ID;
        public FormAdminExclusao(int id)
        {
            ID = id;
            InitializeComponent();
            UpdateDGV();
        }
        private void UpdateDGV()
        {
            using (c = new Conexao())
            {
                List<Admin> list = c.Admins.ToList();
                list.Remove(c.Admins.Find(ID));
                dgvAdmin.DataSource = null;
                dgvAdmin.DataSource = list;
                dgvAdmin.Columns[0].Visible = false;
                dgvAdmin.Columns[3].Visible = false;
            }
        }
        private void BtnExcluirAdmin_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.CurrentRow != null)
            {
                Admin adm = (Admin)dgvAdmin.SelectedRows[0].DataBoundItem;
                DialogResult result = MetroMessageBox.Show(MdiParent, "Você que mesmo excluir o administrador " + adm.Nome + "! Depois da Exclusão ele não tera mais acesso ao sistema!", "Atenção", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    ExcluirAdmin(adm);
                }
                else
                {
                    MetroMessageBox.Show(MdiParent, "Operação Cancelada, Administrador não Excluido");
                }
            }
            else
            {
                MetroMessageBox.Show(MdiParent, "Nenhum Administrador Selecionado!");
            }
        }
        private void ExcluirAdmin(Admin adm)
        {
            try
            {
                using (c = new Conexao())
                {
                    c.Entry(c.Admins.Find(adm.Id)).State = System.Data.Entity.EntityState.Deleted;
                    c.SaveChanges();
                    MetroMessageBox.Show(MdiParent, "Administrador Excluido com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDGV();
                }
            }
            catch
            {
                MetroMessageBox.Show(MdiParent, "Erro no Banco de Dados!");

            }
        }
    }
}
