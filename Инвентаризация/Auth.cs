using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tulpep.NotificationWindow;

namespace Инвентаризация
{
    public class Auth
    {
        public int role;
        public bool Button_Auth_Click(string tb_Login, string tb_Password)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Ошибка";
            popup.BodyColor = Color.Blue;

            InventarizationEntities db = new InventarizationEntities();
            Invent_Users invent_Users = db.Invent_Users.FirstOrDefault(i => i.Login == tb_Login);
            if (string.IsNullOrWhiteSpace(Convert.ToString(tb_Login)) || string.IsNullOrWhiteSpace(Convert.ToString(tb_Password)))
            {
                popup.ContentText = "Ключевые поля не заполнены";
                popup.Popup();
                return false;
            }
            else if (invent_Users != null)
            {
                if (invent_Users.Login == tb_Login && invent_Users.Password == tb_Password)
                {
                    Selecting_Rooms_Win selecting_Rooms_Win = new Selecting_Rooms_Win();
                    MainWindow mainWindow = new MainWindow();
                    if (invent_Users.Login == "Admin")
                    {
                        role = 1;
                        selecting_Rooms_Win.Show();
                        return true;
                    }
                    else if (invent_Users.Login == "Director")
                    {
                        role = 2;
                        selecting_Rooms_Win.Show();
                        return true;
                    }
                }
                else
                {
                    popup.ContentText = "Неверный логин или пароль";
                    popup.Popup();
                    return false;
                }
            }
            else
            {
                popup.ContentText = "Пользователя с таким логином не существует";
                popup.Popup();
                return false;
            }
            return true;
        }
    }
}