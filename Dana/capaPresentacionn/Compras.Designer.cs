namespace capaPresentacionn
{
    partial class Compras
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
            this.txtIdCompra_Compra = new System.Windows.Forms.TextBox();
            this.lblFecha_Compra = new System.Windows.Forms.Label();
            this.txtPrecio_Compra = new System.Windows.Forms.TextBox();
            this.lblPrecio_Compra = new System.Windows.Forms.Label();
            this.lblId_Compra = new System.Windows.Forms.Label();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.btnInsertar_Compra = new System.Windows.Forms.Button();
            this.CBIdProducto_Compras = new System.Windows.Forms.ComboBox();
            this.txtCantidadProducto_Compra = new System.Windows.Forms.TextBox();
            this.lblCantidadProducto_Compras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCompra_Compra
            // 
            this.txtIdCompra_Compra.Location = new System.Drawing.Point(164, 98);
            this.txtIdCompra_Compra.Name = "txtIdCompra_Compra";
            this.txtIdCompra_Compra.Size = new System.Drawing.Size(121, 20);
            this.txtIdCompra_Compra.TabIndex = 23;
            // 
            // lblFecha_Compra
            // 
            this.lblFecha_Compra.AutoSize = true;
            this.lblFecha_Compra.Location = new System.Drawing.Point(47, 98);
            this.lblFecha_Compra.Name = "lblFecha_Compra";
            this.lblFecha_Compra.Size = new System.Drawing.Size(55, 13);
            this.lblFecha_Compra.TabIndex = 22;
            this.lblFecha_Compra.Text = "Id Compra";
            this.lblFecha_Compra.Click += new System.EventHandler(this.lblFecha_Compra_Click);
            // 
            // txtPrecio_Compra
            // 
            this.txtPrecio_Compra.Location = new System.Drawing.Point(164, 139);
            this.txtPrecio_Compra.Name = "txtPrecio_Compra";
            this.txtPrecio_Compra.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio_Compra.TabIndex = 21;
            // 
            // lblPrecio_Compra
            // 
            this.lblPrecio_Compra.AutoSize = true;
            this.lblPrecio_Compra.Location = new System.Drawing.Point(47, 146);
            this.lblPrecio_Compra.Name = "lblPrecio_Compra";
            this.lblPrecio_Compra.Size = new System.Drawing.Size(76, 13);
            this.lblPrecio_Compra.TabIndex = 20;
            this.lblPrecio_Compra.Text = "Precio Compra";
            // 
            // lblId_Compra
            // 
            this.lblId_Compra.AutoSize = true;
            this.lblId_Compra.Location = new System.Drawing.Point(47, 57);
            this.lblId_Compra.Name = "lblId_Compra";
            this.lblId_Compra.Size = new System.Drawing.Size(62, 13);
            this.lblId_Compra.TabIndex = 14;
            this.lblId_Compra.Text = "Id Producto";
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(474, 69);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(240, 150);
            this.dgvCompras.TabIndex = 13;
            this.dgvCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCompras_CellContentClick);
            // 
            // btnInsertar_Compra
            // 
            this.btnInsertar_Compra.Location = new System.Drawing.Point(342, 316);
            this.btnInsertar_Compra.Name = "btnInsertar_Compra";
            this.btnInsertar_Compra.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar_Compra.TabIndex = 12;
            this.btnInsertar_Compra.Text = "Insertar";
            this.btnInsertar_Compra.UseVisualStyleBackColor = true;
            this.btnInsertar_Compra.Click += new System.EventHandler(this.btnInsertar_Compra_Click);
            // 
            // CBIdProducto_Compras
            // 
            this.CBIdProducto_Compras.FormattingEnabled = true;
            this.CBIdProducto_Compras.Location = new System.Drawing.Point(164, 57);
            this.CBIdProducto_Compras.Name = "CBIdProducto_Compras";
            this.CBIdProducto_Compras.Size = new System.Drawing.Size(121, 21);
            this.CBIdProducto_Compras.TabIndex = 24;
            this.CBIdProducto_Compras.SelectedIndexChanged += new System.EventHandler(this.CBIdProducto_Compras_SelectedIndexChanged);
            // 
            // txtCantidadProducto_Compra
            // 
            this.txtCantidadProducto_Compra.Location = new System.Drawing.Point(164, 183);
            this.txtCantidadProducto_Compra.Name = "txtCantidadProducto_Compra";
            this.txtCantidadProducto_Compra.Size = new System.Drawing.Size(121, 20);
            this.txtCantidadProducto_Compra.TabIndex = 26;
            // 
            // lblCantidadProducto_Compras
            // 
            this.lblCantidadProducto_Compras.AutoSize = true;
            this.lblCantidadProducto_Compras.Location = new System.Drawing.Point(47, 190);
            this.lblCantidadProducto_Compras.Name = "lblCantidadProducto_Compras";
            this.lblCantidadProducto_Compras.Size = new System.Drawing.Size(95, 13);
            this.lblCantidadProducto_Compras.TabIndex = 25;
            this.lblCantidadProducto_Compras.Text = "Cantidad Producto";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCantidadProducto_Compra);
            this.Controls.Add(this.lblCantidadProducto_Compras);
            this.Controls.Add(this.CBIdProducto_Compras);
            this.Controls.Add(this.txtIdCompra_Compra);
            this.Controls.Add(this.lblFecha_Compra);
            this.Controls.Add(this.txtPrecio_Compra);
            this.Controls.Add(this.lblPrecio_Compra);
            this.Controls.Add(this.lblId_Compra);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.btnInsertar_Compra);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCompra_Compra;
        private System.Windows.Forms.Label lblFecha_Compra;
        private System.Windows.Forms.TextBox txtPrecio_Compra;
        private System.Windows.Forms.Label lblPrecio_Compra;
        private System.Windows.Forms.Label lblId_Compra;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Button btnInsertar_Compra;
        private System.Windows.Forms.ComboBox CBIdProducto_Compras;
        private System.Windows.Forms.TextBox txtCantidadProducto_Compra;
        private System.Windows.Forms.Label lblCantidadProducto_Compras;
    }
}