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
using System.Windows.Shapes;

namespace MolkApp
{
    /// <summary>
    /// Interaction logic for Unmolk.xaml
    /// </summary>
    public partial class Unmolk : Window
    {
        private string[] files;
        public Unmolk()
        {
            InitializeComponent();
        }


        private void Grid_Drop(object sender, DragEventArgs e)
        {
            files = (string[])e.Data.GetData(DataFormats.FileDrop);
            filePath.Text = files[0];
        }

        private void Unmolk_Click(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;
            process.StartInfo = info;
            process.Start();

            using (StreamWriter sw = process.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("cd \"C:\\Users\\Dator 1\\Desktop\\molk\"");
                    sw.WriteLine($"unmolk \"{MainWindow.files[0]}\" -d \"{files[0]}\"");
                }
            }
        }

        private void Close_Button(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
