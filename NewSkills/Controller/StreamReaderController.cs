using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NewSkills.Controller
{
    class StreamReaderController
    {
        public string[] file { get; set; }
        public string path;

        public StreamReaderController(string fileName) {
            path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\TextFolder\\"+fileName+".txt";
            file = File.ReadAllLines(path);
        }


        public static void writeLetter(char letter, int hashCode) 
        {
            string filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\TextFolder\\logs.txt";

            // Create a file to write to.
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(String.Format("\nLetter "+letter +": Hashcode:" + hashCode +"\n"));
            }
        }


        public void writeLogs(string className, Exception exeption)
        {
           string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TextFolder\logs.txt");

            // Create a file to write to.
            using (StreamWriter sw = File.AppendText(filePath))
            {
                // Get stack trace for the exception with source file information
                var st = new StackTrace(exeption, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                sw.WriteLine(String.Format("\nClass:" + className + " Exception: " + exeption.ToString() + "Line: " + line +"\n"));
            }
          
        }
    }
}
