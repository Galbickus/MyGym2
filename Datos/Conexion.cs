using System;
using MySql.Data.MySqlClient;

namespace MyGym2.Datos
{
    internal class Conexion
    {
        // Variables de conexión
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;

        private static Conexion con = null;

        // Constructor privado
        private Conexion()
        {
            this.baseDatos = "";
            this.servidor = "";    //COMPLETAR Y NO SUBIR A REPOOOOOO
            this.puerto = "";
            this.usuario = "";
            this.clave = "";
        }

        // Método para crear y devolver una conexión MySQL
        public MySqlConnection CrearConexion()
        {
            MySqlConnection cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw new Exception("Error al construir la cadena de conexión: " + ex.Message);
            }

            return cadena;
        }

        // Método para obtener la única instancia (patrón Singleton)
        public static Conexion GetInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
