using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphaMap
{
    public static class MapCompiler
    {

        public static CompiledMap Compile(Map map, short id)
        {
            Bitmap resBitmap = new Bitmap( 
                    map.getMapSize() * map.getTileSize(), 
                    map.getMapSize() * map.getTileSize());

            for(int x = 0; x < map.getMapSize(); x++ )
            {
                for( int y = 0; y < map.getMapSize(); y++ )
                {
                    byte[] tiles = {
                            map.read( x, y, MapLayer.Layer0 ),
                            map.read( x, y, MapLayer.Layer1 ),
                            map.read( x, y, MapLayer.Layer2 ),
                            map.read( x, y, MapLayer.Layer3 )
                    };

                    for( int tX = 0; tX < map.getTileSize(); tX++ )
                    {
                        for( int tY = 0; tY < map.getTileSize(); tY++ )
                        {
                            //resBitmap.SetPixel(tX * x + 1, tY * y + 1,
                        }
                    }

                }
            }

            return new CompiledMap( resBitmap, id );
        }
    }
}
