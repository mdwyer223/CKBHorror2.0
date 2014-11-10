﻿using System;
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
            objs.Add(new Trash(300));
            objs.Add(new Door(700, 2));

            objs.Add(new StairDoor(1200, 2));
            
        }

        public override void update(GameTime gameTime)
        {
            if (Input.escapePressed())
                Game1.changeFloor(new Floor3(), Character);
            base.update(gameTime);
        }
    }
}
