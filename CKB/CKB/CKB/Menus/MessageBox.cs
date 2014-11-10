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

        public bool Visible
        {
            get;
            protected set;
        }

        public bool AcceptsInput
        {
            get;
            protected set;
        }

        public MessageBox()
        {
            text = Image.MessageBox;

            rec.Width = (int)(Game1.View.Width * 0.6f);
            rec.Height = (int)(Game1.View.Height * 0.5f);

            rec.X = (int)((Game1.View.Width - rec.Width) / 2);
            rec.Y = (int)((Game1.View.Height - rec.Height) / 2);

            message = "";

            //rec = new Rectangle(200, 500, 300, 400);
        }

        public void show(string message)
        {
            Visible = true;
            AcceptsInput = false;
            this.message = message;
        }
        public void show(List<string> listView)
        {
            Visible = true;
            AcceptsInput = true;
        }
        public void hide()
        {
            Visible = false;
        }
        public void update(GameTime gameTime)
        {
            if (Input.actionBarPressed())
                this.hide();
        }
        public void draw(SpriteBatch spriteBatch)
        {
            if (Visible)
            {
                spriteBatch.Draw(text, rec, Color.White);
                spriteBatch.DrawString(Fonts.Normal, message, new Vector2(rec.X, rec.Y), Color.White);
            }
        }
    }
}
