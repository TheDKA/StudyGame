using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MonoGame.Extended.Content;
using MonoGame.Extended;
using MonoGame.Extended.BitmapFonts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using StudyGame.Characters;
using StudyGame.Managers;

namespace StudyGame.Scenes
{
    public class SceneGame : SceneBase
    {
        //private Player _player;

        public static Vector2 Position { get; set; }
        #region Methods
        public override void LoadContent()
        {
            base.LoadContent();

        }

        public override void UnloadContent()
        {

            base.UnloadContent();

        }

        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            spriteBatch.Begin();            
            spriteBatch.End();

        }
        #endregion
    }
}
