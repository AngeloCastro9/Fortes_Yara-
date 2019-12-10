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
            if (ClientName.Text != "")
            {
                if (DataFolder.Text != "")
                {
                    if (Databasefile.Text != "")
                    {
                        if (Username.Text != "")
                        {
                            if (Password.Text != "")
                            {

                                //A:\CloudUp\CloudUpCmd
                                string folder = @"C:\" + ClientName.Text; //nome do diretorio a ser criado
                                if (!Directory.Exists(folder))
                                {
                                    Directory.CreateDirectory(folder);
                                }

                                String caminho = folder + "\\" + ClientName.Text + ".ini"; //Qualquer caminho
                                if (!System.IO.File.Exists(caminho))
                                {
                                    System.IO.File.Create(caminho).Close();
                                }
                                else
                                {
                                    MessageBox.Show("Já existe uma pasta criada com o nome " + ClientName.Text);
                                }
                                    StreamWriter sw = new StreamWriter(caminho);
                                sw.WriteLine("[Startup]" + "\n" +
                                   "ProgramFolder = A:\\Exe\\AC" + "\n" +
                                   "DataFolder = D:\\" + DataFolder.Text + "\\" + Databasefile.Text + "_AC" + "\n" +
                                   "DatabaseFile = 127.0.0.1:" + Databasefile.Text + "_AC" + "\n" +
                                   "DriverName = MSSQL" + "\n" +
                                   "UserName = " + Username.Text + ".sql" + "\n" +
                                   "Password = " + Password.Text + "\n" +
                                   "\n" +
                                   "[Settings]" + "\n" +
                                   "ContinueUpdateAfterCrashRecovery = True" + "\n" +
                                   "AllowOldBackupsRestoration = False" + "\n" +
                                   "SkipWarnings = True" + "\n" +
                                   "ByPassInUseCheck = True" + "\n" +
                                   "RetryOnDatabaseInUse = False" + "\n" +
                                   "\n" +
                                   "[Backup]" + "\n" +
                                   "SkipBackupDatabase = True ");
                                sw.Close();
                            } else {
                                MessageBox.Show("Senha não informado");
                            }
                        } else {
                            MessageBox.Show("Usuário não informado");
                        }
                    } else {
                        MessageBox.Show("Banco de dados não informado");
                    }
                } else {
                    MessageBox.Show("Nome da pasta não informado");
                }
            } else {
                MessageBox.Show("Nome do cliente não informado");
            }
        }
    }
}
