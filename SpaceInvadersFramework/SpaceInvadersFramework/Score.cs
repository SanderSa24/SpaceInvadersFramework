using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SpaceInvadersFramework
{
    class Score : TextGameObject
    {
        public int score;
        public Score() : base("GameFont")
        {
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            Position = new Vector2(0, 0);
            Text = "score: " + score;
        }
    }
}
