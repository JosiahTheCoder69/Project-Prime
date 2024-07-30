using System;
using System.Diagnostics;
using System.Windows;

namespace PrimeLauncher
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void NavigateToDashboard(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Navigating to Dashboard...");
        }

       
        private void OpenSettings(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Opening Settings...");
        }

      
        private void OpenDiscordServer(object sender, RoutedEventArgs e)
        {
           
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://discord.gg/Cza6pfmb",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open Discord server: {ex.Message}");
            }
        }

       
        private void LaunchGame(object sender, RoutedEventArgs e)
        {
           
            MessageBox.Show("Launching Game...");
        }
    }
}
