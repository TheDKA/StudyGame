using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using StudyGame.Scenes;
using StudyGame.Managers;

namespace StudyGame.Characters
{
    public class Character : CharacterBase
    {
        //public IEnum.Emotions Test { get; set; }
        #region Variables
        public Enums.Emotions en;
        #endregion

        #region Fields
        public List<Texture2D> Texture { get { return Textures; } }
        #endregion

        #region Methods
        public Character(string name) : base(name)
        {
            SceneGame.Position = new Vector2(300, 150);
            Textures = Texture;
        }

        private List<Texture2D> Textures = new List<Texture2D>()
        {
            ResourceManager.LoadSprites("normal"),
            ResourceManager.LoadSprites("happy"),
            ResourceManager.LoadSprites("surprise"),
            ResourceManager.LoadSprites("angry")
        };
        #endregion
    }
}
