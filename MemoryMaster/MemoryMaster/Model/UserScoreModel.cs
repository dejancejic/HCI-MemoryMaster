using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MemoryMaster.Model
{
    public class UserScoreModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("bestTime")]
        public string BestTime  { get; set; }

        [JsonPropertyName("highScore")]
        public double HighScore { get; set; }

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


    }
}
