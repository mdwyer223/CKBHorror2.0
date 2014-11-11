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
    public class Trash : Object
    {
        string message;

        public Trash(float startPosX, string message)
            : base(Image.Object.Trash, .058f, 0, Vector2.Zero)
        {
            if (message == null)
                this.message = "Oops!";
            else
                this.message = message;

            this.Position = new Vector2(startPosX, Game1.View.Height - this.rec.Height);
        }

        public override void update(GameTime gameTime, Floor floor)
        {
            if (this == floor.Character.Focus)
            {
                if (Input.actionBarPressed() && !Game1.mBox.Visible)
                {
                    //play sound
                    SoundComponent.playEffect(Sound.Trash);
                    Game1.passMessage(this.message);
                }
            }
            base.update(gameTime, floor);
        }
    }
}
