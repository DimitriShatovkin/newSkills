using System.Windows;
using System.Windows.Input;
using System.Windows.Controls.Primitives;
using System;
using NewSkills.ViewModel;
using NewSkills.View;
using System.Windows.Threading;
using NewSkills.Controller;

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
        Second
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindowsCodeBehind
    {
        // Timer Variables
        private DispatcherTimer timer;
        // End of Timer Variables

        public MainWindow()
        {
            InitializeComponent();
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
                UtilController.PauseTime = 10;
            }
            else if (UtilController.WorkTime == 0 && UtilController.PauseTime == 0 && UtilController.ActivateWorkOrPause == true)
            {
                UtilController.WorkTime = 20;
                UtilController.ActivateWorkOrPause = false;
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
            LoadView(ViewType.First);
        }

        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {  
                case ViewType.First:
                    FirstUC viewF = new FirstUC("inputText");
                    FirstViewModel vmF = new FirstViewModel(this);
                    viewF.DataContext = vmF;
                    this.OutputView.Content = viewF;
                    break;
                //case ViewType.Second:
                //    SecondUC viewS = new SecondUC();
                //    SecondViewModel vmS = new SecondViewModel(this);
                //    viewS.DataContext = vmS;
                //    this.OutputView.Content = viewS;
                //    break;
                //    
            }
        }


        private void setTime(int time)
        {
            progress.Content = UtilController.ProgessInPerCent;

            if (time / 60 >= 10 && time % 60 >= 10)
            {
                if (UtilController.ActivateWorkOrPause == false)
                {
                    timerTxt.Content = string.Format("Время печатать 00:{0}:{1}", time / 60, time % 60); // 13: 50
                }
                else
                {
                    timerTxt.Content = string.Format("Пауза 00:{0}:{1}", time / 60, time % 60); // 13: 50
                }
            }
            else if (time / 60 >= 10 && time % 60 < 10)
            {
                if (UtilController.ActivateWorkOrPause == false)
                {
                    timerTxt.Content = string.Format("Время печатать 00:{0}:0{1}", time / 60, time % 60); // 13:05
                }
                else {
                    timerTxt.Content = string.Format("Пауза 00:{0}:0{1}", time / 60, time % 60); // 13:05
                }
            }
            else if (time / 60 <= 10 && time % 60 >= 10)
            {
                if (UtilController.ActivateWorkOrPause == false)
                {
                    timerTxt.Content = string.Format("Время печатать 00:0{0}:{1}", time / 60, time % 60); // 09:59
                }
                else
                {
                    timerTxt.Content = string.Format("Пауза 00:0{0}:{1}", time / 60, time % 60); // 09:59
                }
            }
            else if (time / 60 <= 10 && time % 60 < 10)
            {
                if (UtilController.ActivateWorkOrPause == false)
                {
                    timerTxt.Content = string.Format("Время печатать 00:0{0}:0{1}", time / 60, time % 60); // 11:05
                }
                else {
                    timerTxt.Content = string.Format("Пауза 00:0{0}:0{1}", time / 60, time % 60); // 11:05
                }
            }
        }


        private void Home_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = Home;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Home";
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
            Header.PopupText.Text = "Profile";
        }

        private void Profile_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        private void Settings_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = Settings;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Settings";
        }

        private void Settings_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
