using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using StudyGame.Characters;
using StudyGame.Managers;


namespace StudyGame.Scenes
{
    public class SceneGame : SceneBase
    {
        private Player _player;
        private Texture2D Texture;
        private SpriteFont spriteFont;

        // Position aqui vai se referir a posição do player que está na classe Player.
        public static Vector2 Position { get; set; }
        #region Methods
        public override void LoadContent()
        {
            base.LoadContent();
            _player = new Player(ResourceManager.LoadSprites("girl"), "Garota");
            Texture = _player.Texture;
            spriteFont = ResourceManager.LoadFont("Arial");
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
            spriteBatch.Draw(Texture, Position, Color.White);
            spriteBatch.DrawString(spriteFont, _player.Name, new Vector2(Position.X + 50, Position.Y), Color.White);
            spriteBatch.End();

        }
        #endregion
    }
}
