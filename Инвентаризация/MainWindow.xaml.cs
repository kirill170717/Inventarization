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
            if (tb_Login == null || tb_Password == null)
            {
                MessageBox.Show("Ключевые поля не заполнены");
            }
            //else if (kurs_User != null)
            //{
            //    if (kurs_User.Логин == TxtLogin && kurs_User.Пароль == PasPassword)
            //    {
            //        if (kurs_User.RoleId == 1)
            //        {
            //            ок_ад.Show();
            //        }
            //        else if (kurs_User.RoleId == 2)
            //        {
            //            Idd.TrainerI = db.Kurs_Trainer.FirstOrDefault(i => i.Kurs_User.Логин == TxtLogin).IdTrainer;
            //            ок_тр.Show();
            //        }
            //        else if (kurs_User.RoleId == 3)
            //        {
            //            Idd.ClientI = db.Kurs_Client.FirstOrDefault(i => i.Kurs_User.Логин == TxtLogin).IdClient;
            //            Idd.UnitI = db.Kurs_Client.FirstOrDefault(i => i.Kurs_User.Логин == TxtLogin).UnitId;
            //            if (Idd.UnitI == 1)
            //            {
            //                выбор_Тренера.Show();
            //            }
            //            else
            //            {
            //                автКлиент.Show();
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Неверный логин или пароль");
            //    }
            //}
            else
            {
                MessageBox.Show("Пользователя с таким логином не существует");
            }
        }
    }
}
