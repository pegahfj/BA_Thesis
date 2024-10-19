using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;
using System.IO;

namespace gSpan
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private async void btBrowse_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var result = await openFileDialog.ShowAsync(this);

            if (result != null && result.Length > 0)
            {
                Console.WriteLine("File selected: " + result[0]);
                txtDataset.Text = result[0];
            }
        }

        private void btLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string _sFile = txtDataset.Text.Trim();
                var graphs = readDataset(_sFile);
                Console.WriteLine("Load button clicked");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in btLoad_Click: " + ex.Message);
            }
        }

        private void btClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private List<string> readDataset(string filePath)
        {
            // Your implementation to read the dataset
            return new List<string>();
        }
    }
}