using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Catlogin
{
    class Funciones
    {
        public static List<Catusers> mostrar()
        {
            List<Catusers> lista = new List<Catusers>();
            MySqlCommand sentencia = new MySqlCommand(String.Format("select id, user, password from catusers"), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            while (lector.Read())
            {
                Catusers usr = new Catusers();
                usr.id = lector.GetInt32(0);
                usr.user = lector.GetString(1);
                usr.password = lector.GetString(2);
                lista.Add(usr);
            }

            return lista;
        }


        public static bool login(string usuario, string contra)
        {
            bool bandera = false;
            MySqlCommand sentencia = new MySqlCommand(String.Format("select * from catusers where user='"+usuario+"' and password='"+contra+"'"), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.Read())
            {
                bandera = true;
            }
            else
            {
                bandera = false;
            }
            return bandera;
        }
    }
}
