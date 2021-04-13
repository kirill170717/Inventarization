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
        private void Room_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Trans trans = new Trans();
            trans.Room_1_MouseDown();
        }

        private void Room_2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Trans trans = new Trans();
            trans.Room_2_MouseDown();
        }

        private void Room_3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Trans trans = new Trans();
            trans.Room_3_MouseDown();
        }
    }
}
