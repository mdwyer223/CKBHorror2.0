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
    public class Phone : MessObject
    {
        public Phone(float startPosX)
            : base(Image.Object.Phone, .033f, 0, Vector2.Zero, Sound.Dialtone, "")
        {
            this.Position = new Vector2(startPosX, Game1.View.Height - Game1.View.Height * 0.21f);
        }

        public Phone(float startPosX, string mess)
            : base(Image.Object.Phone, .033f, 0, Vector2.Zero, Sound.Dialtone, mess)
        {
            this.Position = new Vector2(startPosX, Game1.View.Height - Game1.View.Height * 0.21f);
        }

        public Phone(float startPosX, List<string> mess)
            : base(Image.Object.Phone, .033f, 0, Vector2.Zero, Sound.Dialtone, mess)
        {
            this.Position = new Vector2(startPosX, Game1.View.Height - Game1.View.Height * 0.21f);
        }
        // SoundComponent.playEffect(Sound.Dialtone, .25f);
    }
}
