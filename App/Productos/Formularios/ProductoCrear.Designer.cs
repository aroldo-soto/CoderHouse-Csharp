namespace App.Productos.Formularios
{
    partial class ProductoCrear
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
            label1 = new Label();
            label2 = new Label();
            textBoxDescripcion = new TextBox();
            label3 = new Label();
            numericUpDownCosto = new NumericUpDown();
            numericUpDownPrecioVenta = new NumericUpDown();
            label4 = new Label();
            numericUpDownStock = new NumericUpDown();
            label5 = new Label();
            buttonCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(360, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 0;
            label1.Text = "Crear producto";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 47);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            label2.Click += label2_Click;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(224, 79);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(386, 23);
            textBoxDescripcion.TabIndex = 2;
            textBoxDescripcion.TextChanged += textBoxDescripcion_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 119);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "Costo";
            label3.Click += label3_Click;
            // 
            // numericUpDownCosto
            // 
            numericUpDownCosto.Location = new Point(357, 151);
            numericUpDownCosto.Name = "numericUpDownCosto";
            numericUpDownCosto.Size = new Size(120, 23);
            numericUpDownCosto.TabIndex = 4;
            numericUpDownCosto.ValueChanged += numericUpDownCosto_ValueChanged;
            // 
            // numericUpDownPrecioVenta
            // 
            numericUpDownPrecioVenta.Location = new Point(357, 223);
            numericUpDownPrecioVenta.Name = "numericUpDownPrecioVenta";
            numericUpDownPrecioVenta.Size = new Size(120, 23);
            numericUpDownPrecioVenta.TabIndex = 6;
            numericUpDownPrecioVenta.ValueChanged += numericUpDownPrecioVenta_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 191);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 5;
            label4.Text = "PrecioVenta";
            label4.Click += label4_Click;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(357, 295);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(120, 23);
            numericUpDownStock.TabIndex = 8;
            numericUpDownStock.ValueChanged += numericUpDownStock_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 263);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 7;
            label5.Text = "Stock";
            label5.Click += label5_Click;
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(380, 417);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(75, 21);
            buttonCrear.TabIndex = 11;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // ProductoCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCrear);
            Controls.Add(numericUpDownStock);
            Controls.Add(label5);
            Controls.Add(numericUpDownPrecioVenta);
            Controls.Add(label4);
            Controls.Add(numericUpDownCosto);
            Controls.Add(label3);
            Controls.Add(textBoxDescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductoCrear";
            Text = "ProductoCrear";
            Load += ProductoCrear_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxDescripcion;
        private Label label3;
        private NumericUpDown numericUpDownCosto;
        private NumericUpDown numericUpDownPrecioVenta;
        private Label label4;
        private NumericUpDown numericUpDownStock;
        private Label label5;
        private Button buttonCrear;
    }
}