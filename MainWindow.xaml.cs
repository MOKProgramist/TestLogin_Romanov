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

                // для теста
                string email = "email@artcolle.ru";

                // int max = 1;

                // ищем пользоватателя с таким логином, если есть, то ошибка
                var findUser = BaseModel.GetContext().Users.Where(p => p.login == login);
                if(findUser != null)
                {
                    MessageBox.Show($"Пользователь с таким логином уже есть в базе, используйте другой логин", "Ошибка");
                    return;
                }
                currentUser = new Users(login, pass, email);
                Users newUser = BaseModel.GetContext().Users.Add(currentUser);

                try
                {
                    MessageBox.Show($"Регистрация прошла успешно! Ваш айди: {newUser.id}", "Результат");
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
