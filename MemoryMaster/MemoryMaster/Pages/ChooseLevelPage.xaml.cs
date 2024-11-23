using MemoryMaster.Model;
using MemoryMaster.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
  
    public partial class ChooseLevelPage : Window,INotifyPropertyChanged
    {

       private  ObservableCollection<LevelModel> levels = new ObservableCollection<LevelModel>();
        private ObservableCollection<UserScoreModel> userScores = new ObservableCollection<UserScoreModel>();
        int selectedLevelIndex=0;
        private static Button? buttonClicked;
        public ObservableCollection<UserScoreModel> UserScores {
            get { return userScores; } 
            set { userScores = value;
                
                OnPropertyChanged(nameof(UserScores));
            }
        }

        public ChooseLevelPage()
        {

            InitializeComponent();

            buttonClicked = Level1Btn;
            DataContext = this;
            levels = IOUtil.ReadLevelData(myLevel:false);
            userScores = IOUtil.ReadUserData(myLevel:false);


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

            Button[] buttons = { Level1Btn, Level2Btn, Level3Btn, Level4Btn, Level5Btn, Level6Btn, Level7Btn, Level8Btn }; 
            foreach (Button btn in buttons){
                btn.Style = (Style)FindResource("RoundedButtonStyle");
            }
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
            OnPropertyChanged(nameof(UserScores));
            showLevelInfoBtnClick(buttonClicked, new RoutedEventArgs());
        }

        public event PropertyChangedEventHandler PropertyChanged; 
        protected void OnPropertyChanged(string propertyName) 
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); 
        }
    }
}
