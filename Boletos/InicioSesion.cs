using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletos
{
    public partial class InicioSesion : Form
    {
        string connectionString = "Data Source=169.254.1.103;Initial Catalog=estacionamiento;User ID=TORREEROB;Password=erob2023pepe$$mexico0899";

        public InicioSesion()
        {
            InitializeComponent();
            this.AcceptButton = iniciarsesion;

        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea regresar a la página principal? ", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                e.Cancel = false;
                buscarTorre buscartorre = new buscarTorre();
                buscartorre.Show();

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void iniciarsesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(admin.Text) || string.IsNullOrWhiteSpace(contraseña.Text))

            {
                // Muestra un mensaje de error
                MessageBox.Show("Hay campos incompletos, favor de rellenarlos correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                admin.Text = "";

                // Detiene la ejecución del código para que el formulario no se cierre
                return;
            }

            string usuario = admin.Text;
            string contraseña1 = contraseña.Text;

            string query = "SELECT COUNT(*) FROM UsuariosAdministrador WHERE Nombre = @Usuario AND Contra = @Contraseña";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario); // Cambiado a @Usuario
                command.Parameters.AddWithValue("@Contraseña", contraseña1); // Cambiado a contraseña1

                connection.Open();

                int count = (int)command.ExecuteScalar(); 

                if (count > 0)
                {
                    // Inicio de sesión exitoso
                    ///MessageBox.Show("¡Inicio de sesión exitoso!");
                    // Aquí puedes abrir el siguiente formulario o realizar acciones posteriores
                    transacciones Transacciones = new transacciones();
                    Transacciones.Show();
                    this.Hide();


                }
                else
                {
                    // Usuario o contraseña incorrectos
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    admin.Text = "";
                    contraseña.Text = "";
                    return;
                }
            }
        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {
            ///contraseña.PasswordChar = '●';

            contraseña.MaxLength = 9;
            if (contraseña.Text == "Contraseña")
            {
                contraseña.UseSystemPasswordChar = false;

            }
            else
                contraseña.UseSystemPasswordChar = true;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            buscarTorre buscarTorre = new buscarTorre();
            buscarTorre.Show();
            this.Hide();
        }

        private void InicioSesion_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
