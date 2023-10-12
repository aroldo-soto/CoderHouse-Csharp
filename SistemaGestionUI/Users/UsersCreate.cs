using SistemaGestionEntities;
using SistemaGestionBusiness;
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
    public partial class UsersCreate : Form
    {
        public UsersCreate()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var user = new Usuario()
            {
                Nombre = textBoxNombre.Text,
                Apellido = textBoxApellido.Text,
                NombreUsuario = textBoxNombreUsuario.Text,
                Contraseña = textBoxContraseña.Text,
                Mail = textBoxMail.Text,
            };

            UserBusiness.CreateUser(user);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha creado el usuario satisfactoriamente.");
            this.Close();
        }
    }
}
