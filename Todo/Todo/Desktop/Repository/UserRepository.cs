using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Entities
{
    public static class UserRepository
    {
        private static List<UserModel> _users = new List<UserModel>();

        public static void UserAdd(string email, string password, string username)
        {
            UserModel newuser = new UserModel() { Email = email, Password = password, Username = username };
            _users.Add(newuser);
        }
       


        public static  UserModel? GetUser(string email, string pass)
        {
            foreach (var user in _users)
            {
                if (user.Email == email && user.Password == pass)
                {
                    return user;
                }
            }
            return null;
        }
    }
};
