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
        bool listen;
        int floorIndex;

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

            this.floorIndex = floorIndex;
            this.Position = new Vector2(startPosX, Game1.View.Height - this.rec.Height);
            listen = false;
        }

        protected override void hasFocus(Floor floor)
        {
            string response = "";
            List<string> options = new List<string>();
            options.Add("Up");
            options.Add("Down");

            if (!listen && Input.actionBarPressed())
            {
                Game1.passMessage("Up or down?", options);
                listen = true;
            }
            
            //Read answer
            if (!Game1.mBox.Visible && listen)
            {
                response = options[Game1.mBox.OptionIndex];
                listen = false;

                //react to answer
                if (response == "Up")
                    floorIndex++;
                else if (response == "Down")
                    floorIndex--;

                switch (floorIndex)
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
                Game1.hideMessage();
            }            

        }

    }
}
