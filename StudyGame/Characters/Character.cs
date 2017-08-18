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
        #endregion

        #region Fields
        public List<Texture2D> GirlSprites { get { return Girl; } }
        #endregion

        #region Methods
        public Character(string name, Enums.Emotions emotion) : base(name, emotion)
        {
            SceneGame.Position = new Vector2(300, 150);
            Girl = GirlSprites;
            _emotions = emotion;
        }

        //--------------------------
        // Only for test purproses.

        private List<Texture2D> Girl = new List<Texture2D>()
        {
            ResourceManager.LoadSprites("girl_normal", "girl1"),
            ResourceManager.LoadSprites("girl_happy", "girl1"),
            ResourceManager.LoadSprites("girl_surprise", "girl1"),
            ResourceManager.LoadSprites("girl_angry", "girl1"),
        };

        private List<Texture2D> Concept = new List<Texture2D>()
        {

        };
        #endregion
    }
}
