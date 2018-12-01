namespace alphaMap
{
    partial class MapDrawer
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MapDrawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MapDrawer";
            this.Size = new System.Drawing.Size(496, 438);
            this.SizeChanged += new System.EventHandler(this.MapDrawer_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.MapDrawer_VisibleChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapDrawer_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
