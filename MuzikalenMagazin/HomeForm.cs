using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikalenMagazin
{
    public partial class HomeForm : Form
    {
        
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            HomeForm home = new HomeForm();
            home.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            galery1.Hide();
            styles1.Hide();
            contacts1.Hide();
            aboutUs1.Hide();
        }

        private void btnStyles_Click(object sender, EventArgs e)
        {
            galery1.Hide();
            contacts1.Hide();
            aboutUs1.Hide();
            styles1.Show();
            styles1.BringToFront();
        }

        private void btnGallery_Click(object sender, EventArgs e)
        {
            contacts1.Hide();
            aboutUs1.Hide();
            styles1.Hide();
            galery1.Show();
            galery1.BringToFront();
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            styles1.Hide();
            galery1.Hide();
            aboutUs1.Hide();
            contacts1.Show();
            contacts1.BringToFront();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            styles1.Hide();
            galery1.Hide();
            contacts1.Hide();
            aboutUs1.Show();
            aboutUs1.BringToFront();
        }
    }
}
