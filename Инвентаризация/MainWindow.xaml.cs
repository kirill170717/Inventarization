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

namespace Инвентаризация
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {



        }

        private void Logo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }
        private void ExitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string Login = Convert.ToString(tb_Login);
            string Password = Convert.ToString(tb_Password);
            InventarizationEntities inventarization = new InventarizationEntities();
            Invent_Users invent_Users = inventarization.Invent_Users.FirstOrDefault(i => i.Login == Login);
            if (tb_Login == null || tb_Password == null)
            {
                MessageBox.Show("Ключевые поля не заполнены", "Ошибка");
            }
            else if (invent_Users != null) 
            {
                if (invent_Users.Login == Login && invent_Users.Password == Password)
                {
                    if (invent_Users.Login == "Director")
                    {
                        
                    }
                    else if (invent_Users.Login == "Admin")
                    {
                        
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином не существует", "Ошибка");
            }
        }
    }
}
