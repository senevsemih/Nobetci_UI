using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;
using TextBox = System.Windows.Forms.TextBox;

namespace Nöbetci_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly Application xlApp = new Application();
        Workbook xlWorkBook;
        Worksheet xlWorkSheet;

        string fileName;
        string ay;

        bool dosyaAcık = false;
        int indexRow;

        private void Btn_GetExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Nöbetçi Listesi",
                Filter = "Excel File|*.xlsx; *.xls"
            };

            if (!dosyaAcık)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;

                    dosyaAcık = true;

                    ExceltoGrid();
                }
                else
                {
                    MessageBox.Show("Nöbetçi Excel Dosyasını Seçin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Yüklü Excel Var!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (cmb_Nobetci.Text != "" && txt_Telefon.Text != "" && txt_Mail.Text != "")
            {
                YeniNobetciEkle(cmb_Nobetci, txt_Unvan, txt_Telefon, txt_Mail, dtp_Tarih);
            }
            else
            {
                MessageBox.Show("Nöbetçi Atamalarını Yap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_SetExcel_Click(object sender, EventArgs e)
        {
            if (xlWorkBook != null)
            {
                ExcelUpdate();
            }
            else
            {
                MessageBox.Show("Excel Yükle", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dtp_Tarih_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Chc_Degisim_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_Degisim.Checked)
            {
                dgv_Excel.ReadOnly = false;
            }
            else
            {
                dgv_Excel.ReadOnly = true;
            }
        }
        
        private void Cmb_Nobetci_SelectedValueChanged(object sender, EventArgs e)
        {
            int nobetciComboBoxIndex = cmb_Nobetci.SelectedIndex + 2;

            CalisanBilgileriAutoComplete(nobetciComboBoxIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DontAllowToText(cmb_Ay, cmb_Nobetci, txt_Unvan, txt_Telefon, txt_Mail);
            dgv_Excel.ReadOnly = true;
        }



        private void Baglantı(string _fileName)
        {
            ay = cmb_Ay.Text;

            xlWorkBook = xlApp.Workbooks.Open(_fileName);
            xlWorkSheet = xlWorkBook.Worksheets[ay];
        }
        
        private void ExceltoGrid()
        {
            Baglantı(fileName);
            VeriAktarım(cmb_Nobetci, 6);

            for (indexRow = 2; indexRow <= xlWorkSheet.Rows.Count; indexRow++)
            {
                if (xlWorkSheet.Cells[indexRow, 1].value == null)
                {
                    break;
                }
                else
                {
                    string[] row = new string[]
                    {
                        xlWorkSheet.Cells[indexRow, 1].value,
                        xlWorkSheet.Cells[indexRow, 2].value,
                        xlWorkSheet.Cells[indexRow, 3].value,
                        xlWorkSheet.Cells[indexRow, 4].value.ToString(),
                        xlWorkSheet.Cells[indexRow, 5].value
                    };

                    dgv_Excel.Rows.Add(row);
                }
            }
        }

        private void VeriAktarım(ComboBox _comboBox, int _number)
        {
            for (indexRow = 2; indexRow <= xlWorkSheet.Rows.Count; indexRow++)
            {
                if (xlWorkSheet.Cells[indexRow, _number].value == null)
                    break;
                else
                    _comboBox.Items.Add(xlWorkSheet.Cells[indexRow, _number].value);
            }
        }

        private void DontAllowToText(ComboBox comboBox1, ComboBox comboBox2, TextBox textBox1, MaskedTextBox textBox2, TextBox textBox3)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void CalisanBilgileriAutoComplete(int index)
        {
            xlWorkBook = xlApp.Workbooks.Open(fileName);
            xlWorkSheet = xlWorkBook.Worksheets["Nöbet"];

            txt_Unvan.Text = xlWorkSheet.Cells[index, 7].value.ToString();
            txt_Telefon.Text = xlWorkSheet.Cells[index, 8].value.ToString();
            txt_Mail.Text = xlWorkSheet.Cells[index, 9].value.ToString();

            xlWorkBook.Close();
            xlApp.Quit();
        }

        private void YeniNobetciEkle(ComboBox nobetci, TextBox unvan, MaskedTextBox telefon, TextBox mail, DateTimePicker tarih)
        {
            try
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgv_Excel);
                newRow.Cells[0].Value = nobetci.Text;
                newRow.Cells[1].Value = unvan.Text;
                newRow.Cells[2].Value = telefon.Text;
                newRow.Cells[3].Value = mail.Text;
                newRow.Cells[4].Value = tarih.Text;
                dgv_Excel.Rows.Add(newRow);
            }
            catch { }
        }
        
        private void ExcelUpdate()
        {
            Baglantı(fileName);
            dgv_Excel.AllowUserToAddRows = false;

            int rowIndex = 2;

            foreach (DataGridViewRow row in dgv_Excel.Rows)
            {
                for (int i = 0; i < dgv_Excel.Columns.Count; i++)
                {
                    xlWorkSheet.Cells[rowIndex, i + 1] = row.Cells[i].Value.ToString();
                }
                rowIndex++;
            }

            dgv_Excel.AllowUserToAddRows = true;
            xlApp.Visible = true;
        }
    }
}
