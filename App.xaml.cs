using System.Windows;

namespace XTUPairer
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private MainWindow mainView = new MainWindow()
        {
            Visibility = Visibility.Collapsed
        };

        public App()
        {
            this.Startup += this.App_Startup;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
        }
    }
}
