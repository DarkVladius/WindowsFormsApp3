using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Check
    {
        private TextBox textbox;
        public Check(TextBox textbox)
        {
            textbox.KeyPress += CheckingCharacterInput;
            this.textbox = textbox;
        }
        private void CheckingCharacterInput(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled =  true;
            }
            if (textbox.Text == ",") 
            {
                textbox.Text = textbox.Text.Replace(",", ".");
            }
            if (textbox.Text.Length == 0 && e.KeyChar == '-')
            {
                e.Handled = false;
            }
        }
    }
}
