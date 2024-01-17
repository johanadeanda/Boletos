namespace Boletos
{
    partial class transacciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transacciones));
            this.consultar = new Guna.UI2.WinForms.Guna2Button();
            this.vistatransacciones = new Guna.UI2.WinForms.Guna2DataGridView();
            this.inicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tipotransaccion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.reimprimir = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LOGOUT = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vistatransacciones)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // consultar
            // 
            this.consultar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.consultar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.consultar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.consultar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.consultar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(76)))));
            this.consultar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.consultar.ForeColor = System.Drawing.Color.White;
            this.consultar.Location = new System.Drawing.Point(1049, 137);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(140, 36);
            this.consultar.TabIndex = 3;
            this.consultar.Text = "Consultar";
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // vistatransacciones
            // 
            this.vistatransacciones.AllowUserToAddRows = false;
            this.vistatransacciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.vistatransacciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.vistatransacciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vistatransacciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.vistatransacciones.ColumnHeadersHeight = 16;
            this.vistatransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vistatransacciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.vistatransacciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(76)))));
            this.vistatransacciones.Location = new System.Drawing.Point(21, 260);
            this.vistatransacciones.Name = "vistatransacciones";
            this.vistatransacciones.ReadOnly = true;
            this.vistatransacciones.RowHeadersVisible = false;
            this.vistatransacciones.Size = new System.Drawing.Size(1181, 317);
            this.vistatransacciones.TabIndex = 4;
            this.vistatransacciones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.vistatransacciones.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.vistatransacciones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.vistatransacciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.vistatransacciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.vistatransacciones.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.vistatransacciones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(76)))));
            this.vistatransacciones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.vistatransacciones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.vistatransacciones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistatransacciones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.vistatransacciones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.vistatransacciones.ThemeStyle.HeaderStyle.Height = 16;
            this.vistatransacciones.ThemeStyle.ReadOnly = true;
            this.vistatransacciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.vistatransacciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.vistatransacciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistatransacciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.vistatransacciones.ThemeStyle.RowsStyle.Height = 22;
            this.vistatransacciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.vistatransacciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // inicio
            // 
            this.inicio.BackColor = System.Drawing.Color.Transparent;
            this.inicio.Checked = true;
            this.inicio.FillColor = System.Drawing.Color.White;
            this.inicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.inicio.Location = new System.Drawing.Point(532, 137);
            this.inicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.inicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(316, 36);
            this.inicio.TabIndex = 2;
            this.inicio.Value = new System.DateTime(2024, 1, 5, 13, 25, 3, 755);
            this.inicio.ValueChanged += new System.EventHandler(this.inicio_ValueChanged);
            // 
            // tipotransaccion
            // 
            this.tipotransaccion.BackColor = System.Drawing.Color.Transparent;
            this.tipotransaccion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tipotransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipotransaccion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(76)))));
            this.tipotransaccion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tipotransaccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tipotransaccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tipotransaccion.ForeColor = System.Drawing.Color.White;
            this.tipotransaccion.ItemHeight = 30;
            this.tipotransaccion.Items.AddRange(new object[] {
            " Seleccionar",
            "Corte",
            "Retiro"});
            this.tipotransaccion.Location = new System.Drawing.Point(78, 137);
            this.tipotransaccion.Name = "tipotransaccion";
            this.tipotransaccion.Size = new System.Drawing.Size(306, 36);
            this.tipotransaccion.StartIndex = 0;
            this.tipotransaccion.TabIndex = 1;
            this.tipotransaccion.SelectedIndexChanged += new System.EventHandler(this.tipotransaccion_SelectedIndexChanged);
            // 
            // reimprimir
            // 
            this.reimprimir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reimprimir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reimprimir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reimprimir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reimprimir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(76)))));
            this.reimprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reimprimir.ForeColor = System.Drawing.Color.White;
            this.reimprimir.Location = new System.Drawing.Point(853, 620);
            this.reimprimir.Name = "reimprimir";
            this.reimprimir.Size = new System.Drawing.Size(140, 36);
            this.reimprimir.TabIndex = 5;
            this.reimprimir.Text = "Re imprimir";
            this.reimprimir.Click += new System.EventHandler(this.reimprimir_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.consultar);
            this.guna2GroupBox1.Controls.Add(this.tipotransaccion);
            this.guna2GroupBox1.Controls.Add(this.vistatransacciones);
            this.guna2GroupBox1.Controls.Add(this.LOGOUT);
            this.guna2GroupBox1.Controls.Add(this.inicio);
            this.guna2GroupBox1.Controls.Add(this.reimprimir);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(115, 132);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1209, 683);
            this.guna2GroupBox1.TabIndex = 7;
            this.guna2GroupBox1.Text = "Transacciones";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // LOGOUT
            // 
            this.LOGOUT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LOGOUT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LOGOUT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LOGOUT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LOGOUT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(76)))));
            this.LOGOUT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LOGOUT.ForeColor = System.Drawing.Color.White;
            this.LOGOUT.Location = new System.Drawing.Point(1049, 620);
            this.LOGOUT.Name = "LOGOUT";
            this.LOGOUT.Size = new System.Drawing.Size(140, 36);
            this.LOGOUT.TabIndex = 6;
            this.LOGOUT.Text = "Cerrar Sesión";
            this.LOGOUT.Click += new System.EventHandler(this.LOGOUT_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(66, 42);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(729, 47);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "Estacionamiento Robotizado  - Búsqueda de Folios";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(43)))), ((int)(((byte)(75)))));
            this.guna2PictureBox1.Image = global::Boletos.Properties.Resources.Logo_Negativo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1075, 22);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(301, 87);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 20;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox2.Image = global::Boletos.Properties.Resources.Pleca_o_botón;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(1437, 126);
            this.guna2PictureBox2.TabIndex = 21;
            this.guna2PictureBox2.TabStop = false;
            // 
            // transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 866);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1453, 905);
            this.MinimumSize = new System.Drawing.Size(1453, 905);
            this.Name = "transacciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transacciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.transacciones_FormClosing);
            this.Load += new System.EventHandler(this.transacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vistatransacciones)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button consultar;
        private Guna.UI2.WinForms.Guna2DataGridView vistatransacciones;
        private Guna.UI2.WinForms.Guna2DateTimePicker inicio;
        private Guna.UI2.WinForms.Guna2ComboBox tipotransaccion;
        private Guna.UI2.WinForms.Guna2Button reimprimir;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button LOGOUT;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}