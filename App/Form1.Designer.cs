namespace App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonProducto = new Button();
            buttonUsuario = new Button();
            buttonProductoVendido = new Button();
            buttonVenta = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonProducto
            // 
            buttonProducto.Location = new Point(228, 98);
            buttonProducto.Name = "buttonProducto";
            buttonProducto.Size = new Size(109, 50);
            buttonProducto.TabIndex = 1;
            buttonProducto.Text = "Productos";
            buttonProducto.UseVisualStyleBackColor = true;
            buttonProducto.Click += buttonProducto_Click;
            // 
            // buttonUsuario
            // 
            buttonUsuario.Location = new Point(12, 98);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(109, 50);
            buttonUsuario.TabIndex = 2;
            buttonUsuario.Text = "Usuarios";
            buttonUsuario.UseVisualStyleBackColor = true;
            buttonUsuario.Click += buttonUsuario_Click;
            // 
            // buttonProductoVendido
            // 
            buttonProductoVendido.Location = new Point(444, 98);
            buttonProductoVendido.Name = "buttonProductoVendido";
            buttonProductoVendido.Size = new Size(127, 50);
            buttonProductoVendido.TabIndex = 3;
            buttonProductoVendido.Text = "ProductosVendidos";
            buttonProductoVendido.UseVisualStyleBackColor = true;
            buttonProductoVendido.Click += buttonProductoVendido_Click;
            // 
            // buttonVenta
            // 
            buttonVenta.Location = new Point(678, 98);
            buttonVenta.Name = "buttonVenta";
            buttonVenta.Size = new Size(109, 50);
            buttonVenta.TabIndex = 4;
            buttonVenta.Text = "Ventas";
            buttonVenta.UseVisualStyleBackColor = true;
            buttonVenta.Click += buttonVenta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(307, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 37);
            label1.TabIndex = 5;
            label1.Text = "Acceso a Datos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonVenta);
            Controls.Add(buttonProductoVendido);
            Controls.Add(buttonUsuario);
            Controls.Add(buttonProducto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonProducto;
        private Button buttonUsuario;
        private Button buttonProductoVendido;
        private Button buttonVenta;
        private Label label1;
    }
}