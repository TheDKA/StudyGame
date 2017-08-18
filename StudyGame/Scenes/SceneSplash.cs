using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

using StudyGame.Managers;

namespace StudyGame.Scenes
{
    public class SceneSplash : SceneBase
    {
        #region Variables
        // Textures.
        private Texture2D _background;
        #endregion

        #region Methods
        public override void LoadContent()
        {
            base.LoadContent();
            _background = ResourceManager.LoadBackgrounds("splashscreen");
        }

        public override void UnloadContent()
        {
            Content.Unload();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            spriteBatch.Begin();
            spriteBatch.Draw(_background, Vector2.Zero, Color.White);
            spriteBatch.End();
        }
        #endregion
    }
}
