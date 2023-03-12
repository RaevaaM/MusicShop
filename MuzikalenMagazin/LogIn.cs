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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInBTN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="Admin" && textBox2.Text=="admin")
            {
                HomeForm hf = new HomeForm();
                hf.Show();
                this.Hide();
            }
            else if (textBox1.Text == "User" && textBox2.Text == "user")
            {
                HomeForm hf = new HomeForm();
                hf.Show();
                this.Hide();
            }
        }
    }
}
