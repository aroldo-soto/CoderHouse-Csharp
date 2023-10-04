namespace App.ProductosVendidos.Formularios
{
    partial class ProductoVendidoForm
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
            dataGridViewProductoVendido = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            IdVenta = new DataGridViewTextBoxColumn();
            Modificar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductoVendido).BeginInit();
            SuspendLayout();
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(512, 12);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(185, 23);
            textBoxBuscar.TabIndex = 7;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(703, 12);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(85, 23);
            buttonBuscar.TabIndex = 6;
            buttonBuscar.Text = "Buscar por ID";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // dataGridViewProductoVendido
            // 
            dataGridViewProductoVendido.AllowUserToAddRows = false;
            dataGridViewProductoVendido.AllowUserToDeleteRows = false;
            dataGridViewProductoVendido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductoVendido.Columns.AddRange(new DataGridViewColumn[] { Id, IdProducto, Stock, IdVenta, Modificar, Eliminar });
            dataGridViewProductoVendido.Location = new Point(12, 65);
            dataGridViewProductoVendido.Name = "dataGridViewProductoVendido";
            dataGridViewProductoVendido.ReadOnly = true;
            dataGridViewProductoVendido.RowTemplate.Height = 25;
            dataGridViewProductoVendido.Size = new Size(776, 373);
            dataGridViewProductoVendido.TabIndex = 4;
            dataGridViewProductoVendido.CellContentClick += dataGridViewProductoVendido_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // IdProducto
            // 
            IdProducto.DataPropertyName = "IdProducto";
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // IdVenta
            // 
            IdVenta.DataPropertyName = "IdVenta";
            IdVenta.HeaderText = "IdVenta";
            IdVenta.Name = "IdVenta";
            IdVenta.ReadOnly = true;
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
            // ProductoVendidoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxBuscar);
            Controls.Add(buttonBuscar);
            Controls.Add(dataGridViewProductoVendido);
            Name = "ProductoVendidoForm";
            Text = "ProductoVendidoForm";
            Load += ProductoVendidoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductoVendido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxBuscar;
        private Button buttonBuscar;
        private DataGridView dataGridViewProductoVendido;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn IdVenta;
        private DataGridViewButtonColumn Modificar;
        private DataGridViewButtonColumn Eliminar;
    }
}