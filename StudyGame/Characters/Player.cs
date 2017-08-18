using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using StudyGame.Managers;
using StudyGame.Scenes;

namespace StudyGame.Characters
{
    public class Player : CharacterBase
    {
        //origin var

        private Texture2D _texture;
        public Texture2D Texture { get { return _texture; } }

        /// <summary>
        /// Player Constructor.
        /// </summary>
        /// <param name="texture">Texture that will be load when player class be instantiated.</param>
        public Player(Texture2D texture) : base(texture)
        {
            this._texture = texture;
            //SceneGame.Position = new Vector2(300, 150);
        }
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
        }
    }
}
