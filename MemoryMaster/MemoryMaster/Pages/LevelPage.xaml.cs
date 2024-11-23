using MemoryMaster.Model;
using MemoryMaster.Utils;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
using System.Windows.Threading;

namespace MemoryMaster.Pages
{
    public partial class LevelPage
    {
       private static double correctFactor = 2.5;
        private static double incorrectFactor = 0.5;
        private static int baseScoreIncrement = 1000;

        private LevelModel levelInfo;
        private UserScoreModel scores;
        private DispatcherTimer uiTimer;
        private Stopwatch stopwatch;
        private bool isRunning;
        private bool myLevel;
        private int score=0;
        private ObservableCollection<UserScoreModel> scoresList;
        private ObservableCollection<LevelModel> levelsList;
        private bool started = false;
        private int idCard = 0;
        Dictionary<int, int> TAGS = new Dictionary<int, int>();
        Dictionary<int, bool> TAGS_OPENED = new Dictionary<int, bool>();
        private int countCorrect = 0;
        private int countIncorrect = 0;

        //if coordinates are taken the value will be true!
        private  Dictionary<string, bool> COORDINATES = new Dictionary<string, bool> {
            {"30,20",false},
            {"170,20",false},
            {"310,20",false},
            {"450,20",false},
            {"590,20",false},
            {"730,20",false},
            {"870,20",false},
            {"1010,20",false},

            {"30,235",false},
            {"170,235",false},
            {"310,235",false},
            {"450,235",false},
            {"590,235",false},
            {"730,235",false},
            {"870,235",false},
            {"1010,235",false},

            {"30,450",false},
            {"170,450",false},
            {"310,450",false},
            {"450,450",false},
            {"590,450",false},
            {"730,450",false},
            {"870,450",false},
            {"1010,450",false},
        };
        private static List<string> COORDINATES_STRINGS = new List<string> {
            "30,20",
            "170,20",
            "310,20",
            "450,20",
            "590,20",
            "730,20",
            "870,20",
            "1010,20",

            "30,235",
            "170,235",
            "310,235",
            "450,235",
            "590,235",
            "730,235",
            "870,235",
            "1010,235",

            "30,450",
            "170,450",
            "310,450",
            "450,450",
            "590,450",
            "730,450",
            "870,450",
            "1010,450",
        };


        public LevelPage(LevelModel levelInfo, UserScoreModel scores,ObservableCollection<LevelModel> levelsList,
            ObservableCollection<UserScoreModel>scoresList,bool myLevel=false)
        {
            InitializeComponent();
            this.levelInfo = levelInfo;
            this.scores = scores;
            this.myLevel= myLevel;
            this.scoresList = scoresList;
            this.levelsList = levelsList;
            this.Title = "MemoryMaster - " + scores.Name;

            stopwatch = new Stopwatch();
            uiTimer = new DispatcherTimer();
            uiTimer.Interval = TimeSpan.FromMilliseconds(100);
            uiTimer.Tick += UiTimer_Tick;

            CreateImagePanel();
            
        }

        private void UiTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = stopwatch.Elapsed;

            int minutes = elapsed.Minutes;
            int seconds = elapsed.Seconds;
            int millis = elapsed.Milliseconds / 10;

            string minutesString = minutes < 10 ? "0" + minutes : "" + minutes;
            string secondsString = seconds < 10 ? "0" + seconds : "" + seconds;
            string millisString = millis < 10 ? "0" + millis : "" + millis;

            timeLbl.Content = $"{minutesString}:{secondsString},{millisString}";
        }

        private async void StartBackgroundTimer()
        {
            await Task.Run(() =>
            {
                while (isRunning)
                {
                    System.Threading.Thread.Sleep(100);
                }
            });
        }

        public void StopBackgroundTimer()
        {
            isRunning = false;
            stopwatch.Stop();
            uiTimer.Stop();
        }
        

