using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

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
        List<Light> lights = new List<Light>();

        public LightComponent(Game game)
            : base(game)
        {
        }

        public override void Initialize()
        {
            Random rand = new Random();
            map = new Lightmap(15, 54, 32);
            //for (int i = 0; i < 8; i++)
            //{
            //    lights.Add(new Light(new Vector2(i * 800, 240), .8f));
            //}
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(Game1.GameDevice);
            base.LoadContent();
        }

        public virtual void LoadContent(int x)
        {
            spriteBatch = new SpriteBatch(Game1.GameDevice);
        }

        public virtual void Update()
        {
            GameTime gameTime = new GameTime();
            while (true)
            {
                map.update(gameTime, lights);

                Thread.Sleep(16);
            }
        }

        public override void Update(GameTime gameTime)
        {
            map.update(gameTime, lights);
            base.Update(gameTime);
        }

        public virtual void Draw()
        {
            while (true)
            {
                spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied);

                map.draw(spriteBatch);

                spriteBatch.End();

                Thread.Sleep(16);
            }
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
                ColorBlendFunction = BlendFunction.Add
            };
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied);

            map.draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
