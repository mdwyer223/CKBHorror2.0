using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace CKB
{
    public class LightTile
    {
        Vector2 position;
        Rectangle rec;
        Texture2D blankTexture;
        Color color = Color.Black;
        float brightness = 0f;
        float side; //will become a constant

        public Vector2 Position
        {
            get { return position; }
            protected set
            {
                rec.X = (int)value.X;
                rec.Y = (int)value.Y;
                position.Y = value.Y;
                position.X = value.X;
            }
        }

        public Rectangle Rec
        {
            get { return rec; }
        }

        public LightTile(float sideLength, Vector2 pos)
            : base()
        {
            this.side = sideLength;
            rec = new Rectangle(0, 0, (int)sideLength, (int)sideLength);
            this.Position = pos;
            blankTexture = Image.Particle;
        }

        public virtual void update(GameTime gameTime) //needs the lightmap as a resource for lightdistance
        {
            brightness = (float)(255f * ((Math.Sqrt((Math.Pow(Input.mousePos().X - (float)rec.Center.X, 2))
                + (Math.Pow(Input.mousePos().Y - rec.Center.Y, 2)))) / (side * 30)));
        }

        public virtual void draw(SpriteBatch spriteBatch)
        {
            
            spriteBatch.Draw(blankTexture, Rec, color * ((float)Math.Abs(brightness) / 255f));
        }
    }
}
