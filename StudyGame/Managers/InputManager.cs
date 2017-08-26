using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace StudyGame.Managers
{
    public class InputManager
    {
        #region Variables
        private static InputManager _instance = null;
        //private KeyboardState _prevKeyState, _currentKeyState;
        #endregion

        #region Fields
        // Create an InputManager instance.
        public static InputManager Instance {
            get {
                if (_instance == null) {
                    return new InputManager();
                }
                return _instance;
            }
        }
        #endregion

        #region Methods



        // TODO: Key Methods

        // Image.Position += Velocity
        //public void Update()
        //{

        //}
        #endregion
    }
}
