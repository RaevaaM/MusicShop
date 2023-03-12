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
    public partial class Galery : UserControl
    {
        public Galery()
        {
            InitializeComponent();
        }

        private void labelGallery_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            string v1 = "C:\\Users\\maria\\MusicShop\\videos2\\Y2Mate.is - EMILIA - STOYAN ELENKА DUMASHE  Емилия - Стоян Еленка думаше, 2014-_Q6lL4Kjj7s-720p-1654127113329";
            axWindowsMediaPlayer1.URL = v1;
        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {
            string v2 = "C:\\Users\\maria\\MusicShop\\videos2\\Y2Mate.is - Bon Jovi - It's My Life (Official Music Video)-vx2u5uUu3DE-720p-1655348642374";
            axWindowsMediaPlayer2.URL = v2;
        }

        private void axWindowsMediaPlayer3_Enter(object sender, EventArgs e)
        {
            string v3 = "C:\\Users\\maria\\MusicShop\\videos2\\Y2Mate.is - The Weeknd - Save Your Tears (Official Music Video)-XXYlFuWEuKI-720p-1654123292045";
            axWindowsMediaPlayer3.URL = v3;
        }

        private void axWindowsMediaPlayer4_Enter(object sender, EventArgs e)
        {
            string v4 = "C:\\Users\\maria\\MusicShop\\videos2\\Y2Mate.is - OneRepublic - I Ain’t Worried (Hardstyle Remix 2023)-DJbS9ADibiA-720p-1655348503857";
            axWindowsMediaPlayer4.URL = v4;
        }

        private void Galery_Load(object sender, EventArgs e)
        {
        }

        private void linkGallery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
