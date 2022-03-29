using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class User
    {

        public User(string username ,string passwrod , RoleNum role)
        {
            Username = username;
            Password = passwrod;
            Role = role;
        }
        public User()
        {
            _id++;
        }
        public static int ID { get => _id;}
        static int _id;
        public string Username;
        string _password;
        RoleNum Role;
         public string Password
        {
            get => _password;
            set
            {
                if (CheckPassword(value))
                {
                    this._password = value;
                }


            }
        }

        public static bool CheckPassword(string pass)
        {
            if (!string.IsNullOrWhiteSpace(pass) && pass.Length >= 8)
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (char.IsUpper(pass[i]) && char.IsLower(pass[i]) && char.IsDigit(pass[i]))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
       
   
        public  void ShowInfo()
        {
            Console.WriteLine($"Username :{Username} Role: {Role}");
        }




    }
}
