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
    public partial class BD_Win : Window
    {
        public BD_Win()
        {
            InitializeComponent();
            InventarizationEntities db = new InventarizationEntities();
            T_RW_1.ItemsSource = db.InventFirstRooms.ToList();
            T_RW_2.ItemsSource = db.InventSecondRooms.ToList();
            T_RW_3.ItemsSource = db.InventThirdRooms.ToList();
            T_RW_Us.ItemsSource = db.Invent_Users.ToList();
            T_RW_It.ItemsSource = db.InventNames.ToList();
        }
        private void Back_Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Selecting_Rooms_Win win = new Selecting_Rooms_Win();
            win.Show();
            Close();
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
        private void Button_Ins1_Click(object sender, RoutedEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            InventFirstRoom fr = new InventFirstRoom();

            fr.Name = Convert.ToInt32(cb_Name1);
            fr.InventNumber = tb_Num1.ToString();
            fr.Date = Convert.ToDateTime(tb_Date1);
            db.InventFirstRooms.Add(fr);
            db.SaveChanges();
            T_RW_1.ItemsSource = db.InventFirstRooms.ToList();
        }
        private void Button_Ins2_Click(object sender, RoutedEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            InventSecondRoom sr = new InventSecondRoom();
            sr.Name = Convert.ToInt32(cb_Name2);
            sr.InventNumber = tb_Num2.ToString();
            sr.Date = Convert.ToDateTime(tb_Date2);
            db.InventSecondRooms.Add(sr);
            db.SaveChanges();
            T_RW_2.ItemsSource = db.InventSecondRooms.ToList();
        }
        private void Button_Ins3_Click(object sender, RoutedEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            InventThirdRoom tr = new InventThirdRoom();
            tr.Name = Convert.ToInt32(cb_Name3);
            tr.InventNumber = tb_Num3.ToString();
            tr.Date = Convert.ToDateTime(tb_Date3);
            db.InventThirdRooms.Add(tr);
            db.SaveChanges();
            T_RW_3.ItemsSource = db.InventThirdRooms.ToList();
        }
        private void Button_InsUs_Click(object sender, RoutedEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            Invent_Users iu = new Invent_Users();
            iu.Login = tb_Login_Us.ToString();
            iu.Password = tb_Pass_Us.ToString();
            db.Invent_Users.Add(iu);
            db.SaveChanges();
            T_RW_Us.ItemsSource = db.Invent_Users.ToList();
        }
        private void Button_InsIt_Click(object sender, RoutedEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            InventName ina = new InventName();
            ina.Name = tb_Name_It.ToString();
            db.InventNames.Add(ina);
            db.SaveChanges();
            T_RW_It.ItemsSource = db.InventNames.ToList();
        }
        private void Button_Del1_Click(object sender, RoutedEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            InventFirstRoom fr = new InventFirstRoom();
            var dRow = db.InventFirstRooms.FirstOrDefault(i => i.Name == Convert.ToInt32(cb_Name1));
            db.InventFirstRooms.Remove(dRow);
            db.SaveChanges();
            T_RW_1.ItemsSource = db.InventFirstRooms.ToList();
        }
        private void Button_Del2_Click(object sender, RoutedEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            InventSecondRoom sr = new InventSecondRoom();
            var dRow = db.InventSecondRooms.FirstOrDefault(i => i.Name == Convert.ToInt32(cb_Name2));
            db.InventSecondRooms.Remove(dRow);
            db.SaveChanges();
            T_RW_2.ItemsSource = db.InventSecondRooms.ToList();
        }
        private void Button_Del3_Click(object sender, RoutedEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            InventThirdRoom tr = new InventThirdRoom();
            var dRow = db.InventThirdRooms.FirstOrDefault(i => i.Name == Convert.ToInt32(cb_Name3));
            db.InventThirdRooms.Remove(dRow);
            db.SaveChanges();
            T_RW_3.ItemsSource = db.InventThirdRooms.ToList();
        }
        private void Button_DelUs_Click(object sender, RoutedEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            var dRow = db.Invent_Users.FirstOrDefault(i => i.Login == tb_Login_Us.ToString());
            db.Invent_Users.Remove(dRow);
            db.SaveChanges();
            T_RW_Us.ItemsSource = db.Invent_Users.ToList();
        }
        private void Button_DelIt_Click(object sender, RoutedEventArgs e)
        {
            InventarizationEntities db = new InventarizationEntities();
            var dRow = db.InventNames.FirstOrDefault(i => i.Name == tb_Name_It.ToString());
            db.InventNames.Remove(dRow);
            db.SaveChanges();
            T_RW_It.ItemsSource = db.InventNames.ToList();
        }
    }
}