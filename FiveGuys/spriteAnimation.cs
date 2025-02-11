using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace FiveGuys
{
    internal class spriteAnimation
    {
        protected int currentFrame;
        protected int totalFrames;
        protected int height;
        protected int width;
        protected int spriteLocationX;
        protected int spriteLocationY;
        protected int gap;
        protected double frameTime;
        protected double timeElapsed;
        public Texture2D texture { get; private set; }
        public Vector2 position { get; private set; }

        public void setPosition(Vector2 newPos)
        {
            position = newPos;
        }

        public Rectangle DestRect
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, width, height);
            }
        }

        public Rectangle SourceRect
        {
            get
            {
                return new Rectangle(spriteLocationX + gap * (currentFrame + 1) + width * currentFrame, spriteLocationY, width, height);
            }
        }

        public void Update(GameTime gt)
        {

            timeElapsed += gt.ElapsedGameTime.TotalSeconds;
            if (timeElapsed >= frameTime)
            {
                timeElapsed -= frameTime;
                currentFrame++;

                if (currentFrame >= totalFrames)
                {
                    currentFrame = 0;
                }
            }

        }

        public spriteAnimation(Texture2D texture, Vector2 position)
        {

            this.texture = texture;
            this.position = position;
            this.timeElapsed = 0;
            this.currentFrame = 0;

        }
    }
}
