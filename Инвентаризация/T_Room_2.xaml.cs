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

    public partial class T_Room_2 : Window
    {
        public T_Room_2()
        {
            InitializeComponent();
            InventarizationEntities db = new InventarizationEntities();
            T_Room_2a.ItemsSource = db.InventSecondRooms.ToList();
            cb_Name.ItemsSource = db.InventNames.ToList();
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

        private void Button_Ins_Click(object sender, RoutedEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            InventSecondRoom sr = new InventSecondRoom();

            sr.Name = Convert.ToInt32(cb_Name);
            sr.InventNumber = Convert.ToString(tb_Num_Inv);
            sr.Date = Convert.ToDateTime(tb_Date);

            db.InventSecondRooms.Add(sr);
            db.SaveChanges();
            T_Room_2a.ItemsSource = db.InventSecondRooms.ToList();
        }

        private void Button_Del_Click(object sender, RoutedEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            var dRow = db.InventSecondRooms.FirstOrDefault(i => i.Name == Convert.ToInt32(cb_Name));
            db.InventSecondRooms.Remove(dRow);
            db.SaveChanges();
        }

        private void Back_Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Room_Win_2 rw = new Room_Win_2();
            rw.Show();
            Close();
        }
    }
}
