using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.Drawing.Printing;
using ESC_POS_USB_NET.Printer;
using ESC_POS_USB_NET.Enums;
using System.Globalization;

namespace Boletos
{
    public partial class buscarTorre : Form

    {
        Printer printer = new Printer("EPSON TM-T88V Receipt");
        Bitmap imagen = new Bitmap(Properties.Resources.image);

        private bool iconoPresionado = false;

        private string connectionString = "Data Source=169.254.1.103;Initial Catalog=estacionamiento;User ID=TORREEROB;Password=erob2023pepe$$mexico0899";
        public buscarTorre()
        {
            InitializeComponent();
            logout.MouseDown += logout_MouseDown;
            logout.MouseUp += logout_MouseUp;

        }

    

        private void torre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void plataformas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
        }


        private void vistadatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buscarTorre_Load(object sender, EventArgs e)
        {
        
            InicioFecha.MaxDate = DateTime.Today;

           
            finFecha.MaxDate = DateTime.Today.AddDays(1);

            finFecha.Value = DateTime.Today.AddDays(1);
            InicioFecha.Value = DateTime.Today;


            guna2HtmlLabel1.Parent = guna2PictureBox2;
            guna2HtmlLabel1.ForeColor = Color.White ;

            logout.Parent = guna2PictureBox2;
            


            vistadatagrid.BorderStyle = BorderStyle.Fixed3D;

            

            // Establecer estilo para las celdas
            vistadatagrid.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;

            // Cambiar el estilo de las filas alternadas
            vistadatagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Personalizar los encabezados de las columnas
            vistadatagrid.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle style = vistadatagrid.ColumnHeadersDefaultCellStyle;


            estatusplataforma.BorderStyle = BorderStyle.Fixed3D;



            // Establecer estilo para las celdas
            estatusplataforma.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;

            // Cambiar el estilo de las filas alternadas
            estatusplataforma.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Personalizar los encabezados de las columnas
            vistadatagrid.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle style1 = estatusplataforma.ColumnHeadersDefaultCellStyle;


        }


        private void botonLimpiar_Click(object sender, EventArgs e)
        {
        }

