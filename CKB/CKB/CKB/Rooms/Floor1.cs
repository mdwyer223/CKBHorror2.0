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
            : base(Image.Floor2.Wall, Vector2.Zero)
        {
            color = Color.White;

            objs.Add(new Phone(400));
            objs.Add(new Trash(300));
        }

        public override void update(GameTime gameTime)
        {
            if (Input.actionBarPressed())
                Game1.changeFloor(new Floor2());
            base.update(gameTime);
        }
    }
}
