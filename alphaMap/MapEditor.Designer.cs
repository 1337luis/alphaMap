namespace alphaMap
{
    partial class MapEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapEditor));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tileView = new System.Windows.Forms.ListView();
            this.fillTile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fillOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tileList = new System.Windows.Forms.ImageList(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tileNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.xText = new System.Windows.Forms.ToolStripStatusLabel();
            this.yText = new System.Windows.Forms.ToolStripStatusLabel();
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirAlMenúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLayerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vaciarCapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.fillTile.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.clearLayerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.flow);
            this.splitContainer1.Size = new System.Drawing.Size(727, 549);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tileView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBox1);
            this.splitContainer2.Size = new System.Drawing.Size(199, 549);
            this.splitContainer2.SplitterDistance = 443;
            this.splitContainer2.TabIndex = 0;
            // 
            // tileView
            // 
            this.tileView.BackgroundImage = global::alphaMap.Properties.Resources.bg;
            this.tileView.BackgroundImageTiled = true;
            this.tileView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tileView.ContextMenuStrip = this.fillTile;
            this.tileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileView.GridLines = true;
            this.tileView.LargeImageList = this.tileList;
            this.tileView.Location = new System.Drawing.Point(0, 0);
            this.tileView.Name = "tileView";
            this.tileView.Size = new System.Drawing.Size(199, 443);
            this.tileView.SmallImageList = this.tileList;
            this.tileView.TabIndex = 0;
            this.tileView.TileSize = new System.Drawing.Size(56, 48);
            this.tileView.UseCompatibleStateImageBehavior = false;
            this.tileView.View = System.Windows.Forms.View.Tile;
            this.tileView.SelectedIndexChanged += new System.EventHandler(this.tileView_SelectedIndexChanged);
            // 
            // fillTile
            // 
            this.fillTile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillOption});
            this.fillTile.Name = "fillTile";
            this.fillTile.Size = new System.Drawing.Size(261, 26);
            // 
            // fillOption
            // 
            this.fillOption.Name = "fillOption";
            this.fillOption.Size = new System.Drawing.Size(260, 22);
            this.fillOption.Text = "Rellenar base con Tile seleccionado";
            this.fillOption.Click += new System.EventHandler(this.fillOption_Click);
            // 
            // tileList
            // 
            this.tileList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.tileList.ImageSize = new System.Drawing.Size(48, 48);
            this.tileList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ContextMenuStrip = this.clearLayerMenu;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "(0) Base layer",
            "(1) Element layer",
            "(2) Object layer",
            "(3) Overlay"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 102);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileNumber,
            this.statusText,
            this.xText,
            this.yText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tileNumber
            // 
            this.tileNumber.Name = "tileNumber";
            this.tileNumber.Size = new System.Drawing.Size(28, 17);
            this.tileNumber.Text = "tiles";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(453, 17);
            this.statusText.Spring = true;
            this.statusText.Text = "Status: IDLE";
            // 
            // xText
            // 
            this.xText.ForeColor = System.Drawing.Color.Red;
            this.xText.Name = "xText";
            this.xText.Size = new System.Drawing.Size(14, 17);
            this.xText.Text = "X";
            // 
            // yText
            // 
            this.yText.ForeColor = System.Drawing.Color.Blue;
            this.yText.Name = "yText";
            this.yText.Size = new System.Drawing.Size(14, 17);
            this.yText.Text = "Y";
            // 
            // flow
            // 
            this.flow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flow.BackgroundImage = global::alphaMap.Properties.Resources.bg2;
            this.flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flow.Cursor = System.Windows.Forms.Cursors.Cross;
            this.flow.Location = new System.Drawing.Point(0, 0);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(524, 524);
            this.flow.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.redrawToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.salirAlMenúToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirAlMenúToolStripMenuItem
            // 
            this.salirAlMenúToolStripMenuItem.Name = "salirAlMenúToolStripMenuItem";
            this.salirAlMenúToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.salirAlMenúToolStripMenuItem.Text = "Salir al menú";
            this.salirAlMenúToolStripMenuItem.Click += new System.EventHandler(this.salirAlMenúToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // redrawToolStripMenuItem
            // 
            this.redrawToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.redrawToolStripMenuItem.Name = "redrawToolStripMenuItem";
            this.redrawToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.redrawToolStripMenuItem.Text = "Redraw";
            this.redrawToolStripMenuItem.Click += new System.EventHandler(this.redrawToolStripMenuItem_Click);
            // 
            // clearLayerMenu
            // 
            this.clearLayerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vaciarCapaToolStripMenuItem});
            this.clearLayerMenu.Name = "clearLayerMenu";
            this.clearLayerMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // vaciarCapaToolStripMenuItem
            // 
            this.vaciarCapaToolStripMenuItem.Name = "vaciarCapaToolStripMenuItem";
            this.vaciarCapaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vaciarCapaToolStripMenuItem.Text = "Vaciar capa";
            this.vaciarCapaToolStripMenuItem.Click += new System.EventHandler(this.vaciarCapaToolStripMenuItem_Click);
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 573);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MapEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de mapas (v0.4a)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MapEditor_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MapEditor_FormClosed);
            this.Load += new System.EventHandler(this.MapEditor_Load);
            this.ResizeEnd += new System.EventHandler(this.MapEditor_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.MapEditor_SizeChanged);
            this.Resize += new System.EventHandler(this.MapEditor_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.fillTile.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.clearLayerMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView tileView;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ImageList tileList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirAlMenúToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flow;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tileNumber;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel xText;
        private System.Windows.Forms.ToolStripStatusLabel yText;
        private System.Windows.Forms.ToolStripMenuItem redrawToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip fillTile;
        private System.Windows.Forms.ToolStripMenuItem fillOption;
        private System.Windows.Forms.ContextMenuStrip clearLayerMenu;
        private System.Windows.Forms.ToolStripMenuItem vaciarCapaToolStripMenuItem;
    }
}