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
        public enum Emotions
        {
            Teste
        }
        //private Player _player;
        private Character _character;
        private Texture2D Texture;
        private SpriteFont spriteFont;

        public static Vector2 Position { get; set; }
        #region Methods
        public override void LoadContent()
        {
            base.LoadContent();
            _character = new Character("Garota");

            // TODO: 1- Do it another way; 2- Try to start this in the constructor
            _character.en = Enums.Emotions.Normal;

            // Only for test purposes.
            switch (_character.en) {

                case Enums.Emotions.Normal: Texture = _character.Texture[0]; break;

                case Enums.Emotions.Happy: Texture = _character.Texture[1]; break;

                case Enums.Emotions.Surprised: Texture = _character.Texture[2]; break;

                case Enums.Emotions.Angry: Texture = _character.Texture[3]; break;

            }

            //Texture = _character.Texture;
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
            spriteBatch.DrawString(spriteFont, _character.Name, new Vector2(Position.X + 50, Position.Y), Color.White);
            spriteBatch.End();

        }
        #endregion
    }
}
