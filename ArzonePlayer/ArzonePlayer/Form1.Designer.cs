using ArzonePlayer;
namespace ArzonePlayer
{
    partial class ArzonePlayer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.maskinListBox = new Maskin.MaskinListBox();
            this.PlayButton = new Maskin.MaskinPlayerPlayButton();
            this.NextButton = new Maskin.MaskinPlayerNextButton();
            this.LastButton = new Maskin.MaskinPlayerLastButton();
            this.LoopButton = new Maskin.MaskinPlayerLoopButton();
            this.SchedualBar = new Maskin.MaskinVerticalTrackBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.VolumeBar = new Maskin.MaskinTrackBar();
            this.maskinLabel1 = new Maskin.MaskinLabel();
            this.maskinPlayerVolumeButton1 = new Maskin.MaskinPlayerVolumeButton();
            this.configButton1 = new Maskin.MaskinConfigButton();
            this.searchButton1 = new Maskin.SearchButton();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.textButton1 = new Maskin.TextButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 47;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // maskinListBox
            // 
            this.maskinListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskinListBox.AutoScroll = true;
            this.maskinListBox.BackColor = System.Drawing.Color.Transparent;
            this.maskinListBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maskinListBox.Location = new System.Drawing.Point(57, 74);
            this.maskinListBox.MaskinListBoxItemDownColor = System.Drawing.Color.Black;
            this.maskinListBox.MaskinListBoxItemLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maskinListBox.MaskinListBoxItemOnLineColor = System.Drawing.Color.Gray;
            this.maskinListBox.Name = "maskinListBox";
            this.maskinListBox.Size = new System.Drawing.Size(451, 710);
            this.maskinListBox.TabIndex = 4;
            this.maskinListBox.Text = "maskinListBox1";
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.PlayButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayButton.Location = new System.Drawing.Point(227, 809);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.OnLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.PlayButton.PlayState = Maskin.NativeData.PlayState.Pause;
            this.PlayButton.Size = new System.Drawing.Size(39, 39);
            this.PlayButton.TabIndex = 5;
            this.PlayButton.Text = "播放";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.NextButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NextButton.Location = new System.Drawing.Point(340, 812);
            this.NextButton.Name = "NextButton";
            this.NextButton.OnLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.NextButton.Size = new System.Drawing.Size(39, 39);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "maskinPlayerNextButton1";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LastButton.BackColor = System.Drawing.Color.Transparent;
            this.LastButton.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.LastButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LastButton.Location = new System.Drawing.Point(94, 809);
            this.LastButton.Name = "LastButton";
            this.LastButton.OnLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.LastButton.Size = new System.Drawing.Size(39, 39);
            this.LastButton.TabIndex = 7;
            this.LastButton.Text = "maskinPlayerLastButton1";
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // LoopButton
            // 
            this.LoopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoopButton.BackColor = System.Drawing.Color.Transparent;
            this.LoopButton.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.LoopButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoopButton.Location = new System.Drawing.Point(464, 812);
            this.LoopButton.Loop = Maskin.NativeData.LoopState.ListCycle;
            this.LoopButton.Name = "LoopButton";
            this.LoopButton.OnLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.LoopButton.Size = new System.Drawing.Size(40, 37);
            this.LoopButton.TabIndex = 8;
            this.LoopButton.Text = "列表循环";
            this.LoopButton.Click += new System.EventHandler(this.LoopButton_Click);
            // 
            // SchedualBar
            // 
            this.SchedualBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SchedualBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SchedualBar.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SchedualBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SchedualBar.LineWidth = 3;
            this.SchedualBar.LoadProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.SchedualBar.LoadValue = 0.6F;
            this.SchedualBar.Location = new System.Drawing.Point(10, 74);
            this.SchedualBar.Name = "SchedualBar";
            this.SchedualBar.OnLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.SchedualBar.ShowPoint = true;
            this.SchedualBar.Size = new System.Drawing.Size(41, 710);
            this.SchedualBar.TabIndex = 9;
            this.SchedualBar.Value = 0.5F;
            this.SchedualBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SchedualBar_MouseDown);
            this.SchedualBar.MouseLeave += new System.EventHandler(this.SchedualBar_MouseLeave);
            this.SchedualBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SchedualBar_MouseUp);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // VolumeBar
            // 
            this.VolumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeBar.BackColor = System.Drawing.Color.Transparent;
            this.VolumeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolumeBar.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.VolumeBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.VolumeBar.LineWidth = 8;
            this.VolumeBar.Location = new System.Drawing.Point(47, 30);
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.OnLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.VolumeBar.ShowPoint = false;
            this.VolumeBar.Size = new System.Drawing.Size(452, 23);
            this.VolumeBar.TabIndex = 11;
            this.VolumeBar.Text = "maskinTrackBar1";
            this.VolumeBar.Value = 1F;
            this.VolumeBar.ValueChanged += new System.EventHandler(this.VolumeBar_ValueChanged);
            // 
            // maskinLabel1
            // 
            this.maskinLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskinLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.maskinLabel1.DownColor = System.Drawing.Color.AliceBlue;
            this.maskinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maskinLabel1.LineColor = System.Drawing.Color.AliceBlue;
            this.maskinLabel1.Location = new System.Drawing.Point(2, 1);
            this.maskinLabel1.Name = "maskinLabel1";
            this.maskinLabel1.OnLineColor = System.Drawing.Color.AliceBlue;
            this.maskinLabel1.Size = new System.Drawing.Size(457, 23);
            this.maskinLabel1.TabIndex = 11;
            this.maskinLabel1.Text = "SomeDay,We\'ll all be free";
            // 
            // maskinPlayerVolumeButton1
            // 
            this.maskinPlayerVolumeButton1.BackColor = System.Drawing.Color.Transparent;
            this.maskinPlayerVolumeButton1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.maskinPlayerVolumeButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.maskinPlayerVolumeButton1.Location = new System.Drawing.Point(10, 24);
            this.maskinPlayerVolumeButton1.Name = "maskinPlayerVolumeButton1";
            this.maskinPlayerVolumeButton1.OnLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.maskinPlayerVolumeButton1.Silence = false;
            this.maskinPlayerVolumeButton1.Size = new System.Drawing.Size(31, 32);
            this.maskinPlayerVolumeButton1.TabIndex = 12;
            this.maskinPlayerVolumeButton1.Text = "maskinPlayerVolumeButton1";
            // 
            // configButton1
            // 
            this.configButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.configButton1.DownColor = System.Drawing.Color.AliceBlue;
            this.configButton1.LineColor = System.Drawing.Color.AliceBlue;
            this.configButton1.Location = new System.Drawing.Point(465, 1);
            this.configButton1.Name = "configButton1";
            this.configButton1.OnLineColor = System.Drawing.Color.AliceBlue;
            this.configButton1.Size = new System.Drawing.Size(23, 23);
            this.configButton1.TabIndex = 13;
            this.configButton1.Text = "configButton1";
            this.configButton1.Click += new System.EventHandler(this.configButton1_Click);
            // 
            // searchButton1
            // 
            this.searchButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchButton1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.searchButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchButton1.Location = new System.Drawing.Point(12, 798);
            this.searchButton1.Name = "searchButton1";
            this.searchButton1.OnLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.searchButton1.Size = new System.Drawing.Size(50, 50);
            this.searchButton1.TabIndex = 14;
            this.searchButton1.Click += new System.EventHandler(this.searchButton1_Click);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 70;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // textButton1
            // 
            this.textButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textButton1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.textButton1.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.textButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textButton1.Location = new System.Drawing.Point(403, 807);
            this.textButton1.Name = "textButton1";
            this.textButton1.OnLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.textButton1.Size = new System.Drawing.Size(44, 50);
            this.textButton1.TabIndex = 15;
            this.textButton1.Text = "词";
            this.textButton1.Click += new System.EventHandler(this.textButton1_Click);
            // 
            // ArzonePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CanMax = false;
            this.ClientSize = new System.Drawing.Size(511, 860);
            this.Controls.Add(this.textButton1);
            this.Controls.Add(this.searchButton1);
            this.Controls.Add(this.configButton1);
            this.Controls.Add(this.maskinPlayerVolumeButton1);
            this.Controls.Add(this.maskinLabel1);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.SchedualBar);
            this.Controls.Add(this.LoopButton);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.maskinListBox);
            this.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GridenCenterPoint = new System.Drawing.Point(181, 175);
            this.LinesWidth = 2;
            this.Location = new System.Drawing.Point(953, 0);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaskinMiniBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Moveable = false;
            this.Name = "ArzonePlayer";
            this.Opacity = 0.85D;
            this.ShouldDrawBorder = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArzonePlayer_FormClosing);
            this.Load += new System.EventHandler(this.ArzonePlayer_Load);
            this.MouseEnter += new System.EventHandler(this.ArzonePlayer_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ArzonePlayer_MouseLeave);
            this.Controls.SetChildIndex(this.maskinListBox, 0);
            this.Controls.SetChildIndex(this.PlayButton, 0);
            this.Controls.SetChildIndex(this.NextButton, 0);
            this.Controls.SetChildIndex(this.LastButton, 0);
            this.Controls.SetChildIndex(this.LoopButton, 0);
            this.Controls.SetChildIndex(this.SchedualBar, 0);
            this.Controls.SetChildIndex(this.VolumeBar, 0);
            this.Controls.SetChildIndex(this.maskinLabel1, 0);
            this.Controls.SetChildIndex(this.maskinPlayerVolumeButton1, 0);
            this.Controls.SetChildIndex(this.configButton1, 0);
            this.Controls.SetChildIndex(this.searchButton1, 0);
            this.Controls.SetChildIndex(this.textButton1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Maskin.MaskinListBox maskinListBox;
        private Maskin.MaskinPlayerPlayButton PlayButton;
        private Maskin.MaskinPlayerNextButton NextButton;
        private Maskin.MaskinPlayerLastButton LastButton;
        private Maskin.MaskinPlayerLoopButton LoopButton;
        private Maskin.MaskinVerticalTrackBar SchedualBar;
        private System.Windows.Forms.Timer timer2;
        private Maskin.MaskinTrackBar VolumeBar;
        private Maskin.MaskinLabel maskinLabel1;
        private Maskin.MaskinPlayerVolumeButton maskinPlayerVolumeButton1;
        private Maskin.MaskinConfigButton configButton1;
        private Maskin.SearchButton searchButton1;
        private System.Windows.Forms.Timer timer3;
        private Maskin.TextButton textButton1;
    }
}

