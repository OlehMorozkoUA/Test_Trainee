using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Sortable_Shapes
{
    public abstract class Shape : IComparable<Shape>
    {
        public abstract double Area();

        public int CompareTo(Shape other)
        {
            return Area().CompareTo(other.Area());
        }

        public override string ToString()
        {
            return $"{GetType().Name.ToString()}: {Area()}";
        }
    }

    public class ShapeDescendingComparer : IComparer<Shape>
    {
        public int Compare(Shape shape1, Shape shape2)
        {
            if (shape1.Area() < shape2.Area())
                return 1;
            else if (shape1.Area() > shape2.Area())
                return -1;
            else
                return 0;
        }
    }
}
