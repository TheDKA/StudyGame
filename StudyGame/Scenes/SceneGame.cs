using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using MonoGame.Extended.Content;
using MonoGame.Extended;
using MonoGame.Extended.BitmapFonts;

using StudyGame.Characters;
using StudyGame.Managers;
using StudyGame.Sprites;

namespace StudyGame.Scenes
{
    public class SceneGame : SceneBase
    {
        private Animation animation;

        #region Methods
        public override void LoadContent()
        {
            base.LoadContent();
            animation = new Animation("troy", 1f, 16);
        }

        public override void UnloadContent()
        {

            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
            animation.UpdateAnimation(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);           
            spriteBatch.Draw(animation.Texture, animation.Position, animation.SourceRect,
                Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 1f);
        }
        #endregion
    }
}
