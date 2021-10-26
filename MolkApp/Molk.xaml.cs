using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for Molk.xaml
    /// </summary>
    public partial class Molk : Window
    {
        public Molk(string[] file)
        {
            pathToTarget = file;
            arguments = new Dictionary<string, bool>();

            InitializeComponent();
            DestinationContentTextBox.Text = file[0];

            //foreach (string element in pathToFile)
            //{
            //    checkIfDirOrFile(element);
            //}
        }


        private string[] pathToTarget;
        private Dictionary<string, bool> arguments;

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            switch (checkBox.Name)
            {
                case "_f":
                    arguments.Add("-f", true);
                    break;
                case "_d":
                    arguments.Add("-d", true);
                    break;
                case "_r":
                    arguments.Add("-r", true);
                    break;
                case "_0":
                    arguments.Add("-0", true);
                    break;
                case "_1":
                    arguments.Add("-1", true);
                    break;
                case "_q":
                    arguments.Add("-q", true);
                    break;
                case "_c":
                    arguments.Add("-c", true);
                    break;
                case "_at":
                    arguments.Add("-@", true);
                    break;
                case "_x":
                    arguments.Add("-x", true);
                    break;
                case "_F":
                    arguments.Add("-F", true);
                    break;
                case "_A":
                    arguments.Add("-A", true);
                    break;
                case "_T":
                    arguments.Add("-T", true);
                    break;
                case "_exc":
                    arguments.Add("-!", true);
                    break;
                case "_R":
                    arguments.Add("-R", true);
                    break;
                case "_dollar":
                    arguments.Add("-$", true);
                    break;
                case "_e":
                    arguments.Add("-e", true);
                    break;
                case "_u":
                    arguments.Add("-u", true);
                    break;
                case "_m":
                    arguments.Add("-m", true);
                    break;
                case "_j":
                    arguments.Add("-j", true);
                    break;
                case "_l":
                    arguments.Add("-l", true);
                    break;
                case "_9":
                    arguments.Add("-9", true);
                    break;
                case "_v":
                    arguments.Add("-v", true);
                    break;
                case "_z":
                    arguments.Add("-z", true);
                    break;
                case "_o":
                    arguments.Add("-o", true);
                    break;
                case "_i":
                    arguments.Add("-i", true);
                    break;
                case "_D":
                    arguments.Add("-D", true);
                    break;
                case "_J":
                    arguments.Add("-J", true);
                    break;
                case "_X":
                    arguments.Add("-X", true);
                    break;
                case "_S":
                    arguments.Add("-S", true);
                    break;
                case "_n":
                    arguments.Add("-n", true);
                    break;
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            switch (checkBox.Name)
            {
                case "_f":
                    arguments.Remove("-f");
                    break;
                case "_d":
                    arguments.Remove("-d");
                    break;
                case "_r":
                    arguments.Remove("-r");
                    break;
                case "_0":
                    arguments.Remove("-0");
                    break;
                case "_1":
                    arguments.Remove("-1");
                    break;
                case "_q":
                    arguments.Remove("-q");
                    break;
                case "_c":
                    arguments.Remove("-c");
                    break;
                case "_at":
                    arguments.Remove("-@");
                    break;
                case "_x":
                    arguments.Remove("-x");
                    break;
                case "_F":
                    arguments.Remove("-F");
                    break;
                case "_A":
                    arguments.Remove("-A");
                    break;
                case "_T":
                    arguments.Remove("-T");
                    break;
                case "_exc":
                    arguments.Remove("-!");
                    break;
                case "_R":
                    arguments.Remove("-R");
                    break;
                case "_dollar":
                    arguments.Remove("-$");
                    break;
                case "_e":
                    arguments.Remove("-e");
                    break;
                case "_u":
                    arguments.Remove("-u");
                    break;
                case "_m":
                    arguments.Remove("-m");
                    break;
                case "_j":
                    arguments.Remove("-j");
                    break;
                case "_l":
                    arguments.Remove("-l");
                    break;
                case "_9":
                    arguments.Remove("-9");
                    break;
                case "_v":
                    arguments.Remove("-v");
                    break;
                case "_z":
                    arguments.Remove("-z");
                    break;
                case "_o":
                    arguments.Remove("-o");
                    break;
                case "_i":
                    arguments.Remove("-i");
                    break;
                case "_D":
                    arguments.Remove("-D");
                    break;
                case "_J":
                    arguments.Remove("-J");
                    break;
                case "_X":
                    arguments.Remove("-X");
                    break;
                case "_S":
                    arguments.Remove("-S");
                    break;
                case "_n":
                    arguments.Remove("-n");
                    break;
            }
        }

        private void checkIfDirOrFile(string path)
        {
            FileAttributes attr = File.GetAttributes(path);

            if (attr.HasFlag(FileAttributes.Directory))
                MessageBox.Show("Its a directory");
            else
                MessageBox.Show("Its a file");
        }

        private void Destination_ZIP_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                DestinationZIPTextBox.Text = openFileDialog.FileName;
        }

        private void Destination_Content_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
