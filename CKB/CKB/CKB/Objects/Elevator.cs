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

            title = "Select a floor";
            options.Add("1");
            options.Add("2");
            options.Add("3");
            options.Add("4");
        }
        
        protected override void respond(Floor floor, int resIndex)
        {
            //react to answer
            switch (resIndex + 1)
            {
                case 1:
                    Game1.changeFloor(new Floor1(), floor.Character);
                    break;

                case 2:
                    Game1.changeFloor(new Floor2(), floor.Character);
                    break;

                case 3:
                    Game1.changeFloor(new Floor3(), floor.Character);
                    break;

                case 4:
                    Game1.changeFloor(new Floor4(), floor.Character);
                    break;
            }
        }
    }
}
