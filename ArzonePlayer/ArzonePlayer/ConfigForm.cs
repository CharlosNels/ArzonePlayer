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
    public partial class ConfigForm :MaskinForm
    {
        MaskinForm parent;
        public ConfigForm(MaskinForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            Opacity = parent.Opacity;
            maskinCircleTrackBar1.Value = (float)Opacity;
        }
        private void maskinCircleTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            maskinCircleTrackBar1.UpText = maskinCircleTrackBar1.Value.ToString();
            maskinCircleTrackBar1.DownText = (1f - maskinCircleTrackBar1.Value).ToString();
            Opacity = maskinCircleTrackBar1.Value;
            parent.Opacity = maskinCircleTrackBar1.Value;
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            Size = new Size(167, 198);
        }
    }
}
