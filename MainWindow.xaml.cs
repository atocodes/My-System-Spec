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
using System.Windows.Navigation;
using System.IO;
using System.Diagnostics;

namespace MySystemSpec
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           btn.Content = "WRITING Data...";
           string data = SystemSpec.JsonData();
           string appDir = string.Concat(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),"./RESULT");

            try {
                Directory.CreateDirectory(appDir);
                File.WriteAllText(string.Concat(appDir, "./RESULT.txt"),data);
                File.WriteAllText(string.Concat(appDir, "./RESULT.json"), data);

            } catch(IOException) {
                btn.Content = "Error!! Try Again";
            }

            btn.Content = "CREATE DATA";
            Process.Start(appDir);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)=>Close();
    }
}
