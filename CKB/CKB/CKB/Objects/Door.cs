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
    public  class Door : Object
    {
        private bool open;
        public bool Open
        {
            get
            {
                return open;
            }
            protected set
            {
                open = value;

                //Change texture
                switch (floorIndex)
                {
                    case 1:
                        if (value)
                            this.texture = Image.Floor1.DoorOpen;
                        else
                            this.texture = Image.Floor1.DoorClose;
                        break;

                    case 2:
                        if (value)
                            this.texture = Image.Floor2.DoorOpen;
                        else
                            this.texture = Image.Floor2.DoorClose;
                        break;

                    case 3:
                        if (value)
                            this.texture = Image.Floor3.DoorOpen;
                        else
                            this.texture = Image.Floor3.DoorClose;
                        break;

                    case 4:
                        if (value)
                            this.texture = Image.Floor4.DoorOpen;
                        else
                            this.texture = Image.Floor4.DoorClose;
                        break;
                }                

                //Rescale image
                rec.Height = height;
                float aspectRatio = (float)texture.Width / texture.Height;
                rec.Width = (int)(aspectRatio * rec.Height);

                this.Position = new Vector2(startPos - rec.Width, Game1.View.Height - this.rec.Height);
                
            }
        }
                
        private int height;
        private float startPos;

        private int floorIndex;

        float time;

        public Door(float startPosX, int floorIndex)
            : base(Image.Floor2.DoorOpen, .33f, 0, Vector2.Zero)
        {
            this.floorIndex = floorIndex;

            height = this.rec.Height;
            startPos = startPosX;
            Open = false;
        }

        public Door(float startPosX, int floorIndex, bool open)
            : base(Image.Floor2.DoorOpen, .33f, 0, Vector2.Zero)
        {
            this.floorIndex = floorIndex;

            height = this.rec.Height;
            startPos = startPosX;
            Open = open;
        }

        
        public override void update(GameTime gameTime, Floor floor)
        {
            base.update(gameTime, floor);

            time += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (time >= 1f)
            {
                Open = !Open;
                time = 0;
            }
        }

    }
}
