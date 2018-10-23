using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class LamdaUser
    {
        static LamdaUser()
        {
            EventfulUser user = new EventfulUser();
            user.NameChangeEvent += (object sender, NameChangeEventArgs e) =>
            {
                Console.WriteLine($"LamdaUser's name changed from {e.OldName} to {e.NewName}");
            };

            user.SetName("Oh");
            user.SetName("Ah");
        }
    }
}
