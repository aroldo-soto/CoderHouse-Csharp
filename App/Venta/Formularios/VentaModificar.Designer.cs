namespace App.Venta.Formularios
{
    partial class VentaModificar
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
            textBoxComentarios = new TextBox();
            buttonModificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(354, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 14;
            label1.Text = "Modificar venta";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 48);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 15;
            label2.Text = "Comentarios";
            // 
            // textBoxComentarios
            // 
            textBoxComentarios.Location = new Point(220, 81);
            textBoxComentarios.Name = "textBoxComentarios";
            textBoxComentarios.Size = new Size(386, 23);
            textBoxComentarios.TabIndex = 16;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(376, 415);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 17;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // VentaModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonModificar);
            Controls.Add(textBoxComentarios);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentaModificar";
            Text = "VentaModificar";
            Load += VentaModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxComentarios;
        private Button buttonModificar;
    }
}