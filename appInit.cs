using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;

namespace Practical_Cards
{
    class appInit
    {
        
        public static void checkDependencies()
        {
            string CardsPath = Application.StartupPath + "cards\\";
            string ConfigPath = Application.StartupPath + "Practical Cards.ini";

            // Check for File Dependencies

            if (File.Exists(ConfigPath))
            {
                // File exists
            }
            else
            {
                // Create config.ini
                var parser = new FileIniDataParser();
                var data = new IniData();
                data["Variables"]["RunOnStartUp"] = "False";
                data["Variables"]["StartMinimized"] = "False";
                data["Variables"]["MinimizeToSystemTray"] = "False";
                data["Variables"]["CloseToMinimize"] = "False";
                data["Debug"]["ShowDebugTab"] = "False";
                data["Debug"]["ShowBlankCard"] = "False";
                parser.WriteFile(ConfigPath, data);
            }

            // Check for Folder Dependencies

            if (Directory.Exists(CardsPath))
            {
                // Folder exists
            }
            else
            {
                Directory.CreateDirectory(CardsPath);
            }

            var runApp = new Form1();
            runApp.init();
        }

        public static void openCardsFolder()
        {
            checkDependencies();
            string CardsPath = Application.StartupPath + "cards\\";
            Process.Start("explorer.exe", CardsPath);
        }
    }
}
