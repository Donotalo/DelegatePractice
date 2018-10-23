using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class NameChangeEventArgs : EventArgs
    {
        public string OldName = "", NewName = "";
    }

    class EventfulUser
    {
        private string _name;

        //public delegate void OnNameChange(string old_name, string new_name);
        //public event OnNameChange NameChangeEvent;

        public void SetName(string name)
        {
            string old_name = _name;
            _name = name;
            //NameChangeEvent?.Invoke(old_name, name);
            NameChangeEvent?.Invoke(this, new NameChangeEventArgs() { OldName = old_name, NewName = name });
        }

        //public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);
        public event EventHandler<NameChangeEventArgs> NameChangeEvent;
    }
}
