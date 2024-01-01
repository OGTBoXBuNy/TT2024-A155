using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LIBRERIAS



namespace TT2024_A155
{
    internal class Conexion
    {
        public static SqlConnection conexion()
        {

            string strConexion = Properties.Settings.Default.SecretMessage;
            SqlConnection nuevaConexion = new SqlConnection(strConexion);
            return nuevaConexion;
        }
    }
}
