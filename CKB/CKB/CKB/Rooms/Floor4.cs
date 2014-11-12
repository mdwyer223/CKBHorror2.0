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
        bool turnedOffLights = false;
        public Floor4()
            : base(Image.Floor4.Wall, Vector2.Zero)
        {
            objs.Add(new Elevator(130));

            objs.Add(new Trash(300));
            objs.Add(new Door(800, 4));
            objs.Add(new Trash(1900, "YOu lik dis bUlding here?"));

            objs.Add(new StairDoor(2000, 4));
        }

        public override void update(GameTime gameTime)
        {
            if (Input.escapePressed())
                Game1.changeFloor(new Floor1());
            base.update(gameTime);

            if (Character.Position.X < 1000 && !turnedOffLights)
            {
                LightComponent.turnOffLights();
                Sound.HighPitchScream.Play();
                Sound.SmallScream.Play();
                turnedOffLights = true;
            }
        }
    }
}
