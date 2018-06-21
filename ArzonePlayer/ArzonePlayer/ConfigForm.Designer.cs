namespace ArzonePlayer
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maskinLabel1 = new Maskin.MaskinLabel();
            this.maskinCircleTrackBar1 = new Maskin.MaskinCircleTrackBar();
            this.SuspendLayout();
            // 
            // maskinLabel1
            // 
            this.maskinLabel1.DownColor = System.Drawing.Color.AliceBlue;
            this.maskinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.maskinLabel1.LineColor = System.Drawing.Color.AliceBlue;
            this.maskinLabel1.Location = new System.Drawing.Point(1, 2);
            this.maskinLabel1.Name = "maskinLabel1";
            this.maskinLabel1.OnLineColor = System.Drawing.Color.AliceBlue;
            this.maskinLabel1.Size = new System.Drawing.Size(75, 23);
            this.maskinLabel1.TabIndex = 4;
            this.maskinLabel1.Text = "不透明度:";
            // 
            // maskinCircleTrackBar1
            // 
            this.maskinCircleTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.maskinCircleTrackBar1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maskinCircleTrackBar1.DownText = null;
            this.maskinCircleTrackBar1.LineColor = System.Drawing.Color.Gray;
            this.maskinCircleTrackBar1.Location = new System.Drawing.Point(12, 41);
            this.maskinCircleTrackBar1.Name = "maskinCircleTrackBar1";
            this.maskinCircleTrackBar1.OnLineColor = System.Drawing.Color.OldLace;
            this.maskinCircleTrackBar1.Size = new System.Drawing.Size(149, 149);
            this.maskinCircleTrackBar1.TabIndex = 5;
            this.maskinCircleTrackBar1.UpText = null;
            this.maskinCircleTrackBar1.Value = 0F;
            this.maskinCircleTrackBar1.ValueChanged += new System.EventHandler(this.maskinCircleTrackBar1_ValueChanged);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CanMax = false;
            this.ClientSize = new System.Drawing.Size(167, 197);
            this.Controls.Add(this.maskinCircleTrackBar1);
            this.Controls.Add(this.maskinLabel1);
            this.GridenCenterPoint = new System.Drawing.Point(181, 175);
            this.Location = new System.Drawing.Point(500, 270);
            this.MaskinMiniBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.Controls.SetChildIndex(this.maskinLabel1, 0);
            this.Controls.SetChildIndex(this.maskinCircleTrackBar1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Maskin.MaskinLabel maskinLabel1;
        private Maskin.MaskinCircleTrackBar maskinCircleTrackBar1;
    }
}