using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class QuadratitEquation
    {
        double a, b, c, d;

        public QuadratitEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            
            CalculateD();
        }

        public string D => d.ToString();

        public string X1 => d >= 0 ? ((-b + Math.Sqrt(d)) / 2 * a).ToString() : "корня нет";

        public string X2 => d > 0 ? ((-b - Math.Sqrt(d)) / 2 * a).ToString() : "корня нет";

        private void CalculateD()
        {
            d = Math.Pow(b, 2) - 4 * a * c;
        }
    }
}
