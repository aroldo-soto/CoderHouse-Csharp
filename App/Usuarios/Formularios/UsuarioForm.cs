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

namespace App.Usuarios.Formularios
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }
        private Usuario usuarioSeleccionado;
        private void CargarUsuarios()
        {
            List<Usuario> usuariosList = UsuarioData.ListarUsuarios();
            dataGridViewUsuario.AutoGenerateColumns = false;
            dataGridViewUsuario.DataSource = usuariosList;
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            UsuarioCrear usuarioCrear = new UsuarioCrear();
            usuarioCrear.Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (long.TryParse(textBoxBuscar.Text, out long usuarioId))
            {
                Usuario usuarioIdEncontrado = UsuarioData.ObtenerUsuario(usuarioId);

                if (usuarioIdEncontrado != null)
                {
                    string message = $"ID: {usuarioIdEncontrado.Id}\n" +
                         $"Nombre: {usuarioIdEncontrado.Nombre}\n" +
                         $"Apellido: {usuarioIdEncontrado.Apellido}\n" +
                         $"NombreUsuario: {usuarioIdEncontrado.NombreUsuario}\n" +
                         $"Contraseña: {usuarioIdEncontrado.Contraseña}\n" +
                         $"Mail: {usuarioIdEncontrado.Mail}";

                    MessageBox.Show(message, "Detalles del Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID de usuario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewUsuario.Columns["Modificar"].Index)
            {
                usuarioSeleccionado = (Usuario)dataGridViewUsuario.Rows[e.RowIndex].DataBoundItem;

                UsuarioModificar usuarioModificar = new UsuarioModificar(usuarioSeleccionado);
                usuarioModificar.ShowDialog();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewUsuario.Columns["Eliminar"].Index)
            {
                usuarioSeleccionado = (Usuario)dataGridViewUsuario.Rows[e.RowIndex].DataBoundItem;

                UsuarioData.EliminarUsuario(usuarioSeleccionado);
                MessageBox.Show("Se ha eliminado el usuario satisfactoriamente.");
            }
        }
    }
}
