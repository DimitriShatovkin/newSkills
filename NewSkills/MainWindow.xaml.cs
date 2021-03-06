﻿using System.Windows;
using System.Windows.Input;
using System.Windows.Controls.Primitives;
using System;
using NewSkills.ViewModel;
using NewSkills.View;
using System.Windows.Threading;
using NewSkills.Controller;
using System.Windows.Media;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace NewSkills
{
    public interface IMainWindowsCodeBehind
    {
        /// <summary>
        /// Показ сообщения для пользователя
        /// </summary>
        /// <param name="message">текст сообщения</param>
        void ShowMessage(string message);

        /// <summary>
        /// Загрузка нужной View
        /// </summary>
        /// <param name="view">экземпляр UserControl</param>
        void LoadView(ViewType typeView);
    }

    /// <summary>
    /// Типы вьюшек для загрузки
    /// </summary>
    public enum ViewType
    {
        Main,
        First,
        Settings,
        LicenseView,
        CongratulationView
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindowsCodeBehind
    {
        // Timer Variables
        private DispatcherTimer timer;
        private int workTime = 1500;
        private bool soundOn = false;
        // End of Timer Variables

        public MainWindow()
        {
            InitializeComponent();
            checkSoundContent();
            this.Height = (System.Windows.SystemParameters.PrimaryScreenHeight);
            this.Width = (System.Windows.SystemParameters.PrimaryScreenWidth);
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
            this.Loaded += MainWindow_Loaded;

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        // ежесекундый запуск метода, для таймера
        // тут высчитывается, должна ли работать пауза или печать
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (UtilController.BlockTextFieldAndTimer == false)
            {
                if (UtilController.WorkTime > 0)
                {
                    UtilController.ActivateWorkOrPause = false;
                    UtilController.WorkTime--;
                    setTime(UtilController.WorkTime);
                }
                else if (UtilController.PauseTime > 0)
                {
                    UtilController.ActivateWorkOrPause = true;
                    UtilController.PauseTime--;
                    setTime(UtilController.PauseTime);
                }

                if (UtilController.WorkTime == 0 && UtilController.PauseTime == 0 && UtilController.ActivateWorkOrPause == false)
                {
                    UtilController.ActivateWorkOrPause = true;
                    UtilController.PauseTime = UtilController.AfterPauseTime;
                }
                else if (UtilController.WorkTime == 0 && UtilController.PauseTime == 0 && UtilController.ActivateWorkOrPause == true)
                {
                    UtilController.WorkTime = UtilController.AfterWorkTime;
                    UtilController.ActivateWorkOrPause = false;
                }
            }
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //загрузка вьюмодел для кнопок меню
            MenuViewModel vm = new MenuViewModel();
            //даем доступ к этому кодбихайнд
            vm.CodeBehind = this;
            //делаем эту вьюмодел контекстом данных
            this.DataContext = vm;

            //загрузка стартовой View
            if (Properties.Settings.Default.License == false)
            {
                LoadView(ViewType.LicenseView);
            }
            else
            {
                LoadView(ViewType.First);
            }
        }

        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.First:
                    menuVisibility(Visibility.Visible);
                    timeReset(Visibility.Visible);
                    FirstUC viewF = new FirstUC("inputText", progress, this);
                    FirstViewModel vmF = new FirstViewModel(this);
                    viewF.DataContext = vmF;
                    this.OutputView.Content = viewF;
                    break;
                case ViewType.Settings:
                    SettingsView viewS = new SettingsView();
                    SecondViewModel vmS = new SecondViewModel(this);
                    // viewS.DataContext = vmS;
                    this.OutputView.Content = viewS;
                    break;
                case ViewType.LicenseView:
                    menuVisibility(Visibility.Hidden);
                    timeReset(Visibility.Hidden);
                    LicenseWindow lw = new LicenseWindow(this);
                    lw.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    lw.Owner = Application.Current.MainWindow;
                    lw.Show();
                    break;
                case ViewType.CongratulationView:
                    CongratulationWindow congratulationWindow = new CongratulationWindow(this);
                    congratulationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    congratulationWindow.Owner = Application.Current.MainWindow;
                    congratulationWindow.Show();
                    congratulationWindow.loadVideo();

                    //Place it in the directory of your application


                    break;

            }
        }

        public void setTime(int time)
        {
            progress.Content = UtilController.ProgessInPerCent;

            if (time / 60 >= 10 && time % 60 >= 10)
            {
                if (UtilController.ActivateWorkOrPause == false)
                {
                    pauseLbl.Visibility = Visibility.Collapsed;
                    timerTxt.Content = string.Format("Время печатать 00:{0}:{1}", time / 60, time % 60); // 13: 50
                }
                else
                {
                    UtilController.showPause(pauseLbl, time);
                    timerTxt.Content = string.Format("Пауза 00:{0}:{1}", time / 60, time % 60); // 13: 50
                }
            }
            else if (time / 60 >= 10 && time % 60 < 10)
            {
                if (UtilController.ActivateWorkOrPause == false)
                {
                    pauseLbl.Visibility = Visibility.Collapsed;
                    timerTxt.Content = string.Format("Время печатать 00:{0}:0{1}", time / 60, time % 60); // 13:05
                }
                else
                {
                    UtilController.showPause(pauseLbl, time);
                    timerTxt.Content = string.Format("Пауза 00:{0}:0{1}", time / 60, time % 60); // 13:05
                }
            }
            else if (time / 60 <= 10 && time % 60 >= 10)
            {
                if (UtilController.ActivateWorkOrPause == false)
                {
                    pauseLbl.Visibility = Visibility.Collapsed;
                    timerTxt.Content = string.Format("Время печатать 00:0{0}:{1}", time / 60, time % 60); // 09:59
                }
                else
                {
                    UtilController.showPause(pauseLbl, time);
                    timerTxt.Content = string.Format("Пауза 00:0{0}:{1}", time / 60, time % 60); // 09:59
                }
            }
            else if (time / 60 <= 10 && time % 60 < 10)
            {
                if (UtilController.ActivateWorkOrPause == false)
                {
                    pauseLbl.Visibility = Visibility.Collapsed;
                    timerTxt.Content = string.Format("Время печатать 00:0{0}:0{1}", time / 60, time % 60); // 11:05
                }
                else
                {
                    UtilController.showPause(pauseLbl, time);
                    timerTxt.Content = string.Format("Пауза 00:0{0}:0{1}", time / 60, time % 60); // 11:05
                }
            }
        }


        private void Home_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = Home;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Печать";
        }

        private void Home_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        private void Profile_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = Profile;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Профиль";
        }

        private void Profile_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        private void Settings_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            FirstUC viewF = new FirstUC("inputText", progress, this);
            FirstViewModel vmF = new FirstViewModel(this);
            viewF.DataContext = vmF;
            this.OutputView.Content = viewF;
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            SettingsView viewS = new SettingsView();
            SecondViewModel vmS = new SecondViewModel(this);
            // viewS.DataContext = vmS;
            this.OutputView.Content = viewS;
        }

        private void Settings_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = Settings;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Настройки";
        }

        // 0 - visible; 1 - hidden; 2 - collapsed
        private void menuVisibility(Visibility Visibility)
        {
            Home.Visibility = Visibility;
            Profile.Visibility = Visibility;
            Settings.Visibility = Visibility;
        }

        private void timeReset(Visibility visibility)
        {
            if (visibility == Visibility.Hidden)
            {
                timerTxt.Visibility = Visibility.Hidden;
            }
            else
            {
                UtilController.WorkTime = workTime;
                timerTxt.Visibility = Visibility.Visible;
            }
        }

        private void soundButton_Click(object sender, RoutedEventArgs e)
        {
            checkSoundContent();
        }


        private void setSoundImageContent(string soundOnUri,bool soundResourceSetting)
        {
            soundButton.Content = new System.Windows.Controls.Image{Source = new BitmapImage(new Uri("pack://application:,,,/Resources/"+ soundOnUri + ".png")),VerticalAlignment = VerticalAlignment.Center};
            soundOn = soundResourceSetting;
            Properties.Settings.Default.SoundOn = soundResourceSetting;
            Properties.Settings.Default.Save();
        }

        private void checkSoundContent() {

            if (soundOn == false)
            {
                setSoundImageContent("soundOn", true);
            }
            else
            {
                setSoundImageContent("soundOff", false);
            }
        }
    }
}
