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
    public partial class Selecting_Rooms_Win : Window
    {
        public Selecting_Rooms_Win()
        {
            InitializeComponent();
        }
        private void Back_Button_MouseDown(object sender, MouseButtonEventArgs e)
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
        private void BD_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BD_Win bD_Win = new BD_Win();
            bD_Win.Show();
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
        private void Room_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Room_Win_1 room_Win_1 = new Room_Win_1();
            room_Win_1.Show();
            Close();
        }

        private void Room_2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Room_Win_2 room_Win_2 = new Room_Win_2();
            room_Win_2.Show();
            Close();
        }

        private void Room_3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Room_Win_3 room_Win_3 = new Room_Win_3();
            room_Win_3.Show();
            Close();
        }

        private void De_Auth_Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Выйти из аккаунта?", "Выход", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                mainWindow.Show();
                Close();
            }
        }
    }
}
