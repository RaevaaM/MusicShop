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
    public partial class DataOperationsAdmin : Form
    {
        public DataOperationsAdmin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataOperationsAdmin_Load(object sender, EventArgs e)
        {

        }

        private void backHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
    }
}
