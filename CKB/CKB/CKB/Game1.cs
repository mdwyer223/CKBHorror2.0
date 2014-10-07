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
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        static Floor f;
        Vector2 testPos = new Vector2(400, 240);
        LightTile tileTest1, tileTest2, tileTest3, tileTest4;
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
            Components.Add(lights);
            f = new Floor1();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            tileTest1 = new LightTile(240, Vector2.Zero);
            tileTest2 = new LightTile(240, new Vector2(0, 240));
            tileTest3 = new LightTile(240, new Vector2(240, 0));
            tileTest4 = new LightTile(240, new Vector2(240, 240));

            map = new Lightmap(40, 40, 12);
        }

        protected override void UnloadContent()
        {
            
        }

        protected override void Update(GameTime gameTime)
        {
            Input.Update();
            map.update(gameTime);
            tileTest1.update(gameTime);
            tileTest2.update(gameTime);
            tileTest3.update(gameTime);
            tileTest4.update(gameTime);

            if (Input.rightDown())
                testPos.X += 1;
            if (Input.leftDown())
                testPos.X -= 1;
            if (Input.upDown())
            {
                if (!lookingUp)
                {
                    testPos.Y = testPos.Y -= 45;
                    lookingUp = true;
                }
            }
            else
            {
                if(lookingUp)
                    testPos.Y += 45;
                lookingUp = false;
            }

            Game1.Camera.Focus = testPos;
            Game1.Camera.MoveSpeed = 1;

            f.update(gameTime);

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

            spriteBatch.Draw(Image.Particle, new Rectangle((int)testPos.X, (int)testPos.Y, 20, 20), Color.Blue);
            //tileTest1.draw(spriteBatch);
            //tileTest2.draw(spriteBatch);
            //tileTest3.draw(spriteBatch);
            //tileTest4.draw(spriteBatch);
            //map.draw(spriteBatch);
            spriteBatch.Draw(Image.Particle, new Rectangle((int)Input.mousePos().X, (int)Input.mousePos().Y, 20, 20), Color.White);

            spriteBatch.End();

            base.Draw(gameTime);

        }

        public static void changeFloor(Floor newF)
        {
            f = newF;
        }
    }
}
