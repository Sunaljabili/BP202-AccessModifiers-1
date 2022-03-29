using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    class User
    {
        private string _username;
        private string _password;

        public User(string username)
        {
            Username = username;
        }
        public string Username {
            get
            {
                return _username;
            }

            set { 
                if(value.Length>6 && value.Length < 25)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("usernamin uzunlugu 6-25 arasi olmalidir.");
                }

            }
        }
        public string Password {
            get
            {
                return _password;
            }
            set
            {
                if(value.Length>8 && value.Length < 25 && HasDigit(value) && HasLower(value) && HasUpper(value)) {
                    _password = value;               
                }
                else {
                    Console.WriteLine("Uzunlug 8-25 arasi,en azi 1 boyuk Herf ,1 Reqem,1 kicik Herif");
                }
            }
        }


        public bool HasDigit(string str)
        {
            foreach (var item in str)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasUpper(string str)
        {
            foreach (var item in str)
            {
                if (char.IsUpper(item))
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasLower(string str)
        {
            foreach (var item in str)
            {
                if (char.IsLower(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
