namespace capaPresentacionn
{
    partial class Ventas
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreCliente = new System.Windows.Forms.TextBox();
            this.apellidoCliente = new System.Windows.Forms.TextBox();
            this.comboProducto = new System.Windows.Forms.ComboBox();
            this.buscarProducto = new System.Windows.Forms.Button();
            this.cantidadProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.agregarProducto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facturarCompra = new System.Windows.Forms.Button();
            this.estadisticas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cédula";
            // 
            // nombreCliente
            // 
            this.nombreCliente.Location = new System.Drawing.Point(213, 40);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(100, 20);
            this.nombreCliente.TabIndex = 2;
            this.nombreCliente.Text = "Nombre";
            this.nombreCliente.TextChanged += new System.EventHandler(this.NombreCliente_TextChanged);
            // 
            // apellidoCliente
            // 
            this.apellidoCliente.Location = new System.Drawing.Point(331, 41);
            this.apellidoCliente.Name = "apellidoCliente";
            this.apellidoCliente.Size = new System.Drawing.Size(100, 20);
            this.apellidoCliente.TabIndex = 3;
            this.apellidoCliente.Text = "Apellido";
            // 
            // comboProducto
            // 
            this.comboProducto.FormattingEnabled = true;
            this.comboProducto.Location = new System.Drawing.Point(12, 88);
            this.comboProducto.Name = "comboProducto";
            this.comboProducto.Size = new System.Drawing.Size(121, 21);
            this.comboProducto.TabIndex = 4;
            this.comboProducto.Text = "Productos";
            this.comboProducto.SelectedIndexChanged += new System.EventHandler(this.ComboProducto_SelectedIndexChanged);
            // 
            // buscarProducto
            // 
            this.buscarProducto.Location = new System.Drawing.Point(118, 38);
            this.buscarProducto.Name = "buscarProducto";
            this.buscarProducto.Size = new System.Drawing.Size(75, 23);
            this.buscarProducto.TabIndex = 5;
            this.buscarProducto.Text = "Buscar";
            this.buscarProducto.UseVisualStyleBackColor = true;
            this.buscarProducto.Click += new System.EventHandler(this.BuscarProducto_Click);
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.Location = new System.Drawing.Point(183, 89);
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.Size = new System.Drawing.Size(21, 20);
            this.cantidadProducto.TabIndex = 6;
            this.cantidadProducto.TextChanged += new System.EventHandler(this.CantidadProducto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad";
            // 
            // agregarProducto
            // 
            this.agregarProducto.Location = new System.Drawing.Point(282, 89);
            this.agregarProducto.Name = "agregarProducto";
            this.agregarProducto.Size = new System.Drawing.Size(75, 23);
            this.agregarProducto.TabIndex = 8;
            this.agregarProducto.Text = "Agregar";
            this.agregarProducto.UseVisualStyleBackColor = true;
            this.agregarProducto.Click += new System.EventHandler(this.AgregarProducto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 222);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // facturarCompra
            // 
            this.facturarCompra.Location = new System.Drawing.Point(713, 391);
            this.facturarCompra.Name = "facturarCompra";
            this.facturarCompra.Size = new System.Drawing.Size(75, 23);
            this.facturarCompra.TabIndex = 10;
            this.facturarCompra.Text = "Facturar";
            this.facturarCompra.UseVisualStyleBackColor = true;
            this.facturarCompra.Click += new System.EventHandler(this.FacturarCompra_Click);
            // 
            // estadisticas
            // 
            this.estadisticas.Location = new System.Drawing.Point(713, 12);
            this.estadisticas.Name = "estadisticas";
            this.estadisticas.Size = new System.Drawing.Size(75, 23);
            this.estadisticas.TabIndex = 11;
            this.estadisticas.Text = "Estadísticas";
            this.estadisticas.UseVisualStyleBackColor = true;
            this.estadisticas.Click += new System.EventHandler(this.Estadisticas_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.estadisticas);
            this.Controls.Add(this.facturarCompra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.agregarProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidadProducto);
            this.Controls.Add(this.buscarProducto);
            this.Controls.Add(this.comboProducto);
            this.Controls.Add(this.apellidoCliente);
            this.Controls.Add(this.nombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreCliente;
        private System.Windows.Forms.TextBox apellidoCliente;
        private System.Windows.Forms.ComboBox comboProducto;
        private System.Windows.Forms.Button buscarProducto;
        private System.Windows.Forms.TextBox cantidadProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button agregarProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button facturarCompra;
        private System.Windows.Forms.Button estadisticas;
    }
}