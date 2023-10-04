namespace App.Productos.Formularios
{
    partial class ProductoModificar
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
            buttonModificar = new Button();
            numericUpDownStock = new NumericUpDown();
            label5 = new Label();
            numericUpDownPrecioVenta = new NumericUpDown();
            label4 = new Label();
            numericUpDownCosto = new NumericUpDown();
            label3 = new Label();
            textBoxDescripcion = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCosto).BeginInit();
            SuspendLayout();
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(377, 414);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 21);
            buttonModificar.TabIndex = 21;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(354, 302);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(120, 23);
            numericUpDownStock.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 270);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 19;
            label5.Text = "Stock";
            // 
            // numericUpDownPrecioVenta
            // 
            numericUpDownPrecioVenta.Location = new Point(354, 230);
            numericUpDownPrecioVenta.Name = "numericUpDownPrecioVenta";
            numericUpDownPrecioVenta.Size = new Size(120, 23);
            numericUpDownPrecioVenta.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(380, 198);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 17;
            label4.Text = "PrecioVenta";
            // 
            // numericUpDownCosto
            // 
            numericUpDownCosto.Location = new Point(354, 158);
            numericUpDownCosto.Name = "numericUpDownCosto";
            numericUpDownCosto.Size = new Size(120, 23);
            numericUpDownCosto.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 126);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 15;
            label3.Text = "Costo";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(221, 86);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(386, 23);
            textBoxDescripcion.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 54);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 13;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(343, 16);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 12;
            label1.Text = "Modificar producto";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductoModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonModificar);
            Controls.Add(numericUpDownStock);
            Controls.Add(label5);
            Controls.Add(numericUpDownPrecioVenta);
            Controls.Add(label4);
            Controls.Add(numericUpDownCosto);
            Controls.Add(label3);
            Controls.Add(textBoxDescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductoModificar";
            Text = "ProductoModificar";
            Load += ProductoModificar_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCosto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonModificar;
        private NumericUpDown numericUpDownStock;
        private Label label5;
        private NumericUpDown numericUpDownPrecioVenta;
        private Label label4;
        private NumericUpDown numericUpDownCosto;
        private Label label3;
        private TextBox textBoxDescripcion;
        private Label label2;
        private Label label1;
    }
}