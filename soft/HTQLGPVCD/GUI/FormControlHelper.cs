using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class FormControlHelper
    {
        public static void ClearTextComboBox(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox || control is MaskedTextBox || control is ComboBox)
                {
                    if (control is TextBox || control is MaskedTextBox)
                    {
                        control.Text = string.Empty;
                    }
                    else if (control is ComboBox)
                    {
                        ((ComboBox)control).SelectedIndex = -1;
                        ((ComboBox)control).Text = string.Empty; // Xóa nội dung hiển thị trong ComboBox
                    }
                }
                // Kiểm tra xem Control có chứa các Control con hay không
                if (control.Controls.Count > 0)
                {
                    ClearTextComboBox(control); // Gọi đệ quy cho các Control con
                }
            }
        }

        public static void ClearComboBox(params ComboBox[] comboBoxes)
        {
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.Text = string.Empty;
            }
        }

        public static void LoadDataGridView(DataGridView datagridview, DataTable datatable)
        {
            datagridview.DataSource = datatable;
        }




    }
}
