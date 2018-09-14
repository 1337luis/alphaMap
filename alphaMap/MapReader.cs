using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace alphaMap
{
    static class MapReader
    {
        public static Map read( String path )
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            BinaryReader reader = new BinaryReader(stream);
            Map result;
            bool isNew = reader.ReadBoolean();
            short mapSize = reader.ReadInt16();
            short tileSize = reader.ReadInt16();
            result = new Map( mapSize, tileSize, isNew );

            for( short x = 0; x < mapSize; x++ )
            {
                for( short y = 0; y < mapSize; y++ )
                {
                    result.write( x, y, reader.ReadByte(), MapLayer.Layer0 );
                    result.write( x, y, reader.ReadByte(), MapLayer.Layer1 );
                    result.write( x, y, reader.ReadByte(), MapLayer.Layer2 );
                    result.write( x, y, reader.ReadByte(), MapLayer.Layer3 );
                }
            }

            reader.Close();
            return result;
        }
    }
}
