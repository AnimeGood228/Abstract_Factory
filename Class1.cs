using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Abstract_Factory
{
    public interface IFigure
    {
        Shape Draw(); // Метод для отрисовки фигуры
    }

    // Circle.cs


    public class Circle : IFigure
    {
        private string color;

        public Circle(string color)
        {
            this.color = color;
        }

        public Shape Draw()
        {
            Ellipse ellipse = new Ellipse
            {
                Width = 50,
                Height = 50,
                Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(color) // Используем выбранный цвет
            };
            return ellipse;
        }
    }

    // Square.cs


    public class Square : IFigure
    {
        private string color;

        public Square(string color)
        {
            this.color = color;
        }

        public Shape Draw()
        {
            Rectangle rectangle = new Rectangle
            {
                Width = 50,
                Height = 50,
                Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(color) // Используем выбранный цвет
            };
            return rectangle;
        }
    }

    // Triangle.cs


    public class Triangle : IFigure
    {
        private string color;

        public Triangle(string color)
        {
            this.color = color;
        }

        public Shape Draw()
        {
            Polygon triangle = new Polygon
            {
                Points = new PointCollection(new Point[] { new Point(25, 0), new Point(50, 50), new Point(0, 50) }),
                Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(color) // Используем выбранный цвет
            };
            return triangle;
        }
    }
}