using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace CKB
{
    public class Floor3 : Floor
    {
        public Floor3()
            : base(Image.Floor3.Wall, Vector2.Zero)
        {
            objs.Add(new Elevator(130));

            objs.Add(new StairDoor(2000, 3));
        }

        public override void update(GameTime gameTime)
        {
            if (Input.escapePressed())
                Game1.changeFloor(new Floor4(), Character);
            base.update(gameTime);
        }
    }
}
