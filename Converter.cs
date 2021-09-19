using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Converter
    {
        public static double Convert(TextBox textbox)  => double.Parse(textbox.Text); 
        public static string Convert(double doubl) => doubl.ToString();

    }
}
