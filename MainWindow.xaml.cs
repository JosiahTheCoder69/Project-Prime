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

        // Navigate to Dashboard
        private void NavigateToDashboard(object sender, RoutedEventArgs e)
        {
            // Implement navigation logic to the dashboard view
            MessageBox.Show("Navigating to Dashboard...");
        }

        // Open Settings
        private void OpenSettings(object sender, RoutedEventArgs e)
        {
            // Implement settings functionality
            MessageBox.Show("Opening Settings...");
        }

        // Open Discord Server
        private void OpenDiscordServer(object sender, RoutedEventArgs e)
        {
            // Open the Discord server link
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

        // Launch Game
        private void LaunchGame(object sender, RoutedEventArgs e)
        {
            // Implement launch game functionality
            MessageBox.Show("Launching Game...");
        }
    }
}
