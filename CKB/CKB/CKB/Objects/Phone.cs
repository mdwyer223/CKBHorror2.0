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
    public class Phone : Object
    {
        public Phone(float startPosX)
            : base(Image.Object.Phone, .033f, 0, Vector2.Zero)
        {
            this.Position = new Vector2(startPosX, Game1.View.Height - Game1.View.Height * 0.21f);
        }

        public override void update(GameTime gameTime, Floor floor)
        {
            if (this == floor.Character.Focus)
            {
                if (Input.actionBarPressed())
                    SoundComponent.playEffect(Sound.Dialtone, .25f);
            }
            base.update(gameTime, floor);
        }
    }
}
