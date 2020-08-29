using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using NewSkills.ViewModel;
using NewSkills.Controller;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Reflection;
using System.Drawing;
using System.Windows.Interop;
using System.Windows.Media;

namespace NewSkills.View
{
    /// <summary>
    /// Interaction logic for FirstUC.xaml
    /// </summary>
    public partial class FirstUC : UserControl
    {
        // Timer Variables
        private DispatcherTimer timer;
        // End of Timer Variables

        private StreamReaderController streamReaderController;
        public bool spaceButtonClicked = false;
        private string inputText;
     
        
        NextLetterService nextLetterClass = new NextLetterService();
        private int fileLine = 1;
        private string[] wholeText;
        private int fileLength;
        private bool writeLetter = false;
        private int correctTextLenght = 0;


        public FirstUC(string fileName)
        {
            InitializeComponent();
            this.inputText = fileName;
            streamReaderController = new StreamReaderController(fileName);
            wholeText = streamReaderController.file;
            fileLength = wholeText.Length;
            exampleText.Text = streamReaderController.file[0];

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();           
        }


        // ежесекундый запуск метода, для таймера
        // тут высчитывается, должна ли работать пауза или печать
        private void Timer_Tick(object sender, EventArgs e)
        {
            //Спросить, нужно ли заблокировать рабочую область для паузы или нет
            if (UtilController.ActivateWorkOrPause == false)
            {
                typingTextTxt.IsReadOnly = false;
            }
            else
            {
                typingTextTxt.IsReadOnly = true;
            }
        }

        //сравнить два текста, при изменени текста в поле ввода
        private void typingTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                do
                {
                    string typingText = this.typingTextTxt.Text.Trim().Replace(" ", "|");
                    string sampleText = this.exampleText.Text.Trim().Replace(" ", "|");

                    if (spaceButtonClicked == true)
                    {
                        typingText = typingText + "|";
                    }

                    if (typingText.Length < sampleText.Length)
                    {
                        if (!getCurrentLetter(typingText.Length, typingText, sampleText))
                        {
                            popUpToWrongCase();
                            writeLetter = false;
                            this.typingTextTxt.Text = typingText.Substring(0, typingText.Length - 1).Replace("|", " "); // обрезать последнюю букву, если возникла ошибка
                            this.typingTextTxt.CaretIndex = correctTextLenght; //Поставить курсор на последнее место
                        }
                        else
                        {
                            UtilController.getProgressInPercent(typingText, StreamReaderController.WholeSampleText, false);//считать проценты для прогресса

                            char nextLetterToShow = nextLetter(typingText, sampleText);
                            //writeLetter = true;
                            if (nextLetterToShow.ToString() != "|")
                            {
                                nextLetterClass.getLetter(nextLetterToShow);
                                string message = nextLetterClass.returnLetter;
                                popUpToRightCase(message); // set text to "Подсказки"
                                
                                Bitmap bitmap = new System.Drawing.Bitmap(nextLetterClass.getPicture(nextLetterToShow));//it is in the memory now
                                var bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(bitmap.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
                                image.Source = bitmapSource;


                                this.typingTextTxt.Text.Replace("|", " ");
                            }
                            else if (nextLetterToShow.ToString() == "|" && writeLetter == true)
                            {
                                popUpToClickSpace();
                                this.typingTextTxt.Text.Replace("|", " ");
                            }
                        }
                    }

                    if (typingText.Length == sampleText.Length)
                    {
                        if (getCurrentLetter(typingText.Length, typingText, sampleText))
                        {
                            if (fileLine != wholeText.Length)
                            {
                                if (fileLine <= wholeText.Length - 1)
                                {
                                    this.exampleText.Text = wholeText[fileLine];
                                }

                                this.typingTextTxt.Text = "";
                                fileLine++;
                                fileLength--;
                            }
                            else
                            {
                                this.typingTextTxt.IsReadOnly = true;
                                UtilController.getProgressInPercent(typingText, StreamReaderController.WholeSampleText, true);
                            }
                        }
                        else
                        {
                            this.typingTextTxt.Text = typingText.Substring(0, typingText.Length - 1).Replace("|", " "); // обрезать последнюю букву, если возникла ошибка
                            this.typingTextTxt.Select(typingTextTxt.Text.Length, typingTextTxt.Text.Length); //Поставить курсор на последнее место
                        }
                    }

                } while (fileLength == 0);
            }
            catch (Exception exeption)
            {
                MessageBox.Equals(exeption, exeption);
                // streamReaderController.writeLogs(this.GetType().Name, exeption);
            }
        }

        //**сравнить строку с входящим текстом **/
        //И если текст был введён правильный, вернуть "bool"
        private bool getCurrentLetter(int typingTextLenght, string inputText, string sampleText)
        {
            try
            {
                if (typingTextLenght >= 0)
                {
                    string typingText = inputText;

                    typingTextLenght = typingTextLenght - 1;

                    char[] chartsOfTypingText = typingText.ToCharArray();

                    char[] chartsOfExampleText = sampleText.ToCharArray();

                    char typingLastLetter = chartsOfTypingText[typingTextLenght];

                    char exampleLastLetter = chartsOfExampleText[typingTextLenght];

                    if (typingLastLetter == exampleLastLetter)
                    {
                        correctTextLenght = typingTextLenght+1; 
                        writeLetter = true; 
                        return true;
                    }
                    else
                    {
                        writeLetter = false;
                        return false;
                    }
                }
                else
                {
                    writeLetter = false;
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Equals(e,e);
                if (typingTextLenght == -1)
                {
                    correctTextLenght = typingTextLenght+1;
                    writeLetter = true;
                    return true;
                }
                else
                {
                    //streamReaderController.writeLogs(this.GetType().Name, e);
                    writeLetter = false;
                    return false;
                }
            }
        }

        //*определить следующюю букву по тексту
        //*и вернуть эту букву.
        private char nextLetter(string inputText, string sampleText)
        {
            if (inputText.Substring(0, inputText.Length) == sampleText.Substring(0, inputText.Length))
            {
                if (inputText.Length < sampleText.Length)
                {
                    char[] letter = sampleText.ToArray();
                    char toTypingLetter = letter[inputText.Length];
                    return toTypingLetter;
                }
                else
                {
                    exampleText.Text = streamReaderController.file[1];
                }
            }
            return '*';
        }

        private void previewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                spaceButtonClicked = true;
            }
            else
            {
                spaceButtonClicked = false;
            }
        }

        private void popUpToWrongCase()
        {
           
        }

        private void popUpToRightCase(String message)
        {
            suggestionMessage.Content = message;
        }

        private void popUpToClickSpace()
        {
            suggestionMessage.Content = "Нажмите пробел большим пальцем";
            Bitmap bitmap = new System.Drawing.Bitmap(Properties.Resources.letter_space);//it is in the memory now
            var bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(bitmap.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            image.Source = bitmapSource;
        }
    }
}
