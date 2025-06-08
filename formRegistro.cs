using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class formRegistro : Form
    {
        public formRegistro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // nada
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string nombre = txtbNombre.Text;
            string apellido = txtbApellido.Text;
            string nUsuario = txtbNUsuario.Text;
            string mail = txtbMail.Text;
            string contraseña = txtbContraseña.Text;
            string Rcontraseña = txtbRContraseña.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(nUsuario) || string.IsNullOrEmpty(mail) ||
                string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(Rcontraseña)
                )
            {
                MessageBox.Show("Todos los campos deben ser completados");
            }

            if (!mail.Contains("@"))
            {
                MessageBox.Show("El mail no tiene @");
                return;
            }
            ;

            if (contraseña.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener por lo menos 8 caracteres");
                return;
            }
            ;

            if (!contraseña.Any(char.IsUpper))
            {
                MessageBox.Show("La contraseña no contiene mayusculas");
                return;
            }

            if (!contraseña.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña no contiene ningun numero");
                return;
            }

            if (contraseña != Rcontraseña)
            {
                MessageBox.Show("La contrasela ingresada no coincide");
                return;
            }

            if (contraseña.Length >= 8 && contraseña.Any(char.IsUpper) && contraseña.Any(char.IsDigit) && contraseña == Rcontraseña)
            {
                MessageBox.Show("Registro exitoso");
            }

            // conexion a sql
            string cadenaConexion = @"Data Source=localhost\SQLEXPRESS10;Initial Catalog=Algoritmos;Integrated Security=True; TrustServerCertificate=True;";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    SqlCommand verificarUsuario = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE nombre_Usuario = @nUsuario OR email = @mail", conexion);
                    verificarUsuario.Parameters.AddWithValue("@nUsuario", nUsuario);
                    verificarUsuario.Parameters.AddWithValue("@mail", mail);

                    int existe = (int)verificarUsuario.ExecuteScalar();
                    if (existe > 0)
                    {
                        MessageBox.Show("Ya existe un usuario con ese nombre o correo");
                        return;
                    }

                    SqlCommand insertar = new SqlCommand(@"INSERT INTO Usuarios (nombre_Usuario, contraseña, email, nombre, apellido, nivel) 
                    VALUES (@nUsuario, @contraseña, @mail, @nombre, @apellido, @nivel)", conexion);

                    insertar.Parameters.AddWithValue("@nUsuario", nUsuario);
                    insertar.Parameters.AddWithValue("@contraseña", contraseña);
                    insertar.Parameters.AddWithValue("@mail", mail);
                    insertar.Parameters.AddWithValue("@nombre", nombre);
                    insertar.Parameters.AddWithValue("@apellido", apellido);
                    insertar.Parameters.AddWithValue("@nivel", 1);


                    int filas = insertar.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Usuario registrado correctamente");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al registrarse");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexion " + ex.Message);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtbApellido.Clear();
            txtbNombre.Clear();
            txtbMail.Clear();
            txtbContraseña.Clear();
            txtbNUsuario.Clear();
            txtbRContraseña.Clear();
        }
    }
    }
