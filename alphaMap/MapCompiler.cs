using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphaMap
{
    public static class MapCompiler
    {
        
        public static CompiledMap Compile(Map map, short id)
        {
            return new CompiledMap( new System.Drawing.Bitmap(0,0), id );
        }
    }
}
