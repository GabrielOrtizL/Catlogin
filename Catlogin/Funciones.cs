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
            MySqlCommand sentencia = new MySqlCommand(String.Format("select * from usuarios"), Conexion.obtenerConexion());
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
            MySqlCommand sentencia = new MySqlCommand(String.Format("select * from usuarios where user='"+usuario+"' and password='"+contra+"'"), Conexion.obtenerConexion());
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

        public static String insertar(string usuario, string contra)
        {
            string mensaje;
            string query = "INSERT INTO usuarios (user, password) VALUES ( '" + usuario + "', '" + contra + "');";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se registro usuario";
            }
            return mensaje;
        }

        public static string actualizar(int id, string usuario, string contra)
        {
            string mensaje;
            string query = "UPDATE usuarios SET user ='" + usuario + 
                           "', password='" + contra + 
                           "' WHERE id =" + id + ";";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se actualizó el usuario";
            }
            return mensaje;
        }

        public static string eliminar(int id)
        {
            string mensaje;
            string query = "DELETE FROM usuarios WHERE id  =" + id + ";";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se eliminó el usuario";
            }
            return mensaje;
        }

        public static List<Barcode> veralmacen()
        {
            List<Barcode> lista = new List<Barcode>();
            MySqlCommand sentencia = new MySqlCommand(String.Format("select * from stock"), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            while (lector.Read())
            {
                Barcode bar = new Barcode();
                bar.id = lector.GetInt32(0);
                bar.label = lector.GetString(1);
                lista.Add(bar);
            }

            return lista;
        }

        public static String guardar(string caramelo)
        {
            string mensaje;
            string query = "INSERT INTO stock (label) VALUES ( '" + caramelo + "');";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se registro stock";
            }
            return mensaje;
        }


        public static string actualizardulces(int id, string caramelo)
        {
            string mensaje;
            string query = "UPDATE stock SET label ='" + caramelo +"' WHERE id =" + id + ";";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se actualizó el stock";
            }
            return mensaje;
        }

        public static string eliminardulces(int id)
        {
            string mensaje;
            string query = "DELETE FROM stock WHERE id  =" + id + ";";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se eliminó el stock";
            }
            return mensaje;
        }
    }
}
