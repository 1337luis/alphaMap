using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphaMap
{
    public class CompiledMap
    {
        Bitmap map;
        short id;
        public CompiledMap(Bitmap map, short mapId)
        {
            this.map = map;
            this.id = mapId;
        }
        public Bitmap getBitmap()
        {
            return map;
        }

        public Image getImage()
        {
            return map;
        }

        public short getId()
        {
            return id;
        }
    }
}
