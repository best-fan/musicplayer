using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;

namespace MusicPlayer
{
  
    public partial class Main : Form
    {
        //设置音量
        [DllImport("winmm.dll")]
        internal static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);
        [DllImport("winmm.dll")]
        internal static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        private void VolumTrackBar_Scroll(object sender, EventArgs e)
        {
          
          //  Bass.BASS_SetVolume(volume);
            uint currV = ushort.MaxValue / 2;
            waveOutGetVolume(IntPtr.Zero, out currV);
            ushort calcV = (ushort)(currV & 0x0000ffff);
            int newV = ((ushort.MaxValue / 100) * VolumTrackBar.Value);
            uint newVol = (((uint)newV & 0x0000ffff) | ((uint)newV << 16));
            waveOutSetVolume(IntPtr.Zero, newVol);
            //显示调整百分比
          //  Text =Text+ Convert.ToString("Volume: " + VolumTrackBar.Value + "%");
            if(VolumTrackBar.Value==0)
            {
                this.soundstate = SoundState.Nosound;
                Soundpicbox.Image = Properties.Resources.Nosound;
            }
            else
            {
                this.soundstate = SoundState.Sound;
                Soundpicbox.Image = Properties.Resources.sound;
            }
        }
        /// <summary>
        /// 播放器状态
        /// </summary>
        private enum PlayerState
        {
            /// <summary>
            /// 停止模式
            /// </summary>
            Stop,
            /// <summary>
            /// 播放模式
            /// </summary>
            Play,
            /// <summary>
            /// 暂停模式
            /// </summary>
            Pause
        }
        //记录当前播放器的状态。
        private PlayerState playerState;

        /// <summary>
        /// 音量状态
        /// </summary>
        private enum SoundState
        {
            //有声音
            Sound,

            //无声音
            Nosound
        }
        private SoundState soundstate=SoundState.Sound;//初始状态 播放器有声音

        /// <summary>
        /// 播放模式
        /// </summary>
        private enum PlayMode
        {
            /// <summary>
            /// 列表循环播放
            /// </summary>
            cycle,
            /// <summary>
            /// 顺序播放
            /// </summary>
            order,
            /// <summary>
            /// 随机播放
            /// </summary>
            random,
            /// <summary>
            /// 单曲循环
            /// </summary>
            singlecycle
        }
        private PlayMode playmode = PlayMode.order;//初始化播放模式 顺序播放；
        public int this_row;
        /// <summary>
        /// 判断播放模式，进行播放
        /// </summary>

        public void Play_Mode()
        {
            if (this_row >= MusicDgv.RowCount && this.playmode == PlayMode.cycle || this_row < 0)//索引数大于列表歌曲总数且列表循环播放
            {

                this_row = 0;
                Play();
            }

            else if (this_row >= MusicDgv.RowCount && this.playmode == PlayMode.singlecycle)//索引数大于列表歌曲总数且歌曲单曲循环
            {
                this_row = this_row - 1;
                Play();
            }
            else if (this_row >= MusicDgv.RowCount && this.playmode == PlayMode.random)//索引数大于列表歌曲总数且随机播放
            {
                Random rd = new Random();
                this_row = rd.Next(0, MusicDgv.RowCount - 1);
                Play();
            }
            else if (this_row >= MusicDgv.RowCount)//索引数大于列表歌曲总数
            {               
                this_row =0 ;
                SingerLbl.Text = "歌手：";
                SongLbl.Text = "歌曲：";
                progressBar1.Value = 0;
                NowTimeLbl.Text = PlayTimeLbl.Text = "00:00";
                Musictimer.Enabled = false;
                MessageBox.Show("所有歌曲播放完毕，请选择要播放的歌曲");
            }
           
            else
            {
                if (this.playmode == PlayMode.cycle)//列表循环播放
                {
                    Play();

                }
                else if (this.playmode == PlayMode.order)//顺序播放
                {


                    Play();


                }
                else if (this.playmode == PlayMode.singlecycle)//单曲循环
                {
                    this_row = this_row - 1;
                    Play();

                }
                else    //随机播放
                {
                    Random rd = new Random();
                    this_row = rd.Next(0, MusicDgv.RowCount - 1);
                    Play();

                }

            }
          
        }

