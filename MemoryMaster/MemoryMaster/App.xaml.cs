using MemoryMaster.Utils;
using System.Configuration;
using System.Data;
using System.Windows;

namespace MemoryMaster
{
    public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

            

            string? levelsPath = Application.Current.Resources["levelsPath"] as string;
        string? localLevelsPath = Application.Current.Resources["localLevelsPath"] as string;
        string? userDataPath = Application.Current.Resources["userDataPath"] as string;
        string? localUserDataPath = Application.Current.Resources["localUserDataPath"] as string;


        IOUtil.LevelsPath = levelsPath!;
        IOUtil.LocalLevelsPath = localLevelsPath!;
        IOUtil.UserDataPath = userDataPath!;
        IOUtil.LocalUserDataPath = localUserDataPath!;
        }
}


}
