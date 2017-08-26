using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

using StudyGame.Managers;

namespace StudyGame.Scenes
{
    public class SceneSplash : SceneBase
    {
        #region Methods
        public override void LoadContent()
        {
            base.LoadContent();
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
            //spriteBatch.Begin();
            //spriteBatch.End();

            base.Draw(spriteBatch);
        }
        #endregion
    }
}
