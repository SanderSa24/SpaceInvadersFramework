using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SpaceInvadersFramework
{
    class Invader : SpriteGameObject
    {
        public Invader(String assetName) : base(assetName)
        {
            velocity.X = 100;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            //Boundingbox is een property die een vierkant maakt om de sprite van top-left naar bottom-right
            if (BoundingBox.Left < 0 || BoundingBox.Right > SpaceInvaders.Screen.X)
            {
                velocity.X *= -1;
                position.Y += 32;
            }
        }
    }
}
