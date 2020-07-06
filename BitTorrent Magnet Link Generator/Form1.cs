using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BitTorrent_Magnet_Link_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTrackerList();
            _ = txtINFO_HASH.Focus();
        }

        private void txtINFO_HASH_TextChanged(object sender, EventArgs e)
        {
            
            txtINFO_HASH.CharacterCasing = CharacterCasing.Upper;
            if (txtINFO_HASH.Text.Length == 40)
            {
                _ = txtTORRENT_NAME.Focus();
            }
            GenLink();
        }
        public static string TxtTrackerList = @"trackerlist.txt";

        private void LoadTrackerList()
        {
            if (File.Exists(TxtTrackerList))
            {    
                string list = File.ReadAllText(TxtTrackerList);
                txtTRACKER_LIST.Text = list;
            }
        }
        private void txtTORRENT_NAME_TextChanged(object sender, EventArgs e) => GenLink();

        private void btnGen_Click(object sender, EventArgs e) => GenLink();

        private void txtTRACKER_LIST_TextChanged(object sender, EventArgs e) => GenLink();

        private void GenLink()
        {
            if (string.IsNullOrEmpty(txtINFO_HASH.Text) != true && txtINFO_HASH.Text.Length == 40)
            {
                string strtext = txtTRACKER_LIST.Text;
                string[] textArr = strtext.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
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
                    string trackers = txtTRACKER_LIST.Text;
                    string data = "magnet:"
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
                    _ = MessageBox.Show(e.ToString());
                }
            }
        }

        private void linkMAGNET_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtMAGNET_LINK.Text != "")
            {
                _ = System.Diagnostics.Process.Start(txtMAGNET_LINK.Text);
            }
        }

        private void txtMAGNET_LINK_Click(object sender, EventArgs e)
        {
            txtMAGNET_LINK.SelectAll();
            _ = txtMAGNET_LINK.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtINFO_HASH.Clear();
            txtTORRENT_NAME.Clear();
            txtMAGNET_LINK.Clear();
            _ = txtINFO_HASH.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMAGNET_LINK.Text);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/thetooi/BitTorrent-Magnet-Link-Generator");
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Form dlg1 = new DonateForm();
            _ = dlg1.ShowDialog();
        }

        private void txtINFO_HASH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
