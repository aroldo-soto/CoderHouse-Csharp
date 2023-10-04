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
    public partial class UsuarioModificar : Form
    {
        private Usuario _usuario;
        public UsuarioModificar(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }
        private void UsuarioModificar_Load(object sender, EventArgs e)
        {
            this.textBoxNombre.Text = _usuario.Nombre;
            this.textBoxApellido.Text = _usuario.Apellido;
            this.textBoxNombreUsuario.Text = _usuario.NombreUsuario;
            this.textBoxContraseña.Text = _usuario.Contraseña;
            this.textBoxMail.Text = _usuario.Mail;
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            _usuario.Nombre = textBoxNombre.Text;
            _usuario.Apellido = textBoxApellido.Text;
            _usuario.NombreUsuario = textBoxNombreUsuario.Text;
            _usuario.Contraseña = textBoxContraseña.Text;
            _usuario.Mail = textBoxMail.Text;

            UsuarioData.ModificarUsuario(_usuario);
            MessageBox.Show("Se ha actualizado el usuario satisfactoriamente.");
        }

    }
}
