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
    /// Lógica de interacción para InicioPolicia.xaml
    /// </summary>
    public partial class InicioPolicia : Window
    {
        PoliciaManager _manager = new PoliciaManager();
        public InicioPolicia()
        {
            InitializeComponent();


        }

        public void Login(object sender , RoutedEventArgs e)
        {
            int id_policia = int.Parse(txtnplaca.Text);
            string contrasenna = txtpasswd.Password;
            int resultado = _manager.LoginEmpleado(id_policia, contrasenna);

            if (resultado == 0) 
            {
                CentralPolicia centralPolicia = new CentralPolicia();
                centralPolicia.Show();
            }

        }
    }
}
