using System;
using System.Collections.Generic;
using System.Diagnostics; // Debug

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using MonoGame.Extended.BitmapFonts;

namespace StudyGame.Managers
{
    public static class ResourceManager
    {
        #region Variables
        // Dictionary for allocate the resources path and your content.
        private static Dictionary<string, object> _alloc = new Dictionary<string, object>();
        private static Dictionary<string, BitmapFont> _allocFonts = new Dictionary<string, BitmapFont>();

        // ContentManager initializer.
        private static ContentManager _content = new ContentManager(SceneManager.Instance.Content.ServiceProvider, "Content");
        #endregion

        #region Methods
        // TODO: [ ] Create a new loading way
        public static object LoadBackgrounds(string fileName) => LoadResources($@"images/backgrounds/{fileName}", "sprite");

        // TODO: [ ] Create a new loading way without use "optionalPath"
        public static object LoadSprites(string fileName, string optionalPath) => LoadResources($@"images/characters/{(optionalPath != null ? optionalPath + "/" : "")}{fileName}", "sprite");

        public static object LoadFont(string fileName) => LoadResources($@"fonts/{fileName}", "font");

        public static object LoadResources(string fileName, string type)
        {
            if (!_alloc.ContainsKey(fileName))
                if (type == "sprite")
                    _alloc[fileName] = _content.Load<Texture2D>(fileName);
                else if (type == "font")
                    _alloc[fileName] = _content.Load<BitmapFont>(fileName);

            return _alloc[fileName];
        }
        #endregion
    }
}
