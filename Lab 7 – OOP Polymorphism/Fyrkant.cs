using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Polymorphism
{
    internal class Fyrkant : Geometri
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Fyrkant() 
        {
            Height = 4;
            Width = 5;
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
