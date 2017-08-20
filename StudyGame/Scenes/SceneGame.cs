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
        ///private Player _player;
        private Character _character;
        private Texture2D Texture;
        private BitmapFont font;

        public static Vector2 Position { get; set; }
        #region Methods
        public override void LoadContent()
        {
            base.LoadContent();
            _character = new Character("Garota", Enums.Emotions.Happy);

            // TODO: 1[ ] Do it another way;

            // Only for test purposes.
            switch (_character._emotions) {
                case Enums.Emotions.Normal: Texture = _character.GirlSprites[0]; break;
                case Enums.Emotions.Happy: Texture = _character.GirlSprites[1];  break;
                case Enums.Emotions.Surprised: Texture = _character.GirlSprites[2]; break;
                case Enums.Emotions.Angry: Texture = _character.GirlSprites[3]; break;
            }

            //Texture = _character.Texture;
            font = ResourceManager.LoadFont("mechafont");
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
            spriteBatch.DrawString(font, _character.Name, new Vector2(Position.X + 50, Position.Y - 30), Color.White);
            spriteBatch.End();

        }
        #endregion
    }
}
