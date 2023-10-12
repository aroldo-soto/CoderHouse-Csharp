namespace SistemaGestionUI
{
    partial class App
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
            buttonProductos = new Button();
            buttonProductosVendidos = new Button();
            buttonUsuarios = new Button();
            buttonVentas = new Button();
            SuspendLayout();
            // 
            // buttonProductos
            // 
            buttonProductos.Location = new Point(12, 12);
            buttonProductos.Name = "buttonProductos";
            buttonProductos.Size = new Size(75, 23);
            buttonProductos.TabIndex = 0;
            buttonProductos.Text = "Productos";
            buttonProductos.UseVisualStyleBackColor = true;
            buttonProductos.Click += buttonProductos_Click;
            // 
            // buttonProductosVendidos
            // 
            buttonProductosVendidos.Location = new Point(230, 12);
            buttonProductosVendidos.Name = "buttonProductosVendidos";
            buttonProductosVendidos.Size = new Size(120, 23);
            buttonProductosVendidos.TabIndex = 1;
            buttonProductosVendidos.Text = "ProductosVendidos";
            buttonProductosVendidos.UseVisualStyleBackColor = true;
            buttonProductosVendidos.Click += buttonProductosVendidos_Click;
            // 
            // buttonUsuarios
            // 
            buttonUsuarios.Location = new Point(493, 12);
            buttonUsuarios.Name = "buttonUsuarios";
            buttonUsuarios.Size = new Size(75, 23);
            buttonUsuarios.TabIndex = 2;
            buttonUsuarios.Text = "Usuarios";
            buttonUsuarios.UseVisualStyleBackColor = true;
            buttonUsuarios.Click += buttonUsuarios_Click;
            // 
            // buttonVentas
            // 
            buttonVentas.Location = new Point(711, 12);
            buttonVentas.Name = "buttonVentas";
            buttonVentas.Size = new Size(75, 23);
            buttonVentas.TabIndex = 3;
            buttonVentas.Text = "Ventas";
            buttonVentas.UseVisualStyleBackColor = true;
            buttonVentas.Click += buttonVentas_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVentas);
            Controls.Add(buttonUsuarios);
            Controls.Add(buttonProductosVendidos);
            Controls.Add(buttonProductos);
            Name = "App";
            Text = "App";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonProductos;
        private Button buttonProductosVendidos;
        private Button buttonUsuarios;
        private Button buttonVentas;
    }
}