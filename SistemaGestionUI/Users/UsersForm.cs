using SistemaGestionBusiness;
using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionEntities;
using SistemaGestionUI.Products;
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
    public partial class UsersForm : Form
    {
        private Usuario userSelected;
        public UsersForm()
        {
            InitializeComponent();
        }
        private void LoadContent()
        {
            using (var context = new ApplicationDbContext())
            {
                var users = UserBusiness.GetUsers();
                dataGridViewUsers.DataSource = users;
            }
        }
        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadContent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            UsersCreate form = new UsersCreate();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadContent();
            }
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewUsers.Columns["Modificar"].Index)
            {
                userSelected = (Usuario)dataGridViewUsers.Rows[e.RowIndex].DataBoundItem;

                UsersModify form = new UsersModify(userSelected);
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadContent();
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewUsers.Columns["Eliminar"].Index)
            {
                userSelected = (Usuario)dataGridViewUsers.Rows[e.RowIndex].DataBoundItem;

                UserBusiness.DeleteUser(userSelected.Id);
                this.LoadContent();
                MessageBox.Show("Se ha eliminado el usuario satisfactoriamente.");
            }
        }
    }
}
