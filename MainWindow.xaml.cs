using Abstract_Factory;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AbstractFactoryExample
{
    public partial class MainWindow : Window
    {
        private string selectedColor = "Red"; // Цвет по умолчанию

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ColorComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                selectedColor = selectedItem.Tag.ToString(); // Получаем выбранный цвет
            }
        }

        private void CircleButton_Click(object sender, RoutedEventArgs e)
        {
            IFigure circle = new Circle(selectedColor);
            DrawingCanvas.Children.Clear(); // Очистка предыдущих фигур
            DrawingCanvas.Children.Add(circle.Draw());
        }

        private void SquareButton_Click(object sender, RoutedEventArgs e)
        {
            IFigure square = new Square(selectedColor);
            DrawingCanvas.Children.Clear(); // Очистка предыдущих фигур
            DrawingCanvas.Children.Add(square.Draw());
        }

        private void TriangleButton_Click(object sender, RoutedEventArgs e)
        {
            IFigure triangle = new Triangle(selectedColor);
            DrawingCanvas.Children.Clear(); // Очистка предыдущих фигур
            DrawingCanvas.Children.Add(triangle.Draw());
        }
    }
}