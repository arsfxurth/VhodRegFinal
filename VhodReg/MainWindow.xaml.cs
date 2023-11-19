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

namespace VhodReg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public static List<Users> users = new List<Users>();
        static int count;
        static String sex;
        public static string lastUserName;
        public static string lastUserEmail;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (users.Count == 0)
            {
                TextField.Text = "Аккаунтов нет";
            }
            else
            {
                foreach(Users user in users){
                    if(loginText.Text.Equals(user.email) && passwordText.Text.Equals(user.password))
                    {
                        lastUserName = user.name;
                        lastUserEmail = user.email;
                        UserAccount userAccount = new UserAccount();
                        userAccount.Show();
                        this.Close();
                    }
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (buttonName.Text != "" && emailName.Text != "" && count > 0 && firstPassword.Text != "" && secondPassword.Text != "") {
                if (firstPassword.Text.Equals(secondPassword.Text))
                {
                    Users user = new Users(buttonName.Text, emailName.Text, sex, firstPassword.Text);
                    users.Add(user);
                    error.Text = "Вы зарегистрировались";
                }
                else
                {
                    error.Text = "Пароли не совпадают";
                }
            }
            else
            {
                error.Text = "Ошибка ввода";
            }
        }

        private void manButton_Checked(object sender, RoutedEventArgs e)
        {
            count++;
            sex = "Мужской";
        }

        private void womanButton_Checked(object sender, RoutedEventArgs e)
        {
            count++;
            sex = "Женский";
        }
    }
    public class Users
    {
        public string name;
        public string email;
        public string sex;
        public string password;
        public Users(string name, string email, string sex, string password)
        {
            this.name = name;
            this.email = email;
            this.sex = sex;
            this.password = password;
        }
    }
}
