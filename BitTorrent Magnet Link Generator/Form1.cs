using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitTorrent_Magnet_Link_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtINFO_HASH_TextChanged(object sender, EventArgs e)
        {
            txtINFO_HASH.CharacterCasing = CharacterCasing.Upper;
            GenLink();
        }

        private void txtTORRENT_NAME_TextChanged(object sender, EventArgs e)
        {
            GenLink();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            GenLink();
        }

        private void txtTRACKER_LIST_TextChanged(object sender, EventArgs e)
        {
            GenLink();
        }

        private void GenLink()
        {
            if (txtINFO_HASH.Text != "" && txtINFO_HASH.Text.Length == 40)
            {
                string strtext = txtTRACKER_LIST.Text;
                var textArr = strtext.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                int txtLine = textArr.Length;
                string TORRENT_NAME;
                try
                {
                    if (txtTORRENT_NAME.Text == "")
                    {
                        TORRENT_NAME = txtINFO_HASH.Text;
                    }
                    else
                    {
                        TORRENT_NAME = txtTORRENT_NAME.Text;
                    }
                    var trackers = txtTRACKER_LIST.Text;
                    var data = "magnet:"
                        + "?xt=urn:btih:" + txtINFO_HASH.Text
                        + "&dn=" + Uri.EscapeDataString(TORRENT_NAME);
                    for (int i = 0; i <= txtLine - 1; i++)
                    {
                        data += "&tr=" + Uri.EscapeDataString(txtTRACKER_LIST.Lines[i]);
                    }
                    txtMAGNET_LINK.Text = data;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        private void linkMAGNET_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtMAGNET_LINK.Text != "")
            {
                System.Diagnostics.Process.Start(txtMAGNET_LINK.Text);
            }
        }

        private void txtMAGNET_LINK_Click(object sender, EventArgs e)
        {
            txtMAGNET_LINK.SelectAll();
            txtMAGNET_LINK.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtINFO_HASH.Clear();
            txtTORRENT_NAME.Clear();
            txtMAGNET_LINK.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMAGNET_LINK.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("bitcoin:bc1qmrvjhkc6kc79uw049nuquls4pknex3la03fyk4?label=Donate to BitTorrent Magnet Link Generator");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/thetooi/BitTorrent-Magnet-Link-Generator");
        }
    }
}
