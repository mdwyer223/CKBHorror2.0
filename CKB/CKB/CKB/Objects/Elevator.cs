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
    public class Elevator : Object
    {
        public Elevator(float startPosX)
            : base(Image.Elevator, .18f, 0, Vector2.Zero)
        {
            this.Position = new Vector2(startPosX, Game1.View.Height - this.rec.Height);
        }

    }
}
