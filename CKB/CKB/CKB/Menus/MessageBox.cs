using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace CKB
{
    public class MessageBox
    {
        private string message;
        Texture2D text;
        Rectangle rec;

        public MessageBox()
        {
            text = Image.MessageBox;

            rec.Width = (int)(Game1.View.Width * 0.7f);
            rec.Height = (int)(Game1.View.Height * 0.9f);

            rec.X = (int)((Game1.View.Width - text.Width) / 2);
            rec.Y = (int)((Game1.View.Height - text.Height) / 2);

            //rec = new Rectangle(200, 500, 300, 400);
        }

        public void show(string message)
        {
        }
        public void hide()
        {
        }

        public void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(text, rec, Color.White);
        }
    }
}
