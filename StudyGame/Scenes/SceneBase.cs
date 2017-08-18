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

namespace StudyGame.Scenes
{
    public abstract class SceneBase
    {
        #region Variables
        public ContentManager Content;
        #endregion

        #region Methods
        public virtual void LoadContent()
        {
            this.Content = new ContentManager(SceneManager.Instance.Content.ServiceProvider, "Content");
        }

        public virtual void UnloadContent()
        {
            Content.Unload();
        }

        public virtual void Update(GameTime gameTime)
        {
            //InputManager.Instance.Update();
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
        }
        #endregion
    }
}
