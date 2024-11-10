using MemoryMaster.Pages;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MemoryMaster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




        private void languageButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender != null)
            {
                SetLanguage(((Button)sender).Tag.ToString());

            }
        }

            private void SetLanguage(string language)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);

            Application.Current.Resources.MergedDictionaries.Clear();
            ResourceDictionary resdict = new ResourceDictionary()
            { 
            Source=new Uri($"Resources/Dictionary-{language}.xaml",UriKind.Relative)
            };

            Application.Current.Resources.MergedDictionaries.Add(resdict);

            enBtn.IsEnabled = true;
            srBtn.IsEnabled = true;

            switch (language) {
                case "en": enBtn.IsEnabled = false;
                    break;
                case "sr":srBtn.IsEnabled = false; 
                    break;
            }

        }

        private void infoBtn_Click(object sender, RoutedEventArgs e)
        {
            AppInfoPage secondWindow = new AppInfoPage(); 
            secondWindow.Closed += SecondWindow_Closed; 
            secondWindow.Show(); this.Hide();
            this.Hide();
        }
        private void SecondWindow_Closed(object sender, System.EventArgs e) { 
            this.Show();
        }
    }
}