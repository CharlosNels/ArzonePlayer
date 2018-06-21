using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maskin;

namespace ArzonePlayer
{
    public partial class LyricForm : Form
    {
        public LyricForm(out MaskinLyricsPanel mlp)
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            mlp = maskinLyricsPanel1;
        }

        private void LyricForm_Load(object sender, EventArgs e)
        {
            Size = new Size((int)(0.95*Screen.PrimaryScreen.Bounds.Width),Height);
            Location = new Point((Screen.PrimaryScreen.Bounds.Width - Width) / 2,  Screen.PrimaryScreen.Bounds.Height-40-Height);
        }

        private void maskinConfigButton1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.AnyColor = true;
            if (cd.ShowDialog()==DialogResult.OK)
            {
                maskinLyricsPanel1.DownColor = cd.Color;
            }
        }
    }
}
