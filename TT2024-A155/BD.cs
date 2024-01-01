using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace TT2024_A155
{
    internal class BD
    {
        //VARIABLES
        private SqlCommand Comando;

        private SqlDataReader Lector;
        private DataTable dt;
        private SqlDataAdapter da;


        //----------------------------------INICIO DE SESION----------------------------------------------
        public int inicioSesion(string us, string contra)
        {
            int contador = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {

                    if (validarUsuario(us) == 1)
                    {
                        string contraHash = "";
                        this.Comando = new SqlCommand(string.Format("SELECT contrasenia FROM usuario WHERE nombre_usuario = '{0}'", us), nuevacon);
                        nuevacon.Open();
                        Lector = this.Comando.ExecuteReader();
                        if(Lector.Read()) 
                            contraHash =  Lector["contrasenia"].ToString();
                        if (BC.Verify(contra,contraHash))
                            contador++;
                    }
                    
                    
                    nuevacon.Close();
                }
                return contador;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return contador;
            }
            
        }
        //----------------------------------VALIDAR USUARIO EXISTENTE----------------------------------------------
        public int validarUsuario(string us)
        {
            int contador = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    this.Comando = new SqlCommand(string.Format("SELECT * FROM usuario WHERE nombre_usuario = '{0}';", us), nuevacon);
                    nuevacon.Open();
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read()) { contador++; }
                    Lector.Close();
                    nuevacon.Close();
                }
                return contador;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return contador;
            }
        }


        //----------------------------------REGISTRAR USUARIO----------------------------------------------
        public int registroUsuario(string rol, string us, string nombre, string contra, string direccion, string telefono, string correo)
        {
            int contador = 0;
            int x = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    nuevacon.Open();

                    if (validarUsuario(us) == 0)
                    {
                        this.Comando = new SqlCommand(string.Format("SELECT idrol FROM ROL WHERE nombre = '{0}'", rol), nuevacon);
                        Lector = this.Comando.ExecuteReader();
                        while (Lector.Read()) { x = Int32.Parse(Lector["idrol"].ToString()); }
                        Lector.Close();
                        string contraHash = BC.HashPassword(contra);
                        this.Comando = new SqlCommand(string.Format("INSERT INTO usuario (idrol,nombre_usuario,nombre_real,contrasenia,direccion,telefono,correo) VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}');", x, us, nombre, contraHash, direccion, telefono, correo), nuevacon);
                        this.Comando.ExecuteNonQuery();
                        MessageBox.Show("Se registro correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe ese nombre de usuario");
                    }
                    nuevacon.Close();
                }
                return contador;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return contador;
            }
        }

    }
}
