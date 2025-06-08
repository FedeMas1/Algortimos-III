using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void llblRegistarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formRegistro form2 = new formRegistro();
            form2.Show();
        }

        private void llblCambiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formCambio form3 = new formCambio();
            form3.Show();
        }

        private void bttnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioMail = txtBUsuario.Text.Trim();
            string contraseña = txtBContraseña.Text;

            if (string.IsNullOrEmpty(usuarioMail) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("No se han ingresado las credenciales");
                return;
            }

            // conexion a sql
            string cadenaConexion = @"Data Source=localhost\SQLEXPRESS10;Initial Catalog=Algoritmos;Integrated Security=True; TrustServerCertificate=True;";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string consulta = @"Select id_Usuario, nombre, apellido, nivel FROM Usuarios WHERE (nombre_Usuario = @usuario OR email = @usuario) AND contraseña = @contraseña";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@usuario", usuarioMail);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);

                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        int nivel = Convert.ToInt32(reader["nivel"]);
                        string nombreCompleto = reader["nombre"].ToString() + " " + reader["apellido"].ToString();

                        this.Hide();

                        switch (nivel)
                        {
                            case 1:
                                new FormEmpleado(nombreCompleto).Show();
                                break;

                            case 2:
                                new FormEncargado(nombreCompleto).Show();
                                break;

                            case 3:
                                new FormAdministrador(nombreCompleto).Show();
                                break;

                            default:
                                MessageBox.Show("Nivel de usuario no existente");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseñ incorrectos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }
               
        }
    }
}
