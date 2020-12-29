using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature;
using B20_Ex01_Eldar_313371833_Idan_313116543.Logic;
using FacebookWrapper;

namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    public class Facade
    {
        //FilterOptionsFormLogic filterOptionsFormLogic = new FilterOptionsFormLogic();
        //FoundSoulmateAndGroupPopularityLogic foundSoulmateAndGroupPopularityLogic = new FoundSoulmateAndGroupPopularityLogic();
        FacebookSystem facebookSystem = new FacebookSystem();



        public LoginResult LoginToFacebook(string io_AppId, params string[] io_AccessableFacebookAttributes)
        {
            
            return facebookSystem.LoginToFacebook(io_AppId, io_AccessableFacebookAttributes);

        }
    }
}
