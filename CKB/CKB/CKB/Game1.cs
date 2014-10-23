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
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        static Floor f;
        Character c;
        Vector2 testPos = new Vector2(400, 240);
        Lightmap map;
        bool lookingUp = false;

        LightComponent lights;

        public SpriteBatch SpriteBatch
        {
            get { return spriteBatch; }
        }

        static GameState mainGameState = GameState.PLAYING;
        public static GameState State
        {
            get { return mainGameState; }
        }

        static Camera2D camera;
        public static Camera2D Camera
        {
            get { return camera; }
        }

        static ContentManager otherContent;
        public static ContentManager GameContent
        {
            get { return otherContent; }
        }

        static GraphicsDevice otherDevice;
        public static GraphicsDevice GameDevice
        {
            get { return otherDevice; }
        }
        public static Viewport View
        {
            get { return otherDevice.Viewport; }

        }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            otherContent = new ContentManager(Content.ServiceProvider);
            otherContent.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            otherDevice = this.GraphicsDevice;
            camera = new Camera2D(this);
            Components.Add(camera);
            lights = new LightComponent(this);
            lights = new LightComponent(this);
            Components.Add(lights);
            f = new Floor1();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            map = new Lightmap(40, 40, 12);

            c = new Character();
        }

        protected override void UnloadContent()
        {
            
        }

        protected override void Update(GameTime gameTime)
        {
            Input.Update();

            Game1.Camera.Focus = new Vector2(400, 240);
            Game1.Camera.MoveSpeed = c.Speed;

            f.update(gameTime);
            c.update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            RasterizerState rs = new RasterizerState();
            rs.CullMode = CullMode.None;

            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.LinearClamp,
                DepthStencilState.Default, rs, null, Game1.Camera.Transform);

            f.draw(spriteBatch);

            c.draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);

        }

        public static void changeFloor(Floor newF)
        {
            f = newF;
        }
    }
}
