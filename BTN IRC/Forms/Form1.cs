using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN_IRC
{
    public partial class BTNIRC : MetroFramework.Forms.MetroForm
    {
        public BTNIRC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void QuickConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.QuickConnect connect = new Forms.QuickConnect();
            {
                connect.Show();
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Settings settings = new Forms.Settings();
            {
                settings.Show();
            }
        }

        private void LimeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Refresh();
        }

        private void BlueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Refresh();
        }

        private void RedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Refresh();
        }

        private void PinkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Refresh();
        }

        private void MangentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Refresh();
        }

        private void OrangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Refresh();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

        }

        private void AddList_Click(object sender, EventArgs e)
        {
            Forms.ChanelFavAdd channeladd = new Forms.ChanelFavAdd();
            {
                channeladd.Show();
            }
        }
    }
}
