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
    public class MessObject : Object
    {
        int messIndex;
        List<string> messages;

        public MessObject(Texture2D texture, float scaleFactor, float secondsToCrossScreen, Vector2 startPos, string mess)
            : base(texture, scaleFactor, secondsToCrossScreen, startPos)
        {
            messages = new List<string>();
            messages.Add(mess);
        }

        public MessObject(Texture2D texture, float scaleFactor, float secondsToCrossScreen, Vector2 startPos, List<string> mess)
            : base(texture, scaleFactor, secondsToCrossScreen, startPos)
        {
            messages = new List<string>();
            messages = mess;
        }

        protected override void hasFocus(Floor floor)
        {
            if (messages[0] == "")
                return;

            //Show message
            if (!listening && Input.actionBarPressed())
            {
                messIndex %= messages.Count;               

                title = messages[messIndex];
                Game1.passMessage(title);
                listening = true;
            }

            //Hide message
            if (!Game1.mBox.Visible && listening)
            {
                messIndex++;
                if (Input.actionBarPressed())
                {                    
                    if (messIndex >= messages.Count)
                        listening = false;
                    else
                    {
                        title = messages[messIndex];
                        Game1.passMessage(title);
                    }
                }      
                
            }


        }

    }
}
