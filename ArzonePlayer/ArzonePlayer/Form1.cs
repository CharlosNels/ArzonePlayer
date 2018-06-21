using System;
using System.Drawing;
using System.Windows.Forms;
using LYPlayer.Music;
using Maskin;
using System.IO;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Drawing.Text;

namespace ArzonePlayer
{
    struct Infos
    {
        int i;
        public int id
        {
            get
            {
                return i;
            }
            set
            {
                i = value;
            }
        }
        Thread t;
        public Thread ths
        {
            get
            {
                return t;
            }
            set
            {
                t = value;
            }
        }
        public Infos(int id,Thread ts,string str)
        {
            i = id;
            t = ts;
            strs = str;
        }
        string strs;
        public string info
        {
            set
            {
                strs = value;
            }
            get
            {
                return strs;
            }
        }
    }
    public partial class ArzonePlayer:MaskinForm
    {

        MusicKernel mk;
        SearchForm sf;
        public ArzonePlayer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void addSongs()
        {
            string[] files = File.ReadAllLines("Songs",Encoding.UTF8);
            if (files.Length!=0)
            {
                foreach (var item in files)
                {
                    string[] ss = item.Split('$');
                    maskinListBox.AddItem(ss[0], ss[1], ss[2]);
                }
            }
        }
        private void ArzonePlayer_Load(object sender, EventArgs e)
        {
            try
            {
                mk = new MusicKernel(-1, 44100, Un4seen.Bass.BASSInit.BASS_DEVICE_CPSPEAKERS, Handle);
            }
            catch
            {
                MessageBox.Show(this, "Bass初始化错误");
                Close();
            }
            addSongs();
            sf = new SearchForm(mk, flush, maskinListBox);
            mk.StateChanged += Mk_StateChanged;
            lf = new LyricForm(out Mlp);
            Size = new Size(511, Screen.PrimaryScreen.Bounds.Height - 40);
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - Width, 0);
        }
        MaskinLyricsPanel Mlp;
        LyricForm lf;
        private void Mk_StateChanged(object sender, MusicEventArgs e)
        {
            switch (e.PlayState)
            {
                case PlayStates.Play:
                    PlayButton.PlayState = NativeData.PlayState.Playing;
                    PlayButton.Text = "暂停";
                    break;
                case PlayStates.Pause:
                    PlayButton.PlayState = NativeData.PlayState.Pause;
                    PlayButton.Text = "播放";
                    break;
                case PlayStates.Stopped:
                    PlayButton.PlayState = NativeData.PlayState.Pause;
                    PlayButton.Text = "播放";
                    break;
                case PlayStates.Stalled:
                    PlayButton.PlayState = NativeData.PlayState.Playing;
                    PlayButton.Text = "暂停";
                    break;
            }
        }

        private void ArzonePlayer_MouseEnter(object sender, EventArgs e)
        {
            if (roll==256)
            {
                fading = false;
                timer1.Start();
            }
        }

