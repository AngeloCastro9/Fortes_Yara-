using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.IO;

namespace Fortes_Scripts
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String caminho = System.Environment.CurrentDirectory.ToString() + "\\Teste.ini"; //Qualquer caminho
            if (!System.IO.File.Exists(caminho))
                System.IO.File.Create(caminho).Close();
            StreamWriter sw = new StreamWriter(caminho);
            sw.WriteLine("[Startup]" + "\n" +
               "ProgramFolder = A:\\Exe\\AC" + "\n" +
               "DataFolder = D:\\" + DataFolder.Text + "\\" + Databasefile.Text + "_AC" + "\n)");
            sw.Close();
        }
    }
}
