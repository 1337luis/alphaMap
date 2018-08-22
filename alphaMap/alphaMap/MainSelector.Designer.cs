namespace alphaMap
{
    partial class MainSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSelector));
            this.newButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.viewerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.compileMapButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(12, 12);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(255, 67);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "Nuevo mapa";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(273, 12);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(254, 67);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Editar mapa";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // viewerButton
            // 
            this.viewerButton.Enabled = false;
            this.viewerButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewerButton.Location = new System.Drawing.Point(12, 85);
            this.viewerButton.Name = "viewerButton";
            this.viewerButton.Size = new System.Drawing.Size(255, 67);
            this.viewerButton.TabIndex = 2;
            this.viewerButton.Text = "Visualizar mapa";
            this.viewerButton.UseVisualStyleBackColor = true;
            this.viewerButton.Click += new System.EventHandler(this.viewerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 158);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(367, 67);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Salir";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // compileMapButton
            // 
            this.compileMapButton.Enabled = false;
            this.compileMapButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compileMapButton.Location = new System.Drawing.Point(273, 85);
            this.compileMapButton.Name = "compileMapButton";
            this.compileMapButton.Size = new System.Drawing.Size(255, 67);
            this.compileMapButton.TabIndex = 4;
            this.compileMapButton.Text = "Compilar mapa";
            this.compileMapButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(459, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // configButton
            // 
            this.configButton.Enabled = false;
            this.configButton.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configButton.ForeColor = System.Drawing.Color.Blue;
            this.configButton.Image = global::alphaMap.Properties.Resources._new;
            this.configButton.Location = new System.Drawing.Point(385, 158);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(68, 68);
            this.configButton.TabIndex = 6;
            this.configButton.UseVisualStyleBackColor = true;
            // 
            // MainSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(539, 238);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.compileMapButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.viewerButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.newButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "alphaMap - Menú principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button viewerButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button compileMapButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button configButton;
    }
}