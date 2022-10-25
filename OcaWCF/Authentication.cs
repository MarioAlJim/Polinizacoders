using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using OcaBussinessLogic;
using OcaDataAccess;

namespace OcaWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Authentication : IAuthentication
    {
        public bool login(string userName, string password)
        {
            bool sucess = false;
            
            OcaBussinessLogic.Authentication authentication = new OcaBussinessLogic.Authentication();  
            User userAcount = authentication.login(userName, password);
            if (userAcount.Nickname != null)
            {
                sucess = true;
            }
            return sucess;
;        }

        public Boolean SignUp(string nickname, string password)
        {
            OcaBussinessLogic.UsersAdministration users=    new OcaBussinessLogic.UsersAdministration();
            Boolean sucess = false;
            sucess = users.SignUpUser(nickname, password);
            return sucess;
            Console.WriteLine("*** Sign up User Starts ***");
           
                

            
        }
    }
}
