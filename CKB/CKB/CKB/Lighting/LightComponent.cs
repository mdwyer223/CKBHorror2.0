using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace CKB
{
    public class LightComponent : Microsoft.Xna.Framework.DrawableGameComponent
    {
        Lightmap map;
        SpriteBatch spriteBatch;

        public LightComponent(Game game)
            : base(game)
        {
        }

        public override void Initialize()
        {
            map = new Lightmap(5, 160, 96);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(Game1.GameDevice);
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            map.update(gameTime);
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            BlendState Multiply = new BlendState()
            {
                AlphaSourceBlend = Blend.DestinationAlpha,
                AlphaDestinationBlend = Blend.Zero,
                AlphaBlendFunction = BlendFunction.Add,
                ColorSourceBlend = Blend.DestinationColor,
                ColorDestinationBlend = Blend.Zero,
                //ColorBlendFunction = BlendFunction.Add
            };
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied);

            map.draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