        private void Play()
        {
            path = MusicDgv.Rows[this_row].Cells[2].Value.ToString();
            stream = Bass.BASS_StreamCreateFile(path, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT);
            Bass.BASS_ChannelPlay(stream, true);
            ProgressBar1_Time();
            SingerLbl.Text = "歌手：";
            SongLbl.Text = "歌曲：";
            SingerLbl.Text += MusicDgv.Rows[this_row].Cells[3].Value.ToString();
            SongLbl.Text += MusicDgv.Rows[this_row].Cells[4].Value.ToString();
        }

        public Main()
        {
          
            InitializeComponent();
        } 

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string path="";
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //实例化打开对话框
            using (OpenFileDialog ope = new OpenFileDialog())
            {
                //对话框标题
                ope.Title = "请选择媒体文件";
                //文件是否可以多选
                ope.Multiselect = true;
                //设置对话框的文件类型
                ope.Filter = "MP3文件|*.MP3|媒体文件|*.wav";
                //展示对话框
                if (ope.ShowDialog() == DialogResult.OK)
                {
                    //遍历加载当前选中文件
                    for (int i = 0; i < ope.FileNames.Length; i++)
                    {
                        //返回没有后缀的文件名
                        string musicName = Path.GetFileNameWithoutExtension(ope.FileNames[i]);
                        string[] music = musicName.Split('-');
                        string extension = Path.GetExtension(ope.FileNames[i]);
                         extension=  extension.Replace(".","").ToUpper();
                        int index = this.MusicDgv.Rows.Add();
                        this.MusicDgv.Rows[index].Cells[0].Value = musicName;
                        this.MusicDgv.Rows[index].Cells[1].Value = extension;
                        this.MusicDgv.Rows[index].Cells[2].Value = ope.FileNames[i];
                        this.MusicDgv.Rows[index].Cells[3].Value = music[0];
                        this.MusicDgv.Rows[index].Cells[4].Value = music[1];


                    }


                   
                }
                MusicNumber();
               
            }
        }
      
        private void Main_Load(object sender, EventArgs e)
        {
            BassNet.Registration("your@email.com", "2X34243714232222");
            if (!Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_CPSPEAKERS,this.Handle))
            {
                MessageBox.Show("Bass初始化失败" + Bass.BASS_ErrorGetCode().ToString());
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bass.BASS_ChannelStop(stream);//停止播放；
            Bass.BASS_StreamFree(stream);//释放音频流；
            Bass.BASS_Stop();//停止所有输出；
            Bass.BASS_Free();//释放所有资源；
        }
     
        private void Playpicbox_Click(object sender, EventArgs e)
        {
            if (path==string.Empty)
            {
                MessageBox.Show("请添加歌曲");
            }
            else
            {
                if (this.playerState == PlayerState.Play)
                {
                    Bass.BASS_ChannelPause(stream);//音乐暂停
                 Playpicbox.Image=Properties.Resources.play;                
                    this.playerState = PlayerState.Pause;


                }
                else if (this.playerState == PlayerState.Pause)
                {
                    Bass.BASS_ChannelPlay(stream, false);//继续播放
                    Playpicbox.Image = Properties.Resources.pause;
                    this.playerState = PlayerState.Play;
                }
                else//停止播放
                {
                   

                    Bass.BASS_ChannelStop(stream);//停止播放
                    Playpicbox.Image = Properties.Resources.play;
                    this.playerState = PlayerState.Play;
                }

            }
        }

        private void Musictimer_Tick(object sender, EventArgs e)
        {
            //显示当前播放时间
            MusicNowTime = Convert.ToInt32(Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetPosition(stream, BASSMode.BASS_POS_BYTES)));
            TimeSpan ts = new TimeSpan(0, 0, MusicNowTime);
            if (ts.Seconds < 10)
            {
                NowTimeLbl.Text = "0" + (int)ts.Minutes + ":0" + ts.Seconds;
            }
            else
            {
                NowTimeLbl.Text = "0" + (int)ts.Minutes + ":" + ts.Seconds;
            }
            progressBar1.Value = MusicNowTime;
            if (this.MusicNowTime == this.Musictime)//判断歌曲是否播放完毕

            {
               this_row = this_row + 1;
                Play_Mode();
            }if (playerState == PlayerState.Play)
            {
                foreach (string key in lrcDictionary.Keys)
                {
                    if(key== NowTimeLbl.Text)
                    {
                        LrcLbl.Text = lrcDictionary[key];
                    }
                }
            }
     


        }


        private void 删除歌曲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MusicNumLbl.Text == "列表歌曲：" || MusicNumLbl.Text.Contains(":0首"))
            {

            }
            else
            {
                MusicDgv.Rows.RemoveAt(MusicDgv.CurrentRow.Index);
                MusicNumber();
            }
        }

        private void MusicDgv_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //contextMenuStrip1.Show(PointToScreen(e.Location));
                this.contextMenuStrip1.Show(MusicDgv, new Point(e.X, e.Y));//contextMenuStrip1位置
            }
        }
       public int stream;//创建音频流句柄           BASS_ChannelPlay（stream,） true false是否重新播放

       public int Musictime, MusicNowTime;     //歌曲总时间，当前播放时间
        private void MusicDgv_DoubleClick(object sender, EventArgs e)
        {
            Bass.BASS_ChannelStop(stream);//停止播放
            path = MusicDgv.CurrentRow.Cells[2].Value.ToString();
            stream = Bass.BASS_StreamCreateFile(path, 0L, 0L, BASSFlag.BASS_SAMPLE_FLOAT);
            Bass.BASS_ChannelPlay(stream, true);//播放当前音乐
            Playpicbox.Image = Properties.Resources.pause;
            this.playerState = PlayerState.Play;
            Musictimer.Enabled = true;
            MusicInfor();
            ProgressBar1_Time();
            this_row = MusicDgv.CurrentRow.Index;//获取当前选择行的索引
            LrcLbl.Visible = true;//显示歌词
            Lrc_Exist();//*************************是否存在歌词********************************************
        }
        /// <summary>
        /// 歌曲信息
        /// </summary>
        public void MusicInfor()
        {
            SingerLbl.Text = "歌手：";
            SongLbl.Text = "歌曲：";
            SingerLbl.Text += MusicDgv.CurrentRow.Cells[3].Value.ToString() ;
            SongLbl.Text += MusicDgv.CurrentRow.Cells[4].Value.ToString();

        }

        private void Playpicbox_MouseMove(object sender, MouseEventArgs e)
        {
            if(this.playerState==PlayerState.Pause)
            {
                Playpicbox.Image = Properties.Resources.play_m;
            }
            else if (this.playerState == PlayerState.Play)
            {
                Playpicbox.Image = Properties.Resources.pause_m;
            }
            else
            {
                Playpicbox.Image = Properties.Resources.play_m;
            }
            

        }

        private void Playpicbox_MouseLeave(object sender, EventArgs e)
        {
            if (this.playerState == PlayerState.Pause)
            {
                Playpicbox.Image = Properties.Resources.play;
            }
            else if (this.playerState == PlayerState.Play)
            {
                Playpicbox.Image = Properties.Resources.pause;
            }
            else
            {
                Playpicbox.Image = Properties.Resources.play;
            }
        }

        private void Nextpicbox_MouseMove(object sender, MouseEventArgs e)
        {
            Nextpicbox.Image = Properties.Resources.next_m;
        }

        private void Nextpicbox_MouseLeave(object sender, EventArgs e)
        {

            Nextpicbox.Image = Properties.Resources.next;
        }

        private void Prepicbox_MouseMove(object sender, MouseEventArgs e)
        {
            Prepicbox.Image = Properties.Resources.pre_m;
        }

        private void Prepicbox_MouseLeave(object sender, EventArgs e)
        {

            Prepicbox.Image = Properties.Resources.pre;
        }

        private void Soundpicbox_Click(object sender, EventArgs e)
        {
            if (VolumTrackBar.Visible == true)
            {
                VolumTrackBar.Visible = false;
            }
            else
            {
                VolumTrackBar.Visible = true;
            }
       }

        private void Soundpicbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.soundstate == SoundState.Sound)
            {
                Soundpicbox.Image = Properties.Resources.sound_m;
            }
            else
            {
                Soundpicbox.Image = Properties.Resources.Nosound_m;
            }
           
        }

        private void Soundpicbox_MouseLeave(object sender, EventArgs e)
        {
            if (this.soundstate == SoundState.Sound)
            {
                Soundpicbox.Image = Properties.Resources.sound;
            }
            else
            {
                Soundpicbox.Image = Properties.Resources.Nosound;
            }

        }
        /// <summary>
        /// 歌曲数量
        /// </summary>
        private void  MusicNumber()
        {
            MusicNumLbl.Text = "列表歌曲:";
            MusicNumLbl.Text += MusicDgv.RowCount + "首";
        }

        private void PlayModePicbox_Click(object sender, EventArgs e)
        {
            if(this.playmode==PlayMode.order)//如果当前播放模式为顺序播放
            {
                PlayModePicbox.Image = Properties.Resources.singlecycle;
                this.playmode = PlayMode.singlecycle;
                PlayModeLbl.Text = "播放模式：单曲循环";

            }
            else if(this.playmode==PlayMode.singlecycle)
            {
                PlayModePicbox.Image = Properties.Resources.random;
                this.playmode = PlayMode.random;
                PlayModeLbl.Text = "播放模式：随机播放";
            }
            else if(this.playmode==PlayMode.random)
            {
                PlayModePicbox.Image = Properties.Resources.cycle;
                this.playmode = PlayMode.cycle;
                PlayModeLbl.Text = "播放模式：列表循环";
            }
            else
            {
                PlayModePicbox.Image = Properties.Resources.order;
                this.playmode = PlayMode.order;
                PlayModeLbl.Text = "播放模式：顺序播放";
            }
            
        }

        private void PlayModePicbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.playmode == PlayMode.order)//如果当前播放模式为顺序播放
            {
                PlayModePicbox.Image = Properties.Resources.order_m;

            }
            else if (this.playmode == PlayMode.singlecycle)
            {
                PlayModePicbox.Image = Properties.Resources.singlecycle_m;
               
            }
            else if (this.playmode == PlayMode.random)
            {
                PlayModePicbox.Image = Properties.Resources.random_m;            
            }
            else
            {
                PlayModePicbox.Image = Properties.Resources.singlecycle_m;
            }
        }
        private void PlayModePicbox_MouseLeave(object sender, EventArgs e)
        {
            if (this.playmode == PlayMode.order)//如果当前播放模式为顺序播放
            {
                PlayModePicbox.Image = Properties.Resources.order;

            }
            else if (this.playmode == PlayMode.singlecycle)
            {
                PlayModePicbox.Image = Properties.Resources.singlecycle;

            }
            else if (this.playmode == PlayMode.random)
            {
                PlayModePicbox.Image = Properties.Resources.random;
            }
            else
            {
                PlayModePicbox.Image = Properties.Resources.singlecycle;
            }
        }
        /// <summary>
        /// 下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nextpicbox_Click(object sender, EventArgs e)
        {
           
            Bass.BASS_ChannelStop(stream);//停止播放
            Playpicbox.Image = Properties.Resources.pause;
            this.playerState = PlayerState.Play;
            if (this.playmode == PlayMode.singlecycle)
            {
                this_row = this_row + 2;
                Play_Mode();
            }
            else
            {
                this_row++;
                Play_Mode();
            }
            Lrc_Exist();//*************************是否存在歌词********************************************
        }
        /// <summary>
        /// 上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Prepicbox_Click(object sender, EventArgs e)
        {
            Bass.BASS_ChannelStop(stream);//停止播放
            Playpicbox.Image = Properties.Resources.pause;
            this.playerState = PlayerState.Play;
            if (this.playmode == PlayMode.singlecycle)
            {     
                Play_Mode();
            }
            else
            {
                this_row--;
                Play_Mode();
            }
            Lrc_Exist();//*************************是否存在歌词********************************************

        }

        private void 清空列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bass.BASS_ChannelStop(stream);//停止播放
            MusicDgv.Rows.Clear();
            SingerLbl.Text = "歌手：";
            SongLbl.Text = "歌曲：";
            MusicNumber();
        }

       

        /// <summary>
        /// 进度条和显示时间
        /// </summary>
        private void ProgressBar1_Time()
        {
            //获取歌曲的总时长
            Musictime = Convert.ToInt32(Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream, BASSMode.BASS_POS_BYTES)));
            TimeSpan ts = new TimeSpan(0, 0, Musictime);
            if (ts.Seconds < 10)
            {
                PlayTimeLbl.Text = "0" + (int)ts.Minutes + ":0" + ts.Seconds;
            }
            else
            {
                PlayTimeLbl.Text = "0" + (int)ts.Minutes + ":" + ts.Seconds;
            }
            progressBar1.Maximum = Musictime;//设置进度条最大值
        }
        /// <summary>
        /// 判断歌词文件是否存在
        /// </summary>
        /// 
        public string Lrcpath;
        public void Lrc_Exist()
        {
            lrcDictionary.Clear();
            if (playerState == PlayerState.Play)
            {

                string[] lrc_path =path.Split('.');
                Lrcpath = lrc_path[0] + ".lrc";
                if (File.Exists(Lrcpath))
                {                  
                    Lrc_Show();
                }
                else
                {
                    LrcLbl.Text = "歌词不存在";
                }
            }
        }
        public static Dictionary<string, string> lrcDictionary = new Dictionary<string, string>();
       

        private void Lrc_Show ()
        {
            
            string excTime = @"(?<=\[).*?(?=\])";
            string excText = @"(?<=\])(?!\[).*";
            MatchCollection matchTime;
            MatchCollection matchText;
            //读取文件所有行
            string[] str = File.ReadAllLines(Lrcpath, Encoding.Default);
          //  Dictionary<string, string> lrc = lrcDictionary.OrderBy(o => o.Key).ToDictionary(k => k.Key, v => v.Value);
            for (int i = 0; i < str.Length - 1; i++)
            {
                matchTime = Regex.Matches(str[i], excTime);
                matchText = Regex.Matches(str[i], excText);
                foreach (var s in matchTime)
                {
                    string strTemp = "";
                    foreach (var m in matchText)
                    {
                        strTemp += m;
                    }

                    if (s.ToString().Contains("."))
                    {
                        string[] tim = s.ToString().Split('.');
                        string n = tim[0];
                        lrcDictionary.Add(n, strTemp);
                    }
                    else
                    {
                       lrcDictionary.Add(s.ToString(), strTemp);
                    }
                }
            }
                
          
            
        }
        private Point mPoint = new Point();

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-mPoint.X, -mPoint.Y);
                Location = myPosittion;
            }
        }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本软件由小樊工作室出品，软件目前为测试期，如有Bug欢迎及时反馈。目前歌曲支持Mp3格式，如有歌词不显示，请检查歌词文件目录、文件名(歌词与歌曲同一文件夹)歌词文件是否存在");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://blog.bravetimes.cn/");
        }

        private void Lrc_picbox_Click(object sender, EventArgs e)
        {
            if(LrcLbl.Visible==false)
            {
                LrcLbl.Visible = true;
            }
            else
            {
                LrcLbl.Visible = false;
            }
        }

        private void Lrc_picbox_MouseMove(object sender, MouseEventArgs e)
        {
            Lrc_picbox.Image = Properties.Resources.Lrc_Show;
        }

        private void Lrc_picbox_MouseLeave(object sender, EventArgs e)
        {
            Lrc_picbox.Image = Properties.Resources.Lrc;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = e.X;
            mPoint.Y = e.Y;
        }

    }

}
