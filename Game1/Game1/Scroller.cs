using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    static class Scroller
    {
        public static float X;
        public static float Y;

        public static void Translate(float x, float y)
        {
            X += x;
            Y += y;
        }
    }
}
