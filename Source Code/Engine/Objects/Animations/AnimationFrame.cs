﻿using Microsoft.Xna.Framework;
using System;

namespace Engine2D.Objects.Animations
{
    public class AnimationFrame
    {
        public Rectangle SourceRectangle { get; private set; }
        public int Lifespan { get; private set; }

        public AnimationFrame(Rectangle sourceRectangle, int lifespan)
        {
            SourceRectangle = sourceRectangle;
            Lifespan = lifespan;
        }
    }
}
