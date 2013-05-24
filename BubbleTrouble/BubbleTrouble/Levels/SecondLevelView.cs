using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BubbleTrouble.Properties;

namespace BubbleTrouble
{
    public class SecondLevelView :LevelView
    {
        public SecondLevelView(int numLives, int scores)
            : base(Resources._02, Resources.lvlNo2, numLives, scores)
        {
        }
        
    }
}
