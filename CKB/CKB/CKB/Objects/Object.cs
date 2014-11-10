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
    public abstract class Object : AnimatedSprite
    {

        public Object(Texture2D texture, float scaleFactor, float secondsToCrossScreen, Vector2 startPos)
            : base(texture, scaleFactor, secondsToCrossScreen, startPos)
        {
        }

        public sealed override void update(GameTime gameTime)
        {
        }

        public virtual void update(GameTime gameTime, Floor floor)
        {
            base.update(gameTime);
                                    
            //Check if play near by
            if (this == floor.Character.Focus)
            {
                this.color = new Color(185, 185, 185);
                hasFocus(floor);
            }
            else
                this.color = Color.White;

        }

        protected virtual void hasFocus(Floor floor)
        {
        }
    }
}
