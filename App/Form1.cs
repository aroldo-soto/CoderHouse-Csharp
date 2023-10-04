using App.ProductosVendidos.Formularios;
using App.Usuarios.Formularios;
using App.Venta.Formularios;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            UsuarioForm usuarioForm = new UsuarioForm();
            usuarioForm.Show();
        }
        private void buttonProducto_Click(object sender, EventArgs e)
        {
            ProductoForm productoForm = new ProductoForm();
            productoForm.Show();
        }

        private void buttonProductoVendido_Click(object sender, EventArgs e)
        {
            ProductoVendidoForm productoVendidoForm = new ProductoVendidoForm();
            productoVendidoForm.Show();
        }

        private void buttonVenta_Click(object sender, EventArgs e)
        {
            VentaForm ventaForm = new VentaForm();
            ventaForm.Show();
        }
    }
}