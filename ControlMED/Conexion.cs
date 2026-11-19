using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlMED
{
    internal class Conexion
    {
        private static string cadena ="Server=localhost;" +"Database=Veterinaria_2;" +"User ID=root;" +"Password=1234;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}