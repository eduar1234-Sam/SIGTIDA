namespace CapaPresentacion
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
            this.txtNombre_Producto = new System.Windows.Forms.TextBox();
            this.txtCategoria_Producto = new System.Windows.Forms.TextBox();
            this.txtGenero_Producto = new System.Windows.Forms.TextBox();
            this.txtEdad_Producto = new System.Windows.Forms.TextBox();
            this.txtPrecio_Producto = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnIngresar_Producto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre_Producto
            // 
            this.txtNombre_Producto.Location = new System.Drawing.Point(87, 33);
            this.txtNombre_Producto.Name = "txtNombre_Producto";
            this.txtNombre_Producto.Size = new System.Drawing.Size(100, 20);
            this.txtNombre_Producto.TabIndex = 0;
            // 
            // txtCategoria_Producto
            // 
            this.txtCategoria_Producto.Location = new System.Drawing.Point(87, 77);
            this.txtCategoria_Producto.Name = "txtCategoria_Producto";
            this.txtCategoria_Producto.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria_Producto.TabIndex = 1;
            this.txtCategoria_Producto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtGenero_Producto
            // 
            this.txtGenero_Producto.Location = new System.Drawing.Point(87, 121);
            this.txtGenero_Producto.Name = "txtGenero_Producto";
            this.txtGenero_Producto.Size = new System.Drawing.Size(100, 20);
            this.txtGenero_Producto.TabIndex = 2;
            // 
            // txtEdad_Producto
            // 
            this.txtEdad_Producto.Location = new System.Drawing.Point(87, 163);
            this.txtEdad_Producto.Name = "txtEdad_Producto";
            this.txtEdad_Producto.Size = new System.Drawing.Size(100, 20);
            this.txtEdad_Producto.TabIndex = 3;
            // 
            // txtPrecio_Producto
            // 
            this.txtPrecio_Producto.Location = new System.Drawing.Point(87, 205);
            this.txtPrecio_Producto.Name = "txtPrecio_Producto";
            this.txtPrecio_Producto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio_Producto.TabIndex = 4;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(460, 33);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(240, 150);
            this.dgvProductos.TabIndex = 5;
            // 
            // btnIngresar_Producto
            // 
            this.btnIngresar_Producto.Location = new System.Drawing.Point(77, 269);
            this.btnIngresar_Producto.Name = "btnIngresar_Producto";
            this.btnIngresar_Producto.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar_Producto.TabIndex = 6;
            this.btnIngresar_Producto.Text = "ingresar";
            this.btnIngresar_Producto.UseVisualStyleBackColor = true;
            this.btnIngresar_Producto.Click += new System.EventHandler(this.button1_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresar_Producto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtPrecio_Producto);
            this.Controls.Add(this.txtEdad_Producto);
            this.Controls.Add(this.txtGenero_Producto);
            this.Controls.Add(this.txtCategoria_Producto);
            this.Controls.Add(this.txtNombre_Producto);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre_Producto;
        private System.Windows.Forms.TextBox txtCategoria_Producto;
        private System.Windows.Forms.TextBox txtGenero_Producto;
        private System.Windows.Forms.TextBox txtEdad_Producto;
        private System.Windows.Forms.TextBox txtPrecio_Producto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnIngresar_Producto;
    }
}