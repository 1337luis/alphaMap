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
    public partial class MainSelector : Form
    {
        public MainSelector()
        {
            InitializeComponent();
        }

        private void exitButton_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void newButton_Click( object sender, EventArgs e )
        {
            NewMenu n = new NewMenu();
            if( n.ShowDialog() == DialogResult.OK )
            {
                new MapEditor( this, MapReader.read( n.getSavePath() ),n.getSavePath() ).Show();
                Hide();
            }
        }

        private void viewerButton_Click( object sender, EventArgs e )
        {

        }

        private void editButton_Click( object sender, EventArgs e )
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "*.lpf | *.LPF";

            if( o.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    new MapEditor( this, MapReader.read( o.FileName ), o.FileName ).Show();
                    Hide();
                }
                catch( Exception ex ) { Console.WriteLine( ex.Message ); }
            }
        }
    }
}
