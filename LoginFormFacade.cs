using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;

namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    public class LoginFormFacade
    {
        public static LoginResult LoginToFacebook(string i_AppId, params string[] i_AccessableFacebookAttributes)
        {
            return FacebookService.Login(i_AppId, i_AccessableFacebookAttributes);
        }
    }
}