        private void InicioFecha_ValueChanged(object sender, EventArgs e)
        {
            

            if (InicioFecha.Value > finFecha.Value)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor a la fecha Final. Intentalo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }

        }

        private void finFecha_ValueChanged(object sender, EventArgs e)
        {

            
            if (finFecha.Value < InicioFecha.Value)
            {
                MessageBox.Show("La última fecha no puede ser menor a la fecha inicial. Intentalo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                finFecha.Value = InicioFecha.Value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_MouseDown(object sender, MouseEventArgs e)
        {
            // Cambia el tamaño del icono para simular el efecto de aplastamiento
            logout.Size = new Size(logout.Width - 5, logout.Height - 5);
            iconoPresionado = true;
        }

        private void logout_MouseUp(object sender, MouseEventArgs e)
        {
            if (iconoPresionado)
            {
                // Restaura el tamaño original del icono
                logout.Size = new Size(logout.Width + 5, logout.Height + 5);

                // Cierra el formulario
                this.Close();
            }

            iconoPresionado = false;
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void textoplataforma_Click(object sender, EventArgs e)
        {

        }

        private void buscarTorre_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea cerrar el programa? ", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                e.Cancel = false;

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void reimprimir_Click(object sender, EventArgs e)
        {
            if (vistadatagrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = vistadatagrid.SelectedRows[0];
                string folio = selectedRow.Cells["IDBoleto"].Value.ToString();

                DialogResult result = MessageBox.Show($"¿Estás seguro de reimprimir el boleto con Folio: {folio}?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    // Mostrar el formulario de verificación
                    verificacion verificacionForm = new verificacion();

                    // Verificar si el usuario y la contraseña son correctos
                    if (verificacionForm.ShowDialog() == DialogResult.OK)
                    {
                        // Usuario autenticado, proceder con la reimresión del boleto
                        string IDBoleto = selectedRow.Cells["IDBoleto"].Value.ToString();
                        string IDPlataforma = selectedRow.Cells["IDPlataforma"].Value.ToString();
                        string Entrada = selectedRow.Cells["Entrada"].Value.ToString();
                        string entradafecha = Entrada.Substring(0, 10);
                        DateTime fecha = DateTime.ParseExact(entradafecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        string fechaFormateada = fecha.ToString("dddd, d 'de' MMMM 'de' yyyy", new CultureInfo("es-ES"));

                        string horadeingreso = Entrada.Substring(10, 15);
                        horadeingreso = horadeingreso.Trim();

                        string horaFormateada2 = "";
                        string nombreUsuario = verificacionForm.admin.Text;


                        DateTime hora;
                        if (DateTime.TryParse(horadeingreso, out hora))
                        {
                            string horaFormateada = hora.ToString("HH:mm 'hrs.'");
                            horaFormateada2 = horaFormateada;
                        }
                        else
                        {
                            Console.WriteLine("Formato de hora no válido");
                        }

                        // Imprimir el boleto
                        reimprimirboleto(IDBoleto, IDPlataforma, fechaFormateada, horaFormateada2, nombreUsuario);
                    }
                    else
                    {
                        MessageBox.Show("Inicio de sesión incorrecto. No se realizó la reimpresión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para reimprimir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void reimprimirboleto(string folio, string plataforma, string entrada, string horadeingreso, string admin)
         {
            

            printer.NewLines(1);
          /// printer.Image(imagen);
             printer.AlignCenter();
             printer.NewLines(2);
             printer.BoldMode("REIMPRESION DE BOLETO");
            ///printer.Append("" + DateTime.Now);
            printer.NewLines(2);
             //printer.Append("------------------------------------------------");
             //printer.Append("------------------------------------------------");
             printer.NewLines(2);
             printer.Append("Folio:" + folio);
             printer.NewLines(2);
             printer.Append("Fecha de ingreso:");
             printer.NewLines(2);
            printer.Append(entrada);
             //cambiar
            /// printer.Append(DateTime.Now.ToString("dddd, d 'de' MMMM 'de' yyyy"));
             printer.NewLines(2);
            printer.Append("Hora de ingreso:" );
            printer.NewLines(2);
            printer.Append(horadeingreso);
            //cambiAR 
             printer.NewLines(3);
             printer.AlignCenter();
             printer.BoldMode("Lugar: " + plataforma);
             printer.NewLines(3);
             printer.NormalWidth();
            printer.Append("Autorizó: " + admin);
            printer.NewLines(3);
            printer.NormalWidth();
            printer.QrCode(folio, QrCodeSize.Size2);
             printer.NewLines(3);
             //printer.Append("------------------------------------------------");
             //printer.Append("------------------------------------------------");
             printer.NewLines(2);
             //poner reglas de forma basica.
             printer.AlignCenter();
             printer.Append("Tarifas de Estacionamiento: ");
             printer.Append("Comunidad General: $15.00 por hora o fracción.");
             printer.Append("Comunidad BUAP: $5.00 por hora o fracción.");
             printer.NewLines(2);
             printer.Append("Horario de servicio");
             printer.Append("Lunes a viernes: 6:30 - 21:00 hrs.");
             printer.Append("Sabado: 7:00 - 14:00 hrs.");
             printer.AlignLeft();
             printer.NewLines(3);
             printer.Append("Boleto perdido, $100.00 mas tiempo de estancia.");
             printer.Append("Boleto olvidado dentro del vehiculo,$50.00 pesos");
             printer.Append("mas tiempo de estancia.");
            printer.NewLines(2);
            printer.AlignCenter();
            printer.Append("COMPROBANTE IMPRESO PARA FINES INFORMATIVOS");
            printer.BoldMode("" + DateTime.Now);
             printer.NewLines(4);
             printer.AlignLeft();
             printer.FullPaperCut();
             printer.PrintDocument();
             printer.Clear();

            try
            {
                // Realizar la conexión a la base de datos
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    // Consulta SQL para la inserción en la tabla Reimpresion
                    string consultaReimpresion = "INSERT INTO Reimpresion (AutorizadoPor, Folio, FechaReimpresion) VALUES (@AutorizadoPor, @Folio, @FechaReimpresion)";

                    // Crear el comando SQL
                    using (SqlCommand comandoReimpresion = new SqlCommand(consultaReimpresion, conexion))
                    {
                        // Agregar parámetros
                        comandoReimpresion.Parameters.AddWithValue("@AutorizadoPor", admin);
                        comandoReimpresion.Parameters.AddWithValue("@Folio", folio);
                        comandoReimpresion.Parameters.AddWithValue("@FechaReimpresion", DateTime.Now);

                        // Ejecutar la consulta
                        int filasAfectadas = comandoReimpresion.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Datos de Reimpresion insertados correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se pudieron insertar datos de Reimpresion.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar datos de Reimpresion: " + ex.Message);
            }


        }



        private void transacciones_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion(); 
            inicioSesion.Show();
            this.Hide();
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click_1(object sender, EventArgs e)
        {
            if (torre.SelectedItem == null || plataformas.SelectedItem == null)
            {
                MessageBox.Show("Faltan datos por seleccionar, intentalo de nuevo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución del método si no se han seleccionado los elementos necesarios
            }

            string torreSeleccionada = torre.SelectedItem.ToString();
            string plataformaSeleccionada = plataformas.SelectedItem.ToString();
            string torreYPlataforma = torreSeleccionada + plataformaSeleccionada;

            DateTime fechaInicio = InicioFecha.Value;
            DateTime fechaFin = finFecha.Value;

            // Formato para las fechas
            string formatoFecha = "yyyy-MM-dd";

            // Consulta SQL con parámetros
            string consulta = "SELECT IDBoleto, IDPlataforma, Entrada, TipoCobro, Salida, EstatusCobro, Total, CobradoPor " +
                              "FROM boleto " +
                              "WHERE IDPlataforma = @IDPlataforma " +
                              "AND Entrada BETWEEN @FechaInicio AND @FechaFin";



            try
            {
                // Realizar la conexión a la base de datos y ejecutar la consulta
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.Add("@IDPlataforma", SqlDbType.VarChar).Value = torreYPlataforma; // Cambio en la forma de agregar el parámetro
                    comando.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = fechaInicio;
                    comando.Parameters.Add("@FechaFin", SqlDbType.Date).Value = fechaFin;

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    vistadatagrid.DataSource = tabla; // Mostrar los resultados en el DataGridView

                    foreach (DataGridViewColumn column in vistadatagrid.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }


                    vistadatagrid.ColumnHeadersVisible = true;
                    vistadatagrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    vistadatagrid.Columns[0].HeaderText = "Folio";
                    vistadatagrid.Columns[1].HeaderText = "Plataforma";
                    vistadatagrid.Columns[2].HeaderText = "Entrada";
                    vistadatagrid.Columns[3].HeaderText = "Tarifa";
                    vistadatagrid.Columns[4].HeaderText = "Salida";
                    vistadatagrid.Columns[5].HeaderText = "Estatus Cobro";
                    vistadatagrid.Columns[6].HeaderText = "Total";
                    vistadatagrid.Columns[7].HeaderText = "Cobró";



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonLimpiar_Click_1(object sender, EventArgs e)
        {
            torre.SelectedIndex = -1;
            plataformas.SelectedIndex = -1;

            DateTime fechaActual = DateTime.Today;
            if (fechaActual > InicioFecha.MaxDate)
            {
                InicioFecha.Value = InicioFecha.MaxDate;
            }
            else
            {
                InicioFecha.Value = fechaActual;
            }

            vistadatagrid.DataSource = null;

            if (torre.Items.Count > 0)
            {
                torre.SelectedIndex = 0;
            }

            if (plataformas.Items.Count > 0)
            {
                plataformas.SelectedIndex = 0;
            }
        }

        private void consultarEstatus_Click(object sender, EventArgs e)
        {
            if (torreEstatus.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una torre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string torreSeleccionada = torreEstatus.SelectedItem.ToString();

            // Realiza la consulta SQL para obtener las plataformas y su estado
            string consulta = "SELECT IDPlataforma, Estatus, TipoAuto FROM plataformas WHERE Torre = @NombreTorre";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.Add("@NombreTorre", SqlDbType.VarChar).Value = torreSeleccionada;

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    estatusplataforma.AutoGenerateColumns = true; // Generar columnas automáticamente
                    estatusplataforma.DataSource = tabla; // Asignar los datos al DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vistadatagrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            torreEstatus.SelectedIndex = -1;
            

           
            estatusplataforma.DataSource = null;

            if (torreEstatus.Items.Count > 0)
            {
                torreEstatus.SelectedIndex = 0;
            }

            if (torreEstatus.Items.Count > 0)
            {
                torreEstatus.SelectedIndex = 0;
            }
        }
    }
}
