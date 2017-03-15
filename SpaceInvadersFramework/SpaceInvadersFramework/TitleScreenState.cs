using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class TitleScreenState : GameObjectList
    {
        TextGameObject text;
        public TitleScreenState()
        {
            text = new TextGameObject("GameFont");
            this.Add(text);
            text.Position = new Vector2(250, SpaceInvaders.Screen.Y / 2);
            text.Text = "Press 'space' to start!";
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Space))
            {
                SpaceInvaders.GameStateManager.SwitchTo("PlayingState");
            }
        }
    }
}
