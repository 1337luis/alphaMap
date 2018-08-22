namespace alphaMap
{
    partial class NewMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMenu));
            this.objectsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tilePathTextBox = new System.Windows.Forms.TextBox();
            this.selectTilesetButton = new System.Windows.Forms.Button();
            this.elementsPanel = new System.Windows.Forms.Panel();
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.radio128 = new System.Windows.Forms.RadioButton();
            this.radio64 = new System.Windows.Forms.RadioButton();
            this.radio32 = new System.Windows.Forms.RadioButton();
            this.radio16 = new System.Windows.Forms.RadioButton();
            this.saveTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.mapSizeSelector = new System.Windows.Forms.NumericUpDown();
            this.objectsPanel.SuspendLayout();
            this.elementsPanel.SuspendLayout();
            this.radioGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapSizeSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // objectsPanel
            // 
            this.objectsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectsPanel.Controls.Add(this.createButton);
            this.objectsPanel.Controls.Add(this.cancelButton);
            this.objectsPanel.ForeColor = System.Drawing.Color.Black;
            this.objectsPanel.Location = new System.Drawing.Point(12, 146);
            this.objectsPanel.Name = "objectsPanel";
            this.objectsPanel.Size = new System.Drawing.Size(336, 38);
            this.objectsPanel.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createButton.Enabled = false;
            this.createButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(3, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(162, 30);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Crear";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(171, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(159, 30);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // tilePathTextBox
            // 
            this.tilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tilePathTextBox.Enabled = false;
            this.tilePathTextBox.Location = new System.Drawing.Point(3, 3);
            this.tilePathTextBox.Name = "tilePathTextBox";
            this.tilePathTextBox.Size = new System.Drawing.Size(223, 20);
            this.tilePathTextBox.TabIndex = 1;
            // 
            // selectTilesetButton
            // 
            this.selectTilesetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectTilesetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.selectTilesetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectTilesetButton.Location = new System.Drawing.Point(3, 3);
            this.selectTilesetButton.Name = "selectTilesetButton";
            this.selectTilesetButton.Size = new System.Drawing.Size(328, 20);
            this.selectTilesetButton.TabIndex = 3;
            this.selectTilesetButton.Text = "Seleccionar Tileset";
            this.selectTilesetButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectTilesetButton.UseVisualStyleBackColor = false;
            this.selectTilesetButton.Click += new System.EventHandler(this.selectTilesetButton_Click);
            // 
            // elementsPanel
            // 
            this.elementsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementsPanel.Controls.Add(this.radioGroup);
            this.elementsPanel.Controls.Add(this.saveTextBox);
            this.elementsPanel.Controls.Add(this.saveButton);
            this.elementsPanel.Controls.Add(this.sizeLabel);
            this.elementsPanel.Controls.Add(this.mapSizeSelector);
            this.elementsPanel.Controls.Add(this.tilePathTextBox);
            this.elementsPanel.Controls.Add(this.selectTilesetButton);
            this.elementsPanel.Location = new System.Drawing.Point(12, 12);
            this.elementsPanel.Name = "elementsPanel";
            this.elementsPanel.Size = new System.Drawing.Size(336, 131);
            this.elementsPanel.TabIndex = 4;
            // 
            // radioGroup
            // 
            this.radioGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.radioGroup.Controls.Add(this.radio128);
            this.radioGroup.Controls.Add(this.radio64);
            this.radioGroup.Controls.Add(this.radio32);
            this.radioGroup.Controls.Add(this.radio16);
            this.radioGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioGroup.Location = new System.Drawing.Point(3, 29);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(328, 43);
            this.radioGroup.TabIndex = 8;
            this.radioGroup.TabStop = false;
            this.radioGroup.Text = "Tamaño tile";
            // 
            // radio128
            // 
            this.radio128.AutoSize = true;
            this.radio128.Enabled = false;
            this.radio128.Location = new System.Drawing.Point(221, 17);
            this.radio128.Name = "radio128";
            this.radio128.Size = new System.Drawing.Size(66, 17);
            this.radio128.TabIndex = 3;
            this.radio128.TabStop = true;
            this.radio128.Text = "128x128";
            this.radio128.UseVisualStyleBackColor = true;
            this.radio128.CheckedChanged += new System.EventHandler(this.radio128_CheckedChanged);
            // 
            // radio64
            // 
            this.radio64.AutoSize = true;
            this.radio64.Enabled = false;
            this.radio64.Location = new System.Drawing.Point(161, 17);
            this.radio64.Name = "radio64";
            this.radio64.Size = new System.Drawing.Size(54, 17);
            this.radio64.TabIndex = 2;
            this.radio64.TabStop = true;
            this.radio64.Text = "64x64";
            this.radio64.UseVisualStyleBackColor = true;
            this.radio64.CheckedChanged += new System.EventHandler(this.radio64_CheckedChanged);
            // 
            // radio32
            // 
            this.radio32.AutoSize = true;
            this.radio32.Enabled = false;
            this.radio32.Location = new System.Drawing.Point(101, 17);
            this.radio32.Name = "radio32";
            this.radio32.Size = new System.Drawing.Size(54, 17);
            this.radio32.TabIndex = 1;
            this.radio32.TabStop = true;
            this.radio32.Text = "32x32";
            this.radio32.UseVisualStyleBackColor = true;
            this.radio32.CheckedChanged += new System.EventHandler(this.radio32_CheckedChanged);
            // 
            // radio16
            // 
            this.radio16.AutoSize = true;
            this.radio16.Enabled = false;
            this.radio16.Location = new System.Drawing.Point(41, 17);
            this.radio16.Name = "radio16";
            this.radio16.Size = new System.Drawing.Size(54, 17);
            this.radio16.TabIndex = 0;
            this.radio16.TabStop = true;
            this.radio16.Text = "16x16";
            this.radio16.UseVisualStyleBackColor = true;
            this.radio16.CheckedChanged += new System.EventHandler(this.radio16_CheckedChanged);
            // 
            // saveTextBox
            // 
            this.saveTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveTextBox.Enabled = false;
            this.saveTextBox.Location = new System.Drawing.Point(3, 104);
            this.saveTextBox.Name = "saveTextBox";
            this.saveTextBox.Size = new System.Drawing.Size(223, 20);
            this.saveTextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Location = new System.Drawing.Point(3, 104);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(328, 20);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Seleccionar destino";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(3, 80);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(125, 13);
            this.sizeLabel.TabIndex = 5;
            this.sizeLabel.Text = "Tamaño del Mapa (X, Y):";
            // 
            // mapSizeSelector
            // 
            this.mapSizeSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapSizeSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapSizeSelector.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mapSizeSelector.Location = new System.Drawing.Point(134, 78);
            this.mapSizeSelector.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.mapSizeSelector.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.mapSizeSelector.Name = "mapSizeSelector";
            this.mapSizeSelector.Size = new System.Drawing.Size(197, 20);
            this.mapSizeSelector.TabIndex = 4;
            this.mapSizeSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mapSizeSelector.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.mapSizeSelector.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // NewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(360, 196);
            this.Controls.Add(this.elementsPanel);
            this.Controls.Add(this.objectsPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo mapa";
            this.objectsPanel.ResumeLayout(false);
            this.elementsPanel.ResumeLayout(false);
            this.elementsPanel.PerformLayout();
            this.radioGroup.ResumeLayout(false);
            this.radioGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapSizeSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel objectsPanel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox tilePathTextBox;
        private System.Windows.Forms.Button selectTilesetButton;
        private System.Windows.Forms.Panel elementsPanel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.NumericUpDown mapSizeSelector;
        private System.Windows.Forms.TextBox saveTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox radioGroup;
        private System.Windows.Forms.RadioButton radio128;
        private System.Windows.Forms.RadioButton radio64;
        private System.Windows.Forms.RadioButton radio32;
        private System.Windows.Forms.RadioButton radio16;
    }
}