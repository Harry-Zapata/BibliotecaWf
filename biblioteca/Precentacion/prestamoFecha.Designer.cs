﻿namespace biblioteca.Precentacion
{
    partial class prestamoFecha
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
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lbInicio = new System.Windows.Forms.Label();
            this.lbFin = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.dtgPestamo = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Fecha_inicio",
            "Fecha_fin"});
            this.cbTipo.Location = new System.Drawing.Point(49, 24);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 1;
            this.cbTipo.Text = "Seleccionar";
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Location = new System.Drawing.Point(176, 27);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(38, 13);
            this.lbInicio.TabIndex = 2;
            this.lbInicio.Text = "Desde";
            // 
            // lbFin
            // 
            this.lbFin.AutoSize = true;
            this.lbFin.Location = new System.Drawing.Point(319, 27);
            this.lbFin.Name = "lbFin";
            this.lbFin.Size = new System.Drawing.Size(35, 13);
            this.lbFin.TabIndex = 3;
            this.lbFin.Text = "Hasta";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(210, 24);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(103, 20);
            this.dtInicio.TabIndex = 4;
            // 
            // dtFin
            // 
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFin.Location = new System.Drawing.Point(351, 25);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(103, 20);
            this.dtFin.TabIndex = 5;
            // 
            // dtgPestamo
            // 
            this.dtgPestamo.AllowUserToAddRows = false;
            this.dtgPestamo.AllowUserToDeleteRows = false;
            this.dtgPestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPestamo.Location = new System.Drawing.Point(28, 73);
            this.dtgPestamo.Name = "dtgPestamo";
            this.dtgPestamo.ReadOnly = true;
            this.dtgPestamo.Size = new System.Drawing.Size(509, 344);
            this.dtgPestamo.TabIndex = 6;
            this.dtgPestamo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(462, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // prestamoFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtgPestamo);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.lbFin);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label1);
            this.Name = "prestamoFecha";
            this.Text = "prestamoFecha";
            this.Load += new System.EventHandler(this.prestamoFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.Label lbFin;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.DataGridView dtgPestamo;
        private System.Windows.Forms.Button btnBuscar;
    }
}