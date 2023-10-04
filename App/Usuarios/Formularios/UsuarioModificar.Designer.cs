namespace App.Usuarios.Formularios
{
    partial class UsuarioModificar
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
            textBoxMail = new TextBox();
            label6 = new Label();
            textBoxContraseña = new TextBox();
            label5 = new Label();
            textBoxNombreUsuario = new TextBox();
            label4 = new Label();
            textBoxApellido = new TextBox();
            label3 = new Label();
            textBoxNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(363, 417);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 24;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(207, 289);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(386, 23);
            textBoxMail.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(385, 265);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 22;
            label6.Text = "Mail";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(207, 233);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(386, 23);
            textBoxContraseña.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(367, 209);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 20;
            label5.Text = "Contraseña";
            // 
            // textBoxNombreUsuario
            // 
            textBoxNombreUsuario.Location = new Point(207, 177);
            textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            textBoxNombreUsuario.Size = new Size(386, 23);
            textBoxNombreUsuario.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 153);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 18;
            label4.Text = "NombreUsuario";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(207, 121);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(386, 23);
            textBoxApellido.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 97);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 16;
            label3.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(207, 65);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(386, 23);
            textBoxNombre.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 41);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(334, 11);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 13;
            label1.Text = "Modificar usuario";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UsuarioModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonModificar);
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
            Name = "UsuarioModificar";
            Text = "UsuarioModificar";
            Load += UsuarioModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonModificar;
        private TextBox textBoxMail;
        private Label label6;
        private TextBox textBoxContraseña;
        private Label label5;
        private TextBox textBoxNombreUsuario;
        private Label label4;
        private TextBox textBoxApellido;
        private Label label3;
        private TextBox textBoxNombre;
        private Label label2;
        private Label label1;
    }
}