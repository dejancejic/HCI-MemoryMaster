using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MemoryMaster.Model
{
    public class LevelModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("base64Images")]
        public List<string> Base64Images { get; set; }

        public LevelModel()
        {
            Id = 0;
            Name = "";
            Base64Images = new List<string>();
        }

        public LevelModel(int id, string name, List<string> base64Images)
        {
            Id = id;
            Name = name;
            Base64Images = base64Images;
        }

        public override bool Equals(object? obj)
        {
            return obj is LevelModel model &&
                   Id == model.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
