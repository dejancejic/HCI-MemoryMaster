using Microsoft.Win32;
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
using System.IO;
using MemoryMaster.Utils;
using MemoryMaster.Model;
namespace MemoryMaster.Pages
{
    public partial class AddLevelPage : Window
    {
        List<string> list = new List<string>();

        public AddLevelPage()
        {
            InitializeComponent();
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

        private void PickImageBtnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == true)
            {

                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);


                if (list.Contains(filePath))
                {
                    MessageBox.Show((string)FindResource("imageAlreadyExists"), (string)FindResource("errorText"), MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                list.Add(filePath);

                string fileExtension = Path.GetExtension(filePath).ToLower();

                if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png")
                {
                    CreateImageRectangle(fileName,filePath);
                }
                else
                {
                    MessageBox.Show((string)FindResource("selectCorrectFileType"), (string) FindResource("errorText"), MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void CreateImageRectangle(string fileName,string filePath)
        {
            Border imageBorder = new Border
            {
                Background = Brushes.Transparent,
                CornerRadius = new CornerRadius(10),
                Margin = new Thickness(5),
                Padding = new Thickness(2),
                Tag = filePath
                
            };

            Grid grid = new Grid();
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            Label imageLabel = new Label
            {
                Content = fileName,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(2) 
            };
            Grid.SetColumn(imageLabel, 0);

            Button removeButton = new Button
            {
                Style = (Style)FindResource("RoundedButtonStyle"),
                Width = 28,
                Height = 28,
                Background = Brushes.Transparent,
                Margin = new Thickness(0, 0, 2, 0) 
            };
            removeButton.Click += (s, e) => RemoveImageRectangle(imageBorder);
            Grid.SetColumn(removeButton, 1);

            Image buttonImage = new Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Resources/deleteIcon.png")),
                Stretch = Stretch.Uniform
            };
            removeButton.Content = buttonImage;

            grid.Children.Add(imageLabel);
            grid.Children.Add(removeButton);

            imageBorder.Child = grid;
            ImagesStackPanel.Children.Add(imageBorder);
        }



        private void RemoveImageRectangle(Border imageBorder)
        {
            list.Remove(imageBorder.Tag.ToString());
            ImagesStackPanel.Children.Remove(imageBorder);
        }

        private void MainMenuBtnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddLevelBtnClick(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length == 0)
            {
                MessageBox.Show((string)FindResource("levelNameEmpty"),(string)FindResource("errorText"),MessageBoxButton.OK);
                return;
            }

            List<string> base64Strings = new List<string>();

            foreach(string s in list) { 
            
                string base64= Base64EncoderDecorder.ImageToBase64(s);
                base64Strings.Add(base64);
            }
            int id = 0;
            //TODO read the file for users levels!

            LevelModel model = new LevelModel(id,textBox.Text,base64Strings);

            MessageBox.Show((string)FindResource("levelAdded"), (string)FindResource("errorText"), MessageBoxButton.OK);
            this.Close();
        }
    }     
}
