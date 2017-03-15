using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvadersFramework
{
    class PlayingState : GameObjectList{
        Player player;
        GameObjectList invaders;
        GameObjectList bullets;
        Score score;
        public PlayingState(){
            player = new Player(this);
            var xPos = SpaceInvaders.Screen.X / 2 - player.Width / 2;
            var yPos = SpaceInvaders.Screen.Y - player.Width;
            player.Position = new Vector2(xPos, yPos);
            invaders = new GameObjectList();
            bullets = new GameObjectList();
            score = new Score();
            Add(player);
            Add(score);
            Add(invaders);
            for (int i = 0; i < 16; i++){
                for (int j = 0; j < 4; j++){
                    var asset = "blue_invader";
                    if (j == 1)
                       asset = "yellow_invader";
                    if (j == 2)
                       asset = "red_invader";
                    if (j == 3)
                        asset = "green_invader";
                    var invader = new Invader(asset);
                    invaders.Add(invader);
                    invader.Position = new Vector2(i * 50, j * 50);
                }
            }
        }
        public override void HandleInput(InputHelper inputHelper){
            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Space)){
                Bullet bullet = new Bullet();
                bullet.Position = player.Position;
                this.Add(bullet);
                bullets.Add(bullet);
            }
        }
        public override void Update(GameTime gameTime){
            base.Update(gameTime);
           foreach (Bullet b in bullets.Objects){
                foreach (Invader i in invaders.Objects){
                    if (b.CollidesWith(i) && b.Visible && i.Visible){
                        i.Visible = false;
                        b.Visible = false;
                        score.score += 10;
                    }
                }
            }
        }
    }
}
