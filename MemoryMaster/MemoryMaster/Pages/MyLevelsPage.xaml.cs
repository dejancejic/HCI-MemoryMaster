using MemoryMaster.Model;
using MemoryMaster.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Formats.Asn1.AsnWriter;

namespace MemoryMaster.Pages
{
   
    public partial class MyLevelsPage : Window
    {

        private ObservableCollection<UserScoreModel> scoresList = new ObservableCollection<UserScoreModel>();
        private ObservableCollection<LevelModel> levelsList=new ObservableCollection<LevelModel>();
        private Dictionary<int,LevelModel> modelTagDictionary = new Dictionary<int,LevelModel>();
        public MyLevelsPage()
        {
            InitializeComponent();

            levelsList = IOUtil.ReadLevelData(myLevel:true);
            scoresList = IOUtil.ReadUserData(myLevel: true);

            if(scoresList.Count == 0) {
                return;
            }
            resultLbl.Content = scoresList[0].HighScore;
            timeLeftLbl.Content = scoresList[0].BestTime;
            levelNameLbl.Content = scoresList[0].Name;

            CreateLevelButton();
        }
        private void MainMenuBtnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private int CalculateIndex()
        {
            int tag = (int)selectedButton.Tag;
            return levelsList.IndexOf(modelTagDictionary[tag]);
        }
        private void PlayLevelBtnClick(object sender, RoutedEventArgs e)
        {
            int index = CalculateIndex();
            NavigateNextPage(new LevelPage(levelInfo: levelsList[index],
                scoresList[index],levelsList, scoresList,true));
        }
        private int tagUpdate = 0;
        private void NavigateNextPage(Window window)
        {
            window.Closed += SecondWindow_Closed;
            window.Show(); this.Hide();
            this.Hide();
        }
        private void NavigateUpdatePage(Window window) {

            window.Closed += UpdateWindow_Closed;
            window.Show(); this.Hide();
            this.Hide();
        }
        private void UpdateWindow_Closed(object sender, System.EventArgs e)
        {
            this.Show();
            int index = levelsList.IndexOf(modelTagDictionary[tagUpdate]);
            foreach(var panel in stackPanels)
            { 
                if ((int)panel.Tag == tagUpdate)
                {
                    foreach(var btn in  panel.Children)
                    {
                        if ((int)(btn as Button).Tag == tagUpdate)
                        {
                            Button b = btn as Button;
                            b.Content = scoresList[index].Name;
                            break;
                        }
                    }
                    break;
                }
            }
            levelNameLbl.Content = scoresList[index].Name;

        }
        private void LevelNameTextChanged(object sender, System.EventArgs e) {

            string text = textBox.Text;
            //TODO FILTERING(check when there is more)

            List<StackPanel> toRemove = new List<StackPanel>();
            foreach (var comp in levelsStackPanel.Children)
            {
                if (comp is StackPanel)
                {
                    StackPanel pan = comp as StackPanel;

                    toRemove.Add(pan);
                }
            }
            foreach (var panel in toRemove)
            {
                levelsStackPanel.Children.Remove(panel);
            }
            int i = 0;
            foreach (var level in levelsList) { 
            
                if(level.Name.ToLower().Contains(text.ToLower())) {

                    levelsStackPanel.Children.Add(stackPanels[i]);

                }
                i++;
            }

        }
        private void SecondWindow_Closed(object sender, System.EventArgs e)
        {
            this.Show();
            int index = CalculateIndex();
            
            resultLbl.Content = scoresList[index].HighScore;
            timeLeftLbl.Content = scoresList[index].BestTime;
            levelNameLbl.Content = scoresList[index].Name;
        }

        private Button selectedButton;
        private List<StackPanel> stackPanels=new List<StackPanel>();

        private void CreateLevelButton()
        { 
            int index = 0;
            foreach (var level in levelsList)
            {
                StackPanel buttonPanel = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    Margin = new Thickness(5),
                    Tag=index
                };
                stackPanels.Add(buttonPanel);
                modelTagDictionary[index] = level;

                Button levelButton = new Button
                {
                    Content = level.Name,
                    Width = 140,
                    Height = 30,
                    Tag = index,
                    Margin = new Thickness(5),
                    Style = (Style)FindResource("RoundedButtonStyle")
                };
                
                levelButton.Click += LevelButton_Click;

                if (index == 0)
                {
                    selectedButton = levelButton;
                    levelButton.Style = (Style)FindResource("SelectedButtonStyle");

                }
                Button editButton = new Button
                {
                    Width = 30,
                    Height = 30,
                    Tag = index,
                    Margin = new Thickness(5),
                    Style = (Style)FindResource("EditIconButtonStyle")
                };
                editButton.Click += EditButton_Click;


                Button deleteButton = new Button
                {
                    Width = 30,
                    Height = 30,
                    Tag = index,
                    Margin = new Thickness(5),
                    Style = (Style)FindResource("DeleteIconButtonStyle")
                };
                deleteButton.Click += DeleteButton_Click;

                
                buttonPanel.Children.Add(levelButton);
                buttonPanel.Children.Add(editButton);
                buttonPanel.Children.Add(deleteButton);

                
                levelsStackPanel.Children.Add(buttonPanel);
                index++;
            }
        }

        private void LevelButton_Click(object sender, RoutedEventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (selectedButton != null)
            {
                selectedButton.Style = (Style)FindResource("RoundedButtonStyle");
            }


            clickedButton!.Style = (Style)FindResource("SelectedButtonStyle");
            selectedButton = clickedButton;

         
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            int tag = int.Parse((sender as Button).Tag.ToString());
            int index= levelsList.IndexOf(modelTagDictionary[tag]);
            tagUpdate = tag;
            NavigateUpdatePage(new UpdateLevelPage(levelsList[index], scoresList[index],
                levelsList,scoresList));
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int tag = int.Parse((sender as Button).Tag.ToString());
            
           MessageBoxResult result= MessageBox.Show((string)FindResource("sureToDeleteLevel"),
               (string)FindResource("confirmation"),MessageBoxButton.YesNo,MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                int position = levelsList.IndexOf(modelTagDictionary[tag]);
                levelsList.RemoveAt(position);
                scoresList.RemoveAt(position);
                
                levelsStackPanel.Children.Remove(stackPanels[tag]);

                try
                {
                   IOUtil.WriteData(scoresList, myLevel: true);

                    IOUtil.WriteData(levelsList, myLevel: true);
                }
                catch (Exception)
                {

                    MessageBox.Show((string)FindResource("errorWritingFile"), (string)FindResource("errorText"), MessageBoxButton.OK);
                    return;
                }

            }
        }



    }
}
