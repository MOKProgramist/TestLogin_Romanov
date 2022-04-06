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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = textBoxPass.Password.Trim();
            string pass_ = textBoxPass_.Password.Trim();
            string email = textBoxEmail.Text.ToLower().Trim();

            if(login.Length < 5)
            {
                textBoxLogin.ToolTip = "Поле введено не верно";
                textBoxLogin.Background = Brushes.Red;
            } else

            if (pass.Length < 6)
            {
                textBoxPass.ToolTip = "Пароль должен содержать не менее 6 символов";
                textBoxPass.Background = Brushes.Red;
            } else 

            if (pass.Length != pass_.Length )
            {
                textBoxPass.ToolTip = "Введеные пароли не совпадают";
                textBoxPass_.ToolTip = "Введеные пароли не совпадают";
                textBoxPass.Background = Brushes.Red;
                textBoxPass_.Background = Brushes.Red;
            } else 
            
            if(email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Почта указана неверно";
                textBoxEmail.Background = Brushes.Red;
                
            } else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                
                textBoxPass.ToolTip = "";
                textBoxPass.Background = Brushes.Transparent;
                textBoxPass_.ToolTip = "";
                textBoxPass_.Background = Brushes.Transparent;

                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Регистрация прошла успешно!", "Результат");
            }




            // MessageBox.Show($"Login: {login} Pas: {pass} Email: {email}", "Введенные данные:");
        }
    }
}
