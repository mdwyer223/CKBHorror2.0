using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace CKB
{
    public class Floor2 : Floor
    {
        public Floor2()
            : base(Image.Floor2.Wall, Vector2.Zero)
        {
            objs.Add(new Elevator(130));

            objs.Add(new Phone(400));
            objs.Add(new Trash(300, "Don't go to the top floor whatever you do."));
            objs.Add(new Door(700, 2));

            objs.Add(new StairDoor(2000, 2));
            
        }

        public override void update(GameTime gameTime)
        {
            if (Input.escapePressed())
                Game1.changeFloor(new Floor3(), Character);
            base.update(gameTime);
        }
    }
}
