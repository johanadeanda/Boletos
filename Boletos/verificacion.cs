using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletos
{
    public partial class verificacion : Form
    {
        string connectionString = "Data Source=169.254.1.103;Initial Catalog=estacionamiento;User ID=TORREEROB;Password=erob2023pepe$$mexico0899";

        public verificacion()
        {
            InitializeComponent();
            this.AcceptButton = aceptar;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(admin.Text) || string.IsNullOrWhiteSpace(contraseña.Text))
            {
                MessageBox.Show("Hay campos incompletos, favor de rellenarlos correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                admin.Text = "";
                return;
            }

            string usuario = admin.Text;
            string contraseña1 = contraseña.Text;

            string query = "SELECT COUNT(*) FROM UsuariosAdministrador WHERE Nombre = @Usuario AND Contra = @Contraseña";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña1);

                connection.Open();

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    // Inicio de sesión exitoso
                    this.DialogResult = DialogResult.OK;  // Indicar que la verificación fue exitosa
                    this.Close();  // Cerrar el formulario de verificación
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

        private void admin_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {

            contraseña.MaxLength = 9;
            if (contraseña.Text == "Contraseña")
            {
                contraseña.UseSystemPasswordChar = false;

            }
            else
                contraseña.UseSystemPasswordChar = true;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void verificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
           /// Application.Exit();
        }
    }
}
