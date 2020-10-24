﻿using System;
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
        private static int workTime = 300;
        private static int pauseTime = 60;
        private static string progessInPerCent;
        private static int afterWorkTime = 300;
        private static int afterPauseTime = 60;
        public static string ProgessInPerCent { get { return progessInPerCent; } set { progessInPerCent = value; } }
        private static int lettersSum = 0;
        private static int endSum = 0;
        public static int EndSum { get { return endSum; } set { endSum = value; } }
        private static bool blockTextFieldAndTimer = false;

        private static int maxCommonTime = 900;
        public static int MaxCommonTime { get { return maxCommonTime; } set { maxCommonTime = value; } }
        private static int pauseAfterMaxCommonTime = 120;
        private static int startWorkTime = 300;
        public static int StartWorkTime { get { return startWorkTime; } set { startWorkTime = value; } }
       
        public static bool ActivateWorkOrPause { get; set; }
        public static int WorkTime { get { return workTime; } set { workTime = value; } }
        public static int PauseTime { get { return pauseTime; } set { pauseTime = value; } }
        public static int AfterPauseTime { get { return afterPauseTime; } set { afterPauseTime = value; } }
        public static int AfterWorkTime { get { return afterWorkTime; } set { afterWorkTime = value; } }
        public static bool BlockTextFieldAndTimer { get { return blockTextFieldAndTimer; } set { blockTextFieldAndTimer = value; } }

        public static int PauseAfterMaxCommonTime { get { return pauseAfterMaxCommonTime; } set { pauseAfterMaxCommonTime = value; } }

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

        public static void showPause(Label pauseLbl, string labelText)
        {
            pauseLbl.Visibility = Visibility.Visible;
            pauseLbl.Content = labelText;
            pauseLbl.Foreground = new SolidColorBrush(Colors.Red);
        }
    }
}
