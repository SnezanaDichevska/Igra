using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BubbleTrouble.Properties;

namespace BubbleTrouble
{
    public class FirstLevelView : LevelView
    {
        public FirstLevelView(int numLives, int scores)
            : base(Resources._01, Resources.lvlNo1, numLives, scores)
        {
        }
        

    }
}
