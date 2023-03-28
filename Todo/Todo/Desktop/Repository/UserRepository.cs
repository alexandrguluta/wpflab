using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
namespace Entities
{
    public static class UserRepository
    {
        private static List<UserModel> _users = new List<UserModel>();

        public static bool UserAdd(string email, string password, string username)
        {
            UserModel newuser = new UserModel() { Email = email, Password = password, Username = username };
            bool exists = false;
            foreach (var user in _users)
            {
                if (user.Username.Contains(username))
                {
                    exists = true;
                }
            }
            if (!exists)
            {
                _users.Add(newuser);
                exists = false;
            }
            return exists;
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
}
