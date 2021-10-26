using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MolkApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string[] files;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBlock_Drop(object sender, DragEventArgs e)
        {
            Debug.WriteLine("molk");

            files = (string[])e.Data.GetData(DataFormats.FileDrop);

            Molk molk = new Molk(files);
            molk.Show();
            Close();
        }

        private void TextBlock_Drop_1(object sender, DragEventArgs e)
        {
            Debug.WriteLine("unmolk");

            files = (string[])e.Data.GetData(DataFormats.FileDrop);

            Unmolk unMolk = new Unmolk();
            unMolk.Show();
            Close();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Process.Start("cmd.exe");
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{

        //    textboxinput = Input.Text;
        //    Process cmd = Process.Start("cmd.exe", "/C " + textboxinput);
        //    Debug.WriteLine(textboxinput);
        //    cmd.Close();
        //}
    }
}
