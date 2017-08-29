namespace DSED01Project
{
    partial class Form1
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIntro = new System.Windows.Forms.Panel();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.picFish = new System.Windows.Forms.PictureBox();
            this.picBoot = new System.Windows.Forms.PictureBox();
            this.btnCast = new System.Windows.Forms.Button();
            this.btnBait = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelIntro.SuspendLayout();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(3, 561);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(127, 63);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 85F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(778, 230);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lets Go Fishing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelIntro
            // 
            this.panelIntro.BackColor = System.Drawing.Color.White;
            this.panelIntro.Controls.Add(this.label1);
            this.panelIntro.Controls.Add(this.btnPlayGame);
            this.panelIntro.Location = new System.Drawing.Point(0, 24);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(836, 642);
            this.panelIntro.TabIndex = 2;
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayGame.Location = new System.Drawing.Point(12, 233);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(802, 179);
            this.btnPlayGame.TabIndex = 2;
            this.btnPlayGame.Text = "Play Game!";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.Transparent;
            this.panelGame.Controls.Add(this.btnRestart);
            this.panelGame.Controls.Add(this.picFish);
            this.panelGame.Controls.Add(this.picBoot);
            this.panelGame.Controls.Add(this.btnCast);
            this.panelGame.Controls.Add(this.btnBait);
            this.panelGame.Location = new System.Drawing.Point(12, 24);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(802, 627);
            this.panelGame.TabIndex = 3;
            this.panelGame.Visible = false;
            // 
            // picFish
            // 
            this.picFish.BackColor = System.Drawing.Color.Transparent;
            this.picFish.BackgroundImage = global::DSED01Project.Properties.Resources.fish;
            this.picFish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFish.Location = new System.Drawing.Point(636, 447);
            this.picFish.Name = "picFish";
            this.picFish.Size = new System.Drawing.Size(158, 179);
            this.picFish.TabIndex = 0;
            this.picFish.TabStop = false;
            this.picFish.Visible = false;
            // 
            // picBoot
            // 
            this.picBoot.BackColor = System.Drawing.Color.Transparent;
            this.picBoot.BackgroundImage = global::DSED01Project.Properties.Resources.boot;
            this.picBoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoot.Location = new System.Drawing.Point(643, 448);
            this.picBoot.Name = "picBoot";
            this.picBoot.Size = new System.Drawing.Size(158, 179);
            this.picBoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoot.TabIndex = 0;
            this.picBoot.TabStop = false;
            this.picBoot.Visible = false;
            // 
            // btnCast
            // 
            this.btnCast.BackColor = System.Drawing.Color.White;
            this.btnCast.BackgroundImage = global::DSED01Project.Properties.Resources.fishing_pole;
            this.btnCast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCast.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCast.ForeColor = System.Drawing.Color.Green;
            this.btnCast.Location = new System.Drawing.Point(644, 104);
            this.btnCast.Name = "btnCast";
            this.btnCast.Size = new System.Drawing.Size(145, 85);
            this.btnCast.TabIndex = 1;
            this.btnCast.Text = "Fish";
            this.btnCast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCast.UseVisualStyleBackColor = false;
            this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
            // 
            // btnBait
            // 
            this.btnBait.BackColor = System.Drawing.Color.White;
            this.btnBait.BackgroundImage = global::DSED01Project.Properties.Resources.bait;
            this.btnBait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBait.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBait.ForeColor = System.Drawing.Color.Green;
            this.btnBait.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBait.Location = new System.Drawing.Point(644, 13);
            this.btnBait.Name = "btnBait";
            this.btnBait.Size = new System.Drawing.Size(145, 85);
            this.btnBait.TabIndex = 1;
            this.btnBait.Text = "Add Bait";
            this.btnBait.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBait.UseVisualStyleBackColor = false;
            this.btnBait.Click += new System.EventHandler(this.btnBait_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DSED01Project.Properties.Resources.fishing;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1182, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 421);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.White;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(826, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem1});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.homeToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Restart Game";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About Game";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Play Game";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DSED01Project.Properties.Resources.fishing;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(826, 663);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelIntro);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelIntro.ResumeLayout(false);
            this.panelGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panelIntro;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.PictureBox picBoot;
        private System.Windows.Forms.PictureBox picFish;
        private System.Windows.Forms.Button btnCast;
        private System.Windows.Forms.Button btnBait;
        protected System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

