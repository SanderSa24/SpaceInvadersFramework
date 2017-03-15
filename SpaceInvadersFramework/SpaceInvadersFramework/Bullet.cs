using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SpaceInvadersFramework
{
    class Bullet : SpriteGameObject
    {
        public Bullet() : base("bullet")
        {
            velocity.Y = -10;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            this.position += velocity;
        }
    }
}
