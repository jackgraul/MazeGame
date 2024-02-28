namespace JGraulQGame
{
	partial class PlayForm
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelGrid = new System.Windows.Forms.Panel();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.lblMoves = new System.Windows.Forms.Label();
			this.lblBoxes = new System.Windows.Forms.Label();
			this.txtMoves = new System.Windows.Forms.TextBox();
			this.txtBoxes = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1291, 33);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
			this.fileToolStripMenuItem.Text = "File";
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
			// panelGrid
			// 
			this.panelGrid.Location = new System.Drawing.Point(21, 52);
			this.panelGrid.Name = "panelGrid";
			this.panelGrid.Size = new System.Drawing.Size(683, 625);
			this.panelGrid.TabIndex = 2;
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(940, 450);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(89, 82);
			this.btnUp.TabIndex = 3;
			this.btnUp.Text = "Up";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.HandleMovementButtonClick);
			// 
			// btnLeft
			// 
			this.btnLeft.Location = new System.Drawing.Point(845, 538);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(89, 82);
			this.btnLeft.TabIndex = 4;
			this.btnLeft.Text = "Left";
			this.btnLeft.UseVisualStyleBackColor = true;
			this.btnLeft.Click += new System.EventHandler(this.HandleMovementButtonClick);
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(940, 538);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(89, 82);
			this.btnDown.TabIndex = 5;
			this.btnDown.Text = "Down";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.HandleMovementButtonClick);
			// 
			// btnRight
			// 
			this.btnRight.Location = new System.Drawing.Point(1035, 538);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(89, 82);
			this.btnRight.TabIndex = 6;
			this.btnRight.Text = "Right";
			this.btnRight.UseVisualStyleBackColor = true;
			this.btnRight.Click += new System.EventHandler(this.HandleMovementButtonClick);
			// 
			// lblMoves
			// 
			this.lblMoves.AutoSize = true;
			this.lblMoves.Location = new System.Drawing.Point(776, 111);
			this.lblMoves.Name = "lblMoves";
			this.lblMoves.Size = new System.Drawing.Size(59, 20);
			this.lblMoves.TabIndex = 7;
			this.lblMoves.Text = "Moves:";
			// 
			// lblBoxes
			// 
			this.lblBoxes.AutoSize = true;
			this.lblBoxes.Location = new System.Drawing.Point(947, 111);
			this.lblBoxes.Name = "lblBoxes";
			this.lblBoxes.Size = new System.Drawing.Size(137, 20);
			this.lblBoxes.TabIndex = 8;
			this.lblBoxes.Text = "Remaining Boxes:";
			// 
			// txtMoves
			// 
			this.txtMoves.Enabled = false;
			this.txtMoves.Location = new System.Drawing.Point(841, 108);
			this.txtMoves.Name = "txtMoves";
			this.txtMoves.Size = new System.Drawing.Size(100, 26);
			this.txtMoves.TabIndex = 9;
			// 
			// txtBoxes
			// 
			this.txtBoxes.Enabled = false;
			this.txtBoxes.Location = new System.Drawing.Point(1090, 108);
			this.txtBoxes.Name = "txtBoxes";
			this.txtBoxes.Size = new System.Drawing.Size(100, 26);
			this.txtBoxes.TabIndex = 10;
			// 
			// PlayForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1291, 689);
			this.Controls.Add(this.txtBoxes);
			this.Controls.Add(this.txtMoves);
			this.Controls.Add(this.lblBoxes);
			this.Controls.Add(this.lblMoves);
			this.Controls.Add(this.btnRight);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnLeft);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.panelGrid);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PlayForm";
			this.Text = "Play Form";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.Panel panelGrid;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Label lblMoves;
		private System.Windows.Forms.Label lblBoxes;
		private System.Windows.Forms.TextBox txtMoves;
		private System.Windows.Forms.TextBox txtBoxes;
	}
}