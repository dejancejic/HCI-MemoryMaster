using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MemoryMaster.Model
{
    public class UserScoreModel: INotifyPropertyChanged
    {
        
        private double _highScore;
        private string _bestTime;
        private string _name;

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get { return _name; }
            set
            {
                _name = value; OnPropertyChanged(nameof(Name));
            }
        }

        [JsonPropertyName("bestTime")]
        public string BestTime  { get { return _bestTime; } 
            
            set { _bestTime = value; OnPropertyChanged(nameof(BestTime));
            }
        }

        [JsonPropertyName("highScore")]
        public double HighScore {
            get { return _highScore; }

            set { _highScore = value;
                OnPropertyChanged(nameof(HighScore)); } }

        public UserScoreModel()
        {
            Id = 0;
            Name = "";
            BestTime = "";
            HighScore = 0.0;
        }
        public UserScoreModel(int id, string name, string bestTime,double highScore)
        {
            Id = id;
            Name = name;
            BestTime = bestTime;
            HighScore = highScore;
        }

        public override bool Equals(object? obj)
        {
            return obj is UserScoreModel model &&
                   Id == model.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); 
        }
    }
}
