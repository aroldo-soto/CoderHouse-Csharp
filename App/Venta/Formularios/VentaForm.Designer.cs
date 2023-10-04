namespace App.Venta.Formularios
{
    partial class VentaForm
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
            dataGridViewVenta = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Comentarios = new DataGridViewTextBoxColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Modificar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVenta).BeginInit();
            SuspendLayout();
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(512, 13);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(185, 23);
            textBoxBuscar.TabIndex = 11;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(703, 12);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(85, 23);
            buttonBuscar.TabIndex = 10;
            buttonBuscar.Text = "Buscar por ID";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // dataGridViewVenta
            // 
            dataGridViewVenta.AllowUserToAddRows = false;
            dataGridViewVenta.AllowUserToDeleteRows = false;
            dataGridViewVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVenta.Columns.AddRange(new DataGridViewColumn[] { Id, Comentarios, IdUsuario, Modificar, Eliminar });
            dataGridViewVenta.Location = new Point(12, 65);
            dataGridViewVenta.Name = "dataGridViewVenta";
            dataGridViewVenta.ReadOnly = true;
            dataGridViewVenta.RowTemplate.Height = 25;
            dataGridViewVenta.Size = new Size(776, 373);
            dataGridViewVenta.TabIndex = 8;
            dataGridViewVenta.CellContentClick += dataGridViewVenta_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Comentarios
            // 
            Comentarios.DataPropertyName = "Comentarios";
            Comentarios.HeaderText = "Comentarios";
            Comentarios.Name = "Comentarios";
            Comentarios.ReadOnly = true;
            // 
            // IdUsuario
            // 
            IdUsuario.DataPropertyName = "IdUsuario";
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
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
            // VentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxBuscar);
            Controls.Add(buttonBuscar);
            Controls.Add(dataGridViewVenta);
            Name = "VentaForm";
            Text = "VentaForm";
            Load += VentaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxBuscar;
        private Button buttonBuscar;
        private DataGridView dataGridViewVenta;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Comentarios;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewButtonColumn Modificar;
        private DataGridViewButtonColumn Eliminar;
    }
}