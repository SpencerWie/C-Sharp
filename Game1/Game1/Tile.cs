using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Tile
    {
        public Vector2 destPos;
        public Vector2 sourcePos;
        public int size;

        public Tile(Vector2 destPos, Vector2 sourcePos, int size)
        {
            this.destPos = destPos;
            this.sourcePos = sourcePos;
            this.size = size;
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D tilemap, int drawSize)
        {
            spriteBatch.Draw(tilemap, new Rectangle((int)destPos.X, (int)destPos.Y, drawSize, drawSize), 
                                      new Rectangle((int)sourcePos.X, (int)sourcePos.Y, size, size), Color.White);
        }
        
    }
}
