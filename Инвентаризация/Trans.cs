using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Инвентаризация
{
    public class Trans
    {
        public bool Room_1_MouseDown()
        {
            Auth auth = new Auth();
            Selecting_Rooms_Win selecting_Rooms_Win = new Selecting_Rooms_Win();
            if (auth.role == 1)
            {
                Room_Win_1 room_Win_1 = new Room_Win_1();
                room_Win_1.Show();
                selecting_Rooms_Win.Close();
            }
            else if (auth.role == 2)
            {

            }
            return true;
        }
        public bool Room_2_MouseDown()
        {
            Auth auth = new Auth();
            Selecting_Rooms_Win selecting_Rooms_Win = new Selecting_Rooms_Win();
            if (auth.role == 1)
            {
                Room_Win_2 room_Win_2 = new Room_Win_2();
                room_Win_2.Show();
                selecting_Rooms_Win.Close();
            }
            else if (auth.role == 2)
            {

            }
            return true;
        }
        public bool Room_3_MouseDown()
        {
            Auth auth = new Auth();
            Selecting_Rooms_Win selecting_Rooms_Win = new Selecting_Rooms_Win();
            if (auth.role == 1)
            {
                Room_Win_3 room_Win_3 = new Room_Win_3();
                room_Win_3.Show();
                selecting_Rooms_Win.Close();
            }
            else if (auth.role == 2)
            {

            }
            return true;
        }
    }
}
