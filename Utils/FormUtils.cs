using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneGroup.Utils
{
    public class FormUtils
    {
        public static bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        public static void ValidateNumericInput(TextBox textBox, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                textBox.BackColor = Color.Red;
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                textBox.BackColor = SystemColors.ActiveCaption;
            }
        }

        public static void ValidateRequiredField(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.BackColor = Color.Red;
                MessageBox.Show("Este campo é obrigatório.");
            }
            else
            {
                textBox.BackColor = SystemColors.ActiveCaption;
            }
        }
    }
}
