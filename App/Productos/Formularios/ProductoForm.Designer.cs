namespace App
{
    partial class ProductoForm
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
            dataGridViewProducto = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripciones = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Modificar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            buttonCrear = new Button();
            buttonBuscar = new Button();
            textBoxBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducto
            // 
            dataGridViewProducto.AllowUserToAddRows = false;
            dataGridViewProducto.AllowUserToDeleteRows = false;
            dataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducto.Columns.AddRange(new DataGridViewColumn[] { Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario, Modificar, Eliminar });
            dataGridViewProducto.Location = new Point(12, 65);
            dataGridViewProducto.Name = "dataGridViewProducto";
            dataGridViewProducto.ReadOnly = true;
            dataGridViewProducto.RowTemplate.Height = 25;
            dataGridViewProducto.Size = new Size(860, 373);
            dataGridViewProducto.TabIndex = 0;
            dataGridViewProducto.CellContentClick += dataGridViewProducto_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Descripciones
            // 
            Descripciones.DataPropertyName = "Descripciones";
            Descripciones.HeaderText = "Descripciones";
            Descripciones.Name = "Descripciones";
            Descripciones.ReadOnly = true;
            // 
            // Costo
            // 
            Costo.DataPropertyName = "Costo";
            Costo.HeaderText = "Costo";
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.DataPropertyName = "PrecioVenta";
            PrecioVenta.HeaderText = "PrecioVenta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
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
            Modificar.Resizable = DataGridViewTriState.True;
            Modificar.SortMode = DataGridViewColumnSortMode.Automatic;
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
            // buttonCrear
            // 
            buttonCrear.Location = new Point(12, 12);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(75, 23);
            buttonCrear.TabIndex = 1;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(787, 12);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(85, 23);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar por ID";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(596, 12);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(185, 23);
            textBoxBuscar.TabIndex = 3;
            // 
            // ProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 450);
            Controls.Add(textBoxBuscar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonCrear);
            Controls.Add(dataGridViewProducto);
            Name = "ProductoForm";
            Text = "ProductoForm";
            Load += ProductoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProducto;
        private Button buttonCrear;
        private Button buttonBuscar;
        private TextBox textBoxBuscar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripciones;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewButtonColumn Modificar;
        private DataGridViewButtonColumn Eliminar;
    }
}