using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ImageViewer
{
    public partial class MainWindow : Window
    {
        private double currentAngle = 0; // хранение текущего угла поворота

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RotateLeft_Click(object sender, RoutedEventArgs e)
        {
            currentAngle -= 90; // Уменьшаем угол на 90 градусов
            RotateImage(image1);
        }

        private void RotateRight_Click(object sender, RoutedEventArgs e)
        {
            currentAngle += 90; // Увеличиваем угол на 90 градусов
            RotateImage(image1);
        }

        private void RotateImage(Image image)
        {
            // Создаем новый RotateTransform и применяем его к изображению
            RotateTransform rotateTransform = new RotateTransform(currentAngle);
            image.RenderTransform = rotateTransform;
        }
    }
}
