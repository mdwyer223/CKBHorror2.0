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
        static Lightmap map;
        SpriteBatch spriteBatch;
        static List<Light> lights = new List<Light>();

        public LightComponent(Game game)
            : base(game)
        {
        }

        public override void Initialize()
        {
            Random rand = new Random();
            map = new Lightmap(12, 67, 40);//15,54,32
            lights.Add(new Light(true));
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
            map.update(gameTime, lights);
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

        public static void passLights(List<Light> newLights)
        {
            lights.Clear();
            map = new Lightmap(12, 67, 40);
            lights.Add(new Light(true));
            foreach (Light l in newLights)
            {
                lights.Add(l);
            }
        }
    }
}
