using MemoryMaster.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace MemoryMaster.Utils
{
    public static class IOUtil
    {

        private static string levelsPath = "";
        private static string localLevelsPath = "";
        private static string userDataPath = "";
        private static string localUserDataPath = "";


        public static string LevelsPath {set { levelsPath = value; } }
        public static string LocalLevelsPath { set { localLevelsPath = value; } }
        public static string UserDataPath { set { userDataPath = value; } }
        public static string LocalUserDataPath { set { localUserDataPath = value; } }

        private static T ReadData<T>(string path)
        {
            string jsonString = File.ReadAllText(path);
            T data = JsonSerializer.Deserialize<T>(jsonString)!;
            return data;
        }

        public static ObservableCollection<LevelModel> ReadLevelData(bool myLevel)
        {
            string path = myLevel ? localLevelsPath : levelsPath;
            return ReadData<ObservableCollection<LevelModel>>(path);
        }

        public static ObservableCollection<UserScoreModel> ReadUserData(bool myLevel)
        {
            string path = myLevel ? localUserDataPath : userDataPath;
            return ReadData<ObservableCollection<UserScoreModel>>(path);
        }

        public static void WriteData<T>(ObservableCollection<T> list,bool myLevel)
        {
            
            string path="";
            if (typeof(T)==typeof(LevelModel))
            path = myLevel ? localLevelsPath : levelsPath;
            else
                path = myLevel ? localUserDataPath : userDataPath;


            string json= JsonSerializer.Serialize(list);
            File.WriteAllText(path,json);
        }


    }
}
