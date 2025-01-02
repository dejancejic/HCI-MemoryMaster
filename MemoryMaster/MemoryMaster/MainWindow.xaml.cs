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
using System.Windows.Threading;

namespace MemoryMaster
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            enBtn.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }


        private void StartAnimation()
        {
            loadingLbl.Visibility = Visibility.Visible;
            progressBar.Visibility=Visibility.Visible;
        }
       
        private void StopAnimation()
        {
                loadingLbl.Visibility = Visibility.Hidden;
                progressBar.Visibility = Visibility.Hidden;
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
        private void NavigateNextPage(Window window)
        {
            Overlay.Visibility = Visibility.Visible;
            window.Closed += SecondWindow_Closed;
            window.Show(); this.Hide();
            this.Hide();
            Overlay.Visibility = Visibility.Collapsed;
        }

        private void infoBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigateNextPage(new AppInfoPage());
        }
        private void SecondWindow_Closed(object sender, System.EventArgs e) { 
            this.Show();
        }

        private async void StartGameBtnClick(object sender, RoutedEventArgs e)
        {
            Overlay.Visibility = Visibility.Visible;
            StartAnimation();
            
            await Task.Delay(new Random().Next(500,1500));
            NavigateNextPage(new ChooseLevelPage());
           
            StopAnimation();
            Overlay.Visibility = Visibility.Collapsed;
        }

        private void addLevelBtnClick(object sender, RoutedEventArgs e)
        {
            NavigateNextPage(new AddLevelPage());
        }

        private async void MyLevelsBtnClick(object sender, RoutedEventArgs e)
        {
            Overlay.Visibility = Visibility.Visible;
            StartAnimation();
            await Task.Delay(new Random().Next(500, 1500));
            NavigateNextPage(new MyLevelsPage());
            StopAnimation();
            Overlay.Visibility = Visibility.Collapsed;
        }
    }
}