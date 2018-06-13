using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technobook.Model.Client.Models
{
    public class User
    {
        private int _ID;
        private string _FirstName;
        private string _LastName;
        private string _Email;
        private string _Password;
   
        public int ID
        {
            get { return _ID; }
            private set { _ID = value; }
        }


        public string FirstName
        {
            get { return _FirstName; }
            private set { _FirstName = value; }
        }


        public string LastName
        {
            get { return _LastName; }
            private set { _LastName = value; }
        }


        public string Email
        {
            get { return _Email; }
            private set { _Email = value; }
        }


        public string Password
        {
            get { return _Password; }
            private set { _Password = value; }
        }

        public User(int ID, string FirstName, string LastName, string Email, string Password)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Password = Password;
        }

        public User(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }

    }
}
