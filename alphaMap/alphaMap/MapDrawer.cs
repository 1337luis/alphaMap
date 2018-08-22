using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alphaMap
{
    public partial class MapDrawer : UserControl
    {
        BufferedGraphics buffer;
        BufferedGraphicsContext context;
        ImageList tiles;
        Map map;
        Point mouse, relative;
        int sz;

        public MapDrawer( Map map, ImageList tiles )
        {
            InitializeComponent();
            this.map = map;
            this.tiles = tiles;
            context = BufferedGraphicsManager.Current;
            buffer = context.Allocate( CreateGraphics(), new Rectangle( 0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height ) );
            mouse = new Point( 0, 0 );
            relative = new Point( 0, 0 );
        }

        public void initialize()
        {
            sz = map.getMapSize();
            buffer.Graphics.Clear( Color.FromArgb( 16, 16, 32 ) );
            reDraw();
        }

        public void writeTile( byte tile, int x, int y, MapLayer layer )
        {
            map.write( x, y, tile, layer );
            drawTile( x, y );
            buffer.Render();
        }
        public void drawTile( int x, int y )
        {
            float w = Width;
            float relSz = w / (float)map.getMapSize();
            buffer.Graphics.FillRectangle( new SolidBrush( Color.FromArgb( 16, 16, 32 ) ), new RectangleF( x * relSz, y * relSz, relSz, relSz ) );
            buffer.Graphics.DrawImage( tiles.Images[ map.read( x, y, MapLayer.Layer0 ) ], x * relSz, y * relSz, relSz, relSz );
            buffer.Graphics.DrawImage( tiles.Images[ map.read( x, y, MapLayer.Layer1 ) ], x * relSz, y * relSz, relSz, relSz );
            buffer.Graphics.DrawImage( tiles.Images[ map.read( x, y, MapLayer.Layer2 ) ], x * relSz, y * relSz, relSz, relSz );
            buffer.Graphics.DrawImage( tiles.Images[ map.read( x, y, MapLayer.Layer3 ) ], x * relSz, y * relSz, relSz, relSz );
        }

        public void reDraw()
        {
            buffer.Graphics.Clear( Color.FromArgb( 16, 16, 32 ) );
            drawMap();
        }

        private void MapDrawer_VisibleChanged( object sender, EventArgs e )
        {
            
        }

        private void MapDrawer_SizeChanged( object sender, EventArgs e )
        {

        }

        private void MapDrawer_MouseMove( object sender, MouseEventArgs e )
        {
            mouse.X = e.X;
            mouse.Y = e.Y;
            relative.X = map.getMapSize() * mouse.X / Width;
            relative.Y = map.getMapSize() * mouse.Y / Height;
        }

        public Point getXY()
        {
            return mouse;
        }

        public Point getGridXY()
        {
            return new Point(
                ( relative.X >= 0 ? relative.X : 0 ) < sz ? relative.X : sz,
                ( relative.Y >= 0 ? relative.Y : 0 ) < sz ? relative.Y : sz
                );
        }

        public void drawMap()
        {
            for( int x = 0; x < map.getMapSize(); x++ )
            {
                for( int y = 0; y < map.getMapSize(); y++ )
                {
                    drawTile( x, y );
                }
            }
            buffer.Render();
        }
    }

}
