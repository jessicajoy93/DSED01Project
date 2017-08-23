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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelIntro = new System.Windows.Forms.Panel();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.btnCast = new System.Windows.Forms.Button();
            this.btnBait = new System.Windows.Forms.Button();
            this.picBoot = new System.Windows.Forms.PictureBox();
            this.picFish = new System.Windows.Forms.PictureBox();
            this.panelIntro.SuspendLayout();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFish)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(616, 443);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 63);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(350, 443);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(127, 63);
            this.btnPlayAgain.TabIndex = 0;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(483, 443);
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
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "How Many Fish Can You Get?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(731, 144);
            this.label2.TabIndex = 1;
            this.label2.Text = "See how many fish you can catch.\r\nTo win the game you need to get a score 400 poi" +
    "nts.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelIntro
            // 
            this.panelIntro.Controls.Add(this.btnPlayGame);
            this.panelIntro.Controls.Add(this.label1);
            this.panelIntro.Controls.Add(this.label2);
            this.panelIntro.Location = new System.Drawing.Point(12, 12);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(731, 425);
            this.panelIntro.TabIndex = 2;
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayGame.Location = new System.Drawing.Point(10, 233);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(709, 179);
            this.btnPlayGame.TabIndex = 2;
            this.btnPlayGame.Text = "Play Game!";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.btnCast);
            this.panelGame.Controls.Add(this.btnBait);
            this.panelGame.Controls.Add(this.picBoot);
            this.panelGame.Controls.Add(this.picFish);
            this.panelGame.Location = new System.Drawing.Point(9, 15);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(731, 425);
            this.panelGame.TabIndex = 3;
            this.panelGame.Visible = false;
            // 
            // btnCast
            // 
            this.btnCast.BackColor = System.Drawing.Color.White;
            this.btnCast.BackgroundImage = global::DSED01Project.Properties.Resources.fishing_pole;
            this.btnCast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCast.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCast.ForeColor = System.Drawing.Color.Green;
            this.btnCast.Location = new System.Drawing.Point(142, 4);
            this.btnCast.Name = "btnCast";
            this.btnCast.Size = new System.Drawing.Size(130, 177);
            this.btnCast.TabIndex = 1;
            this.btnCast.Text = "Fish";
            this.btnCast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCast.UseVisualStyleBackColor = false;
            this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
            // 
            // btnBait
            // 
            this.btnBait.BackgroundImage = global::DSED01Project.Properties.Resources.bait;
            this.btnBait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBait.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBait.Location = new System.Drawing.Point(5, 4);
            this.btnBait.Name = "btnBait";
            this.btnBait.Size = new System.Drawing.Size(131, 177);
            this.btnBait.TabIndex = 1;
            this.btnBait.Text = "Add Bait";
            this.btnBait.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBait.UseVisualStyleBackColor = true;
            this.btnBait.Click += new System.EventHandler(this.btnBait_Click);
            // 
            // picBoot
            // 
            this.picBoot.BackgroundImage = global::DSED01Project.Properties.Resources.boot;
            this.picBoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoot.Location = new System.Drawing.Point(573, 243);
            this.picBoot.Name = "picBoot";
            this.picBoot.Size = new System.Drawing.Size(158, 179);
            this.picBoot.TabIndex = 0;
            this.picBoot.TabStop = false;
            this.picBoot.Visible = false;
            // 
            // picFish
            // 
            this.picFish.BackgroundImage = global::DSED01Project.Properties.Resources.fish;
            this.picFish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFish.Location = new System.Drawing.Point(409, 243);
            this.picFish.Name = "picFish";
            this.picFish.Size = new System.Drawing.Size(158, 179);
            this.picFish.TabIndex = 0;
            this.picFish.TabStop = false;
            this.picFish.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 520);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelIntro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelIntro.ResumeLayout(false);
            this.panelGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlayAgain;
        public System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panelIntro;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.PictureBox picBoot;
        private System.Windows.Forms.PictureBox picFish;
        private System.Windows.Forms.Button btnCast;
        private System.Windows.Forms.Button btnBait;
        protected System.Windows.Forms.Panel panelGame;
    }
}

