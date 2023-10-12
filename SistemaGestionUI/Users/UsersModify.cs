using SistemaGestionBusiness;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI.Users
{
    public partial class UsersModify : Form
    {
        private Usuario _user;
        public UsersModify(Usuario user)
        {
            InitializeComponent();
            _user = user;
        }

        private void UsersModify_Load(object sender, EventArgs e)
        {
            this.textBoxNombre.Text = _user.Nombre;
            this.textBoxApellido.Text = _user.Apellido;
            this.textBoxNombreUsuario.Text = _user.NombreUsuario;
            this.textBoxContraseña.Text = _user.Contraseña;
            this.textBoxMail.Text = _user.Mail;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            var user = new Usuario()
            {
                Id = _user.Id,
                Nombre = textBoxNombre.Text,
                Apellido = textBoxApellido.Text,
                NombreUsuario = textBoxNombreUsuario.Text,
                Contraseña = textBoxContraseña.Text,
                Mail = textBoxMail.Text,
            };

            UserBusiness.UpdateUser(user);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha actualizado el usuario satisfactoriamente.");
            this.Close();
        }
    }
}
