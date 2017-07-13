using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Model;

namespace TCC.Forms.FormAdmin
{
    public partial class FormAdminContas : MetroForm
    {
        private Conexao c;
        private MetroForm a;
        public FormAdminContas()
        {
            InitializeComponent();
            setDateMax();
            //setDGV();
        }

        private void AddLancamentos_Click(object sender, EventArgs e)
        {
            FormAdminPrincipal frm = (FormAdminPrincipal)this.MdiParent;
            frm.OpenMdiForm(new FormAdminContasAdd());
        }
        private void setDGV() {
            using (c = new Conexao()) {

                List<Contas> contas = c.Contas.ToList();
                dgvContas.DataSource = null;
                dgvContas.DataSource = contas;
                dgvContas.Columns[0].Visible = false;
                dgvContas.Columns[2].HeaderText = "Valor (R$)";
                dgvContas.Columns[3].HeaderText = "Lançamentos";
                dgvContas.Columns[4].HeaderText = "Data de Cadastro";
            }
        }
        private void setDGV(DateTime dataInicial, DateTime datafinal)
        {
            using (c = new Conexao())
            {
                List<Contas> contas = c.Contas.ToList();
                dgvContas.DataSource = null;
                dgvContas.DataSource = contas.Where(x => Between(x.Data_Contribuicao, dataInicial, datafinal)).ToList();
                dgvContas.Columns[0].Visible = false;
                dgvContas.Columns[2].HeaderText = "Valor (R$)";
                dgvContas.Columns[3].HeaderText = "Lançamentos";
                dgvContas.Columns[4].HeaderText = "Data de Cadastro";
            }
        }
        private  void setDateMax() {
            dateInicial.MaxDate = dateFinal.MaxDate = DateTime.Today;
        }
        private bool Between(DateTime dateTime, DateTime startDate, DateTime endDate)
        {
                dateTime =  dateTime.AddHours(-dateTime.Hour).AddMinutes(-dateTime.Minute).AddMilliseconds(-dateTime.Millisecond).AddSeconds(-dateTime.Second);
         return dateTime >= startDate && dateTime <= endDate;

        }
        private void dateInicial_ValueChanged(object sender, EventArgs e)
        {
                
                setDGV(dateInicial.Value, dateFinal.Value);
        }
        private void dateFinal_ValueChanged(object sender, EventArgs e)
        {
                setDGV(dateInicial.Value, dateFinal.Value);
        }

        private void btnExcluirLancamento_Click(object sender, EventArgs e)
        {
            if (dgvContas.CurrentRow != null)
            {
                Contas conta = (Contas)dgvContas.CurrentRow.DataBoundItem;
                DialogResult result = MetroMessageBox.Show(MdiParent, "Você que mesmo excluir lançamento de valor  " +conta.Valor +" \n lançado em : "+ conta.Data_Lancamento.ToString("dd/MM/yyyy"), "Atenção", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    ExcluirLancamento(conta);
                    setDGV();
                }
                else
                {
                    MetroMessageBox.Show(MdiParent, "Operação Cancelada, Lançamentos não Excluido");
                }
            }
            else
            {
                MetroMessageBox.Show(MdiParent, "Nenhum Lançamento Selecionado!");
            }
        }
        private void ExcluirLancamento(Contas conta)
        {
            using (c = new Conexao()) {
                try { 
                c.Entry(c.Contas.Find(conta.Id)).State = System.Data.Entity.EntityState.Deleted;
                c.SaveChanges();
                }
                catch
                {

                }
            }
        }
        #region Excel não entendo mais funciona


        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Xls);
                   t.TrySetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void Xls()
        {
            a = this;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Documento de Planilha (*.xls)|*.xls";
            sfd.FileName = "Contas_" + dateInicial.Value.ToString("dd_MM_yyyy") + "_ate_" + dateFinal.Value.ToString("dd_MM_yyyy") + ".xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application xlexcel = new Microsoft.Office.Interop.Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Worksheet xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Format column D as text before pasting results, this was required for my data
                Range rng = xlWorkSheet.get_Range("D:D").Cells;
                rng.NumberFormat = "@";

                // Paste clipboard results to worksheet range
                Range CR = (Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                // Delete blank column A and select cell A1
                Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dgvContas.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }
        private void copyAlltoClipboard()
        {
            dgvContas.SelectAll();
            DataObject dataObj = dgvContas.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        #endregion 
    }
}
