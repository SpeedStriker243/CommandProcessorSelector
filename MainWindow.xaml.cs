using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Shapes;

namespace CommandProcessSelector_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Background = SystemParameters.WindowGlassBrush;
            if (!File.Exists("C:\\Windows\\Sysnative\\wsl.exe"))
            {
                wsl.IsEnabled = false;
            }
            KeyDown += new KeyEventHandler(MainWindow_KeyDown);
        }
        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D1)
            {
                Process.Start("cmd.exe");
            }
            if (e.Key == Key.D2)
            {
                Process.Start("powershell.exe");
            }
            if (e.Key == Key.D3)
            {
                if (File.Exists("C:\\Windows\\Sysnative\\wsl.exe"))
                {
                    Process.Start("C:\\Windows\\Sysnative\\wsl.exe");
                }
            }
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }

        private void Cmd_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd.exe");
        }

        private void Powershell_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("powershell.exe");
        }

        private void Wsl_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Windows\\Sysnative\\.exe");
        }
    }
}
