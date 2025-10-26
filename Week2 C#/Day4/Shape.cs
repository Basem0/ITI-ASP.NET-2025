using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace dayFour
{
    public abstract class Shape
     {

        public Shape() { }

        public Raylib_cs.Color Color { get; set; }
        public abstract void Draw();

     }
}
