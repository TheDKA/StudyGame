using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace GameProject.Sprites
{
    public class Animation
    {
        private ContentManager Content;

        public int ticksPassed { get; set; }
        public int index { get; set; }
        public int updateRate { get; set; }
        public Animation(int updateRate, SpriteBatch[] sprites)
        {
            this.ticksPassed = 0;
            this.updateRate = updateRate;
        }
        public void LoadContent()
        {
            this.Content = new ContentManager(Content.ServiceProvider, "Content");
        }
        public void Update(GameTime gameTime)
        {
            ticksPassed++;

            if (ticksPassed > updateRate) {
                ticksPassed = 0;
            }
        }

        public void ChangeSprite()
        {

        }
    }
}
