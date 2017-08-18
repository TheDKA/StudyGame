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
        private Texture2D _girl;
        #endregion

        #region Methods
        public override void LoadContent()
        {
            base.LoadContent();
            _background = ImageManager.LoadBackgrounds("splashscreen");
            _girl = ImageManager.LoadSprites("girl");
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
            spriteBatch.Draw(_girl, new Vector2(500, 60), Color.White);
            spriteBatch.End();
        }
        #endregion
    }
}
