namespace ArzonePlayer
{
    partial class SearchForm
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
            this.maskinTextBox1 = new Maskin.MaskinTextBox();
            this.searchButton1 = new Maskin.SearchButton();
            this.maskinListBox1 = new Maskin.MaskinListBox();
            this.SuspendLayout();
            // 
            // maskinLabel1
            // 
            this.maskinLabel1.DownColor = System.Drawing.Color.AliceBlue;
            this.maskinLabel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maskinLabel1.LineColor = System.Drawing.Color.AliceBlue;
            this.maskinLabel1.Location = new System.Drawing.Point(12, 12);
            this.maskinLabel1.Name = "maskinLabel1";
            this.maskinLabel1.OnLineColor = System.Drawing.Color.AliceBlue;
            this.maskinLabel1.Size = new System.Drawing.Size(75, 39);
            this.maskinLabel1.TabIndex = 4;
            this.maskinLabel1.Text = "搜索";
            // 
            // maskinTextBox1
            // 
            this.maskinTextBox1.AcceptsReturn = true;
            this.maskinTextBox1.BackColor = System.Drawing.Color.Black;
            this.maskinTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maskinTextBox1.ForeColor = System.Drawing.Color.SlateGray;
            this.maskinTextBox1.Location = new System.Drawing.Point(31, 72);
            this.maskinTextBox1.MaxLength = 30;
            this.maskinTextBox1.Name = "maskinTextBox1";
            this.maskinTextBox1.Size = new System.Drawing.Size(780, 29);
            this.maskinTextBox1.TabIndex = 5;
            // 
            // searchButton1
            // 
            this.searchButton1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.searchButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchButton1.Location = new System.Drawing.Point(825, 70);
            this.searchButton1.Name = "searchButton1";
            this.searchButton1.OnLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.searchButton1.Size = new System.Drawing.Size(30, 30);
            this.searchButton1.TabIndex = 6;
            this.searchButton1.Text = "searchButton1";
            // 
            // maskinListBox1
            // 
            this.maskinListBox1.AutoScroll = true;
            this.maskinListBox1.BackColor = System.Drawing.Color.Transparent;
            this.maskinListBox1.Location = new System.Drawing.Point(31, 120);
            this.maskinListBox1.MaskinListBoxItemDownColor = System.Drawing.Color.Black;
            this.maskinListBox1.MaskinListBoxItemLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maskinListBox1.MaskinListBoxItemOnLineColor = System.Drawing.Color.Gray;
            this.maskinListBox1.Name = "maskinListBox1";
            this.maskinListBox1.Size = new System.Drawing.Size(824, 371);
            this.maskinListBox1.TabIndex = 7;
            this.maskinListBox1.Text = "maskinListBox1";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CanMax = false;
            this.ClientSize = new System.Drawing.Size(887, 519);
            this.CloseOrHide = false;
            this.Controls.Add(this.maskinListBox1);
            this.Controls.Add(this.searchButton1);
            this.Controls.Add(this.maskinTextBox1);
            this.Controls.Add(this.maskinLabel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.GridenCenterPoint = new System.Drawing.Point(181, 175);
            this.Location = new System.Drawing.Point(520, 330);
            this.MaskinMiniBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShouldDrawBorder = false;
            this.ShowIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.Controls.SetChildIndex(this.maskinLabel1, 0);
            this.Controls.SetChildIndex(this.maskinTextBox1, 0);
            this.Controls.SetChildIndex(this.searchButton1, 0);
            this.Controls.SetChildIndex(this.maskinListBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Maskin.MaskinLabel maskinLabel1;
        private Maskin.MaskinTextBox maskinTextBox1;
        private Maskin.SearchButton searchButton1;
        private Maskin.MaskinListBox maskinListBox1;
    }
}