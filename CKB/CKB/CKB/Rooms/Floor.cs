using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace CKB
{
    public class Floor
    {

        

        //list of objects
        protected Color color;
        Texture2D background;
        Vector2 position;
        Rectangle drawingRec;
        int width, height;

        public Character charater
        {
            get;
            protected set;
        }

        protected List<Object> objs;

        public Floor(Texture2D background, Vector2 position)
            : base()
        {
            this.background = background;
            this.position = position;
            this.height = Game1.View.Height;
            float aspectRatio = background.Width / background.Height;
            this.width = (int)(aspectRatio * background.Width);
            if (width >= 5 * Game1.View.Width)
                width = 5 * Game1.View.Width;
            drawingRec = new Rectangle((int)position.X, (int)position.Y, width, height);

            charater = new Character();
            objs = new List<Object>();

            
        }

        public virtual void update(GameTime gameTime)
        {
            //updates everything

            charater.update(gameTime, this);

            foreach (Object obj in objs)
                obj.update(gameTime, this);
        }

        public virtual void draw(SpriteBatch spriteBatch)
        {
            //draws everything
            spriteBatch.Draw(background, drawingRec, color);

            foreach (Object obj in objs)
                obj.draw(spriteBatch);

            charater.draw(spriteBatch);
        }
    }
}
