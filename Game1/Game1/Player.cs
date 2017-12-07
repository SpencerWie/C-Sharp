using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Game1
{
    class Player
    {
        public Texture2D playerTexture;
        public int spriteSize;
        public double speed = 100.0;
        public Vector2 position;
        public Rectangle sourceRect;

        public int frameTicks = 0;
        public int animationSpeed = 5; // Number of frames per sprite change
        public int walkFrames = 8;

        public Player(Texture2D sprite, Vector2 pos, int size)
        {
            position = pos;
            spriteSize = size;
            sourceRect = new Rectangle(0, spriteSize * 2, spriteSize, spriteSize);
            playerTexture = sprite;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(playerTexture, position, sourceRect, Color.White);
        }

        public void Update(GameTime gameTime)
        {
            // Update Frame Ticks, note old position
            frameTicks++;
            float oldX = position.X;
            float oldY = position.Y;

            // Move Player

            if (Keyboard.GetState().IsKeyDown(Keys.Up) || Keyboard.GetState().IsKeyDown(Keys.W))
                Move(0, -(float)(speed * gameTime.ElapsedGameTime.TotalSeconds));

            else if (Keyboard.GetState().IsKeyDown(Keys.Down) || Keyboard.GetState().IsKeyDown(Keys.S))
                Move(0 , (float)(speed * gameTime.ElapsedGameTime.TotalSeconds));

            if (Keyboard.GetState().IsKeyDown(Keys.Left) || Keyboard.GetState().IsKeyDown(Keys.A))
                Move(-(float)(speed * gameTime.ElapsedGameTime.TotalSeconds), 0);

            else if (Keyboard.GetState().IsKeyDown(Keys.Right) || Keyboard.GetState().IsKeyDown(Keys.D))
                Move((float)(speed * gameTime.ElapsedGameTime.TotalSeconds), 0);

            // If not moved then reset ticks
            if (oldX == position.X && oldY == position.Y)
            {
                frameTicks = 0;
                sourceRect.X = 0;
            }

            // Move view by the different in player position.
            Scroller.Translate(position.X - oldX, position.Y - oldY);
        }

        // Handles movement and sprite animation based on movement
        public void Move(float moveX, float moveY)
        {
            position.X += moveX;
            position.Y += moveY;

            if (moveY < 0) sourceRect.Y = spriteSize * 8;
            else if (moveY > 0) sourceRect.Y = spriteSize * 10;

            if (moveX < 0) sourceRect.Y = spriteSize * 9;
            else if (moveX > 0) sourceRect.Y = spriteSize * 11;

            if (frameTicks > animationSpeed)
            {
                sourceRect.X += spriteSize;
                sourceRect.X = sourceRect.X % (walkFrames * spriteSize);
                frameTicks = 0;
            }
        } 
    }
}
