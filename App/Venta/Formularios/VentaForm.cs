using App.Productos;
using App.Productos.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Venta.Formularios
{
    public partial class VentaForm : Form
    {
        private Venta ventaSeleccionada;
        public VentaForm()
        {
            InitializeComponent();
        }
        private void CargarVentas()
        {
            List<Venta> ventasList = VentaData.ListarVentas();
            dataGridViewVenta.AutoGenerateColumns = false;
            dataGridViewVenta.DataSource = ventasList;
        }
        private void VentaForm_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (long.TryParse(textBoxBuscar.Text, out long ventaId))
            {
                Venta ventaEncontrada = VentaData.ObtenerVenta(ventaId);

                if (ventaEncontrada != null)
                {
                    string message = $"ID: {ventaEncontrada.Id}\n" +
                         $"Comentarios: {ventaEncontrada.Comentarios}\n" +
                         $"IdUsuario: {ventaEncontrada.IdUsuario}";

                    MessageBox.Show(message, "Detalles de la venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Venta no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID de venta válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewVenta.Columns["Modificar"].Index)
            {
                ventaSeleccionada = (Venta)dataGridViewVenta.Rows[e.RowIndex].DataBoundItem;

                VentaModificar ventaModificar = new VentaModificar(ventaSeleccionada);
                ventaModificar.ShowDialog();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewVenta.Columns["Eliminar"].Index)
            {
                ventaSeleccionada = (Venta)dataGridViewVenta.Rows[e.RowIndex].DataBoundItem;

                VentaData.EliminarVenta(ventaSeleccionada);
                MessageBox.Show("Se ha eliminado la venta satisfactoriamente.");
            }
        }
    }
}
