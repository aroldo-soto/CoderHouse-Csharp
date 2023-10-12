namespace SistemaGestionUI.SoldProducts
{
    partial class SoldProductsForm
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
            dataGridViewSoldProducts = new DataGridView();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSoldProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSoldProducts
            // 
            dataGridViewSoldProducts.AllowUserToAddRows = false;
            dataGridViewSoldProducts.AllowUserToDeleteRows = false;
            dataGridViewSoldProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSoldProducts.Columns.AddRange(new DataGridViewColumn[] { Eliminar });
            dataGridViewSoldProducts.Location = new Point(12, 70);
            dataGridViewSoldProducts.Name = "dataGridViewSoldProducts";
            dataGridViewSoldProducts.ReadOnly = true;
            dataGridViewSoldProducts.RowTemplate.Height = 25;
            dataGridViewSoldProducts.Size = new Size(776, 368);
            dataGridViewSoldProducts.TabIndex = 2;
            dataGridViewSoldProducts.CellContentClick += dataGridViewSoldProducts_CellContentClick;
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
            // SoldProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewSoldProducts);
            Name = "SoldProductsForm";
            Text = "SoldProductsForm";
            Load += SoldProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSoldProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSoldProducts;
        private DataGridViewButtonColumn Eliminar;
    }
}