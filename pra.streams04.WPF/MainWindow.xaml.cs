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
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace pra.streams04.WPF
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

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory 
                = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\nieuwemap";
            openFileDialog.Filter = "Tekstestanden (*.txt)|*.txt|Alle bestanden (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string pad = openFileDialog.FileName;
                txtTest.Text = File.ReadAllText(pad);
            }
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string map = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            map += "\\nieuwemap";
            saveFileDialog.FileName = map + "\\test.txt";
            saveFileDialog.Filter = "Tekstbestand (*.txt)|*.txt|C# bestand (*.cs)|*.cs";
            if (saveFileDialog.ShowDialog() == true)
            {
                map = saveFileDialog.FileName;
                File.WriteAllText(map, txtTest.Text);
            }
        }
    }
}
