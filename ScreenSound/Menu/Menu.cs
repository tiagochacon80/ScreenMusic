using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menu
{
    internal class Menu
    {
        public abstract class Menu
        {
            protected List<Band> bands = new List<Band> ();

            public abstract void Execute();
        }
    }
}
