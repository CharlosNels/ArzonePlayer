using System;
using System.Collections.Generic;
using System.Text;
//作者：小红帽   QQ：761716178  论坛：http://bbs.cskin.net/
using Un4seen.Bass;
using Un4seen.Bass.AddOn.WaDsp;

namespace LYPlayer.Music
{
    /// <summary>
    /// DSP插件
    /// </summary>
    public class DSP
    {
        /// <summary>
        /// DSP句柄
        /// </summary>
        private int dspHandle = 0;
        private int dspModule = 0;

        private string fileName = String.Empty;
        /// <summary>
        /// DSP插件路径
        /// </summary>
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        private int stream;
        /// <summary>
        /// 音频流句柄
        /// </summary>
        public int Stream
        {
            get { return stream; }
            set { stream = value; }
        }

        /// <summary>
        /// 获取DSP插件名
        /// </summary>
        /// <returns></returns>
        public string DSPName
        {
            get { return BassWaDsp.BASS_WADSP_GetName(dspHandle); }

        }

        bool isActive = false;
        /// <summary>
        /// DSP是否处于激活状态
        /// </summary>
        public bool IsActive
        {
            get { return isActive; }
        }

        bool isLoaded = false;
        /// <summary>
        /// 是否已加载DSP插件
        /// </summary>
        public bool IsLoaded
        {
            get { return isLoaded; }
        }

        object tag;
        /// <summary>
        /// 与对象关联的用户数据
        /// </summary>
        public object Tag
        {
            get { return tag; }
            set { tag = value; }
        }

        /// <summary>
        /// 初始化DSP支持模块
        /// </summary>
        /// <param name="FormIntPtr"></param>
        public static void InitDSP(IntPtr FormIntPtr)
        {
            BassWaDsp.BASS_WADSP_Init(FormIntPtr);
        }

        /// <summary>
        /// 初始化DSP插件
        /// </summary>
        /// <param name="fileName"></param>
        public DSP(string fileName)
        {
            this.fileName = fileName;
        }

        /// <summary>
        /// 加载DSP插件
        /// </summary>
        /// <returns></returns>
        public void LoadDSP()
        {
            dspHandle = BassWaDsp.BASS_WADSP_Load(fileName, 5, 5, 100, 100, null);
            if (dspHandle != 0)
            {
                isLoaded = true;
            }
        }

        /// <summary>
        /// 启动DSP插件
        /// </summary>
        public void StartDSP()
        {
            BassWaDsp.BASS_WADSP_Start(dspHandle, dspModule, 0);

            isActive = true;
        }

        /// <summary>
        /// 设置DSP信道
        /// </summary>
        /// <param name="stream">音频流句柄</param>
        public void SetDSPChannel(int stream)
        {          
            this.stream = stream;

            if (Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                int hDsp = BassWaDsp.BASS_WADSP_ChannelSetDSP(dspHandle, stream, 1);
            }     
        }

        /// <summary>
        /// 对于某些DSP插件需要歌曲文件名，需要此方法设置来文件名
        /// </summary>
        /// <param name="fileName">歌曲文件名</param>
        public void SetMusicFileName(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                BassWaDsp.BASS_WADSP_SetFileName(dspHandle, fileName);
            }
        }

        /// <summary>
        /// 对于某些DSP插件需要歌曲名，需要此方法来设置歌曲名
        /// </summary>
        /// <param name="title">歌曲名</param>
        public void SetMusicTitle(string title)
        {
            if (!string.IsNullOrEmpty(title))
            {
                BassWaDsp.BASS_WADSP_SetSongTitle(dspHandle, title);
            }
        }

        /// <summary>
        /// 关闭DSP插件
        /// </summary>
        public void StopDSP()
        {
            BassWaDsp.BASS_WADSP_Stop(dspHandle);
            isActive = false;
        }

        /// <summary>
        /// 释放DSP插件
        /// </summary>
        public void FreeDSP()
        {
            StopDSP();
            if (BassWaDsp.BASS_WADSP_FreeDSP(dspHandle))
            {
                isLoaded = false;
            }
        }


        /// <summary>
        /// 设置DSP插件，显示DSP插件界面
        /// </summary>
        public void ConfigDSP()
        {
            if (dspHandle >= 0 && dspModule >= 0)
            {
                BassWaDsp.BASS_WADSP_Config(dspHandle);
            }
        }

        /// <summary>
        /// 释放DSP支持模块
        /// </summary>
        public static void Free()
        {
            BassWaDsp.BASS_WADSP_Free();
        }
    }
}
