﻿using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Engine2D.Input
{
    public class BaseInputMapper
    {
        public virtual IEnumerable<BaseInputCommand> GetKeyboardState(KeyboardState state)
        {
            return new List<BaseInputCommand>();
        }

        public virtual IEnumerable<BaseInputCommand> GetMouseState(MouseState state)
        {
            return new List<BaseInputCommand>();
        }

        public virtual IEnumerable<BaseInputCommand> GetGamePadState(GamePadState state)
        {
            return new List<BaseInputCommand>();
        }
    }
}
