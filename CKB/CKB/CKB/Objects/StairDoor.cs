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
    public class StairDoor : Object
    {
        public StairDoor(float startPosX, int floorIndex)
            : base(Image.Floor2.DoorStair, .205f, 0, Vector2.Zero)
        {
            //Select texture
            switch (floorIndex)
            {
                case 1:
                    this.texture = Image.Floor1.DoorStair;
                    break;

                case 2:
                    this.texture = Image.Floor2.DoorStair;
                    break;

                case 3:
                    this.texture = Image.Floor3.DoorStair;
                    break;

                case 4:
                    this.texture = Image.Floor4.DoorStair;
                    break;
            }

            this.Position = new Vector2(startPosX, Game1.View.Height - this.rec.Height);
        }

        protected override void hasFocus(Floor floor)
        {
            if (Input.actionBarPressed())
            {

            }
        }

    }
}
