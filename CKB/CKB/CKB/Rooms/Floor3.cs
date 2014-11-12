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
        float lightsOffTimer = 0, timeOff = 3;
        bool lightsOff = false;
        public Floor3()
            : base(Image.Floor3.Wall, Vector2.Zero)
        {
            objs.Add(new BrokenElevator(130));
            objs.Add(new Phone(300));
            objs.Add(new Trash(600, "You should turn around"));
            objs.Add(new Trash(900, "She is coming after you...\nI am coming after you\nWe are all coming after you"));
            //objs.Add(new Trash(1900, "Didn't I say not to go to the top floor?"));
            objs.Add(new StairDoor(2000, 3));
        }

        public override void update(GameTime gameTime)
        {
            if (Input.escapePressed())
                Game1.changeFloor(new Floor4());
            if (Character.Position.X > 700 && !lightsOff)
            {
                lightsOff = true;
                LightComponent.turnOffLights();
            }
            if(lightsOff)
                lightsOffTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (lightsOffTimer > timeOff)
            {
                LightComponent.turnLightOn();
            }
            base.update(gameTime);
        }
    }
}
