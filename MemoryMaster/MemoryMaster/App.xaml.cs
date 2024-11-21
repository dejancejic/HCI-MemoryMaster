using MemoryMaster.Utils;
using System.Configuration;
using System.Data;
using System.Windows;

namespace MemoryMaster
{
    public partial class App : Application
{
        public static int maxImages=12;
        public static int minImages = 2;
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

            

            string? levelsPath = Application.Current.Resources["levelsPath"] as string;
        string? localLevelsPath = Application.Current.Resources["localLevelsPath"] as string;
        string? userDataPath = Application.Current.Resources["userDataPath"] as string;
        string? localUserDataPath = Application.Current.Resources["localUserDataPath"] as string;
        maxImages = int.Parse(Application.Current.Resources["maxImages"] as string);
        minImages = int.Parse(Application.Current.Resources["minImages"] as string);

            IOUtil.LevelsPath = levelsPath!;
        IOUtil.LocalLevelsPath = localLevelsPath!;
        IOUtil.UserDataPath = userDataPath!;
        IOUtil.LocalUserDataPath = localUserDataPath!;
        }
}


}
