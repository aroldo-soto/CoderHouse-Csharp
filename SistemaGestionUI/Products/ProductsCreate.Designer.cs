namespace SistemaGestionUI.Products
{
    partial class ProductsCreate
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
            textBoxDescripciones = new TextBox();
            label2 = new Label();
            numericUpDownCosto = new NumericUpDown();
            numericUpDownPrecioVenta = new NumericUpDown();
            label3 = new Label();
            numericUpDownStock = new NumericUpDown();
            label4 = new Label();
            buttonCrear = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 46);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripciones";
            // 
            // textBoxDescripciones
            // 
            textBoxDescripciones.Location = new Point(291, 78);
            textBoxDescripciones.Name = "textBoxDescripciones";
            textBoxDescripciones.Size = new Size(225, 23);
            textBoxDescripciones.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 118);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Costo";
            // 
            // numericUpDownCosto
            // 
            numericUpDownCosto.Location = new Point(291, 150);
            numericUpDownCosto.Name = "numericUpDownCosto";
            numericUpDownCosto.Size = new Size(225, 23);
            numericUpDownCosto.TabIndex = 3;
            // 
            // numericUpDownPrecioVenta
            // 
            numericUpDownPrecioVenta.Location = new Point(291, 222);
            numericUpDownPrecioVenta.Name = "numericUpDownPrecioVenta";
            numericUpDownPrecioVenta.Size = new Size(225, 23);
            numericUpDownPrecioVenta.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 190);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "PrecioVenta";
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(291, 294);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(225, 23);
            numericUpDownStock.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 262);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Stock";
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(366, 415);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(75, 23);
            buttonCrear.TabIndex = 8;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDark;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(346, 9);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 9;
            label5.Text = "Crear producto";
            // 
            // ProductCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(buttonCrear);
            Controls.Add(numericUpDownStock);
            Controls.Add(label4);
            Controls.Add(numericUpDownPrecioVenta);
            Controls.Add(label3);
            Controls.Add(numericUpDownCosto);
            Controls.Add(label2);
            Controls.Add(textBoxDescripciones);
            Controls.Add(label1);
            Name = "ProductCreate";
            Text = "ProductCreate";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxDescripciones;
        private Label label2;
        private NumericUpDown numericUpDownCosto;
        private NumericUpDown numericUpDownPrecioVenta;
        private Label label3;
        private NumericUpDown numericUpDownStock;
        private Label label4;
        private Button buttonCrear;
        private Label label5;
    }
}