using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersFramework
{
    class PlayingState: GameObjectList 
    {
        private SpriteGameObject background = null;

        public PlayingState() {
            background = new SpriteGameObject("background");
            this.Add(background);
        }
    }
}
