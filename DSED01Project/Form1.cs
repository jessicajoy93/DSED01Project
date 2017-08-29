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
        FishClass myFishClass = new FishClass();
        MenuClass myMenuClass = new MenuClass();

        public Form1()
        {
            InitializeComponent();
        }

        #region Debug
        private void Debug()
        {
            this.Text = myFishClass.debugBaitNum().ToString() + " Bait " + myFishClass.castNum().ToString() + "  Cast " + myFishClass.debugCountDown().ToString() + "  Countdown " + myFishClass.bait();
        }
        #endregion

        #region Restart Game
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGameVisible();
            StopSoundRiver();
        }

        //private static void StopSoundRiver()
        //{
        //    SoundPlayer simpleSound =
        //                    new SoundPlayer(
        //                        @"C:\Users\Jessica Anderson\Dropbox\DSED01Project\DSED01Project\Resources\flowing_water.wav");
        //    simpleSound.Stop();
        //}

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
        }
        #endregion

        #region Play Game

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            PlayGameVisible();
            PlayGame();
            Debug();

            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Jessica Anderson\Dropbox\DSED01Project\DSED01Project\Resources\flowing_water.wav");
            simpleSound.Play();

            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Audio Files (.wav)|*.wav";

            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    string path = dialog.FileName;
            //    PlaySound(path);
            //}


        }

        //private void PlaySound(string path)
        //{
        //    System.Media.SoundPlayer player =
        //        new System.Media.SoundPlayer();
        //    player.SoundLocation = path;
        //    player.Load();
        //    player.Play();
        //}

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

        // todo: create a button click code where you can change bait two times only. Use a boolean to say when you cannot change bait any more
        private void btnBait_Click(object sender, EventArgs e)
        {
            myFishClass.baitNum();
            btnBait.Visible = myFishClass.bait();
            Debug();

        }

        // create a button click to count down the casts left
        private void btnCast_Click(object sender, EventArgs e)
        {
            //todo: if the countDown equals the castNum AND castNum equals true - you win
            myFishClass.PlayGame();
            picFish.Visible = myFishClass.fishVisible();
            picBoot.Visible = myFishClass.bootVisible();
            //PlayGame();
            //GameControlsHidden();
            Debug();
        }

        //private void PlayGame()
        //{
        //    //if (myFishClass.debugCountDown() == myFishClass.castNum() && myFishClass.bait() == true)
        //    //{
        //    //    picFish.Visible = true;
        //    //    MessageBox.Show("You win!");
        //    //    GameControlsHidden();
        //    //}
        //    ////todo: if the count down equals the rnd AND fireaway equals false - you lose
        //    //else if (myFishClass.debugCountDown() == myFishClass.castNum() && myFishClass.bait() == false)
        //    //{
        //    //    picBoot.Visible = true;
        //    //    MessageBox.Show("You lose!");

        //    //}
        //    //else
        //    //{
        //    //    myFishClass.countDown();
        //    //}
        //}

        private void GameControlsHidden()
        {
            btnBait.Visible = false;
            btnCast.Visible = false;
        }


        // Menu Items
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
    }
}
