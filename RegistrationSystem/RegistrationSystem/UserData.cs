using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    public class UserData
    {
        public string Name { set; get; }
        public string Surname { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }

        public UserData(string _Name,string _Surname , string _Email, string _Password)
        {
            Name = _Name;
            Surname = _Surname;
            Email = _Email;
            Password = _Password;

        }

    }

}
