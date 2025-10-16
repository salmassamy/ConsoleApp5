using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    #region Question01
    public interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }

    // Derived interfaces
    public interface ICircle : IShape { }
    public interface IRectangle : IShape { }

    // Circle implementation
    public class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Circle, Radius = {Radius}, Area = {Area:F2}");
        }
    }

    // Rectangle implementation
    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Rectangle, Width = {Width}, Height = {Height}, Area = {Area}");

        }
    }
}
#endregion