        private void CreateImagePanel()
        {
            Random random = new Random();
            int position = 0;
            for (int i = 0; i < 2; i++)
            {
                position = 0;
                foreach (string base64 in levelInfo.Base64Images)
                {
                    Border imageCard = new Border
                    {
                        Background = Brushes.White,
                        CornerRadius = new CornerRadius(10),
                        Width = 100,
                        Height = 200,
                        Tag = idCard,
                            BorderBrush = Brushes.Gray,
                            BorderThickness = new Thickness(1)
                        };

                    TAGS[idCard] = position;
                    position++;
                    TAGS_OPENED[idCard] = false;
                   
                    idCard++;
                    imageCard.MouseLeftButtonUp += CardClickedEvent;



                    Image imageControl = new Image
                        {
                            Width = 80,
                            Height = 180,
                            Stretch = Stretch.Uniform,
                            Margin = new Thickness(10)
                        };

                        BitmapImage bitmapImage = 
                        new BitmapImage(new Uri("pack://application:,,,/Resources/logoIcon.png"));
                    
                    imageControl.Source = bitmapImage;

                   
                        imageCard.Child = imageControl;

                    bool variable = false;
                    int number = 0;
                    do
                    {
                        number = random.Next(0, 24);
                        COORDINATES.TryGetValue(COORDINATES_STRINGS[number], out variable);


                    } while (variable);

                    COORDINATES[COORDINATES_STRINGS[number]] = true;
                    string[] split = COORDINATES_STRINGS[number].Split(',');

                        double left=int.Parse(split[0]);
                        double top = int.Parse(split[1]);

                
                        Canvas.SetLeft(imageCard, left);
                        Canvas.SetTop(imageCard, top);

                 
                        MainCanvas.Children.Add(imageCard);
             
                    }
                }
            }
        private List<Border> OPENED_CARDS = new List<Border>();
        private void CardClickedEvent(object sender, EventArgs e)
        {
            if (started == false)
            {
                return;
            }
            Border border = sender as Border;
            int tag = (int)border.Tag;
            if (TAGS_OPENED[tag] == true)
            {
                return;
            }
            if (OPENED_CARDS.Contains(border))
            {
                return;
            }
            if (OPENED_CARDS.Count <2)
            {
                OPENED_CARDS.Add(border);
            }
            
            Image imageControl = border.Child as Image;
            
            int index = TAGS[tag];
            TAGS_OPENED[tag] = true;
           
            BitmapImage bitmapImage = Base64EncoderDecorder.Base64ToImage(levelInfo.Base64Images[index]);

            imageControl.Source = bitmapImage;
            border.Child = imageControl;

            if (OPENED_CARDS.Count == 2)
            {
                int tag1 = (int)OPENED_CARDS[0].Tag;
                int tag2 = (int)OPENED_CARDS[1].Tag;

                int index1 = TAGS[tag1];
                int index2 = TAGS[tag2];
                if (index1 == index2)
                {
                    //Game score logic(based on time, less time means better result,
                    //and on correct and incorrect guesses difference)
                    TimeSpan elapsed = stopwatch.Elapsed;
                    int millis = elapsed.Milliseconds;

                    

                    double timeFactor = 1.0 / (elapsed.TotalSeconds + 1);

                    
                    int scoreIncrement =
                        (int)(baseScoreIncrement * timeFactor * 
                        (countCorrect * correctFactor - countIncorrect * incorrectFactor));
                    if (scoreIncrement < 0)
                        scoreIncrement = 0;

                    score += scoreIncrement;
                    
                    countCorrect++;
                    countIncorrect = 0;
                }
                else
                {
                    TAGS_OPENED[tag1] = false;
                    TAGS_OPENED[tag2] = false;

                    BitmapImage bitmapImage1 =
                      new BitmapImage(new Uri("pack://application:,,,/Resources/logoIcon.png"));
                    BitmapImage bitmapImage2 =
                      new BitmapImage(new Uri("pack://application:,,,/Resources/logoIcon.png"));
                    //closing both images
                    Image imageControl1= OPENED_CARDS[0].Child as Image;
                    Image imageControl2 = OPENED_CARDS[1].Child as Image;

                    imageControl1.Source = bitmapImage1;
                    imageControl2.Source = bitmapImage2;

                    OPENED_CARDS[0].Child = imageControl1;
                    OPENED_CARDS[1].Child = imageControl2;
                    
                    //incrementing incorrect guesses
                    countIncorrect++;

                }
                OPENED_CARDS.Clear();
            }



            scoreLbl.Content = score;
            if (countCorrect == levelInfo.Base64Images.Count)
            {
                StopBackgroundTimer();

              
                NavigateNextPage(new ScorePage(scores, score, timeLbl.Content.ToString()));

                
                if(score>=scores.HighScore)
                {
                    scores.HighScore = score;
                    scores.BestTime = timeLbl.Content.ToString();
                    //writing results to files

                    try
                    {

                        IOUtil.WriteData(levelsList, myLevel: myLevel);
                        IOUtil.WriteData(scoresList,myLevel: myLevel);
                        
                    }
                    catch (Exception)
                    {

                        MessageBox.Show((string)FindResource("errorWritingFile"), (string)FindResource("errorText"), MessageBoxButton.OK);
                        return;
                    }


                }
                
            }

        }
        private void NavigateNextPage(Window window)
        {
            window.Closed += SecondWindow_Closed;
            window.Show(); 
           
        }
        private void SecondWindow_Closed(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private Border? FindBorderByTag(Canvas canvas, object desiredTag)
        {
            foreach (var child in canvas.Children)
            {
                if (child is Border border && border.Tag != null && border.Tag.Equals(desiredTag))
                {
                    return border;
                }
            }
            return null; 
        }

        private void StartGameBtnClicked(object sender, RoutedEventArgs e)
        {
                started = true;

            Button b = sender as Button;

            b.IsEnabled = false;

            stopwatch.Start();
            uiTimer.Start();

            isRunning = true;
            StartBackgroundTimer();

        }
    }
}
