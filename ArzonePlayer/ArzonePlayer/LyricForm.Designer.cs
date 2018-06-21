using System;

namespace ArzonePlayer
{
    partial class LyricForm
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
            this.maskinLyricsPanel1 = new Maskin.MaskinLyricsPanel();
            this.SuspendLayout();
            // 
            // maskinLyricsPanel1
            // 
            this.maskinLyricsPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskinLyricsPanel1.BackColor = System.Drawing.Color.Transparent;
            this.maskinLyricsPanel1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.maskinLyricsPanel1.Font = new System.Drawing.Font("ADELE", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskinLyricsPanel1.LineColor = System.Drawing.Color.LightGray;
            this.maskinLyricsPanel1.Location = new System.Drawing.Point(0, 1);
            this.maskinLyricsPanel1.Lyrics = new string[] {
        "Maskin Player"};
            this.maskinLyricsPanel1.Name = "maskinLyricsPanel1";
            this.maskinLyricsPanel1.OnLineColor = System.Drawing.Color.Silver;
            this.maskinLyricsPanel1.Size = new System.Drawing.Size(1440, 82);
            this.maskinLyricsPanel1.TabIndex = 4;
            // 
            // LyricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 84);
            this.Controls.Add(this.maskinLyricsPanel1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LyricForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(54)))));
            this.Load += new System.EventHandler(this.LyricForm_Load);
            this.ResumeLayout(false);

        }
        

        #endregion

        private Maskin.MaskinLyricsPanel maskinLyricsPanel1;
    }
}