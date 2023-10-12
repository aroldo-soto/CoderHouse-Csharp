namespace SistemaGestionUI.Products
{
    partial class ProductsModify
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
            label5 = new Label();
            buttonModificar = new Button();
            numericUpDownStock = new NumericUpDown();
            label4 = new Label();
            numericUpDownPrecioVenta = new NumericUpDown();
            label3 = new Label();
            numericUpDownCosto = new NumericUpDown();
            label2 = new Label();
            textBoxDescripciones = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCosto).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDark;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(342, 9);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 10;
            label5.Text = "Modificar producto";
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(377, 415);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 19;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(302, 294);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(225, 23);
            numericUpDownStock.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 262);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 17;
            label4.Text = "Stock";
            // 
            // numericUpDownPrecioVenta
            // 
            numericUpDownPrecioVenta.Location = new Point(302, 222);
            numericUpDownPrecioVenta.Name = "numericUpDownPrecioVenta";
            numericUpDownPrecioVenta.Size = new Size(225, 23);
            numericUpDownPrecioVenta.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 190);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 15;
            label3.Text = "PrecioVenta";
            // 
            // numericUpDownCosto
            // 
            numericUpDownCosto.Location = new Point(302, 150);
            numericUpDownCosto.Name = "numericUpDownCosto";
            numericUpDownCosto.Size = new Size(225, 23);
            numericUpDownCosto.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 118);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 13;
            label2.Text = "Costo";
            // 
            // textBoxDescripciones
            // 
            textBoxDescripciones.Location = new Point(302, 78);
            textBoxDescripciones.Name = "textBoxDescripciones";
            textBoxDescripciones.Size = new Size(225, 23);
            textBoxDescripciones.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 46);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 11;
            label1.Text = "Descripciones";
            // 
            // ProductModify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonModificar);
            Controls.Add(numericUpDownStock);
            Controls.Add(label4);
            Controls.Add(numericUpDownPrecioVenta);
            Controls.Add(label3);
            Controls.Add(numericUpDownCosto);
            Controls.Add(label2);
            Controls.Add(textBoxDescripciones);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "ProductModify";
            Text = "ProductModify";
            Load += ProductModify_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCosto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button buttonModificar;
        private NumericUpDown numericUpDownStock;
        private Label label4;
        private NumericUpDown numericUpDownPrecioVenta;
        private Label label3;
        private NumericUpDown numericUpDownCosto;
        private Label label2;
        private TextBox textBoxDescripciones;
        private Label label1;
    }
}