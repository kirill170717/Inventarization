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

namespace Инвентаризация
{
    /// <summary>
    /// Логика взаимодействия для Selecting_Rooms_Win.xaml
    /// </summary>
    public partial class Selecting_Rooms_Win : Window
    {
        public Selecting_Rooms_Win()
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

        }

        private void Room_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Room_Win_1 room_Win_1 = new Room_Win_1();
            room_Win_1.Show();
        }

        private void Room_2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Room_Win_2 room_Win_2 = new Room_Win_2();
            room_Win_2.Show();
        }

        private void Room_3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Room_Win_3 room_Win_3 = new Room_Win_3();
            room_Win_3.Show();
        }
    }
}
