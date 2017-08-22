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
    /// todo: generate a random number
    /// todo: create  count down code under fire button to count down from 6 to 1
    /// todo: create a button click to count down the fireaway
    /// todo: create  fire away code where you can fire away for two times only. Use a boolean to say when you cannot fire away any more
    /// todo: if the count down equals the rnd AND fireaway equals true - you win
    /// todo: if the count down equals the rnd AND fireaway equals false - you lose
    /// </summary>
    public partial class Form1 : Form
    {
        FishClass myFishClass = new FishClass();

        public Form1()
        {
            InitializeComponent();
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
            myFishClass.counter;
            if (myFishClass != null) myFishClass.bait;
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            PlayGameVisible();

            lblBait.Text = myFishClass.baitNum().ToString();
            lblCount.Text = myFishClass.count().ToString();
        }

        private void PlayGameVisible()
        {
            panelIntro.Visible = false;
            panelGame.Visible = true;
            btnRestart.Visible = true;
        }

        private void btnBait_Click(object sender, EventArgs e)
        {
            //if (myFishClass.baitNum() > 0)
            //{
            lblBait.Text = myFishClass.baitNum().ToString();
            lblCount.Text = myFishClass.count().ToString();
            //}
            //else
            //{
            //lblBait.Visible = false;
            //}

        }
    }
}
