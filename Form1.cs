using IniParser;
using IniParser.Model;

namespace Practical_Cards
{
    public partial class Form1 : Form
    {
        public static class GVar
        {
            public static bool DebugModeVar = false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        public void init()
        {
            string CardsPath = Application.StartupPath + "cards\\";
            string ConfigPath = Application.StartupPath + "Practical Cards.ini";
            
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(ConfigPath);
            string DebugVar = data["Debug"]["ShowDebugTab"];
            // ShowDebugTab contains "true"
            bool bool_Debug = bool.Parse(DebugVar);
            tabControl1.TabPages.Remove(DebugTab);
            if (bool_Debug == true)
            {
                GVar.DebugModeVar = true;
                MessageBox.Show("Cards Path: " + CardsPath + "\n\n" + "Config Path: " + ConfigPath);
                DebugGUI(GVar.DebugModeVar);
            }
            else
            {
                GVar.DebugModeVar = false;
                DebugGUI(GVar.DebugModeVar);
            }
        }

        public void DebugGUI(bool DebugMode)
        {
            ShowDebugTabChkBox.Checked = DebugMode;
            if (DebugMode == true)
            {
                tabControl1.TabPages.Insert(2, DebugTab);
            }
            else
            {
                tabControl1.TabPages.Remove(DebugTab);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            appInit.checkDependencies();
        }

        private void RefreshCardsTBtn_Click(object sender, EventArgs e)
        {
            appInit.checkDependencies(); // Recheck everythig is in order & reload config.ini
            // Load *.ini files
        }

        private void OpenCardsFolderTBtn_Click(object sender, EventArgs e)
        {
            appInit.openCardsFolder();
        }


        private void ShowBlankCardChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowBlankCardChkBox.Checked)
            {
                Card.Visible = true;
                Card2.Visible = true;
                Card3.Visible = true;
            }
            else
            {
                Card.Visible = false;
                Card2.Visible = false;
                Card3.Visible = false;
            }
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            string ConfigPath = Application.StartupPath + "Practical Cards.ini";
            var parser = new FileIniDataParser();
            var data = new IniData();
            data["Variables"]["RunOnStartUp"] = StartWithWindowsChkBox.Checked.ToString();
            data["Variables"]["StartMinimized"] = StartMinimizedChkBox.Checked.ToString();
            data["Variables"]["MinimizeToSystemTray"] = MinimizeToSysTrayChkBox.Checked.ToString();
            data["Variables"]["CloseToMinimize"] = CloseToMinimizeChkBox.Checked.ToString();
            data["Debug"]["ShowDebugTab"] = ShowDebugTabChkBox.Checked.ToString();
            data["Debug"]["ShowBlankCard"] = ShowBlankCardChkBox.Checked.ToString();
            parser.WriteFile(ConfigPath, data);
        }

        private void ShowDebugTabChkBox_CheckedChanged(object sender, EventArgs e)
        {

            if (ShowDebugTabChkBox.Checked)
            {
                tabControl1.TabPages.Insert(2, DebugTab);
            }
            else
            {
                tabControl1.TabPages.Remove(DebugTab);
            }
        }
    }
}   