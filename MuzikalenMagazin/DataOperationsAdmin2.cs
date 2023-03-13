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
    public partial class DataOperationsAdmin2 : UserControl
    {
        public DataOperationsAdmin2()
        {
            InitializeComponent();
        }

        private void backHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomeForm hf = new HomeForm();
            hf.ShowDialog();
            this.Hide();
        }

        private void linkSongs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
