using HCLauncher.Modules;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HCLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Components.ViewModelControl.PageName = "MainPage";
            InitializeComponent();
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo($"{FolderPath.pathMCFolder}versions");
            foreach (var dir in info.EnumerateDirectories())
            {
                if (File.Exists(TextString.SlashReplace($"{dir.FullName}/{dir.Name}.json")))
                {
                    Console.WriteLine(dir.FullName);
                }
            }
        }
    }
}