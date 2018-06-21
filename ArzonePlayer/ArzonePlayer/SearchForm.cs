using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maskin;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using LYPlayer.Music;
using System.Threading;
using System.Runtime.InteropServices;

namespace ArzonePlayer
{
    public partial class SearchForm : MaskinForm
    {
        MusicKernel mker;
        public delegate void flush(string name);
        flush f;
        MaskinListBox Songs;
        const int WM_ADDITEM = 0x155;
        public SearchForm(MusicKernel mk,flush f,MaskinListBox parentList)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            mker = mk;
            this.f = f;
            Songs = parentList;
        }

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}