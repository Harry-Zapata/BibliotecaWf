namespace biblioteca.Precentacion
{
    partial class Consultar
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
            this.DtgLibro = new System.Windows.Forms.DataGridView();
            this.cbElegir = new System.Windows.Forms.ComboBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgLibro
            // 
            this.DtgLibro.AllowUserToAddRows = false;
            this.DtgLibro.AllowUserToDeleteRows = false;
            this.DtgLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgLibro.Location = new System.Drawing.Point(12, 47);
            this.DtgLibro.Name = "DtgLibro";
            this.DtgLibro.ReadOnly = true;
            this.DtgLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgLibro.Size = new System.Drawing.Size(776, 391);
            this.DtgLibro.TabIndex = 0;
            // 
            // cbElegir
            // 
            this.cbElegir.FormattingEnabled = true;
            this.cbElegir.Location = new System.Drawing.Point(12, 12);
            this.cbElegir.Name = "cbElegir";
            this.cbElegir.Size = new System.Drawing.Size(133, 21);
            this.cbElegir.TabIndex = 1;
            this.cbElegir.Text = "Seleccionar";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(151, 12);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(549, 20);
            this.txtTexto.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = global::biblioteca.Properties.Resources.xmag_search_find_export_locate_5984;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(706, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 39);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::biblioteca.Properties.Resources.wp3234816;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.cbElegir);
            this.Controls.Add(this.DtgLibro);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgLibro;
        private System.Windows.Forms.ComboBox cbElegir;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnBuscar;
    }
}