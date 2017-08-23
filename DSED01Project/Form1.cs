using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Debug()
        {
            this.Text = myFishClass.baitNum().ToString() + " Bait " + myFishClass.castNum().ToString() + "  Cast " + myFishClass.countDown().ToString() + "  Countdown " + myFishClass.bait();
            //this.Text = dice.ToString() + " Counter " + counter.ToString() + "  Firing " + IsFiringThisTurn + "  Protect jacket " + ProtectJacket;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGameVisible();
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
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            PlayGameVisible();

            myFishClass.Count();
            myFishClass.Cast();
            myFishClass.Bait();
            myFishClass.BaitIsTrue();
            Debug();
        }

        private void PlayGameVisible()
        {
            panelIntro.Visible = false;
            panelGame.Visible = true;
            btnRestart.Visible = true;
        }

        // todo: create a button click code where you can change bait two times only. Use a boolean to say when you cannot change bait any more
        private void btnBait_Click(object sender, EventArgs e)
        {
            btnBait.Visible = myFishClass.bait();
            //Debug();

        }

        // create a button click to count down the casts left
        private void btnCast_Click(object sender, EventArgs e)
        {
            //todo: if the countDown equals the castNum AND castNum equals true - you win
            if (myFishClass.countDown() == myFishClass.castNum())//&& myFishClass.bait() == true
            {
                MessageBox.Show("You win!");
            }
            //todo: if the count down equals the rnd AND fireaway equals false - you lose
            else if (myFishClass.countDown() == myFishClass.castNum() && myFishClass.bait() == false)
            {
                MessageBox.Show("You lose!");
            }
            Debug();
        }
    }
}
