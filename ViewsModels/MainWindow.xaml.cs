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

namespace Policia
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
        public void abrirpolicia(Object sender, RoutedEventArgs e)
        {
            InicioPolicia _abrirpolicia = new InicioPolicia();
            _abrirpolicia.Show();
        }
        public void abrirciudadano(Object sender, RoutedEventArgs e)
        {
            Ciudadano _abrirciudadano = new Ciudadano();
            _abrirciudadano.Show();
        }
    }
}