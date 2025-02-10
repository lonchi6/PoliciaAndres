using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Policia
{
    /// <summary>
    /// Lógica de interacción para CentralPolicia.xaml
    /// </summary>
    public partial class CentralPolicia : Window
    {
        public CentralPolicia()
        {
            InitializeComponent();
        }

        public void DatosCiudadano(object sender, RoutedEventArgs e)
        {
            stkDatos.Visibility = Visibility.Visible;
        }
        public void IntroducirMatricula(object sender, RoutedEventArgs e)
        {
            stkDatos.Visibility = Visibility.Collapsed;
        }
    }
}
