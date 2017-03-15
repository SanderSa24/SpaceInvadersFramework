using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class Player : SpriteGameObject
    {
        
        public Player(PlayingState playingState)
            : base("ship")
        {
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            velocity.X = 0;
            if (inputHelper.IsKeyDown(Keys.Left))
            {
                velocity.X = -500;
            }

            else if (inputHelper.IsKeyDown(Keys.Right))
            {
                velocity.X = 500;
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            //blijft binnen het scherm
            position = Vector2.Clamp(position, Vector2.Zero, new Vector2(SpaceInvaders.Screen.X - Width, SpaceInvaders.Screen.Y));
        }
    }
}
