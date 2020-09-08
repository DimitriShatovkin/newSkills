using NewSkills.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NewSkills.View
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();
            successImage.Visibility = Visibility.Collapsed;
        }

        private void saveSettings_Click(object sender, RoutedEventArgs e)
        {
            int selectedComboBoxValue = styleComboBox.SelectedIndex;

            Properties.Settings.Default.FontVariant = selectedComboBoxValue;
            Properties.Settings.Default.Save();
            successImage.Visibility = Visibility.Visible;
            
        }

        private void styleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (successImage != null) {
                successImage.Visibility = Visibility.Collapsed;
            }
        }

        private void styleComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            styleComboBox.SelectedIndex = Properties.Settings.Default.FontVariant;
        }
    }
}
