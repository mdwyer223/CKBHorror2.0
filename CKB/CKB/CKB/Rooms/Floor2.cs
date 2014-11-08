using System;
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
            : base(Image.Floor3.Wall, Vector2.Zero)
        {
            color = Color.Green;
        }
    }
}
