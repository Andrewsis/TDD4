namespace TDD4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }


    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) : base("Rectangle")
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }


    public class Parallelogram : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double Side { get; set; }

        public Parallelogram(double baseLength, double height, double side) : base("Parallelogram")
        {
            Base = baseLength;
            Height = height;
            Side = side;
        }

        public override double GetArea()
        {
            return Base * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Base + Side);
        }
    }


    public class ShapeContainer
    {
        private List<Shape> shapes = new List<Shape>();

        public int Count => shapes.Count;

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public void RemoveShape(Shape shape)
        {
            shapes.Remove(shape);
        }

        public void DisplayAllShapes()
        {
            foreach (var shape in shapes)
            {
                shape.DisplayInfo();
            }
        }

        public void DisplayShapesByType(string shapeType)
        {
            foreach (var shape in shapes)
            {
                if (shape.Name == shapeType)
                {
                    shape.DisplayInfo();
                }
            }
        }

        public Shape this[int index] => shapes[index];
    }


}
