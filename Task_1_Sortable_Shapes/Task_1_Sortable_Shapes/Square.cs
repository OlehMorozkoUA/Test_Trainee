using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Sortable_Shapes
{
    public class Square : Shape
    {
        public double Side { get; set; }
        public Square() { }
        public Square(double side)
        {
            Side = side;
        }
        public override double Area()
        {
            return Side * Side;
        }
    }
}
