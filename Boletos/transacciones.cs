using ESC_POS_USB_NET.Printer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletos
{
    public partial class transacciones : Form

    {
      

        Printer printer = new Printer("EPSON TM-T88V Receipt");
        Bitmap imagen = new Bitmap(Properties.Resources.image);
        private string connectionString = "Data Source=169.254.1.103;Initial Catalog=estacionamiento;User ID=TORREEROB;Password=erob2023pepe$$mexico0899";
        public transacciones()
        {
            InitializeComponent();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void inicio_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            if (tipotransaccion.SelectedItem == null)
                {
                    MessageBox.Show("Faltan datos por seleccionar, intentalo de nuevo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
            string transacciones = tipotransaccion.SelectedItem.ToString();
            DateTime fechaInicio = inicio.Value;
            

            
            string formatoFecha = "yyyy-MM-dd";

            
            string consulta = "SELECT ID, FechaTransaccion, Monto, Tipo, Usuario, HoraTransaccion, UsuarioEnCaja " +
                      "FROM Transacciones " +
                      "WHERE FechaTransaccion = @FechaInicio AND Tipo=@tipoTransacciones";

            try
            {
                
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand(consulta, conexion);

                    comando.Parameters.Add("@tipoTransacciones", SqlDbType.VarChar).Value = transacciones;
                    comando.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = fechaInicio;
                    

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    vistatransacciones.DataSource = tabla; 

                    foreach (DataGridViewColumn column in vistatransacciones.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }

                    vistatransacciones.ColumnHeadersVisible = true;
                    vistatransacciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    vistatransacciones.Columns[0].HeaderText = "ID";
                    vistatransacciones.Columns[1].HeaderText = "Fecha";
                    vistatransacciones.Columns[2].HeaderText = "Monto Total";
                    vistatransacciones.Columns[3].HeaderText = "Tipo de Transacción";
                    vistatransacciones.Columns[4].HeaderText = "Usuario Admin";
                    vistatransacciones.Columns[5].HeaderText = "Hora de Movimiento";
                    vistatransacciones.Columns[6].HeaderText = "Usuario en Caja";
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void tipotransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void transacciones_Load(object sender, EventArgs e)
        {
            inicio.MaxDate = DateTime.Today;
            inicio.Value = DateTime.Today;
            guna2HtmlLabel1.Parent = guna2PictureBox2;
            guna2HtmlLabel1.ForeColor = Color.White;
        }

        private void reimprimir_Click(object sender, EventArgs e)
        {
            if (vistatransacciones.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = vistatransacciones.SelectedRows[0];

                string idTransaccion = selectedRow.Cells[0].Value.ToString();
                DateTime fecha = (DateTime)selectedRow.Cells[1].Value;
                string fechaTransaccion = fecha.ToString("dd 'de' MMMM 'del' yyyy", new System.Globalization.CultureInfo("es-ES")); // Formato de fecha "dd de MMMM del yyyy"
                string montoTotal = selectedRow.Cells[2].Value.ToString();
                string tipoTransaccion = selectedRow.Cells[3].Value.ToString();
                string usuarioAdmin = selectedRow.Cells[4].Value.ToString();
                string horaMovimiento = selectedRow.Cells[5].Value.ToString(); // Obtienes la cadena de tiempo de la base de datos

                string horaFormateada = ObtenerHoraFormateada(horaMovimiento);

                string usuarioEnCaja = selectedRow.Cells[6].Value.ToString();

                string contenidoImpresion = $"ID: {idTransaccion}\nFecha: {fechaTransaccion}\nMonto Total: {montoTotal}\nTipo de Transacción: {tipoTransaccion}\nUsuario Admin: {usuarioAdmin}\nHora: {horaFormateada}\nUsuario en Caja: {usuarioEnCaja}";

                Imprimir(contenidoImpresion, tipoTransaccion);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para reimprimir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string ObtenerHoraFormateada(string horaMovimiento)
        {
            int indicePunto = horaMovimiento.IndexOf('.'); // Encuentra el punto que separa los milisegundos

            if (indicePunto != -1) // Si se encuentra el punto de los milisegundos
            {
                return horaMovimiento.Substring(0, indicePunto); // Devuelve solo la parte de la hora sin los milisegundos
            }
            else
            {
                return horaMovimiento; // Devuelve la cadena original si no hay milisegundos
            }
        }


        private void Imprimir(string contenido, string tipoTransaccion)
            {
                string titulo = "";
                if (tipoTransaccion == "Corte")
                {
                    titulo = "REIMPRESION DE CORTE DE CAJA:";
                }
                else if (tipoTransaccion == "Retiro")
                {
                    titulo = "REIMPRESION DE RETIRO DE EFECTIVO";
                }
                else
                {
                    titulo = "Esto es una reimpresión:";
                }

            // Usar tu objeto Printer para imprimir el contenido
                printer.NewLines(1);
               ///printer.Image(imagen);
                printer.AlignCenter();
                printer.NewLines(2);
                printer.BoldMode(titulo);
                printer.NewLines(2);
                printer.Append(contenido);
                printer.NewLines(4);
            printer.AlignCenter();
            printer.Append("COMPROBANTE IMPRESO PARA FINES INFORMATIVOS");
            printer.BoldMode("" + DateTime.Now);
            printer.FullPaperCut();
                printer.PrintDocument();
                printer.Clear();
            }



            private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            // Muestra un cuadro de diálogo para confirmar si el usuario quiere cerrar sesión
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Si el usuario confirma, cierra la sesión y regresa al formulario principal
                buscarTorre buscartorre = new buscarTorre();
                buscartorre.Show();
                this.Hide(); // Oculta el formulario actual
            }
        }

        private void transacciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
