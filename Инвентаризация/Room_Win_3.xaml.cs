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

    public partial class Room_Win_3 : Window
    {
        public Room_Win_3()
        {
            InitializeComponent();
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

        private void Button_Redact_Click(object sender, RoutedEventArgs e)
        {
            T_Room_3 t_Room_3 = new T_Room_3();
            t_Room_3.Show();
        }

        private void Back_Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Selecting_Rooms_Win win = new Selecting_Rooms_Win();
            win.Show();
            Close();
        }
    }
}
