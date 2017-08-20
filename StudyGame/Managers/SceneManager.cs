using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MonoGame.Extended;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using StudyGame.Scenes;

namespace StudyGame.Managers
{
    public class SceneManager
    {
        #region Variables
        public GraphicsDevice GraphicsDevice;
        public SpriteBatch SpriteBatch;

        //private InputManager Input;

        private SceneBase _currentScene;
        private SceneBase _newScene;
        private SceneGame _bgScene;

        private static SceneManager _instance;
        #endregion

        #region Fields
        public Vector2 Dimensions { get; private set; }
        public ContentManager Content { get; private set; }
        public static SceneManager Instance {
            get {
                if (_instance == null) {
                    _instance = new SceneManager();
                }

                return _instance;
            }
        }
        #endregion

        #region Methods
        public SceneManager()
        {
            // TODO: Viewport
            Dimensions = new Vector2(800, 600);
            _currentScene = new SceneSplash();
            _bgScene = new SceneGame();
        }

        public SceneBase GetCurrentScene() => _currentScene;

        public void LoadContent(ContentManager Content)
        {
            this.Content = new ContentManager(Content.ServiceProvider, "Content");
            _currentScene.LoadContent();
            _bgScene.LoadContent();
        }

        //public void UpdateFps(GameTime gameTime)
        //{
        //}

        public void Update(GameTime gameTime)
        {
            _currentScene.Update(gameTime);
            _bgScene.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            _currentScene.Draw(spriteBatch);
            _bgScene.Draw(spriteBatch);
        }

        public void ChangeScene(string newScene)
        {
            // Create new Scenes.
            _newScene = (SceneBase)Activator.CreateInstance(Type.GetType($"StudyGame.Scenes.{newScene}"));
        }
        #endregion
    }
}
