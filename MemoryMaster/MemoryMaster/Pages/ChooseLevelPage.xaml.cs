using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MemoryMaster.Pages
{
    /// <summary>
    /// Interaction logic for ChooseLevelPage.xaml
    /// </summary>
    public partial class ChooseLevelPage : Window
    {
        public ChooseLevelPage()
        {
            InitializeComponent();
        }

        private void showLevelInfoBtnClick(object sender, RoutedEventArgs e)
        {
            String text = ((Button)sender).Content.ToString();
            
            levelLbl.Content= text;

            Button clickedButton = sender as Button; 
            
             Level1Btn.Style = (Style)FindResource("RoundedButtonStyle"); 
            Level2Btn.Style = (Style)FindResource("RoundedButtonStyle");
            Level3Btn.Style = (Style)FindResource("RoundedButtonStyle");
            Level4Btn.Style = (Style)FindResource("RoundedButtonStyle");
            Level5Btn.Style = (Style)FindResource("RoundedButtonStyle");
            Level6Btn.Style = (Style)FindResource("RoundedButtonStyle"); 
            Level7Btn.Style = (Style)FindResource("RoundedButtonStyle");
            Level8Btn.Style = (Style)FindResource("RoundedButtonStyle");
            clickedButton.Style = (Style)FindResource("SelectedButtonStyle");



        }

        private void MainMenuBtnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void playLevelBtnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
