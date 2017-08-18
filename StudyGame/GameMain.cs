using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

using StudyGame.Managers;

namespace StudyGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameMain : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        public GameMain()
        {
            graphics = new GraphicsDeviceManager(this);
            // Screen Size.
            // TODO: Viewport
            graphics.PreferredBackBufferHeight = (int)SceneManager.Instance.Dimensions.Y;
            graphics.PreferredBackBufferWidth = (int)SceneManager.Instance.Dimensions.X;
            //graphics.IsFullScreen = true;
            graphics.ApplyChanges();
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            // Calling SceneManager itens for load the content.
            SceneManager.Instance.GraphicsDevice = GraphicsDevice;
            SceneManager.Instance.SpriteBatch = spriteBatch;
            SceneManager.Instance.LoadContent(Content);

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // Dispose.
            SceneManager.Instance.Content.Unload();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // Update.
            SceneManager.Instance.Update(gameTime);
            //
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            SceneManager.Instance.GetCurrentScene();
            // TODO: Change 'spriteBatch.Begin' and 'spriteBatch.End' to their respective "correct positions"
            //spriteBatch.Begin();
            SceneManager.Instance.Draw(spriteBatch);
            //spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
