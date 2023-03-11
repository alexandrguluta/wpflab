using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Entities
{
    public class UserRepository
    {
        private List<UserModel> _users = new List<UserModel>()
        {
            new UserModel  {Email = "admin@example.com", Password = "example123"}
        };



        public  UserModel? GetUser(string email, string pass)
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
        public void NewUser(string email, string pass)
            {
                new UserModel { Email = email, Password = pass};

            }

    }
};
