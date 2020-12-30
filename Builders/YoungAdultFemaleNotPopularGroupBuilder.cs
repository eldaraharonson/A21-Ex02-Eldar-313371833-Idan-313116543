using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    public class YoungAdultFemaleNotPopularGroupBuilder : IGroupStatisticBuilder
    {
        private GroupParams m_GroupParams = new GroupParams();

        public void AgeBuilder()
        {
            AgeRange ageRange = new AgeRange(26, 35);
            m_GroupParams.AgePreferences = ageRange;
        }

        public void GenderBuilder()
        {
            List<string> Gender = new List<string>();
            Gender.Add("Female");
            m_GroupParams.Gender = Gender;
        }

        public void LikeBuilder(int likes)
        {
            m_GroupParams.Likes = likes;
            m_GroupParams.IsPopular = false;
        }
    }
}
