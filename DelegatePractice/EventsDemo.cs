using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class EventsDemo
    {
        static EventsDemo()
        {
            EventfulUser user = new EventfulUser();
            //            user.NameChangeEvent += User_NameChangeEvent;
            user.NameChangeEvent += User_NameChangeEvent;

            user.SetName("Oh");
            user.SetName("Ah");
        }

        private static void User_NameChangeEvent(object sender, NameChangeEventArgs e)
        {
            Console.WriteLine($"Name changed from {e.OldName} to {e.NewName}");
        }

        private static void User_NameChangeEvent(string old_name, string new_name)
        {
            Console.WriteLine($"Name changed from {old_name} to {new_name}");
        }
    }
}
