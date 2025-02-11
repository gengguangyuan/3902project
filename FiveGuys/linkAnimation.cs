using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FiveGuys
{
    internal class linkAnimation : spriteAnimation
    {

        public linkAnimation(Texture2D texture, Vector2 position) : base(texture, position)
        {
            this.frameTime = 0.15;
            this.totalFrames = 4;
            this.width = 99;
            this.height = 131;
            this.gap = 2;
            this.spriteLocationX = 0;
            this.spriteLocationY = 9;

        }
    }
}
