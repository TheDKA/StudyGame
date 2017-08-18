﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using StudyGame.Managers;

namespace StudyGame.Characters
{
    public abstract class CharacterBase
    {
        #region Variables
        public ContentManager Content;
        #endregion

        #region Fields
        public string Name { get; set; }
        #endregion

        #region Methods
        public CharacterBase(string _name)
        {
            Name = _name;
            // TODO
        }

        public CharacterBase(Texture2D texture)
        {
        }

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
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }
        #endregion
    }
}