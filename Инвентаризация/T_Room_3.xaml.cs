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
    /// Логика взаимодействия для T_Room_3.xaml
    /// </summary>
    public partial class T_Room_3 : Window
    {
        public T_Room_3()
        {
            InitializeComponent();
            InventarizationEntities db = new InventarizationEntities();
            T_Room_3a.ItemsSource = db.InventThirdRooms.ToList();
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
            InventThirdRoom tr = new InventThirdRoom();

            tr.Name = Convert.ToInt32(cb_Name);
            tr.InventNumber = Convert.ToString(tb_Num_Inv);
            tr.Date = Convert.ToDateTime(tb_Date);

            db.InventThirdRooms.Add(tr);
            db.SaveChanges();
            T_Room_3a.ItemsSource = db.InventThirdRooms.ToList();
        }

        private void Button_Del_Click(object sender, RoutedEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            var dRow = db.InventThirdRooms.FirstOrDefault(i => i.Name == Convert.ToInt32(cb_Name));
            db.InventThirdRooms.Remove(dRow);
            db.SaveChanges();
            T_Room_3a.ItemsSource = db.InventThirdRooms.ToList();
        }

        private void Back_Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Room_Win_3 rw = new Room_Win_3();
            rw.Show();
            Close();
        }
    }
}
