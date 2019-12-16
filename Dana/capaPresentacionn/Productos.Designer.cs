namespace capaPresentacionn
{
    partial class Productos
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
            this.btnInsertar_Producto = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.lblNombre_Producto = new System.Windows.Forms.Label();
            this.txtNombre_Producto = new System.Windows.Forms.TextBox();
            this.txtPrecio_Producto = new System.Windows.Forms.TextBox();
            this.lblPrecio_Producto = new System.Windows.Forms.Label();
            this.txtEdad_Producto = new System.Windows.Forms.TextBox();
            this.lblEdad_Producto = new System.Windows.Forms.Label();
            this.txtGenero_Producto = new System.Windows.Forms.TextBox();
            this.lblGenero_Producto = new System.Windows.Forms.Label();
            this.txtCategoria_Producto = new System.Windows.Forms.TextBox();
            this.lblCategoria_Producto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar_Producto
            // 
            this.btnInsertar_Producto.Location = new System.Drawing.Point(327, 297);
            this.btnInsertar_Producto.Name = "btnInsertar_Producto";
            this.btnInsertar_Producto.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar_Producto.TabIndex = 0;
            this.btnInsertar_Producto.Text = "Insertar";
            this.btnInsertar_Producto.UseVisualStyleBackColor = true;
            this.btnInsertar_Producto.Click += new System.EventHandler(this.btnInsertar_Producto_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(492, 79);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(240, 150);
            this.dgvProducto.TabIndex = 1;
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            // 
            // lblNombre_Producto
            // 
            this.lblNombre_Producto.AutoSize = true;
            this.lblNombre_Producto.Location = new System.Drawing.Point(32, 38);
            this.lblNombre_Producto.Name = "lblNombre_Producto";
            this.lblNombre_Producto.Size = new System.Drawing.Size(44, 13);
            this.lblNombre_Producto.TabIndex = 2;
            this.lblNombre_Producto.Text = "Nombre";
            // 
            // txtNombre_Producto
            // 
            this.txtNombre_Producto.Location = new System.Drawing.Point(149, 38);
            this.txtNombre_Producto.Name = "txtNombre_Producto";
            this.txtNombre_Producto.Size = new System.Drawing.Size(100, 20);
            this.txtNombre_Producto.TabIndex = 3;
            // 
            // txtPrecio_Producto
            // 
            this.txtPrecio_Producto.Location = new System.Drawing.Point(149, 216);
            this.txtPrecio_Producto.Name = "txtPrecio_Producto";
            this.txtPrecio_Producto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio_Producto.TabIndex = 5;
            // 
            // lblPrecio_Producto
            // 
            this.lblPrecio_Producto.AutoSize = true;
            this.lblPrecio_Producto.Location = new System.Drawing.Point(32, 216);
            this.lblPrecio_Producto.Name = "lblPrecio_Producto";
            this.lblPrecio_Producto.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio_Producto.TabIndex = 4;
            this.lblPrecio_Producto.Text = "Precio";
            // 
            // txtEdad_Producto
            // 
            this.txtEdad_Producto.Location = new System.Drawing.Point(149, 168);
            this.txtEdad_Producto.Name = "txtEdad_Producto";
            this.txtEdad_Producto.Size = new System.Drawing.Size(100, 20);
            this.txtEdad_Producto.TabIndex = 7;
            // 
            // lblEdad_Producto
            // 
            this.lblEdad_Producto.AutoSize = true;
            this.lblEdad_Producto.Location = new System.Drawing.Point(32, 175);
            this.lblEdad_Producto.Name = "lblEdad_Producto";
            this.lblEdad_Producto.Size = new System.Drawing.Size(32, 13);
            this.lblEdad_Producto.TabIndex = 6;
            this.lblEdad_Producto.Text = "Edad";
            // 
            // txtGenero_Producto
            // 
            this.txtGenero_Producto.Location = new System.Drawing.Point(149, 120);
            this.txtGenero_Producto.Name = "txtGenero_Producto";
            this.txtGenero_Producto.Size = new System.Drawing.Size(100, 20);
            this.txtGenero_Producto.TabIndex = 9;
            // 
            // lblGenero_Producto
            // 
            this.lblGenero_Producto.AutoSize = true;
            this.lblGenero_Producto.Location = new System.Drawing.Point(32, 127);
            this.lblGenero_Producto.Name = "lblGenero_Producto";
            this.lblGenero_Producto.Size = new System.Drawing.Size(42, 13);
            this.lblGenero_Producto.TabIndex = 8;
            this.lblGenero_Producto.Text = "Genero";
            // 
            // txtCategoria_Producto
            // 
            this.txtCategoria_Producto.Location = new System.Drawing.Point(149, 79);
            this.txtCategoria_Producto.Name = "txtCategoria_Producto";
            this.txtCategoria_Producto.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria_Producto.TabIndex = 11;
            // 
            // lblCategoria_Producto
            // 
            this.lblCategoria_Producto.AutoSize = true;
            this.lblCategoria_Producto.Location = new System.Drawing.Point(32, 79);
            this.lblCategoria_Producto.Name = "lblCategoria_Producto";
            this.lblCategoria_Producto.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria_Producto.TabIndex = 10;
            this.lblCategoria_Producto.Text = "Categoria";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCategoria_Producto);
            this.Controls.Add(this.lblCategoria_Producto);
            this.Controls.Add(this.txtGenero_Producto);
            this.Controls.Add(this.lblGenero_Producto);
            this.Controls.Add(this.txtEdad_Producto);
            this.Controls.Add(this.lblEdad_Producto);
            this.Controls.Add(this.txtPrecio_Producto);
            this.Controls.Add(this.lblPrecio_Producto);
            this.Controls.Add(this.txtNombre_Producto);
            this.Controls.Add(this.lblNombre_Producto);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.btnInsertar_Producto);
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar_Producto;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Label lblNombre_Producto;
        private System.Windows.Forms.TextBox txtNombre_Producto;
        private System.Windows.Forms.TextBox txtPrecio_Producto;
        private System.Windows.Forms.Label lblPrecio_Producto;
        private System.Windows.Forms.TextBox txtEdad_Producto;
        private System.Windows.Forms.Label lblEdad_Producto;
        private System.Windows.Forms.TextBox txtGenero_Producto;
        private System.Windows.Forms.Label lblGenero_Producto;
        private System.Windows.Forms.TextBox txtCategoria_Producto;
        private System.Windows.Forms.Label lblCategoria_Producto;
    }
}