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

        public static string Encriptar(string password)
        {
            using(MD5CryptoServiceProvider md5=new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(password));
                return Convert.ToBase64String(data);
            }
        }

        public static MySqlConnection InsertarValores(string user, string password)
        {
            string server = "sql5.freemysqlhosting.net";
            string database = "sql5509494";
            string passsword = "a8UvGA27ii";

            string text = "INSERT INTO usuarios (idusuarios, password) VALUES('" + user + "', '" + password + "');";
            MySqlConnection conectar = new MySqlConnection("server=" + server +";database=" + database +";Uid=" + database +";pwd =" + passsword + ";");


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
                conectar.Close();
            }

            return conectar;
        }

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

            if (result != null)
            {
                iniciar = true;
            }

            return iniciar;

        }

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
