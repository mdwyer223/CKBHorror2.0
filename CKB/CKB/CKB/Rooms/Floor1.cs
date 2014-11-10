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
            : base(Image.Floor1.Wall, Vector2.Zero)
        {
            objs.Add(new Elevator(130));

            objs.Add(new Phone(400));

            objs.Add(new StairDoor(1200, 1));
        }

        public override void update(GameTime gameTime)
        {
            if (Input.escapePressed())
                Game1.changeFloor(new Floor2(), Character);
            base.update(gameTime);
        }
    }
}
