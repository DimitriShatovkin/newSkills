using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewSkills.Controller
{
    class UtilController
    {
        private static int workTime = 20;
        private static int pauseTime = 10;

        public static bool ActivateWorkOrPause { get; set; }
        public static int WorkTime { get { return workTime; } set { workTime = value; }}
        public static int PauseTime { get { return pauseTime; } set { pauseTime = value; }}
        public static string ProgessInPerCent { get; set; }
        private static int lettersSum = 0;
        private static int endSum = 0;


        public static void getProgressInPercent(string typingText, string wholeText,bool setToHundertPercent)
        {
            if (typingText.Length != 0)
            {
                 lettersSum = typingText.Length;
            }
            else {
                 endSum = endSum + lettersSum;
            }
            

            int percent = (endSum * 100) / wholeText.Length;
            ProgessInPerCent = percent.ToString();

            if (setToHundertPercent == true) {
                 ProgessInPerCent = "100";
            }
        }
    }
}
