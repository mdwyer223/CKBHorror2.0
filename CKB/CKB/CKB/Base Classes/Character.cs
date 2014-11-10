﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CKB
{
    public class Character : AnimatedSprite
    {

        KeyboardState keys, oldkeys;
        Animation aniWalk, aniIdle;

        public Character()
            : base(Image.Character.Walk, 0.15f, 2.5f, Vector2.Zero)
        {
            aniWalk = new Animation(Image.Character.Walk, 350, 0.16f);
            aniIdle = new Animation(Image.Character.Idle, 350, 2f);
            playAnimation(aniIdle);

            this.Position = new Vector2(0, Game1.View.Height - this.Rec.Height);
            Flip = true;
        }

        public void update(GameTime gameTime, Floor floor)
        {
            base.update(gameTime);
            keys = Keyboard.GetState();

            
            this.Position += this.velocity;

            velocity = Vector2.Zero;

            //Check for X direction movement--adjust sprite if need
            if (keys.IsKeyDown(Keys.D) || keys.IsKeyDown(Keys.Right))
            {
                velocity.X = this.Speed;
                Flip = false;
            }
            if (keys.IsKeyDown(Keys.A) || keys.IsKeyDown(Keys.Left))
            {
                velocity.X = -this.Speed;
                Flip = true;
            }

            if (velocity.X == 0)
                playAnimation(aniIdle);
            else
                playAnimation(aniWalk);

            //Check for Y direction movement
            //if (keys.IsKeyDown(Keys.S) || keys.IsKeyDown(Keys.Down))
            //    velocity.Y = this.Speed;
            //if (keys.IsKeyDown(Keys.W) || keys.IsKeyDown(Keys.Up))
            //    velocity.Y = -this.Speed;

            oldkeys = keys;
        }
    }
}
