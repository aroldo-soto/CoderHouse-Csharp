using App.Productos;
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
    public partial class VentaModificar : Form
    {
        private Venta _venta;
        public VentaModificar(Venta venta)
        {
            InitializeComponent();
            _venta = venta;
        }
        private void VentaModificar_Load(object sender, EventArgs e)
        {
            this.textBoxComentarios.Text = _venta.Comentarios;
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            _venta.Comentarios = textBoxComentarios.Text;

            VentaData.ModificarVenta(_venta);
            MessageBox.Show("Se ha actualizado la venta satisfactoriamente.");
        }

    }
}
