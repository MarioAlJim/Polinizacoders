using System;
using OcaBussinessLogic;
using OcaDataAccess;

namespace OcaWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public partial class OcaGameServices : IAuthentication
    {
        public OcaDataAccess.Users login(string userName, string password)
        {
            Authentication ocaGameServices = new Authentication();
            OcaDataAccess.Users userAcount = ocaGameServices.login(userName, password);
            return userAcount;
        }

        public Boolean SignUp(string nickname, string password)
        {
            OcaBussinessLogic.UsersAdministration users = new OcaBussinessLogic.UsersAdministration();
            Boolean sucess = false;
            sucess = users.SignUpUser(nickname, password);
            return sucess;
        }
    }
}
