using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;



namespace Controladora
{
    public class BdComun
    {
        public static MySqlConnection InsertarValores(string user, string password)
        {
            string server = "sql10.freemysqlhosting.net";
            string database = "sql10501139";
            string passsword = "7L8lWLZdHR";




            string text = "INSERT INTO usuarios (idusuarios, password) VALUES('" + user + "', '" + password + "');";
            MySqlConnection conectar = new MySqlConnection("server=" + server +";database=" + database +";Uid=" + database +";pwd =" + passsword + ";");


            conectar.Open();
            MySqlCommand comm = conectar.CreateCommand();
            comm.CommandText = text;

            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Error");
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
            string login = "SELECT * FROM usuarios WHERE idusuarios= '" + user + "' and password= '" + password + "';";
            MySqlConnection conectar = new MySqlConnection("server = sql10.freemysqlhosting.net; database = sql10501139; Uid = sql10501139; pwd =7L8lWLZdHR;");


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



    }
}
