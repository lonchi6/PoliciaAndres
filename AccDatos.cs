using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Policia
{
    public class AccDatos
    {
        MySqlConnection _conn;
        MySqlCommand _cmd;

        public AccDatos()
        {
            _conn = new MySqlConnection("server=127.0.0.1;" +
                                        "port=3309;" +
                                        "uid=root;" +
                                        "pwd=1234;" +
                                        "database=policia");

            _cmd = new MySqlCommand();
        }

        public int PA_LoginEmpleado(int usuario,
                                    string pass)
        {
            int resultado = -99;
            try
            {
                //Apertura de conexion y preparacion del PA
                _conn.Open();
                _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.CommandText = "LoginPolicia";

                //Parametros de entrada
                _cmd.Parameters.AddWithValue("_nplaca", usuario);
                _cmd.Parameters["_nplaca"].Direction = ParameterDirection.Input;

                _cmd.Parameters.AddWithValue("_pass", pass);
                _cmd.Parameters["_pass"].Direction = ParameterDirection.Input;

                //Parametros de salida
                _cmd.Parameters.Add(new MySqlParameter("_res", MySqlDbType.Int32));
                _cmd.Parameters["_res"].Direction = ParameterDirection.Output;

                _cmd.ExecuteNonQuery();

                resultado = (int)_cmd.Parameters["_res"].Value;
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return resultado;
            }

            return resultado;

        }
        public string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
    }
}
