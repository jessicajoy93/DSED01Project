using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED01Project
{
    /// <summary>
    /// 
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        // my classes
        #region Classes
        FishClass myFishClass = new FishClass();
        MenuClass myMenuClass = new MenuClass();
        SoundsClass mySoundClass = new SoundsClass();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        // Debug
        #region Debug
        private void Debug()
        {
            this.Text = myFishClass.debugBaitNum().ToString() + " Bait " + myFishClass.castNum().ToString() + "  Cast " + myFishClass.debugCountDown().ToString() + "  Countdown " + myFishClass.bait();
        }
        #endregion

        // Restart Game
        #region Restart Game
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGameVisible();
            SoundsClass.StopRiverSound();
            SoundsClass.StopReelSound();
            SoundsClass.StopWinSound();
            SoundsClass.StopLoseSound();
        }


        private void RestartGameVisible()
        {
            btnRestart.Visible = false;
            panelIntro.Visible = true;
            panelGame.Visible = false;
            myFishClass.Bait();
            myFishClass.BaitIsTrue();
            btnBait.Visible = true;
            myFishClass.Count();
            myFishClass.Cast();
            myFishClass.fish = false;
            myFishClass.boot = false;
            picFish.Visible = false;
            picBoot.Visible = false;
            picWinner.Visible = false;
            picGameOver.Visible = false;

        }
        #endregion

        // Play Game
        #region Play Game

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            PlayGameVisible();
            PlayGame();
            Debug();

            SoundsClass.PlayRiverSound();
        }

        private void PlayGame()
        {
            myFishClass.Count();
            myFishClass.Cast();
            myFishClass.Bait();
            myFishClass.BaitIsTrue();
        }

        private void PlayGameVisible()
        {
            panelIntro.Visible = false;
            panelGame.Visible = true;
            btnRestart.Visible = true;
            btnBait.Visible = true;
            btnCast.Visible = true;
        }
        #endregion

        private void btnBait_Click(object sender, EventArgs e)
        {
            myFishClass.baitNum();
            btnBait.Visible = myFishClass.bait();
            Debug();

        }

        // create a button click to count down the casts left
        private void btnCast_Click(object sender, EventArgs e)
        {
            myFishClass.PlayGame();
            picFish.Visible = myFishClass.fishVisible();
            picWinner.Visible = myFishClass.fishVisible();
            picBoot.Visible = myFishClass.bootVisible();
            picGameOver.Visible = myFishClass.bootVisible();

            Debug();
        }

        // Menu Items
        #region Menu
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // exit button
            myMenuClass.menuExit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RestartGameVisible();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // about game button
            myMenuClass.menuAbout();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PlayGameVisible();
        }
        #endregion

    }
}
