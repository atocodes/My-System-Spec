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

namespace MySystemSpec.Windows
{
    /// <summary>
    /// Interaction logic for Display.xaml
    /// </summary>
    public partial class Display : Window
    {
        SystemSpec system = new SystemSpec();

        public Display()
        {
            InitializeComponent();
            RenderData();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void RenderData()
        {
            UserName.Text += system.username;
            UserDomainName.Text += system.userdomainame;
            OS.Text += system.os;
            CPU.Text += system.cpu;
            Memory.Text += system.memory;
            UUID.Text += system.uuid;
            BuildDrivesInfo();
        }

        private void BuildDrivesInfo()
        {
            foreach(var diskData in system.storage)
            {
                TextBlock size = new TextBlock()
                { Text = $"{diskData["name"].ToUpper()} -> {diskData["freeSpace"]}GB/{diskData["totalSize"]}GB" };
                display.Children.Add(size);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) => Close();
    }
}
