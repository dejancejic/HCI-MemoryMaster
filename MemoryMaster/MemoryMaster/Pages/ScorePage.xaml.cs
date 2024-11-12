using MemoryMaster.Model;
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
   
    public partial class ScorePage : Window
    {
        
        public ScorePage(UserScoreModel scoreModel,int score,string time)
        {
            InitializeComponent();
            this.levelName.Content = scoreModel.Name;
            this.resultPrevious.Content = scoreModel.HighScore;
            this.resultPreviousTime.Content = scoreModel.BestTime;
            this.resultScore.Content = score;
            this.resultTime.Content = time; 

            
        }
    }
}
