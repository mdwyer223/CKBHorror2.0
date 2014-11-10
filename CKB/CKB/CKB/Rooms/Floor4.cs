using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace CKB
{
    public class Floor4 : Floor
    {
        public Floor4()
            : base(Image.Floor4.Wall, Vector2.Zero)
        {
            objs.Add(new Elevator(130));

            objs.Add(new Trash(300, "YOu lik dis bUlding here?"));

            objs.Add(new StairDoor(2000, 4));
        }

        public override void update(GameTime gameTime)
        {
            if (Input.escapePressed())
                Game1.changeFloor(new Floor1(), Character);
            base.update(gameTime);
        }
    }
}
