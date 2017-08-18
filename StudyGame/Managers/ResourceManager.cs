using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace StudyGame.Managers
{
    public static class ResourceManager
    {
        #region Variables
        // Dictionary for allocate the resources path and your content.
        private static Dictionary<string, Texture2D> _alloc = new Dictionary<string, Texture2D>();
        private static Dictionary<string, SpriteFont> _allocFonts = new Dictionary<string, SpriteFont>();

        // ContentManager initializer.
        private static ContentManager _content = new ContentManager(SceneManager.Instance.Content.ServiceProvider, "Content");
        #endregion

        #region Methods
        public static Texture2D LoadBackgrounds(string fileName) => LoadResources($@"images/backgrounds/{fileName}");

        public static Texture2D LoadSprites(string fileName) => LoadResources($@"images/characters/{fileName}");

        public static SpriteFont LoadFont(string fileName)
        {
            return LoadSpriteFont($@"fonts/{fileName}");
        }

        public static Texture2D LoadResources(string fileName)
        {
            if (!_alloc.ContainsKey(fileName)) {
                try {
                    _alloc[fileName] = _content.Load<Texture2D>(fileName);
                }
                catch (Exception ex) {
                    Debug.WriteLine(ex.ToString());
                }
            }
            return _alloc[fileName];
        }

        public static SpriteFont LoadSpriteFont(string fileName)
        {
            if (!_allocFonts.ContainsKey(fileName)) {
                try {
                    _allocFonts[fileName] = _content.Load<SpriteFont>(fileName);
                }
                catch (Exception ex) {
                    Debug.WriteLine(ex.ToString());
                }
            }
            return _allocFonts[fileName];
        }
        #endregion
    }
}
