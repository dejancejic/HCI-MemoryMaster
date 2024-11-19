using MemoryMaster.Model;
using MemoryMaster.Utils;
using Microsoft.Win32;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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

namespace MemoryMaster.Pages
{ 
    public partial class UpdateLevelPage : Window
    {

        private LevelModel level;
        private UserScoreModel score;
        private ObservableCollection<LevelModel> levels;
        private ObservableCollection<UserScoreModel> scores;
        private bool modified = false;
        private List<string> images=new List<string>();
        private Dictionary<StackPanel,string> panelString=new Dictionary<StackPanel,string>();
            public UpdateLevelPage(LevelModel level,UserScoreModel score,
                ObservableCollection<LevelModel> levels,ObservableCollection<UserScoreModel> scores)
        {
            InitializeComponent();
            this.level = level;
            this.score = score;
            this.scores = scores;
            this.levels = levels;
            textBox.Text = level.Name;
            foreach (var base64 in level.Base64Images)
            {
                images.Add(base64);
                CreateImagePanel(base64);
            }

            }

            private void UpdateBtnClick(object sender, RoutedEventArgs e)
        {
            if (!textBox.Text.Equals(level.Name))
            { 
                modified = true;
            }

            if (modified == false)
            {
                this.Close();
                return;
            }
            
            level.Base64Images = images;
            level.Name = textBox.Text;
            score.Name= textBox.Text;
            //serializing the file
            try
            {

                string json = JsonSerializer.Serialize(scores);

                IOUtil.WriteData(scores,myLevel:true);
                json = JsonSerializer.Serialize(levels);
                IOUtil.WriteData(levels,myLevel:true);
            }
            catch (Exception)
            {

                MessageBox.Show((string)FindResource("errorWritingFile"), (string)FindResource("errorText"), MessageBoxButton.OK);
                return;
            }

            MessageBox.Show((string)FindResource("updatedLevel"),(string)FindResource("success"),MessageBoxButton.OK,MessageBoxImage.Information);

            this.Close();
        }
        private void LevelNameTextChanged(object sender, TextChangedEventArgs e)
        {
            String text = ((TextBox)sender).Text.ToString();
            if (text.Length > 20)
            {
                string message = (string)FindResource("levelNameTextSize");
                string title = (string)FindResource("errorText");
                MessageBox.Show(message, title, MessageBoxButton.OK);
                textBox.Text = textBox.Text.Substring(0, 20);
                textBox.CaretIndex = textBox.Text.Length;
            }
            
        }
        private void CreateImagePanel(string base64)
        {
            
                StackPanel imagePanel = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    Margin = new Thickness(5)
                };
            panelString[imagePanel] = base64;

                Border imageBorder = new Border
                {
                    Width = 100,
                    Height = 100,
                    CornerRadius=new CornerRadius(10),
                    Background=Brushes.White,
                    BorderBrush = Brushes.White,
                    BorderThickness = new Thickness(1),
                    Margin = new Thickness(5)
                };

                Image imageControl = new Image
                {
                    Width = 80,
                    Height = 80,
                    Stretch = Stretch.Uniform,
                    Margin = new Thickness(10)
                };

                BitmapImage bitmapImage = Base64EncoderDecorder.Base64ToImage(base64);
                imageControl.Source = bitmapImage;

                
                imageBorder.Child = imageControl;

          
                Button deleteButton = new Button
                {
                   
                    Width = 50,
                    Height = 50,
                    Margin = new Thickness(5),
                    Style = (Style)FindResource("DeleteIconButtonStyle")
                };
                deleteButton.Click += (sender, e) => DeleteImage(imagePanel);

                imagePanel.Children.Add(imageBorder);
                imagePanel.Children.Add(deleteButton);

                imagesStackPanel.Children.Add(imagePanel);
            
        }

        private void DeleteImage(StackPanel imagePanel)
        {
            modified = true;
            imagesStackPanel.Children.Remove(imagePanel);
            images.Remove(panelString[imagePanel]);
        }

        private void PickImageBtnClick(object sender, RoutedEventArgs e)
        {
            modified = true;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == true)
            {

                string filePath = openFileDialog.FileName;


                string base64 = Base64EncoderDecorder.ImageToBase64(filePath);
                if (images.Contains(base64))
                {
                    MessageBox.Show((string)FindResource("imageAlreadyExists"), (string)FindResource("errorText"), MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                
                string fileExtension = Path.GetExtension(filePath).ToLower();

                if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png")
                {
                    images.Add(base64);
                    CreateImagePanel(base64);
                }
                else
                {
                    MessageBox.Show((string)FindResource("selectCorrectFileType"), (string)FindResource("errorText"), MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
