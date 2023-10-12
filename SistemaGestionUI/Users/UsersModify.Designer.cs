namespace SistemaGestionUI.Users
{
    partial class UsersModify
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
            Mail = new Label();
            textBoxContraseña = new TextBox();
            label4 = new Label();
            textBoxNombreUsuario = new TextBox();
            label3 = new Label();
            textBoxApellido = new TextBox();
            label2 = new Label();
            textBoxNombre = new TextBox();
            label1 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(363, 417);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 33;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(292, 308);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(217, 23);
            textBoxMail.TabIndex = 32;
            // 
            // Mail
            // 
            Mail.AutoSize = true;
            Mail.Location = new Point(385, 282);
            Mail.Name = "Mail";
            Mail.Size = new Size(30, 15);
            Mail.TabIndex = 31;
            Mail.Text = "Mail";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(292, 248);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(217, 23);
            textBoxContraseña.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 222);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 29;
            label4.Text = "Contraseña";
            // 
            // textBoxNombreUsuario
            // 
            textBoxNombreUsuario.Location = new Point(292, 188);
            textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            textBoxNombreUsuario.Size = new Size(217, 23);
            textBoxNombreUsuario.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 162);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 27;
            label3.Text = "NombreUsuario";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(292, 128);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(217, 23);
            textBoxApellido.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 102);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 25;
            label2.Text = "Apellido ";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(292, 68);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(217, 23);
            textBoxNombre.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 42);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 23;
            label1.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDark;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(334, 11);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 22;
            label5.Text = "Modificar usuario";
            // 
            // UsersModify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonModificar);
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
            Name = "UsersModify";
            Text = "UsersModify";
            Load += UsersModify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonModificar;
        private TextBox textBoxMail;
        private Label Mail;
        private TextBox textBoxContraseña;
        private Label label4;
        private TextBox textBoxNombreUsuario;
        private Label label3;
        private TextBox textBoxApellido;
        private Label label2;
        private TextBox textBoxNombre;
        private Label label1;
        private Label label5;
    }
}