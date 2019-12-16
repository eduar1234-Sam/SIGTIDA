namespace capaPresentacionn
{
    partial class Clientes
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.cedula = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(138, 39);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(12, 39);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(100, 20);
            this.cedula.TabIndex = 1;
            this.cedula.Text = "Cédula";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(269, 39);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 2;
            this.apellido.Text = "Apellido";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(12, 109);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 3;
            this.telefono.Text = "Teléfono";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(150, 109);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(100, 20);
            this.mail.TabIndex = 4;
            this.mail.Text = "E-mail";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(269, 109);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 20);
            this.direccion.TabIndex = 5;
            this.direccion.Text = "Dirección";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(391, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 426);
            this.dataGridView1.TabIndex = 6;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(163, 216);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 7;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Menú Principal";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.nombre);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button button1;
    }
}