namespace App.Usuarios.Formularios
{
    partial class UsuarioCrear
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
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            label3 = new Label();
            textBoxNombreUsuario = new TextBox();
            label4 = new Label();
            textBoxContraseña = new TextBox();
            label5 = new Label();
            textBoxMail = new TextBox();
            label6 = new Label();
            buttonCrear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(355, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 1;
            label1.Text = "Crear usuario";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 39);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(214, 63);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(386, 23);
            textBoxNombre.TabIndex = 3;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(214, 119);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(386, 23);
            textBoxApellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 95);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // textBoxNombreUsuario
            // 
            textBoxNombreUsuario.Location = new Point(214, 175);
            textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            textBoxNombreUsuario.Size = new Size(386, 23);
            textBoxNombreUsuario.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 151);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 6;
            label4.Text = "NombreUsuario";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(214, 231);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(386, 23);
            textBoxContraseña.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 207);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 8;
            label5.Text = "Contraseña";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(214, 287);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(386, 23);
            textBoxMail.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 263);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 10;
            label6.Text = "Mail";
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(370, 415);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(75, 23);
            buttonCrear.TabIndex = 12;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // UsuarioCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCrear);
            Controls.Add(textBoxMail);
            Controls.Add(label6);
            Controls.Add(textBoxContraseña);
            Controls.Add(label5);
            Controls.Add(textBoxNombreUsuario);
            Controls.Add(label4);
            Controls.Add(textBoxApellido);
            Controls.Add(label3);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsuarioCrear";
            Text = "UsuarioCrear";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private Label label3;
        private TextBox textBoxNombreUsuario;
        private Label label4;
        private TextBox textBoxContraseña;
        private Label label5;
        private TextBox textBoxMail;
        private Label label6;
        private Button buttonCrear;
    }
}