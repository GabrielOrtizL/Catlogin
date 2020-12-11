using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Catlogin
{
    class Conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;database=catcandy;Uid=root;pwd=Ga19331500*;");
            conexion.Open();
            return conexion;

        }

    }
}
