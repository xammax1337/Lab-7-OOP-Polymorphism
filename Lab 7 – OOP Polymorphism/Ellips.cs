using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Polymorphism
{
    internal class Ellips : Geometri
    {
        public double Radius1 { get; set; }
        public double Radius2 { get; set; }

        public Ellips() 
        {
            Radius1 = 6;
            Radius2 = 3;
        }

        public override double Area()
        {
            return Math.PI * Radius1 * Radius2;
        }
    }
}
