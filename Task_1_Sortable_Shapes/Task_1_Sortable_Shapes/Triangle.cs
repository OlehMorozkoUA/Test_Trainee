using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Sortable_Shapes
{
    public class Triangle : Shape
    {
        public double BaseSide { get; set; }
        public double Height { get; set; }
        public Triangle() { }
        public Triangle(double baseSide, double height)
        {
            BaseSide = baseSide;
            Height = height;
        }
        public override double Area()
        {
            return BaseSide * Height / 2;
        }
    }
}
