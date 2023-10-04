namespace App.Usuarios.Formularios
{
    partial class UsuarioForm
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
            textBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            buttonCrear = new Button();
            dataGridViewUsuario = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Mail = new DataGridViewTextBoxColumn();
            Modificar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).BeginInit();
            SuspendLayout();
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(593, 12);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(185, 23);
            textBoxBuscar.TabIndex = 7;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(784, 12);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(85, 23);
            buttonBuscar.TabIndex = 6;
            buttonBuscar.Text = "Buscar por ID";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(12, 12);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(75, 23);
            buttonCrear.TabIndex = 5;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // dataGridViewUsuario
            // 
            dataGridViewUsuario.AllowUserToAddRows = false;
            dataGridViewUsuario.AllowUserToDeleteRows = false;
            dataGridViewUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuario.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail, Modificar, Eliminar });
            dataGridViewUsuario.Location = new Point(12, 65);
            dataGridViewUsuario.Name = "dataGridViewUsuario";
            dataGridViewUsuario.ReadOnly = true;
            dataGridViewUsuario.RowTemplate.Height = 25;
            dataGridViewUsuario.Size = new Size(857, 373);
            dataGridViewUsuario.TabIndex = 4;
            dataGridViewUsuario.CellContentClick += dataGridViewUsuario_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "NombreUsuario";
            NombreUsuario.HeaderText = "NombreUsuario";
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            // 
            // Contraseña
            // 
            Contraseña.DataPropertyName = "Contraseña";
            Contraseña.HeaderText = "Contraseña";
            Contraseña.Name = "Contraseña";
            Contraseña.ReadOnly = true;
            // 
            // Mail
            // 
            Mail.DataPropertyName = "Mail";
            Mail.HeaderText = "Mail";
            Mail.Name = "Mail";
            Mail.ReadOnly = true;
            // 
            // Modificar
            // 
            Modificar.DataPropertyName = "Modificar";
            Modificar.HeaderText = "Modificar";
            Modificar.Name = "Modificar";
            Modificar.ReadOnly = true;
            Modificar.Text = "Modificar";
            Modificar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            Eliminar.DataPropertyName = "Eliminar";
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // UsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 450);
            Controls.Add(textBoxBuscar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonCrear);
            Controls.Add(dataGridViewUsuario);
            Name = "UsuarioForm";
            Text = "UsuarioForm";
            Load += UsuarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxBuscar;
        private Button buttonBuscar;
        private Button buttonCrear;
        private DataGridView dataGridViewUsuario;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Mail;
        private DataGridViewButtonColumn Modificar;
        private DataGridViewButtonColumn Eliminar;
    }
}