using SharpConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryAssistant
{
    public partial class MemorizePeopleForm : Form
    {
        public const string VERSION = "Beta 1.1";
        public const string VERDATE = "2016.9.3";

        public float[] LevelSetting = { 1.0f, 0.8f, 0.6f, 0.4f, 0.2f };
        public int TimeRemind = 1200000;

        public bool ShowInfo
        {
            get
            {
                return m_showInfo;
            }
            set
            {
                m_showInfo = value;
                if (m_showInfo)
                {
                    lab_ShowInfo.Text = Info;
                }
                else
                {
                    lab_ShowInfo.Text = "点击查看信息";
                }
            }
        }
        public Mode FormMode { get; private set; } = Mode.MEMORIZE;
        public string Info { get; private set; }
        public string NowID { get; private set; }

        public Dictionary<string, Image> AllImg { get; private set; }
        //public Dictionary<string, string> AllInfo { get; private set; }

        private bool m_showInfo = false;

        private Configuration config;
        private Random random = new Random();

        public MemorizePeopleForm()
        {
            InitializeComponent();
        }

        private void MemorizePeopleForm_Load(object sender, EventArgs e)
        {
            //标题显示版本信息
            Text += " - " + VERSION + " - " + VERDATE;

            //更新模式
            if (chkBox_ModeSelect.Checked)
            {
                FormMode = Mode.TEST;
                ShowInfo = true;
            }  
            else
            {
                FormMode = Mode.MEMORIZE;
                ShowInfo = false;
            }


            //如果没有配置文件创建
            if(!File.Exists(Application.StartupPath + "\\config.ini"))
            {
                var c = new Configuration();
                c["IniInfo"]["CreateVer"].StringValue = VERSION;
                c["IniInfo"]["CreateDate"].StringValue = DateTime.Now.ToString();
                c["General"]["LevelSetting"].FloatValueArray = LevelSetting;
                c["General"]["TimeRemind"].IntValue = TimeRemind;
                c.SaveToFile("config.ini");
                ShowHelp();
                ShowAbout();
            }

            //如果没有photos目录创建并报错
            if (!Directory.Exists(Application.StartupPath + "//photos//"))
            {
                Directory.CreateDirectory(Application.StartupPath + "//photos//");
                MessageBox.Show("请将照片放入photos文件夹中，并以希望显示的名字命名！");
                this.Close();
                return;
            }

            config = Configuration.LoadFromFile("config.ini");

            //读取阶梯熟悉度设置
            LevelSetting = config["General"]["LevelSetting"].FloatValueArray;

            int timeRemind = config["General"]["TimeRemind"].IntValue;
            if (timeRemind <= 0) timer.Enabled = false;
            else
            {
                timer.Enabled = true;
                TimeRemind = timeRemind;
            }
            
            

            //读取照片
            try
            {
                LoadImages();
            }
            catch
            {
                this.Close();
                return;
            }

            //自动读取模式设置
            try
            {
                chkBox_ModeSelect.Checked = 
                    config["General"]["IsTest"].BoolValue;
            }
            catch
            {
                config["General"]["IsTest"].BoolValue = chkBox_ModeSelect.Checked;
                config.SaveToFile("config.ini");
            }


            Next();

            UpdateStatusStrip();
        }

        private void lab_ShowInfo_Click(object sender, EventArgs e)
        {
            if(FormMode == Mode.TEST)
               ShowInfo = !ShowInfo;
        }

        private void btn_Know_Click(object sender, EventArgs e)
        {
            if(FormMode == Mode.MEMORIZE)
            {
                Next();
                return;
            }
            int l = LoadLevel(NowID);
            if (l < LevelSetting.Count<float>() - 1)
                SaveLevel(NowID, ++l);
            else SaveLevel(NowID, LevelSetting.Count<float>() - 1);
            Next();
        }

        private void btn_Unkown_Click(object sender, EventArgs e)
        {
            if (FormMode == Mode.MEMORIZE)
            {
                Next();
                return;
            }
            int l = LoadLevel(NowID);
            if (l > 0)
                SaveLevel(NowID, --l);
            else SaveLevel(NowID, 0);
            Next();
        }

        private void LoadImages()
        {
            string path = Application.StartupPath + "\\photos\\";
            DirectoryInfo theFolder = new DirectoryInfo(path);

            AllImg = new Dictionary<string, Image>();
            //AllInfo = new Dictionary<string, string>();

            bool havePhotos = false;
            //读取照片
            foreach (FileInfo nextFile in theFolder.GetFiles())
            {
                if(nextFile.Extension != ".jpg" &&
                    nextFile.Extension != ".png" &&
                    nextFile.Extension != ".gif" &&
                    nextFile.Extension != ".bmp" &&
                    nextFile.Extension != ".ico" &&
                    nextFile.Extension != ".dib" &&
                    nextFile.Extension != ".tif")
                         continue;

                havePhotos = true;

                //获取照片名作为id编号
                string id = nextFile.Name.Split('.')[0];
                

                //AllInfo.Add(id, nextFile.Name);
                AllImg.Add(id, Image.FromFile(nextFile.FullName));

                //如果没有，创建熟练度信息
                if (LoadLevel(id) < 0)
                {
                    SaveLevel(id, 0);
                }
                
            }

            if (!havePhotos)
            {
                MessageBox.Show("没有在photos文件夹中检测到照片！");
                this.Close();
                throw new Exception("NoPhotoInFolder");
            }

        }

        public void Next()
        {
            string next = RandomID();
            Info = next;
            pBox_ShowPhotos.Image = AllImg[next];
            NowID = next;
            if (FormMode == Mode.MEMORIZE)
            {
                ShowInfo = true;
            }
            else
            {
                ShowInfo = false;
            }
            UpdateStatusStrip();
        }

        public string RandomID()
        {
            int total = AllImg.Count;
            int ran = random.Next(total);
            string id = AllImg.Keys.ToList<string>()[ran];
            if(random.NextDouble() > LevelSetting[LoadLevel(id)])
            {
                return RandomID();
            }
            return id;
        }
        public void SaveLevel(string id, int level)
        {
            config["Data"][id].SetValue<int>(level);
            config.SaveToFile("config.ini");
        }
        /// <summary>
        /// 没有返回-1
        /// </summary>
        public int LoadLevel(string id)
        {
            Section section = config["Data"];
            try
            {
                int result = section[id].IntValue;
                return result;
            }
            catch
            {
                return -1;
            }
        }

        public dynamic Check()
        {
            int total = 0;
            int remNum = 0;
            foreach (string key in AllImg.Keys)
            {
                total++;
                if (LoadLevel(key) >= LevelSetting.Count<float>() - 1)
                    remNum++;
            }
            return new { TotalNumber = total, HaveBeenRemembered = remNum, Complete = remNum / (float) total * 100f };
        }

        public void UpdateStatusStrip()
        {
            dynamic r = Check();
            Lab_ShowRem.Text = String.Format("您已记住{0}位，共{1}位。完成率：{2}%", r.HaveBeenRemembered, r.TotalNumber, Math.Round(r.Complete, 2));
            progressBar.Value = (int)r.Complete;
        }


        public enum Mode
        {
            TEST, MEMORIZE
        }

        private void chkBox_ModeSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_ModeSelect.Checked)
            {
                FormMode = Mode.TEST;
                ShowInfo = false;
            }
            else
            {
                FormMode = Mode.MEMORIZE;
                ShowInfo = true;
            }
            config["General"]["IsTest"].BoolValue = chkBox_ModeSelect.Checked;
            config.SaveToFile("config.ini");
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }
        public void ShowHelp()
        {
            MessageBox.Show("将照片放入photos文件夹中即可自动读取，并以文件名作为名字读取。\n现支持照片格式：jpg gif bmp ico png dib tif\n\n在【测验模式】下，系统会根据用户选择的【认识】与【不认识】来判断用户对某照片的熟悉程度，并按熟悉程度衰减其出现的概率。\n\nTips:此窗口大小可更改。", "帮助");
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }
        public void ShowAbout()
        {
            MessageBox.Show(String.Format("版本号：{0}\nRelease日期：{1}\n本软件为免费软件,未经许可禁止用于商业用途！", VERSION, VERDATE), "关于");
        }

        private void 重置熟悉度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (string key in AllImg.Keys)
            {
                SaveLevel(key, 0);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("您已经连续记忆" + TimeRemind / 1000 / 60 + "分钟了。\n休息一下吧！", "休息一下");
        }

        private void 更新日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        public void UpdateList()
        {
            MessageBox.Show("Alpha 1.0\n    进行内部测试。\n\nBeta 1.0\n    小范围发布测试。\n\nBeta 1.1\n    ·增加了长时间提醒和更新日志。", "更新日志");
        }
    }
}
