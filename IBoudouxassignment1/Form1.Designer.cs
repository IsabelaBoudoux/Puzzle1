namespace IBoudouxassignment1
{
    partial class QPuzzel
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
            this.txtCol = new System.Windows.Forms.TextBox();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenarate = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnYellowDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnBlueDoor = new System.Windows.Forms.Button();
            this.btnYellowBox = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.btnBlueBox = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCol
            // 
            this.txtCol.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCol.Location = new System.Drawing.Point(220, 41);
            this.txtCol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(76, 20);
            this.txtCol.TabIndex = 0;
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(340, 39);
            this.txtRow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(76, 20);
            this.txtRow.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Col";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Row";
            // 
            // btnGenarate
            // 
            this.btnGenarate.Location = new System.Drawing.Point(433, 38);
            this.btnGenarate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenarate.Name = "btnGenarate";
            this.btnGenarate.Size = new System.Drawing.Size(68, 25);
            this.btnGenarate.TabIndex = 4;
            this.btnGenarate.Text = "Genarate";
            this.btnGenarate.UseVisualStyleBackColor = true;
            this.btnGenarate.Click += new System.EventHandler(this.btnGenarate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";

            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnYellowDoor
            // 
            this.btnYellowDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYellowDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYellowDoor.Image = global::IBoudouxassignment1.Properties.Resources.doorYellow;
            this.btnYellowDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYellowDoor.Location = new System.Drawing.Point(9, 492);
            this.btnYellowDoor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYellowDoor.Name = "btnYellowDoor";
            this.btnYellowDoor.Size = new System.Drawing.Size(199, 50);
            this.btnYellowDoor.TabIndex = 13;
            this.btnYellowDoor.Text = "YELLOW DOOR";
            this.btnYellowDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnYellowDoor.UseVisualStyleBackColor = true;
            this.btnYellowDoor.Click += new System.EventHandler(this.btnYellowDoor_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRedDoor.Image = global::IBoudouxassignment1.Properties.Resources.doorRed;
            this.btnRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.Location = new System.Drawing.Point(9, 437);
            this.btnRedDoor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(199, 50);
            this.btnRedDoor.TabIndex = 12;
            this.btnRedDoor.Text = "RED DOOR";
            this.btnRedDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.btnRedDoor_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGreenDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenDoor.Image = global::IBoudouxassignment1.Properties.Resources.doorGreen;
            this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGreenDoor.Location = new System.Drawing.Point(9, 382);
            this.btnGreenDoor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(199, 50);
            this.btnGreenDoor.TabIndex = 11;
            this.btnGreenDoor.Text = "GREEN DOOR";
            this.btnGreenDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.btnGreenDoor_Click);
            // 
            // btnBlueDoor
            // 
            this.btnBlueDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlueDoor.Image = global::IBoudouxassignment1.Properties.Resources.doorBlue;
            this.btnBlueDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlueDoor.Location = new System.Drawing.Point(9, 328);
            this.btnBlueDoor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBlueDoor.Name = "btnBlueDoor";
            this.btnBlueDoor.Size = new System.Drawing.Size(199, 50);
            this.btnBlueDoor.TabIndex = 10;
            this.btnBlueDoor.Text = "BLUE DOOR";
            this.btnBlueDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBlueDoor.UseVisualStyleBackColor = true;
            this.btnBlueDoor.Click += new System.EventHandler(this.btnBlueDoor_Click);
            // 
            // btnYellowBox
            // 
            this.btnYellowBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYellowBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYellowBox.Image = global::IBoudouxassignment1.Properties.Resources.boxYellow;
            this.btnYellowBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYellowBox.Location = new System.Drawing.Point(9, 275);
            this.btnYellowBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYellowBox.Name = "btnYellowBox";
            this.btnYellowBox.Size = new System.Drawing.Size(199, 50);
            this.btnYellowBox.TabIndex = 9;
            this.btnYellowBox.Text = "YELLOW BOX";
            this.btnYellowBox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnYellowBox.UseVisualStyleBackColor = true;
            this.btnYellowBox.Click += new System.EventHandler(this.btnYellowBox_Click);
            // 
            // btnRedBox
            // 
            this.btnRedBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRedBox.Image = global::IBoudouxassignment1.Properties.Resources.boxRed;
            this.btnRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.Location = new System.Drawing.Point(9, 220);
            this.btnRedBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(199, 50);
            this.btnRedBox.TabIndex = 8;
            this.btnRedBox.Text = "RED    BOX";
            this.btnRedBox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.btnRedBox_Click);
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGreenBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGreenBox.Image = global::IBoudouxassignment1.Properties.Resources.boxGreen;
            this.btnGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.Location = new System.Drawing.Point(9, 175);
            this.btnGreenBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(199, 50);
            this.btnGreenBox.TabIndex = 7;
            this.btnGreenBox.Text = "GREEN BOX";
            this.btnGreenBox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.btnGreenBox_Click);
            // 
            // btnBlueBox
            // 
            this.btnBlueBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBlueBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBlueBox.Image = global::IBoudouxassignment1.Properties.Resources.boxBlue;
            this.btnBlueBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueBox.Location = new System.Drawing.Point(9, 122);
            this.btnBlueBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBlueBox.Name = "btnBlueBox";
            this.btnBlueBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBlueBox.Size = new System.Drawing.Size(199, 50);
            this.btnBlueBox.TabIndex = 6;
            this.btnBlueBox.Text = "BLUE   BOX";
            this.btnBlueBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBlueBox.UseVisualStyleBackColor = true;
            this.btnBlueBox.Click += new System.EventHandler(this.btnBlueBox_Click);
            // 
            // btnWall
            // 
            this.btnWall.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWall.Image = global::IBoudouxassignment1.Properties.Resources.wall;
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.Location = new System.Drawing.Point(9, 67);
            this.btnWall.Margin = new System.Windows.Forms.Padding(0);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(199, 50);
            this.btnWall.TabIndex = 5;
            this.btnWall.Text = "WALL";
            this.btnWall.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.btnWall_Click);
            // 
            // btnNone
            // 
            this.btnNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNone.Location = new System.Drawing.Point(9, 547);
            this.btnNone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(199, 43);
            this.btnNone.TabIndex = 15;
            this.btnNone.Text = "NONE";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // QPuzzel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.btnYellowDoor);
            this.Controls.Add(this.btnRedDoor);
            this.Controls.Add(this.btnGreenDoor);
            this.Controls.Add(this.btnBlueDoor);
            this.Controls.Add(this.btnYellowBox);
            this.Controls.Add(this.btnRedBox);
            this.Controls.Add(this.btnGreenBox);
            this.Controls.Add(this.btnBlueBox);
            this.Controls.Add(this.btnWall);
            this.Controls.Add(this.btnGenarate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.txtCol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QPuzzel";
            this.Text = "QPuzzel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenarate;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnBlueBox;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnYellowBox;
        private System.Windows.Forms.Button btnBlueDoor;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnYellowDoor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnNone;
    }
}

