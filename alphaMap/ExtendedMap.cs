using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphaMap
{
    public enum MapLayer
    {
        Layer0 = 0,
        Layer1,
        Layer2,
        Layer3
    }
    public class Map
    {
        private List<short>[] layers = new List<short>[4];
        private short sz, tileSz;
        private bool isNewMap;

        public Map( short mapSize, short tileSize, bool isNew )
        {
            sz = mapSize;
            tileSz = tileSize;
            layers[ 0 ] = new List<short>( sz * sz );
            layers[ 1 ] = new List<short>( sz * sz );
            layers[ 2 ] = new List<short>( sz * sz );
            layers[ 3 ] = new List<short>( sz * sz );
            isNewMap = isNew;
            init();

        }

        public void write( int x, int y, short tile, MapLayer layer )
        {
            try
            {
                layers[ ( int )layer ][ y * sz + x ] = tile;
            }
            catch( Exception ex )
            {
                Console.WriteLine( ex.Message );
            }

        }

        public short read( int x, int y, MapLayer layer )
        {
            short result = 0x0000;
            try
            {
                result = layers[ ( int )layer ][ y * sz + x ];
            }
            catch( Exception ex )
            {
                Console.WriteLine( ex.Message );
            }
            return result;
        }

        public short getMapSize()
        {
            return sz;
        }

        public short getTileSize()
        {
            return tileSz;
        }

        public bool getNew()
        {
            return isNewMap;
        }

        public void setNew( bool isNew )
        {
            isNewMap = isNew;
        }

        private void init()
        {
            for( int x = 0; x < sz * sz; x++ )
            {
                layers[ 0 ].Add( 0x00 );
                layers[ 1 ].Add( 0x00 );
                layers[ 2 ].Add( 0x00 );
                layers[ 3 ].Add( 0x00 );
            }
        }
    }
}
