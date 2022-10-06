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

        public Boolean login(string userName, string password)
        {
            var users = 0;
            Boolean login = false;
            using (var context = new OcaDBEntities())
            {
                users = (from Users in context.Users
                         where Users.Nickname == userName && Users.Password == password
                         select Users).Count();
            }
            if (users > 0)
            {
                login = true;
            }
            return login;
        }

    }
}
