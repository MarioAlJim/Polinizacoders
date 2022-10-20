using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using OcaBussinessLogic;

namespace OcaWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Authentication : IAuthentication
    {
        public bool login(string userName, string password)
        {
            Authentication authentication = new Authentication();
            Boolean sucess = false;
            sucess= authentication.login(userName, password);
            return sucess
;        }
    }
}
