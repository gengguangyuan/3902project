using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    internal class Goku : Sprite
    {

        
        private bool frameIncreasing;
        private bool isAnimated;
        private bool isMoving;
        private bool movingRight;
        private bool isMovingUp;
        protected double timeElapsedMoving;



        public new void Update(GameTime gt)
        {
            timeElapsed += gt.ElapsedGameTime.TotalSeconds;
            if (isAnimated){
                if (timeElapsed >= frameTime) {
                    timeElapsed -= frameTime;
                    if (frameIncreasing)
                    {
                        currentFrame++;
                    }
                    else
                    {
                        currentFrame--;
                    }
                    if (currentFrame >= totalFrames - 1 || currentFrame <= 0)
                    {
                        frameIncreasing = !frameIncreasing;
                    }
                }
            }

            Vector2 newPos = position;
            if (isMoving)
            {
                timeElapsedMoving += gt.ElapsedGameTime.TotalSeconds;
                if (timeElapsedMoving >= .5)
                {
                    movingRight = !movingRight;
                    timeElapsedMoving = 0;
                }
                if (movingRight)
                {
                    newPos.X += 5;
                }
                else
                {
                    newPos.X -= 5;
                }
            }
            else if (isMovingUp)
            {
                timeElapsedMoving += gt.ElapsedGameTime.TotalSeconds;
                if (timeElapsedMoving >= .5)
                {
                    movingRight = !movingRight;
                    timeElapsedMoving = 0;
                }
                if (movingRight)
                {
                    newPos.Y += 5;
                }
                else
                {
                    newPos.Y -= 5;
                }
            }
            setPosition( newPos );

        }

        public void startMotion() 
        {
            isMoving = true;
        }
        public void startMotionUp()
        {
            isMovingUp = true;
        }

        public void stopMotion() 
        {
            isMoving = false;
            isMovingUp = false;
        }

        public void animate(){ isAnimated = true; }
        public void unAnimate() { isAnimated = false; }
        public Goku(Texture2D texture, Vector2 position) : base(texture, position) 
        {
            this.frameTime = 0.15;
            this.totalFrames = 4;
            this.width = 99;
            this.height = 131;
            this.frameIncreasing = true;
            this.gap = 2;
            this.spriteLocation = 9;
            this.timeElapsedMoving = 0;
            this.isAnimated = false;
        }

    }
}
