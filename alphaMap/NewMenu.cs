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
    public partial class NewMenu : Form
    {
        bool haveValidTileset = false, haveValidSave = false, haveValidTileSize = false;
        Image tileset;
        short tileSize;
        public NewMenu()
        {
            InitializeComponent();
        }

        private void selectTilesetButton_Click( object sender, EventArgs e )
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "*.png | *.PNG";
            if(o.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tileset = Image.FromFile( o.FileName );
                    if( tileset.Width < 16 || tileset.Height < 16 ) throw new Exception();
                    if( tileset.Width % 16 != 0 || tileset.Height % 16 != 0 ) throw new Exception();
                    haveValidTileset = true;
                    tilePathTextBox.Text = o.FileName;
                    validRadios();
                    checkCreate();
                } catch( Exception ex)
                {
                    MessageBox.Show( "No se ha seleccionado una imagen válida" );
                    haveValidTileset = false;
                    tilePathTextBox.Text = "";
                    Console.WriteLine( ex.Message );
                } finally
                {
                    checkCreate();
                }
            }
        }

        private void radio16_CheckedChanged( object sender, EventArgs e )
        {
            if( radio16.Enabled  && radio16.Checked ) haveValidTileSize = true; else haveValidTileSize = false;
            tileSize = 16;
            checkCreate();
        }

        private void radio32_CheckedChanged( object sender, EventArgs e )
        {
            if( radio32.Enabled  && radio32.Checked ) haveValidTileSize = true; else haveValidTileSize = false;
            tileSize = 32;
            checkCreate();
        }

        private void radio64_CheckedChanged( object sender, EventArgs e )
        {
            if( radio64.Enabled && radio64.Checked ) haveValidTileSize = true; else haveValidTileSize = false;
            tileSize = 64;
            checkCreate();
        }

        private void radio128_CheckedChanged( object sender, EventArgs e )
        {
            if( radio128.Enabled && radio128.Checked ) haveValidTileSize = true; else haveValidTileSize = false;
            tileSize = 128;
            checkCreate();
        }

        private void saveButton_Click( object sender, EventArgs e )
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "*.lpf | *.lpf";

            if(s.ShowDialog() == DialogResult.OK)
            {
                haveValidSave = true;
                saveTextBox.Text = s.FileName;
                checkCreate();
            }
            checkCreate();
        }

        private void checkCreate()
        {
            if(haveValidSave && haveValidTileset && haveValidTileSize)
            {
                createButton.Enabled = true;
            } else
            {
                createButton.Enabled = false;
            }
        }

        private void validRadios()
        {

            radio16.Checked = false;
            radio32.Checked = false;
            radio64.Checked = false;
            radio128.Checked = false;

            radio16.Enabled = false;
            radio32.Enabled = false;
            radio64.Enabled = false;
            radio128.Enabled = false;

            if(tileset.Width >= 16 && tileset.Width % 16 == 0 )
            {
                radio16.Enabled = true;
            }

            if( tileset.Width >= 32 && tileset.Width % 32 == 0 )
            {
                radio32.Enabled = true;
            }

            if( tileset.Width >= 64 && tileset.Width % 64 == 0 )
            {
                radio64.Enabled = true;
            }

            if( tileset.Width >= 128 && tileset.Width % 128 == 0 )
            {
                radio128.Enabled = true;
            }
        }


        public short getTileSize()
        {
            return tileSize;
        }

        public short getMapSize()
        {
            return ( short )mapSizeSelector.Value;
        }

        private void createButton_Click( object sender, EventArgs e )
        {
            tileset.Save( saveTextBox.Text + ".tile" );
            MapWriter.write( new Map( ( short )mapSizeSelector.Value, tileSize, true ), saveTextBox.Text );
        }

        public string getTilesetPath()
        {
            return tilePathTextBox.Text;
        }

        public string getSavePath()
        {
            return saveTextBox.Text;
        }
    }
}
