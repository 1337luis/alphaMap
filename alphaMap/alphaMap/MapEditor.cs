using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alphaMap
{
    public partial class MapEditor : Form
    {
        private MainSelector main;
        private Map toWork;
        private String path;
        private Bitmap tileset;
        private MapDrawer mapDrawer;
        private bool mouseDown = false;
        private byte selectedTile = 0;
        private Point gridXY;
        private MapLayer selectedLayer = MapLayer.Layer0;

        public MapEditor( MainSelector m, Map openMap, String mapPath )
        {


            main = m;
            toWork = openMap;
            path = mapPath;
            InitializeComponent();
            mapDrawer = new alphaMap.MapDrawer( toWork, tileList );
            try
            {
                tileset = new Bitmap( Image.FromFile( mapPath + ".tile" ) );
                listBox1.SetSelected( 0, true );

            }
            catch( Exception ex )
            {
                Console.WriteLine( ex.Message );
                MessageBox.Show( "No se ha encontrado el archivo de tileset", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                Close();
            }

        }

        private void MapEditor_FormClosed( object sender, FormClosedEventArgs e )
        {
            main.Show();
        }

        private void loadTiles()
        {
            setStatus( "Loading tileset" );
            int tileSz = toWork.getTileSize();
            int tiles = tileset.Width / tileSz;
            byte key = 0;
            for( int x = 0; x < tiles; x++ )
            {
                for( int y = 0; y < tiles; y++ )
                {
                    tileList.Images.Add( key.ToString(), tileset.Clone( new Rectangle( x * tileSz, y * tileSz, tileSz, tileSz ), System.Drawing.Imaging.PixelFormat.DontCare ) );
                    tileView.Items.Add( "", ( int )key );
                    tileView.Items[ key ].ToolTipText = "Tile " + key.ToString();
                    key++;
                }
            }
            tileNumber.Text = key + " tiles, SZ: " + toWork.getMapSize() + " (" + 32 * 32 + ") ";
            setStatus( "IDLE" );
        }

        private void MapEditor_Load( object sender, EventArgs e )
        {
            loadTiles();
            addMapDrawer();
            mapDrawer.initialize();
        }

        private void setStatus( String msg )
        {
            statusText.Text = "Status: " + msg;
        }

        private void guardarToolStripMenuItem_Click( object sender, EventArgs e )
        {
            try
            {
                MapWriter.write( toWork, path );
            }
            catch( Exception ex )
            {
                MessageBox.Show( "Error al guardar ( " + ex.Message + " )." );
            }
        }

        private void MapEditor_Resize( object sender, EventArgs e )
        {

        }

        private void MapEditor_ResizeEnd( object sender, EventArgs e )
        {
            if( mapDrawer != null )
            {
                try
                {
                    checkResize();
                }
                catch( NullReferenceException ex )
                {
                    Console.WriteLine( ex.Message );
                }
            }
        }

        private void checkResize()
        {
            try
            {
                if( flow.Height < flow.Width )
                {
                    mapDrawer.Height = flow.Height - 10;
                    mapDrawer.Width = mapDrawer.Height;
                }
                else if( flow.Width < flow.Height )
                {
                    mapDrawer.Width = flow.Width - 10;
                    mapDrawer.Height = mapDrawer.Width;
                }
                else
                {
                    mapDrawer.Width = flow.Width - 10;
                    mapDrawer.Height = flow.Height - 10;
                }
            }
            catch( Exception ex )
            {
                Console.WriteLine( ex.Message );
            }
            mapDrawer.reDraw();
        }

        private void MapEditor_SizeChanged( object sender, EventArgs e )
        {
            if( mapDrawer != null )
            {
                try
                {
                    checkResize();
                }
                catch( NullReferenceException ex )
                {
                    Console.WriteLine( ex.Message );
                }
            }
        }

        private void redrawToolStripMenuItem_Click( object sender, EventArgs e )
        {
            setStatus( "Redrawing map" );
            mapDrawer.reDraw();
            setStatus( "IDLE" );
        }
        public void addMapDrawer()
        {
            flow.Controls.Add( mapDrawer );
            mapDrawer.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            mapDrawer.BackgroundImage = global::alphaMap.Properties.Resources.bg3;
            mapDrawer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mapDrawer.Location = new System.Drawing.Point( 3, 3 );
            mapDrawer.Name = "mapDrawer";
            mapDrawer.Size = new System.Drawing.Size( 512, 512 );
            mapDrawer.TabIndex = 0;

            mapDrawer.MouseMove += MapDrawer_MouseMove;
            mapDrawer.MouseDown += MapDrawer_MouseDown;
            mapDrawer.MouseUp += MapDrawer_MouseUp;
            mapDrawer.MouseClick += MapDrawer_MouseClick;
            mapDrawer.MouseLeave += MapDrawer_MouseLeave;
        }

        private void MapDrawer_MouseLeave( object sender, EventArgs e )
        {
            mouseDown = false;
        }

        private void MapDrawer_MouseClick( object sender, MouseEventArgs e )
        {
            mapDrawer.writeTile( selectedTile, gridXY.X, gridXY.Y, selectedLayer );
        }

        private void MapDrawer_MouseUp( object sender, MouseEventArgs e )
        {
            mouseDown = false;
        }

        private void MapDrawer_MouseDown( object sender, MouseEventArgs e )
        {
            mouseDown = true;
        }

        private void MapDrawer_MouseMove( object sender, MouseEventArgs e )
        {
            xText.Text = mapDrawer.getGridXY().X.ToString();
            yText.Text = mapDrawer.getGridXY().Y.ToString();
            gridXY = mapDrawer.getGridXY();
            if( mouseDown )
            {
                mapDrawer.writeTile( selectedTile, gridXY.X, gridXY.Y, selectedLayer );
            }
        }

        private void splitContainer1_SplitterMoved( object sender, SplitterEventArgs e )
        {
            if( mapDrawer != null )
            {
                try
                {
                    checkResize();
                }
                catch( Exception ex )
                {
                    Console.WriteLine( ex.Message );
                }
            }
        }

        private void tileView_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( tileView.SelectedItems.Count > 0 )
            {
                selectedTile = ( byte )tileView.SelectedItems[ 0 ].Index;
            }
        }

        private void listBox1_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( listBox1.GetSelected( 0 ) )
            {
                selectedLayer = MapLayer.Layer0;
                listBox1.BackColor = Color.White;
            }
            else if( listBox1.GetSelected( 1 ) )
            {
                selectedLayer = MapLayer.Layer1;
                listBox1.BackColor = Color.FromArgb( 200, 200, 255 );
            }
            else if( listBox1.GetSelected( 2 ) )
            {
                selectedLayer = MapLayer.Layer2;
                listBox1.BackColor = Color.FromArgb( 165, 165, 255 );
            }
            else if( listBox1.GetSelected( 3 ) )
            {
                selectedLayer = MapLayer.Layer3;
                listBox1.BackColor = Color.FromArgb( 115, 115, 255 );
            }
        }

        private void fillOption_Click( object sender, EventArgs e )
        {
            if( tileView.SelectedItems.Count > 0 )
            {
                for( int x = 0; x < toWork.getMapSize(); x++ )
                {
                    for( int y = 0; y < toWork.getMapSize(); y++ )
                    {
                        mapDrawer.writeTile( selectedTile, x, y, MapLayer.Layer0 );
                    }
                }
            }
        }

        private void salirAlMenúToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click( object sender, EventArgs e )
        {
            main.Close();
        }

        private void MapEditor_FormClosing( object sender, FormClosingEventArgs e )
        {
            guardarToolStripMenuItem.PerformClick();
        }

        private void vaciarCapaToolStripMenuItem_Click( object sender, EventArgs e )
        {
            switch( listBox1.SelectedIndex )
            {
                case 0:
                    clearLayer( MapLayer.Layer0 );
                    break;
                case 1:
                    clearLayer( MapLayer.Layer1 );
                    break;
                case 2:
                    clearLayer( MapLayer.Layer2 );
                    break;
                case 3:
                    clearLayer( MapLayer.Layer3 );
                    break;
            }
        }

        private void clearLayer( MapLayer layer )
        {
            for( int x = 0; x < toWork.getMapSize(); x++ )
            {
                for( int y = 0; y < toWork.getMapSize(); y++ )
                {
                    mapDrawer.writeTile( 0, x, y, layer );
                }
            }
        }
    }
}
