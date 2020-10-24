﻿using NewSkills.Controller;
using NewSkills.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace NewSkills.View
{
    /// <summary>
    /// Interaction logic for StartConditionView.xaml
    /// </summary>
    public partial class StartConditionView : Window
    {
        bool btn1Bool = false;
        bool btn2Bool = false;
        bool btn3Bool = false;
        bool btn4Bool = false;
        bool btn5Bool = false;
        bool btn6Bool = false;
        bool btn7Bool = false;
        bool btn8Bool = false;
        bool btn9Bool = false;

        bool btn1Controll = false;
        bool btn2Controll = false;
        bool btn3Controll = false;
        bool btn4Controll = false;
        bool btn5Controll = false;
        bool btn6Controll = false;
        bool btn7Controll = false;
        bool btn8Controll = false;
        bool btn9Controll = false;

        Label progress;
        MainWindow mainWindow;

        public StartConditionView(Label progress, MainWindow mainWindow)
        {
            InitializeComponent();
            this.progress = progress;
            this.mainWindow = mainWindow;
            BtnForward.IsEnabled = false;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (btn1Bool == true)
            {
                btn1Bool = false;
                btn1Controll = true;
            }
            else
            {
                btn1Bool = true;
                btn1Controll = false;
            }
            checkSoundContent(btn1, btn1Bool);
            makeButtonActive();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {

            if (btn2Bool == true)
            {
                btn2Bool = false;
                btn2Controll = true;
            }
            else
            {
                btn2Bool = true;
                btn2Controll = false;
            }
            checkSoundContent(btn2, btn2Bool);
            makeButtonActive();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {

            if (btn3Bool == true)
            {
                btn3Bool = false;
                btn3Controll = true;
            }
            else
            {
                btn3Bool = true;
                btn3Controll = false;
            }
            checkSoundContent(btn3, btn3Bool);
            makeButtonActive();
        }



        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (btn4Bool == true)
            {
                btn4Bool = false;
                btn4Controll = true;
            }
            else
            {
                btn4Bool = true;
                btn4Controll = false;
            }
            checkSoundContent(btn4, btn4Bool);
            makeButtonActive();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (btn5Bool == true)
            {
                btn5Bool = false;
                btn5Controll = true;
            }
            else
            {
                btn5Bool = true;
                btn5Controll = false;
            }
            checkSoundContent(btn5, btn5Bool);
            makeButtonActive();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (btn6Bool == true)
            {
                btn6Bool = false;
                btn6Controll = true;
            }
            else
            {
                btn6Bool = true;
                btn6Controll = false;
            }
            checkSoundContent(btn6, btn6Bool);
            makeButtonActive();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (btn7Bool == true)
            {
                btn7Bool = false;
                btn7Controll = true;
            }
            else
            {
                btn7Bool = true;
                btn7Controll = false;
            }
            checkSoundContent(btn7, btn7Bool);
            makeButtonActive();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (btn8Bool == true)
            {
                btn8Bool = false;
                btn8Controll = true;
            }
            else
            {
                btn8Bool = true;
                btn8Controll = false;
            }
            checkSoundContent(btn8, btn8Bool);
            makeButtonActive();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (btn9Bool == true)
            {
                btn9Bool = false;
                btn9Controll = true;
            }
            else
            {
                btn9Bool = true;
                btn9Controll = false;
            }
            checkSoundContent(btn9, btn9Bool);
            makeButtonActive();
        }

        private void BtnForward_Click(object sender, RoutedEventArgs e)
        {

            if (btn1Controll == true && btn2Controll == true && btn3Controll == true && btn4Controll == true &&
                btn5Controll == true && btn6Controll == true && btn7Controll == true && btn8Controll == true &&
                btn9Controll == true)
            {
                UtilController.WorkTime = UtilController.StartWorkTime;
                //this.Close();
                FirstUC viewF = new FirstUC("inputText", progress, mainWindow);
                FirstViewModel vmF = new FirstViewModel(mainWindow);
                viewF.DataContext = vmF;
                mainWindow.OutputView.Content = viewF;
                mainWindow.timerTxt.Visibility = Visibility.Visible;
                mainWindow.Home.Visibility = Visibility.Visible;
                mainWindow.Settings.Visibility = Visibility.Visible;
                mainWindow.CommonTime = 0;

            }
        }


        private void setSoundImageContent(Button button, string imageName)
        {
            button.Content = new System.Windows.Controls.Image { Source = new BitmapImage(new Uri("pack://application:,,,/Resources/" + imageName + ".png")), VerticalAlignment = VerticalAlignment.Center };
        }

        private void checkSoundContent(Button button, bool buttonActive)
        {

            if (buttonActive == false)
            {
                setSoundImageContent(button, "checkBoxActive");
            }
            else
            {
                setSoundImageContent(button, "checkBoxInActive");
            }
        }

        public void makeButtonActive()
        {
            if (btn1Controll == true && btn2Controll == true && btn3Controll == true && btn4Controll == true &&
                    btn5Controll == true && btn6Controll == true && btn7Controll == true && btn8Controll == true &&
                    btn9Controll == true)
            {
                BtnForward.IsEnabled = true;
            }
            else {
                BtnForward.IsEnabled = false;
            }
        }
    }
}

