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
            InventarizationEntities db = new InventarizationEntities();
            T_RW3.ItemsSource = db.InventThirdRooms.ToList();
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
        private void Table_MouseDown(object sender, MouseButtonEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            T_RW3.ItemsSource = db.InventThirdRooms.Where(i => i.Name == 1).ToList();
        }
        private void Chair_MouseDown(object sender, MouseButtonEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            T_RW3.ItemsSource = db.InventThirdRooms.Where(i => i.Name == 2).ToList();
        }
        private void Monitor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            T_RW3.ItemsSource = db.InventThirdRooms.Where(i => i.Name == 3).ToList();
        }
        private void PC_MouseDown(object sender, MouseButtonEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            T_RW3.ItemsSource = db.InventThirdRooms.Where(i => i.Name == 4).ToList();
        }
        private void Keyboard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            T_RW3.ItemsSource = db.InventThirdRooms.Where(i => i.Name == 5).ToList();
        }
        private void Mouse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            T_RW3.ItemsSource = db.InventThirdRooms.Where(i => i.Name == 6).ToList();
        }
    }
}
