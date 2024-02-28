namespace JGraulQGame
{
    partial class DesignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.lblRows = new System.Windows.Forms.Label();
			this.txtRows = new System.Windows.Forms.TextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.lblColumns = new System.Windows.Forms.Label();
			this.txtColumns = new System.Windows.Forms.TextBox();
			this.lblToolbox = new System.Windows.Forms.Label();
			this.panelGrid = new System.Windows.Forms.Panel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnGreenBox = new System.Windows.Forms.Button();
			this.btnRedDoor = new System.Windows.Forms.Button();
			this.btnWall = new System.Windows.Forms.Button();
			this.btnNone = new System.Windows.Forms.Button();
			this.btnGreenDoor = new System.Windows.Forms.Button();
			this.btnRedBox = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(951, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
			this.loadToolStripMenuItem.Text = "Load";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "qgame|*.qgame";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "none.png");
			this.imageList1.Images.SetKeyName(1, "wall.png");
			this.imageList1.Images.SetKeyName(2, "greenBox.png");
			this.imageList1.Images.SetKeyName(3, "greenDoor.png");
			this.imageList1.Images.SetKeyName(4, "redBox.png");
			this.imageList1.Images.SetKeyName(5, "redDoor.png");
			// 
			// lblRows
			// 
			this.lblRows.AutoSize = true;
			this.lblRows.Location = new System.Drawing.Point(21, 55);
			this.lblRows.Name = "lblRows";
			this.lblRows.Size = new System.Drawing.Size(53, 20);
			this.lblRows.TabIndex = 1;
			this.lblRows.Text = "Rows:";
			// 
			// txtRows
			// 
			this.txtRows.Location = new System.Drawing.Point(78, 52);
			this.txtRows.Name = "txtRows";
			this.txtRows.Size = new System.Drawing.Size(88, 26);
			this.txtRows.TabIndex = 0;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(439, 46);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(117, 38);
			this.btnGenerate.TabIndex = 2;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// lblColumns
			// 
			this.lblColumns.AutoSize = true;
			this.lblColumns.Location = new System.Drawing.Point(202, 55);
			this.lblColumns.Name = "lblColumns";
			this.lblColumns.Size = new System.Drawing.Size(75, 20);
			this.lblColumns.TabIndex = 4;
			this.lblColumns.Text = "Columns:";
			// 
			// txtColumns
			// 
			this.txtColumns.Location = new System.Drawing.Point(283, 52);
			this.txtColumns.Name = "txtColumns";
			this.txtColumns.Size = new System.Drawing.Size(88, 26);
			this.txtColumns.TabIndex = 1;
			// 
			// lblToolbox
			// 
			this.lblToolbox.AutoSize = true;
			this.lblToolbox.Location = new System.Drawing.Point(21, 121);
			this.lblToolbox.Name = "lblToolbox";
			this.lblToolbox.Size = new System.Drawing.Size(64, 20);
			this.lblToolbox.TabIndex = 6;
			this.lblToolbox.Text = "Toolbox";
			// 
			// panelGrid
			// 
			this.panelGrid.Location = new System.Drawing.Point(189, 121);
			this.panelGrid.Name = "panelGrid";
			this.panelGrid.Size = new System.Drawing.Size(739, 632);
			this.panelGrid.TabIndex = 13;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnGreenBox
			// 
			this.btnGreenBox.ImageIndex = 2;
			this.btnGreenBox.ImageList = this.imageList1;
			this.btnGreenBox.Location = new System.Drawing.Point(25, 306);
			this.btnGreenBox.Name = "btnGreenBox";
			this.btnGreenBox.Size = new System.Drawing.Size(133, 75);
			this.btnGreenBox.TabIndex = 5;
			this.btnGreenBox.Text = "Green Box";
			this.btnGreenBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGreenBox.UseVisualStyleBackColor = true;
			this.btnGreenBox.Click += new System.EventHandler(this.HandleToolBoxClick);
			// 
			// btnRedDoor
			// 
			this.btnRedDoor.ImageIndex = 5;
			this.btnRedDoor.ImageList = this.imageList1;
			this.btnRedDoor.Location = new System.Drawing.Point(25, 549);
			this.btnRedDoor.Name = "btnRedDoor";
			this.btnRedDoor.Size = new System.Drawing.Size(133, 75);
			this.btnRedDoor.TabIndex = 8;
			this.btnRedDoor.Text = "Red Door";
			this.btnRedDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRedDoor.UseVisualStyleBackColor = true;
			this.btnRedDoor.Click += new System.EventHandler(this.HandleToolBoxClick);
			// 
			// btnWall
			// 
			this.btnWall.ImageIndex = 1;
			this.btnWall.ImageList = this.imageList1;
			this.btnWall.Location = new System.Drawing.Point(25, 225);
			this.btnWall.Name = "btnWall";
			this.btnWall.Size = new System.Drawing.Size(133, 75);
			this.btnWall.TabIndex = 4;
			this.btnWall.Text = "Wall";
			this.btnWall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnWall.UseVisualStyleBackColor = true;
			this.btnWall.Click += new System.EventHandler(this.HandleToolBoxClick);
			// 
			// btnNone
			// 
			this.btnNone.ImageIndex = 0;
			this.btnNone.ImageList = this.imageList1;
			this.btnNone.Location = new System.Drawing.Point(25, 144);
			this.btnNone.Name = "btnNone";
			this.btnNone.Size = new System.Drawing.Size(133, 75);
			this.btnNone.TabIndex = 3;
			this.btnNone.Text = "None";
			this.btnNone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNone.UseVisualStyleBackColor = true;
			this.btnNone.Click += new System.EventHandler(this.HandleToolBoxClick);
			// 
			// btnGreenDoor
			// 
			this.btnGreenDoor.ImageIndex = 3;
			this.btnGreenDoor.ImageList = this.imageList1;
			this.btnGreenDoor.Location = new System.Drawing.Point(25, 387);
			this.btnGreenDoor.Name = "btnGreenDoor";
			this.btnGreenDoor.Size = new System.Drawing.Size(133, 75);
			this.btnGreenDoor.TabIndex = 6;
			this.btnGreenDoor.Text = "Green Door";
			this.btnGreenDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGreenDoor.UseVisualStyleBackColor = true;
			this.btnGreenDoor.Click += new System.EventHandler(this.HandleToolBoxClick);
			// 
			// btnRedBox
			// 
			this.btnRedBox.ImageIndex = 4;
			this.btnRedBox.ImageList = this.imageList1;
			this.btnRedBox.Location = new System.Drawing.Point(25, 468);
			this.btnRedBox.Name = "btnRedBox";
			this.btnRedBox.Size = new System.Drawing.Size(133, 75);
			this.btnRedBox.TabIndex = 7;
			this.btnRedBox.Text = "Red Box";
			this.btnRedBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRedBox.UseVisualStyleBackColor = true;
			this.btnRedBox.Click += new System.EventHandler(this.HandleToolBoxClick);
			// 
			// DesignForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(951, 775);
			this.Controls.Add(this.btnGreenBox);
			this.Controls.Add(this.btnRedDoor);
			this.Controls.Add(this.btnWall);
			this.Controls.Add(this.panelGrid);
			this.Controls.Add(this.btnNone);
			this.Controls.Add(this.btnGreenDoor);
			this.Controls.Add(this.btnRedBox);
			this.Controls.Add(this.lblToolbox);
			this.Controls.Add(this.txtColumns);
			this.Controls.Add(this.lblColumns);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.txtRows);
			this.Controls.Add(this.lblRows);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "DesignForm";
			this.Text = "Design Form";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Label lblToolbox;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}