using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace CKB
{
    public class Toy : Object
    {
        Animation aniWalk;
        SoundEffect sound;

        public Toy(int startX)
            : base(Image.Toy, 0.05f, 4f, Vector2.Zero, null)
        {
            this.Position = new Vector2(startX, Game1.View.Height - this.rec.Height);
            aniWalk = new Animation(Image.Toy, 350, 0.13f);
        }

        public override void update(GameTime gameTime, Floor floor)
        {
            base.update(gameTime, floor);
            playAnimation(aniWalk);

            Vector2 velo = floor.Character.Position - this.Position;
            velo.Normalize();
            this.Velocity = velo * Speed;

        }
    }
}
