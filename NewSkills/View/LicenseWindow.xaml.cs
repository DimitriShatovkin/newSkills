using System.Windows;
using System.Windows.Controls;
using NewSkills.Controller;
using System.Management;
using System.Linq;
using System.Threading.Tasks;


namespace NewSkills.View
{
    /// <summary>
    /// Interaction logic for LicenseWindow.xaml
    /// </summary>
    public partial class LicenseWindow : Window
    {
        private MainWindow mainWindow;
        private string cpuId = "";
        private static string licenseExistence = "LicenseExistence";
        private static string excersiceNumber = "ExcerciseNumber";
        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);


        public static object ManagementObjectServer { get; private set; }

        public LicenseWindow(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            GetCPUId();
        }

        private void licenseCodeOne_ChangeEvent(object sender, TextChangedEventArgs e)
        {
            if (licenseCode1.Text.Length == 5)
            {
                licenseCode2.Focus();
            }
        }

        private void licenseCodeTwo_ChangeEvent(object sender, TextChangedEventArgs e)
        {
            if (licenseCode2.Text.Length == 5)
            {
                licenseCode3.Focus();
            }
        }

        private void licenseCodeThree_ChangeEvent(object sender, TextChangedEventArgs e)
        {
            if (licenseCode3.Text.Length == 5)
            {
                licenseCode4.Focus();
            }
        }

        private void sendRequest_ButtonClick(object sender, RoutedEventArgs e)
        {
 
            string licenseCode = licenseCode1.Text + "-" + licenseCode2.Text + "-" + licenseCode3.Text + "-" + licenseCode4.Text;

            if (checkInternetConnection())
            {
                LicenseServiceController licenseController = new LicenseServiceController();
                int licenseNumber = licenseController.getLincenceRequest(licenseCode);

                var licenceService = new NewSkillsLicenceService.LicenseService();
                object licenseNumberFromServer = licenceService.getLincenseAndCPURequest(licenseCode, cpuId);


                if (licenseNumber == (int)licenseNumberFromServer.GetType().GetProperty(excersiceNumber).GetValue(licenseNumberFromServer, null)
                    && (bool)licenseNumberFromServer.GetType().GetProperty(licenseExistence).GetValue(licenseNumberFromServer, null))
                {
                    this.Hide();
                    mainWindow.LoadView(ViewType.First);

                    Properties.Settings.Default.License = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    messageLabel.Visibility = Visibility.Visible;
                }
            }
            else {
                messageLabel.Content = "Подключитесь к интернету для проверки ключа";
                messageLabel.Visibility = Visibility.Visible;
            }           
        }

        private void GetCPUId()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select ProcessorId from Win32_Processor");
            foreach (ManagementObject mj in searcher.Get())
            {
                cpuId = System.Convert.ToString(mj["ProcessorId"]);
            }
        }

        public static bool checkInternetConnection()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }
    }
}