        private void ArzonePlayer_MouseLeave(object sender, EventArgs e)
        {
            if (roll==256)
            {
                if (MousePosition.X < Location.X || MousePosition.Y > Height)
                {
                    fading = true;
                    timer1.Start();
                }
            }
        }
        private bool fading = true;
        private int roll = 256;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fading)
            {
                if (Location.X < Screen.PrimaryScreen.Bounds.Width-1)
                {
                    Location = new Point(Location.X + roll, 0);
                    roll /= 2;
                }
                else
                {
                    roll = 256;
                    timer1.Stop();
                }
            }
            else
            {
                if (Location.X > Screen.PrimaryScreen.Bounds.Width - Size.Width)
                {
                    Location = new Point(Location.X - roll, 0);
                    roll /= 2;
                }
                else
                {
                    roll = 256;
                    timer1.Stop();
                }
            }
        }
        int ID=1;
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            SchedualBar.Value = (float)mk.Schedule;
            if ((int)mk.MusicTime==(int)mk.Length&&mk.MusicTime!=-1)
            {
                switch (LoopButton.Loop)
                {
                    case NativeData.LoopState.SingleCycle:
                        mk.Play(true);
                        break;
                    case NativeData.LoopState.ListCycle:
                        PlayNextSong();
                        break;
                    case NativeData.LoopState.RandomPlay:
                        Random r = new Random();
                        ID = r.Next(maskinListBox.Count);
                        string inf = maskinListBox.GetInfoByID(ID);
                        break;
                }
            }
        }
        private void PlayNextSong()
        {
            if (ID == maskinListBox.Count-1)
            {
                ID = 0;
                string inf = maskinListBox.GetInfoByID(ID);
            }
            else
            {
                ID++;
                string infs = maskinListBox.GetInfoByID(ID);
            }
        }

        private void PlayLastSong()
        {
            if (ID==0)
            {
                ID = maskinListBox.Count-1;
                string infs = maskinListBox.GetInfoByID(ID);
            }
            else
            {
                ID-=1;
                string inf = maskinListBox.GetInfoByID(ID);
            }
        }

        private void VolumeBar_ValueChanged(object sender, EventArgs e)
        {
            mk.Volume =(int)( VolumeBar.Value * 100);
        }
        private void SchedualBar_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Stop();
            SchedualBar.ValueChanged += SchedualBar_ValueChanged;
        }

        private void SchedualBar_ValueChanged(object sender, EventArgs e)
        {
            mk.Schedule = SchedualBar.Value;
        }

        private void SchedualBar_MouseUp(object sender, MouseEventArgs e)
        {
            SchedualBar.ValueChanged -= SchedualBar_ValueChanged;
            timer2.Start();
        }

        private void LoopButton_Click(object sender, EventArgs e)
        {
            switch (LoopButton.Loop)
            {
                case NativeData.LoopState.SingleCycle:
                    LoopButton.Loop = NativeData.LoopState.ListCycle;
                    LoopButton.Text = "列表循环";
                    break;
                case NativeData.LoopState.ListCycle:
                    LoopButton.Loop = NativeData.LoopState.RandomPlay;
                    LoopButton.Text = "随机播放";
                    break;
                case NativeData.LoopState.RandomPlay:
                    LoopButton.Loop = NativeData.LoopState.SingleCycle;
                    LoopButton.Text = "单曲循环";
                    break;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            switch (LoopButton.Loop)
            {
                case NativeData.LoopState.SingleCycle:
                    PlayNextSong();
                    break;
                case NativeData.LoopState.ListCycle:
                    PlayNextSong();
                    break;
                case NativeData.LoopState.RandomPlay:
                    Random r = new Random();
                    ID = r.Next(maskinListBox.Count) ;
                    string inf = maskinListBox.GetInfoByID(ID);
                    break;
            }
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            PlayLastSong();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (mk.PlayState==PlayStates.Pause)
            {
                mk.Play(false);
                PlayButton.PlayState = NativeData.PlayState.Playing;
                PlayButton.Text = "暂停";
            }
            else
            {
                mk.Pause();
                PlayButton.PlayState = NativeData.PlayState.Pause;
                PlayButton.Text = "播放";
            }
        }

        private void configButton1_Click(object sender, EventArgs e)
        {
            ConfigForm cf = new ConfigForm(this);
            cf.ShowDialog();
        }

        private void SchedualBar_MouseLeave(object sender, EventArgs e)
        {
            if (MousePosition.X<Location.X)
            {
                OnMouseLeave(e);
            }
        }
        private void flush(string name)
        {
            maskinLabel1.Text = name;
        }
        private void searchButton1_Click(object sender, EventArgs e)
        {
            sf.Opacity = Opacity;
            sf.Show();
        }

        private void ArzonePlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveList();
        }
        private void SaveList()
        {
            string[] Lists = new string[maskinListBox.Count];
            for (int i = 0; i < maskinListBox.Count; i++)
            {
                string[] str = maskinListBox.getMsg(i);
                Lists[i] = str[0] +'$'+ str[1] +'$'+ str[2];
            }
            File.WriteAllLines("Songs", Lists, Encoding.UTF8);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            SchedualBar.LoadValue = (float)mk.LoadProgress;
        }

        private void textButton1_Click(object sender, EventArgs e)
        {
            if (!lf.Visible)
            {
                lf.Show();
            }else
            {
                lf.Hide();
            }
        }
    }
}
