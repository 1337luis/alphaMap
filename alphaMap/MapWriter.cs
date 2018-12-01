using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace alphaMap
{
    static class MapWriter
    {
        public static void write( Map map, String path )
        {
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryWriter writer = new BinaryWriter(stream);
            short mapSize = map.getMapSize();
            //New-mapSize-tileSize-layer0-3
            writer.Write( map.getNew() );

            writer.Write( map.getMapSize() );
            writer.Write( map.getTileSize() );

            //LAYER 0
            for( short x = 0; x < mapSize; x++ )
            {
                for( short y = 0; y < mapSize; y++ )
                {
                    writer.Write( map.read( x, y, MapLayer.Layer0 ) );
                    writer.Write( map.read( x, y, MapLayer.Layer1 ) );
                    writer.Write( map.read( x, y, MapLayer.Layer2 ) );
                    writer.Write( map.read( x, y, MapLayer.Layer3 ) );
                }
            }

            writer.Close();
        }
    }
}
