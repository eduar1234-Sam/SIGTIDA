namespace capaPresentacionn
{
    partial class Inventario
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
            this.txtCantidad_Producto = new System.Windows.Forms.TextBox();
            this.lblCantidad_Producto = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnInsertar_Inventario = new System.Windows.Forms.Button();
            this.lblIdProducto_Inventario = new System.Windows.Forms.Label();
            this.CBIdProducto_Inventario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidad_Producto
            // 
            this.txtCantidad_Producto.Location = new System.Drawing.Point(170, 125);
            this.txtCantidad_Producto.Name = "txtCantidad_Producto";
            this.txtCantidad_Producto.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad_Producto.TabIndex = 15;
            // 
            // lblCantidad_Producto
            // 
            this.lblCantidad_Producto.AutoSize = true;
            this.lblCantidad_Producto.Location = new System.Drawing.Point(53, 125);
            this.lblCantidad_Producto.Name = "lblCantidad_Producto";
            this.lblCantidad_Producto.Size = new System.Drawing.Size(95, 13);
            this.lblCantidad_Producto.TabIndex = 14;
            this.lblCantidad_Producto.Text = "Cantidad Producto";
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(510, 125);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(240, 150);
            this.dgvInventario.TabIndex = 13;
            // 
            // btnInsertar_Inventario
            // 
            this.btnInsertar_Inventario.Location = new System.Drawing.Point(345, 343);
            this.btnInsertar_Inventario.Name = "btnInsertar_Inventario";
            this.btnInsertar_Inventario.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar_Inventario.TabIndex = 12;
            this.btnInsertar_Inventario.Text = "Insertar";
            this.btnInsertar_Inventario.UseVisualStyleBackColor = true;
            this.btnInsertar_Inventario.Click += new System.EventHandler(this.btnInsertar_Inventario_Click);
            // 
            // lblIdProducto_Inventario
            // 
            this.lblIdProducto_Inventario.AutoSize = true;
            this.lblIdProducto_Inventario.Location = new System.Drawing.Point(53, 72);
            this.lblIdProducto_Inventario.Name = "lblIdProducto_Inventario";
            this.lblIdProducto_Inventario.Size = new System.Drawing.Size(62, 13);
            this.lblIdProducto_Inventario.TabIndex = 16;
            this.lblIdProducto_Inventario.Text = "Id Producto";
            // 
            // CBIdProducto_Inventario
            // 
            this.CBIdProducto_Inventario.FormattingEnabled = true;
            this.CBIdProducto_Inventario.Location = new System.Drawing.Point(170, 72);
            this.CBIdProducto_Inventario.Name = "CBIdProducto_Inventario";
            this.CBIdProducto_Inventario.Size = new System.Drawing.Size(121, 21);
            this.CBIdProducto_Inventario.TabIndex = 17;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBIdProducto_Inventario);
            this.Controls.Add(this.lblIdProducto_Inventario);
            this.Controls.Add(this.txtCantidad_Producto);
            this.Controls.Add(this.lblCantidad_Producto);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.btnInsertar_Inventario);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCantidad_Producto;
        private System.Windows.Forms.Label lblCantidad_Producto;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnInsertar_Inventario;
        private System.Windows.Forms.Label lblIdProducto_Inventario;
        private System.Windows.Forms.ComboBox CBIdProducto_Inventario;
    }
}