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

            lblCount.Text = myFishClass.Count().ToString();
            lblCast.Text = myFishClass.Cast().ToString();
            lblBait.Text = myFishClass.Bait().ToString();
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
            // debugging data to be deleted later
            lblBait.Text = myFishClass.baitNum().ToString();
        }

        // create a button click to count down the casts left
        private void btnCast_Click(object sender, EventArgs e)
        {
            //todo: if the count down equals the rnd AND fireaway equals true - you win
            //if (myFishClass.countDown())
            //{

            //}
            //else if ()
            //{

            //}
            //todo: if the count down equals the rnd AND fireaway equals false - you lose
            //else
            //{

            //}

            // debugging data to be deleted later
            lblCast.Text = myFishClass.castNum().ToString();
            lblCount.Text = myFishClass.countDown().ToString();

        }
    }
}
