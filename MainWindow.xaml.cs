using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EP_01___3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void boton_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "CAMBIADO!";
            boton2.IsEnabled = false;
        }

        private void boton2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("cuidado con lo que tocas");
        }

        private void boton3_Click(object sender, RoutedEventArgs e)
        {
            boton2.IsEnabled = true;
            label.Content = "label normal";
        }
    }
}