using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystemForTCD.forms
{
    public partial class Profile : Form
    {
        private int id;
        private bool isAdmin;
        public Profile(int id, bool isAdmin)
        {
            InitializeComponent();
            ProfileImage.Image = Image.FromFile(".\\..\\..\\..\\resources\\images\\profile.png");
            this.id = id;
            this.isAdmin = isAdmin;
            ChangeVisible(isAdmin);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            OpenNewWIndow(new Authorization());
        }

        private void OpenNewWIndow(Form form)
        {
            this.Hide();
            form.Show();
        }

        private void ChangeVisible(bool isAdmin)
        {
            if (isAdmin)
            {
                SurnameBox.Visible = false;
                EmailBox.Visible = false;
                NumberBox.Visible = false;
                AddressBox.Visible = false;
            }
            else
            {
                ArchiveButton.Visible = false;
                ClientsButton.Visible = false;
                ServicesButton.Visible = false;
            }
        }
    }
}
