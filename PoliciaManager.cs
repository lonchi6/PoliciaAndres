using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Policia
{
    public class PoliciaManager
    {
        public AccDatos _ad = new AccDatos();
        public int LoginEmpleado(int usuario,
                                string pass)
        {
            int resultado = _ad.PA_LoginEmpleado(usuario, pass);

            if (resultado == 1)
            {
                MessageBox.Show("Usuario incorrectos");
            }
            else if (resultado == 2)
            {
                MessageBox.Show("Contrasenna incorrecta");

            }
            else if (resultado == 0)
            {
                MessageBox.Show("Bienvenido " + usuario);
            }
            else
            {
                MessageBox.Show("Error");
            }
            return resultado;
        }

    }

}
