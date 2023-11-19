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
using System.Windows.Shapes;

namespace VhodReg
{
    /// <summary>
    /// Логика взаимодействия для UserAccount.xaml
    /// </summary>
    public partial class UserAccount : Window
    {
        public UserAccount()
        {
            InitializeComponent();
            userName.Text = MainWindow.lastUserName;
            userEmail.Text = MainWindow.lastUserEmail;
        }

        private void logOut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
