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
        private Texture2D _texture;
        public Texture2D Texture { get { return _texture; } }
        /// <summary>
        /// Player Constructor.
        /// </summary>
        /// <param name="texture">Textura que vai ser carregada na hora de instanciar a classe player.</param>
        /// <param name="_name">"Nome" da textura em questão.</param>
        public Player(Texture2D texture, string _name) : base(texture, _name)
        {
            this._texture = texture;
            SceneGame.Position = new Vector2(300, 150);
            // TODO
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
