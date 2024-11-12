using MemoryMaster.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MemoryMaster.Pages
{
  
    public partial class ChooseLevelPage : Window
    {

       private  List<LevelModel> levels = new List<LevelModel>();
        private List<UserScoreModel> userScores = new List<UserScoreModel>();
        int selectedLevelIndex=0;
        private static Button? buttonClicked;
        public ChooseLevelPage()
        {
            InitializeComponent();
            buttonClicked = Level1Btn;

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.Parent.FullName;
            string filePath = Path.Combine(projectDirectory, "Resources", "Data");
            levels = AddLevelPage.ReadLevelData(filePath+"\\Levels.txt");
            userScores = AddLevelPage.ReadUserData(filePath+"\\UserData.txt");


            resultLbl.Content = userScores[0].HighScore;
            timeLeftLbl.Content = userScores[0].BestTime;
            levelNameLbl.Content = userScores[0].Name;
        }

        private void showLevelInfoBtnClick(object sender, RoutedEventArgs e)
        {
            String text = ((Button)sender).Content.ToString();
            int index = int.Parse(((Button)sender).Tag.ToString())-1;
            if (index >= levels.Count)
            {
                return;
            }
            levelLbl.Content= text;
            resultLbl.Content = userScores[index].HighScore;
            timeLeftLbl.Content = userScores[index].BestTime;
            levelNameLbl.Content = userScores[index].Name;
            selectedLevelIndex = index;

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

            buttonClicked = clickedButton;

        }

        private void MainMenuBtnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PlayLevelBtnClick(object sender, RoutedEventArgs e)
        {
            if (selectedLevelIndex >=levels.Count)
            {
                return;
            }
            NavigateNextPage(new LevelPage(levelInfo: levels[selectedLevelIndex], 
                userScores[selectedLevelIndex],levels,userScores));
        }
        private void NavigateNextPage(Window window)
        {
            window.Closed += SecondWindow_Closed;
            window.Show(); this.Hide();
            this.Hide();
        }
        private void SecondWindow_Closed(object sender, System.EventArgs e)
        {
            this.Show();
            showLevelInfoBtnClick(buttonClicked, new RoutedEventArgs());
        }
    }
}
