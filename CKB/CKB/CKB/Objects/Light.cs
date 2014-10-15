using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CKB
{
    public class Light
    {
        Random rand = new Random();
        Vector2 position, startPosition;
        float brightnessFactor = 1;
        bool isDead;

        public Vector2 Position
        {
            get { return position; }
        }

        public bool IsDead
        {
            get { return isDead; }
        }

        public float BrightnessFactor
        {
            get { return brightnessFactor; }
        }

        public Light(Vector2 position, float brightness)
            : base()
        {
            this.position = position;
            startPosition = new Vector2(position.X + 400, position.Y + 240);
            this.brightnessFactor = brightness;
            isDead = false;
        }

        public virtual void update()
        {
            this.position.X = (this.startPosition.X - Game1.Camera.Position.X);
            this.position.Y = (this.startPosition.Y - Game1.Camera.Position.Y);
            //brightnessFactor = (float)(rand.NextDouble() * .5f);
        }
    }
}
