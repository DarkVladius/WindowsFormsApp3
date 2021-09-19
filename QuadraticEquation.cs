using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
     class QuadraticEquation
    {
        public (double, double) X1andX2 { get; set;}
        public double C { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double D { get; set; }
        public static double GetD(double A, double B, double C) 
        {
           return B * B - 4 * A * C;
        }
      public  static (double X1,double X2) GetX1AndX2(double A, double B, double C, double D)
        {
          
            return ((-1 * B - Math.Sqrt(D))/2*A, (-1 * B + Math.Sqrt(D)) / 2 * A);
        }
    }
}
