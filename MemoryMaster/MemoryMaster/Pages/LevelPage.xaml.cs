using MemoryMaster.Model;
using MemoryMaster.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace MemoryMaster.Pages
{
    public partial class LevelPage
    {
        private LevelModel levelInfo;
        private UserScoreModel scores;
        private DispatcherTimer uiTimer;
        private Stopwatch stopwatch;
        private bool isRunning;
        
        //if coordinates are taken the value will be true!
         Dictionary<string, bool> COORDINATES = new Dictionary<string, bool> {
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
        static List<string> COORDINATES_STRINGS = new List<string> {
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


        public LevelPage(LevelModel levelInfo, UserScoreModel scores)
        {
            InitializeComponent();
            this.levelInfo = levelInfo;
            this.scores = scores;
            this.Title = "MemoryMaster - " + scores.Name;

            stopwatch = new Stopwatch();
            uiTimer = new DispatcherTimer();
            uiTimer.Interval = TimeSpan.FromMilliseconds(100);
            uiTimer.Tick += UiTimer_Tick;
            stopwatch.Start();
            uiTimer.Start();

            isRunning = true;
            CreateImagePanel();
            StartBackgroundTimer();
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

                foreach (string base64 in levelInfo.Base64Images)
                {
                    for (int i = 0; i < 2; i++)
                    {

                        Border imageCard = new Border
                        {
                            Background = Brushes.White,
                            CornerRadius = new CornerRadius(10),
                            Width = 100,
                            Height = 200,
                            BorderBrush = Brushes.Gray,
                            BorderThickness = new Thickness(1)
                        };

                     
                        Image imageControl = new Image
                        {
                            Width = 80,
                            Height = 180,
                            Stretch = Stretch.Uniform,
                            Margin = new Thickness(10)
                        };

                        //BitmapImage bitmapImage = Base64EncoderDecorder.Base64ToImage(base64);
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
            





        }
}
