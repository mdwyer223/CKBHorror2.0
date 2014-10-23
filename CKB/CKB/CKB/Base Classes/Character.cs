using System;
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
        Animation aniWalk;

        public Character()
            : base(Image.Character.Walk, 0.05f, 1, Vector2.Zero)
        {
            aniWalk = new Animation(Image.Character.Walk, 50, .3f);
            playAnimation(aniWalk);

            this.Position = new Vector2(0, Game1.View.Height - this.Rec.Height - 5);
            Flip = true;
        }

        public override void update(GameTime gameTime)
        {
            base.update(gameTime);
            keys = Keyboard.GetState();

            playAnimation(aniWalk);
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

            //Check for Y direction movement
            //if (keys.IsKeyDown(Keys.S) || keys.IsKeyDown(Keys.Down))
            //    velocity.Y = this.Speed;
            //if (keys.IsKeyDown(Keys.W) || keys.IsKeyDown(Keys.Up))
            //    velocity.Y = -this.Speed;

            oldkeys = keys;
        }
    }
}
