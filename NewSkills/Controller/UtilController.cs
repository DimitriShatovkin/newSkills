using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NewSkills.Controller
{ 
    class UtilController
    {
        private static int workTime = 900;
        private static int pauseTime = 300;
        private static string progessInPerCent;
        private static int afterWorkTime = 900;
        private static int afterPauseTime = 300;
        public static string ProgessInPerCent { get { return progessInPerCent; } set { progessInPerCent = value; } }
        private static int lettersSum = 0;
        private static int endSum = 0;
        private static bool blockTextFieldAndTimer = false;

        public static bool ActivateWorkOrPause { get; set; }
        public static int WorkTime { get { return workTime; } set { workTime = value; } }
        public static int PauseTime { get { return pauseTime; } set { pauseTime = value; } }
        public static int AfterPauseTime { get { return afterPauseTime; } set { afterPauseTime = value; } }
        public static int AfterWorkTime { get { return afterWorkTime; } set { afterWorkTime = value; } }
        public static bool BlockTextFieldAndTimer { get { return blockTextFieldAndTimer; } set { blockTextFieldAndTimer = value; } }


        public static void getProgressInPercent(string typingText, string wholeText, bool setToHundertPercent)
        {
            if (typingText.Length != 0)
            {
                lettersSum = typingText.Length;
            }
            else
            {
                endSum = endSum + lettersSum;
            }

            int percent = (endSum * 100) / wholeText.Length;
            ProgessInPerCent = percent.ToString();

            if (setToHundertPercent == true || BlockTextFieldAndTimer == true)
            {
                ProgessInPerCent = "100";
            }
        }

        public static void showPause(Label pauseLbl, int time)
        {
            pauseLbl.Visibility = Visibility.Visible;
            pauseLbl.Content = "Отдых 5 минут";
            pauseLbl.Foreground = new SolidColorBrush(Colors.Red);
        }
    }
}
