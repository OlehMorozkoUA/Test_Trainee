using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Sortable_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*-------------Data for constructor------*/
            double side = 2;

            double width = 2;
            double heightR = 3;

            double baseSide = 2;
            double heightT = 3;

            double radius = 1;
            /*-------------Data for constructor------*/

            /*-------------Shapes-------------------*/
            Square square = new Square(side);
            Rectangle rectangle = new Rectangle(width, heightR);
            Triangle triangle = new Triangle(baseSide, heightT);
            Circle circle = new Circle(radius);
            /*-------------Shapes-------------------*/

            /*------------- List shapes-------------------*/
            List<Shape> shapes = new List<Shape> { square, rectangle, triangle, circle };
            /*------------- List shapes-------------------*/

            /*------------- display list shapes-------------------*/
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
            /*------------- display list shapes-------------------*/

            /*------------- sort list shapes-------------------*/
            shapes.Sort();
            /*------------- sort list shapes-------------------*/
            Console.WriteLine();

            /*------------- display sorted ascending list shapes-------------------*/
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
            /*------------- display sorted ascending list shapes-------------------*/
            Console.WriteLine(
                );
            shapes.Sort(new ShapeDescendingComparer());
            /*------------- display sorted descending list shapes-------------------*/
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
            /*------------- display sorted descending list shapes-------------------*/

            Console.ReadLine();
        }
    }
}
