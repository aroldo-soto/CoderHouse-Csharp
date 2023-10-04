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
    public partial class UsuarioCrear : Form
    {
        public UsuarioCrear()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = textBoxNombre.Text;
            usuario.Apellido = textBoxApellido.Text;
            usuario.NombreUsuario = textBoxNombreUsuario.Text;
            usuario.Contraseña = textBoxContraseña.Text;
            usuario.Mail = textBoxMail.Text;

            UsuarioData.CrearUsuario(usuario);
            MessageBox.Show("Se ha creado el usuario satisfactoriamente.");
        }
    }
}
