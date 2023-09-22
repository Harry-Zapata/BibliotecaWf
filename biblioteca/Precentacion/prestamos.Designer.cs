namespace biblioteca.Precentacion
{
    partial class prestamos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtgLibros = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIdLibro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbExistencia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbLibro = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lbFecha = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dtgVista = new System.Windows.Forms.DataGridView();
            this.idLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewPrestamo = new System.Windows.Forms.Button();
            this.btnBuscarPrestamo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(75, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(864, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dtgLibros
            // 
            this.dtgLibros.AllowUserToAddRows = false;
            this.dtgLibros.AllowUserToDeleteRows = false;
            this.dtgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLibros.Location = new System.Drawing.Point(15, 38);
            this.dtgLibros.Name = "dtgLibros";
            this.dtgLibros.ReadOnly = true;
            this.dtgLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLibros.Size = new System.Drawing.Size(924, 185);
            this.dtgLibros.TabIndex = 2;
            this.dtgLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLibros_CellContentClick);
            this.dtgLibros.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLibros_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "idLibro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(205, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Libro";
            // 
            // lbIdLibro
            // 
            this.lbIdLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIdLibro.Location = new System.Drawing.Point(99, 231);
            this.lbIdLibro.Name = "lbIdLibro";
            this.lbIdLibro.Size = new System.Drawing.Size(100, 23);
            this.lbIdLibro.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Existencia";
            // 
            // lbExistencia
            // 
            this.lbExistencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbExistencia.Location = new System.Drawing.Point(99, 263);
            this.lbExistencia.Name = "lbExistencia";
            this.lbExistencia.Size = new System.Drawing.Size(100, 23);
            this.lbExistencia.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(205, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Autor";
            // 
            // lbLibro
            // 
            this.lbLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLibro.Location = new System.Drawing.Point(253, 231);
            this.lbLibro.Name = "lbLibro";
            this.lbLibro.Size = new System.Drawing.Size(276, 23);
            this.lbLibro.TabIndex = 9;
            // 
            // lbAutor
            // 
            this.lbAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAutor.Location = new System.Drawing.Point(253, 260);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(276, 23);
            this.lbAutor.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(535, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Fecha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(535, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Devolucion";
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucion.Location = new System.Drawing.Point(626, 263);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(96, 20);
            this.dtpDevolucion.TabIndex = 13;
            // 
            // lbFecha
            // 
            this.lbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFecha.Location = new System.Drawing.Point(626, 231);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(96, 23);
            this.lbFecha.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::biblioteca.Properties.Resources._1486485588_add_create_new_math_sign_cross_plus_81186;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(749, 231);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 55);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = global::biblioteca.Properties.Resources.delete_delete_exit_1577;
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(847, 231);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(92, 55);
            this.btnQuitar.TabIndex = 16;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dtgVista
            // 
            this.dtgVista.AllowUserToAddRows = false;
            this.dtgVista.AllowUserToDeleteRows = false;
            this.dtgVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLibro,
            this.Libro,
            this.Autor,
            this.Fecha_Devolucion});
            this.dtgVista.Location = new System.Drawing.Point(12, 303);
            this.dtgVista.Name = "dtgVista";
            this.dtgVista.ReadOnly = true;
            this.dtgVista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVista.Size = new System.Drawing.Size(772, 188);
            this.dtgVista.TabIndex = 17;
            this.dtgVista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVista_CellClick);
            // 
            // idLibro
            // 
            this.idLibro.HeaderText = "idLibro";
            this.idLibro.Name = "idLibro";
            this.idLibro.ReadOnly = true;
            // 
            // Libro
            // 
            this.Libro.HeaderText = "Libro";
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            this.Libro.Width = 220;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 220;
            // 
            // Fecha_Devolucion
            // 
            this.Fecha_Devolucion.HeaderText = "Fecha Devolucion";
            this.Fecha_Devolucion.Name = "Fecha_Devolucion";
            this.Fecha_Devolucion.ReadOnly = true;
            this.Fecha_Devolucion.Width = 188;
            // 
            // btnNewPrestamo
            // 
            this.btnNewPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPrestamo.Image = global::biblioteca.Properties.Resources.new_file_40454;
            this.btnNewPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPrestamo.Location = new System.Drawing.Point(790, 303);
            this.btnNewPrestamo.Name = "btnNewPrestamo";
            this.btnNewPrestamo.Size = new System.Drawing.Size(149, 72);
            this.btnNewPrestamo.TabIndex = 18;
            this.btnNewPrestamo.Text = "Nuevo Prestamo";
            this.btnNewPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewPrestamo.UseVisualStyleBackColor = true;
            this.btnNewPrestamo.Click += new System.EventHandler(this.btnNewPrestamo_Click);
            // 
            // btnBuscarPrestamo
            // 
            this.btnBuscarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPrestamo.Image = global::biblioteca.Properties.Resources.xmag_search_find_export_locate_5984;
            this.btnBuscarPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPrestamo.Location = new System.Drawing.Point(790, 377);
            this.btnBuscarPrestamo.Name = "btnBuscarPrestamo";
            this.btnBuscarPrestamo.Size = new System.Drawing.Size(149, 72);
            this.btnBuscarPrestamo.TabIndex = 19;
            this.btnBuscarPrestamo.Text = "Buscar Prestamo";
            this.btnBuscarPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPrestamo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(787, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total Libro Prestamo";
            // 
            // lbTotal
            // 
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotal.Location = new System.Drawing.Point(790, 468);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(149, 23);
            this.lbTotal.TabIndex = 21;
            // 
            // prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::biblioteca.Properties.Resources.img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 503);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarPrestamo);
            this.Controls.Add(this.btnNewPrestamo);
            this.Controls.Add(this.dtgVista);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.dtpDevolucion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.lbLibro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbExistencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbIdLibro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgLibros);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "prestamos";
            this.Text = "prestamos libros";
            this.Load += new System.EventHandler(this.prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dtgLibros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIdLibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbExistencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbLibro;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dtgVista;
        private System.Windows.Forms.Button btnNewPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Devolucion;
        private System.Windows.Forms.Button btnBuscarPrestamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
    }
}