﻿using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

using StudyGame.Managers;

namespace StudyGame.Sprites
{
    public class Animation {

        #region Vars

        private ContentManager Content;

        private KeyboardState previousKbState;
        private KeyboardState currentKbState;

        private Texture2D texture;

        private Rectangle sourceRect;

        private Vector2 position;

        private float elapsed;
        private float frameTime;

        private int framesNumber;
        private int currentFrame;
        private int frameWidth;
        private int frameHeight;
        #endregion


        #region Propertys
        public Vector2 Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }

        public Rectangle SourceRect
        {
            get
            {
                return sourceRect;
            }
            set
            {
                sourceRect = value;
            }
        }

        public float FrameTime
        {
            get
            {
                return frameTime;
            }
            set
            {
                frameTime = value;
            }
        }

        public Texture2D Texture
        {
            get
            {
                return texture;
            }
            set
            {
                texture = value;
            }
        }
        #endregion


        #region Methods
        public Animation(string asset, float frameSpeed, int framesNumber)
        {
            this.frameTime = frameSpeed;
            this.framesNumber = framesNumber;
            // Cast because the methods Load Sprites belong the type "object" and must be an explicit type method.
            this.texture = (Texture2D)ResourceManager.LoadSprites(asset, null);

            frameWidth = (texture.Width / framesNumber);
            frameHeight = (texture.Height);

        }

        public void LoadContent(ContentManager Content)
        {
            this.Content = new ContentManager(Content.ServiceProvider, "Content");
        }

        public void UnloadContent()
        {
            Content.Unload();
        }

        public void UpdateAnimation(GameTime gameTime)
        {
            previousKbState = currentKbState;
            currentKbState = Keyboard.GetState();

            sourceRect = new Rectangle((currentFrame * frameWidth), 0, frameWidth, frameHeight);

            // Reset position.
            // [ ] TODO: Fix Monogame input bug.

            if (currentKbState.GetPressedKeys().Length == 0)
            {
                if (currentFrame > 0 && currentFrame <= 4)
                    currentFrame = 2;

                else if (currentFrame > 12 && currentFrame <= 16)
                    currentFrame = 14;

                if (currentFrame > 4 && currentFrame <= 8)
                    currentFrame = 6;

                else if (currentFrame > 8 && currentFrame <= 12)
                    currentFrame = 10;
            }

            // Right edge collision.
            if (currentKbState.IsKeyDown(Keys.D))
            {
                if (position.X < 760)
                    position.X += frameTime;

                if (currentKbState != previousKbState)
                    currentFrame = 9;

                elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;

                if (elapsed > frameTime)
                {
                    currentFrame++;

                    if (currentFrame > 11)
                        currentFrame = 8;

                    elapsed = 0f;
                }

            }

            // Left edge collision.
            else if (currentKbState.IsKeyDown(Keys.A))
            {
                if (position.X > 10)
                    position.X -= frameTime;

                if (currentKbState != previousKbState)
                    currentFrame = 5;

                elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;

                if (elapsed > frameTime)
                {
                    currentFrame++;

                    if (currentFrame > 7)
                        currentFrame = 4;

                    elapsed = 0f;
                }
            }

            // Bottom edge collision.
            else if (currentKbState.IsKeyDown(Keys.S))
            {
                if (position.Y < 430)
                    position.Y += frameTime;

                if (currentKbState != previousKbState)
                    currentFrame = 1;

                elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;

                if (elapsed > frameTime)
                {
                    currentFrame++;

                    if (currentFrame > 3)
                        currentFrame = 1;

                    elapsed = 0f;
                }
            }

            // Top edge collision.
            if (currentKbState.IsKeyDown(Keys.W))
            {
                if (position.Y > 20)
                    position.Y -= frameTime;

                if (currentKbState != previousKbState)
                    currentFrame = 13;

                elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;

                if (elapsed > frameTime)
                {
                    currentFrame++;

                    if (currentFrame > 15)
                        currentFrame = 12;

                    elapsed = 0f;
                }
            }
        }
        #endregion
    }
}
