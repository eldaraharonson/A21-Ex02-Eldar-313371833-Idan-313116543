using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    public class PotentialCrush : User
    {
        public User m_PotentiallyHasCrushOn;
        public int m_numberOfLikesGiven = 0;
        
        public PotentialCrush(User i_PotentiallyHasCrushOn)
        {
            this.m_PotentiallyHasCrushOn = i_PotentiallyHasCrushOn;
        }

        public void numberOfLikesGiven()
        {
            foreach (Post post in this.m_PotentiallyHasCrushOn.Posts)
            {
                if (post.LikedBy.Contains(this))
                {
                    m_numberOfLikesGiven++;
                }
            }
        }
    }
}
