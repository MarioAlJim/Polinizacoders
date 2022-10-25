using OcaDataAccess;
using System;
using System.Linq;

namespace OcaBussinessLogic
{
    public class Authentication
    {
        public Authentication()
        {
        }

        public User login(string userName, string password)
        {
            User users;
            using (var context = new OcaEntities())
            {
                users = (User)(from Users in context.Users
                         where Users.Nickname == userName && Users.Password == password
                         select Users);
            }
            return users;
        }



    }
}
