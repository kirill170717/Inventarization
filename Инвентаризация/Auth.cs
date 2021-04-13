using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Инвентаризация
{
    public class Auth
    {
        public bool Button_Auth_Click(string tb_Login, string tb_Password)
        {
            InventarizationEntities db = new InventarizationEntities();
            Invent_Users invent_Users = db.Invent_Users.FirstOrDefault(i => i.Login == tb_Login);
            if (string.IsNullOrWhiteSpace(Convert.ToString(tb_Login)) || string.IsNullOrWhiteSpace(Convert.ToString(tb_Password)))
            {
                MessageBox.Show("Ключевые поля не заполнены", "Ошибка");
                return false;
            }
            else if (invent_Users != null)
            {
                if (invent_Users.Login == tb_Login && invent_Users.Password == tb_Password)
                {
                    Selecting_Rooms_Win selecting_Rooms_Win = new Selecting_Rooms_Win();
                    MainWindow mainWindow = new MainWindow();
                    if (invent_Users.Login == "Director")
                    {
                        selecting_Rooms_Win.Show();
                        mainWindow.Close();
                    }
                    else if (invent_Users.Login == "Admin")
                    {
                        selecting_Rooms_Win.Show();
                        mainWindow.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином не существует", "Ошибка");
                return false;
            }
            return true;
        }
    }
}