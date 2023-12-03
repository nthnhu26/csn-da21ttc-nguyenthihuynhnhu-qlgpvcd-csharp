using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;


namespace GUI
{
    public class PrintList
    {
        public static void InExcel(DataGridView dataGridView)
        {
            if (dataGridView != null && dataGridView.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Chọn vị trí lưu file Excel";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    using (ExcelPackage excelPackage = new())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Danh sách");

                        // Ghi dữ liệu từ DataGridView vào ExcelWorksheet
                        for (int i = 1; i <= dataGridView.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
                        }

                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;
                            }
                        }
                        // Lưu file Excel
                        FileInfo excelFile = new FileInfo(filePath);
                        excelPackage.SaveAs(excelFile);
                    }

                    MessageBox.Show("Dữ liệu đã được xuất thành công ra file Excel.");
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất ra file Excel.");
            }

        }
    }
}
