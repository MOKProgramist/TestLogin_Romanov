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

namespace TestLogin_Romanov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Users currentUser;
        private BaseModel db;

        public MainWindow()
        {
            InitializeComponent();

            db = new BaseModel();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = textBoxPass.Password.Trim();

            if(login.Length < 5)
            {
                textBoxLogin.ToolTip = "Логин меньше 6 символов";
                textBoxLogin.Background = Brushes.Red;
            } else

            if (pass.Length < 6)
            {
                textBoxPass.ToolTip = "Пароль должен содержать не менее 6 символов";
                textBoxPass.Background = Brushes.Red;
            } 
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                
                textBoxPass.ToolTip = "";
                textBoxPass.Background = Brushes.Transparent;

             
                Users currentUser = new Users(login, pass);
               
                BaseModel.GetContext().Users.Add(currentUser);
                try
                {
                    MessageBox.Show("Регистрация прошла успешно!", "Результат");
                    // сохраняем результат
                    BaseModel.GetContext().SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка регистрации. {0}", ex.Message);
                }
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
