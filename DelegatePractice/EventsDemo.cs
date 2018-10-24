using System;

namespace DelegatePractice
{
    class EventsDemo1
    {
        static private void User_NameChangeEvent(string old_name, string new_name)
        {
            Console.WriteLine($"Name changed from {old_name} to {new_name}");
        }

        static EventsDemo1()
        {
            EventfulUser1 user = new EventfulUser1();
            user.NameChangeEvent += User_NameChangeEvent;

            user.SetName("Neptune");
            user.SetName("Saturn");
        }
    }

    class EventsDemo2
    {
        static private void User_NameChangeEvent(object sender, NameChangeEventArgs e)
        {
            Console.WriteLine($"Name changed from {e.OldName} to {e.NewName}");
        }

        static EventsDemo2()
        {
            EventfulUser2 user = new EventfulUser2();
            user.NameChangeEvent += User_NameChangeEvent;

            user.SetName("Neptune");
            user.SetName("Saturn");
        }
    }
}
