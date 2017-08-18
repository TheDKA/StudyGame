using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using MonoGame.Extended.BitmapFonts;
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
        private static Dictionary<string, BitmapFont> _allocFonts = new Dictionary<string, BitmapFont>();

        // ContentManager initializer.
        private static ContentManager _content = new ContentManager(SceneManager.Instance.Content.ServiceProvider, "Content");
        #endregion

        #region Methods
        // TODO: [ ] Create a new loading way
        public static Texture2D LoadBackgrounds(string fileName) => LoadResources($@"images/backgrounds/{fileName}");

        // TODO: [ ] Create a new loading way without use "optionalPath"
        public static Texture2D LoadSprites(string fileName, string optionalPath) => LoadResources($@"images/characters/{(optionalPath != null ? optionalPath + "/" : "")}{fileName}");

        public static BitmapFont LoadFont(string fileName) => LoadSpriteFont($@"fonts/{fileName}");

        public static Texture2D LoadResources(string fileName)
        {
            if (!_alloc.ContainsKey(fileName))
                    _alloc[fileName] = _content.Load<Texture2D>(fileName);

            return _alloc[fileName];
        }
        public static BitmapFont LoadSpriteFont(string fileName)
        {
            if (!_allocFonts.ContainsKey(fileName))
                    _allocFonts[fileName] = _content.Load<BitmapFont>(fileName);

            return _allocFonts[fileName];
        }
        #endregion
    }
}
