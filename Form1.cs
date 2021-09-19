using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        QuadraticEquation a = new QuadraticEquation();
        public Form1()
        {
           
            InitializeComponent();
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
           new Check(textBoxA);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.A =  Converter.Convert(textBoxA);
            a.B =  Converter.Convert(textBoxB);
            a.C = Converter.Convert(textBoxC);
            a.D =  QuadraticEquation.GetD(a.A, a.B, a.C);
            a.X1andX2 = (QuadraticEquation.GetX1AndX2(a.A, a.B, a.C, a.D));
            
            MessageBox.Show($"x1= {a.X1andX2.Item1}");
        }

        private void textBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            new Check(textBoxB);
        }

        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            new Check(textBoxC);
        }
    }
}
