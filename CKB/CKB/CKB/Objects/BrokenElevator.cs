using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CKB
{
    public class BrokenElevator : Object
    {
        public BrokenElevator(float startPosX)
            : base(Image.Elevator, .18f, 0, Vector2.Zero)
        {
            this.Position = new Vector2(startPosX, Game1.View.Height - this.rec.Height);
        }

        protected override void hasFocus(Floor floor)
        {
            if (Input.actionBarPressed())
            {
                Game1.passMessage("OUT OF ORDER");
            }    
        }
    }
}
