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

        public Users login(string userName, string password)
        {
            Users users;
            using (var context = new OcaDBEntities())
            {
                users = (Users)(from Users in context.Users
                         where Users.Nickname == userName && Users.Password == password
                         select Users);
            }
            return users;
        }



    }
}
