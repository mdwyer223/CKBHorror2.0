using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace CKB
{
    public class Floor1 : Floor
    {
        public Floor1()
            : base(Image.Floor1, Vector2.Zero)
        {
            color = Color.White;
        }

        public override void update(GameTime gameTime)
        {
            if (Input.actionBarPressed())
                Game1.changeFloor(new Floor2());
            base.update(gameTime);
        }
    }
}
