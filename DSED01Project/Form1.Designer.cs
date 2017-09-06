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
            this.picGameOver = new System.Windows.Forms.PictureBox();
            this.picWinner = new System.Windows.Forms.PictureBox();
            this.picFish = new System.Windows.Forms.PictureBox();
            this.picBoot = new System.Windows.Forms.PictureBox();
            this.btnCast = new System.Windows.Forms.Button();
            this.btnBait = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.panelIntro.SuspendLayout();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.panelGame.Controls.Add(this.label2);
            this.panelGame.Controls.Add(this.picGameOver);
            this.panelGame.Controls.Add(this.picWinner);
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
            // picGameOver
            // 
            this.picGameOver.BackgroundImage = global::DSED01Project.Properties.Resources.game_over;
            this.picGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picGameOver.Location = new System.Drawing.Point(291, 0);
            this.picGameOver.Name = "picGameOver";
            this.picGameOver.Size = new System.Drawing.Size(511, 377);
            this.picGameOver.TabIndex = 4;
            this.picGameOver.TabStop = false;
            this.picGameOver.Visible = false;
            // 
            // picWinner
            // 
            this.picWinner.BackgroundImage = global::DSED01Project.Properties.Resources.winner;
            this.picWinner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWinner.Location = new System.Drawing.Point(291, 0);
            this.picWinner.Name = "picWinner";
            this.picWinner.Size = new System.Drawing.Size(508, 377);
            this.picWinner.TabIndex = 3;
            this.picWinner.TabStop = false;
            this.picWinner.Visible = false;
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem2.Text = "Play Game";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem1.Text = "Restart Game";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem.Text = "About Game";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playGameToolStripMenuItem,
            this.restartGameToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // playGameToolStripMenuItem
            // 
            this.playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            this.playGameToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.playGameToolStripMenuItem.Text = "Play Game";
            this.playGameToolStripMenuItem.Click += new System.EventHandler(this.playGameToolStripMenuItem_Click);
            // 
            // restartGameToolStripMenuItem
            // 
            this.restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            this.restartGameToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.restartGameToolStripMenuItem.Text = "Restart Game";
            this.restartGameToolStripMenuItem.Click += new System.EventHandler(this.restartGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem2});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem2.Text = "About";
            this.aboutToolStripMenuItem2.Click += new System.EventHandler(this.aboutToolStripMenuItem2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 141);
            this.label2.TabIndex = 5;
            this.label2.Text = "Can you catch the fish?\r\nYou have 2 chances to put new bait on your hook, if you " +
    "run out of bait you will end up catching a boot.";
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelIntro.ResumeLayout(false);
            this.panelGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.PictureBox picWinner;
        private System.Windows.Forms.PictureBox picGameOver;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem playGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.Label label2;
    }
}

