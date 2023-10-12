namespace SistemaGestionUI.Users
{
    partial class UsersCreate
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
            label1 = new Label();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            label2 = new Label();
            textBoxNombreUsuario = new TextBox();
            label3 = new Label();
            textBoxContraseña = new TextBox();
            label4 = new Label();
            textBoxMail = new TextBox();
            Mail = new Label();
            buttonCrear = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDark;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(368, 9);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 10;
            label5.Text = "Crear usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(394, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 11;
            label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(311, 66);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(217, 23);
            textBoxNombre.TabIndex = 12;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(311, 126);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(217, 23);
            textBoxApellido.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 100);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 13;
            label2.Text = "Apellido ";
            // 
            // textBoxNombreUsuario
            // 
            textBoxNombreUsuario.Location = new Point(311, 186);
            textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            textBoxNombreUsuario.Size = new Size(217, 23);
            textBoxNombreUsuario.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 160);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 15;
            label3.Text = "NombreUsuario";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(311, 246);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(217, 23);
            textBoxContraseña.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 220);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 17;
            label4.Text = "Contraseña";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(311, 306);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(217, 23);
            textBoxMail.TabIndex = 20;
            // 
            // Mail
            // 
            Mail.AutoSize = true;
            Mail.Location = new Point(404, 280);
            Mail.Name = "Mail";
            Mail.Size = new Size(30, 15);
            Mail.TabIndex = 19;
            Mail.Text = "Mail";
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(382, 415);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(75, 23);
            buttonCrear.TabIndex = 21;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // UsersCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCrear);
            Controls.Add(textBoxMail);
            Controls.Add(Mail);
            Controls.Add(textBoxContraseña);
            Controls.Add(label4);
            Controls.Add(textBoxNombreUsuario);
            Controls.Add(label3);
            Controls.Add(textBoxApellido);
            Controls.Add(label2);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "UsersCreate";
            Text = "UsersCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private Label label2;
        private TextBox textBoxNombreUsuario;
        private Label label3;
        private TextBox textBoxContraseña;
        private Label label4;
        private TextBox textBoxMail;
        private Label Mail;
        private Button buttonCrear;
    }
}