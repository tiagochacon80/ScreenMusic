using System;
using System.Collections.Generic;
using ScreenSound.Model;

namespace ScreenSound.Menus
{
    internal abstract class Menu
    {
        protected List<Band> bands;

        protected Menu(List<Band> bands)
        {
            this.bands = bands;
        }

        public abstract void Execute();
    }
}
