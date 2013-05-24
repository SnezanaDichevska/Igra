using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BubbleTrouble.Properties;

namespace BubbleTrouble
{
    public class ThirdLevelView:LevelView
    {
        public ThirdLevelView(int numLives, int scores)
            : base(Resources._03, Resources.lvlNo3, numLives, scores)
        {
        }
    }
}
