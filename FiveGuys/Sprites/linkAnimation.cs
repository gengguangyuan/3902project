using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FiveGuys.Animation
{
    public class linkAnimation : Sprite
    {
        public void pickUp()
        {
            spriteLocationX = 213;
        }

        public void woodSwordright()
        {
            spriteLocationX = 1;
            spriteLocationY = 77;
            this.origin = new Vector2(1, 77);
        }

        public void woodSwordup()
        {
            spriteLocationX = 1;
            spriteLocationY = 109;
            this.origin = new Vector2(1, 124);
        }

        public void woodSwordleft()
        {
            spriteLocationX = 16;
            spriteLocationY = 77;
            this.origin = new Vector2(1, 77);
        }

        public void woodSwordDown()
        {
            spriteLocationX = 1;
            spriteLocationY = 47;
            this.origin = new Vector2(1, 47);
        }

        public void right()
        {
            spriteLocationX = 35;
        }

        public void up()
        {
            spriteLocationX = 69;
        }

        public void left()
        {
            spriteLocationX = 50;
            width = -width;
        }

        public linkAnimation(Texture2D texture, Vector2 position) : base(texture, position)
        {
            frameTime = 0.4;
            totalFrames = 2;
            width = 16;
            height = 16;
            gap = 1;
            spriteLocationX = 1;
            spriteLocationY = 11;
            this.origin = new Vector2(spriteLocationX, spriteLocationY);
        }
    }
}
