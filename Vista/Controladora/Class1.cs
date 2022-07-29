using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Security.Cryptography;



namespace Controladora
{
    public class BdComun
    {
        // Funcion utilizada para encriptar clave

        public static string Encriptar(string password)
        {
            using(MD5CryptoServiceProvider md5=new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(password));
                return Convert.ToBase64String(data);
            }
        }

        // Funcion designada para insertar los valores al registrarse

        public static MySqlConnection InsertarValores(string user, string password)
        {

            // informacion de base de datos remota

            string server = "sql5.freemysqlhosting.net";
            string database = "sql5509494";
            string passsword = "a8UvGA27ii";

            // comando de MySql
            string text = "INSERT INTO usuarios (idusuarios, password) VALUES('" + user + "', '" + password + "');";
            MySqlConnection conectar = new MySqlConnection("server=" + server +";database=" + database +";Uid=" + database +";pwd =" + passsword + ";");

            // Creamos la conexion
            conectar.Open();
            MySqlCommand comm = conectar.CreateCommand();
            comm.CommandText = text;

            try
            {
                comm.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Tu cuenta ha sido creada", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                string aux_text = "Se ha producido un error. Es posible que el nombre de usuario ya este en uso";
                System.Windows.Forms.MessageBox.Show(aux_text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerramos la conexion
                conectar.Close();
            }

            return conectar;
        }

        // Funcion designada para eliminar usuario
        public static string Eliminar(string user)
        {
            string server = "sql5.freemysqlhosting.net";
            string database = "sql5509494";
            string passsword = "a8UvGA27ii";

            string text = "DELETE FROM usuarios WHERE idusuarios = '" + user + "';";
            MySqlConnection conectar = new MySqlConnection("server=" + server + ";database=" + database + ";Uid=" + database + ";pwd =" + passsword + ";");


            conectar.Open();
            MySqlCommand comm = conectar.CreateCommand();
            comm.CommandText = text;

            comm.ExecuteNonQuery();
            System.Windows.Forms.MessageBox.Show("Tu cuenta ha sido eliminado", "Eliminacion completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conectar.Close();

            return "";
        }

        // Funcion que se encarga de revisar si los valores ingresados por pantalla coinciden con un usuario registrado
        public static bool CheckearValores(string user, string password)
        {
            bool iniciar = false;
            string password_encriptada = Encriptar(password);

            string login = "SELECT * FROM usuarios WHERE idusuarios= '" + user + "' and password= '" + password_encriptada + "';";
            MySqlConnection conectar = new MySqlConnection("server = sql5.freemysqlhosting.net; database = sql5509494; Uid = sql5509494; pwd =a8UvGA27ii;");


            conectar.Open();
            MySqlCommand check_User_Name = new MySqlCommand(login, conectar);


            var result = check_User_Name.ExecuteScalar();
            conectar.Close();

            // Si el usuario existe, el valor recibido no sera null
            if (result != null)
            {
                iniciar = true;
            }

            return iniciar;

        }

        // Funcion para obtener el dinero almacenado en la cuenta
        public static string ObtenerCuenta(string user)
        {
            string cuenta_comando = "SELECT cuenta FROM usuarios WHERE idusuarios ='" + user + "'";
            MySqlConnection conectar = new MySqlConnection("server = sql5.freemysqlhosting.net; database = sql5509494; Uid = sql5509494; pwd =a8UvGA27ii;");
            conectar.Open();
            MySqlCommand check_cuenta = new MySqlCommand(cuenta_comando, conectar);
            var aux_cuenta = check_cuenta.ExecuteScalar();
            conectar.Close();
            string cuenta = Convert.ToString(aux_cuenta);

            return cuenta;
            
        }

        // Funcion para aumentar o reducir la cuenta del usuario
        public static void UpdateCuenta(string user, string valor)
        {
            string update_comando = "UPDATE usuarios SET cuenta =" + valor + " WHERE idusuarios = '" + user + "';";
            MySqlConnection conectar = new MySqlConnection("server = sql5.freemysqlhosting.net; database = sql5509494; Uid = sql5509494; pwd =a8UvGA27ii;");
            conectar.Open();
            MySqlCommand cmd = new MySqlCommand(update_comando, conectar);
            int numRowsUpdated = cmd.ExecuteNonQuery();
            conectar.Close();    

        }

    }
}
