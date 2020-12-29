using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B20_Ex01_Eldar_313371833_Idan_313116543.Logic
{
    public class FacebookSystem
    {
        public LoginResult LoginToFacebook(string i_AppId, params string[] i_AccessableFacebookAttributes)
        {
            return FacebookService.Login(i_AppId, i_AccessableFacebookAttributes);
        }
    }
}
