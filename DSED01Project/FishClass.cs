using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED01Project
{
    public class FishClass
    {
        //public TYPE Type { get; set; }
        private static Random random = new Random(DateTime.Now.Millisecond);

        public int newCast;
        private int count;
        private bool IsBait = true;
        private int newBait;
        public bool fish = false;
        public bool boot = false;

        SoundPlayer riverSound =
            new SoundPlayer(
                @"C:\Users\Jessica Anderson\Dropbox\DSED01Project\DSED01Project\Resources\flowing_water.wav");

        public int Count()
        {
            return count = 6;
        }

        // generate a random number
        public int Cast()
        {
            return newCast = random.Next(1, 7);
        }

        public bool BaitIsTrue()
        {
            IsBait = true;
            return IsBait;
        }
        public int Bait()
        {
            return newBait = 2;
        }

        public int Cast(int v)
        {
            throw new NotImplementedException();
        }

        // create countdown to count down from 6 to 1
        public int countDown()
        {
            count--;
            return count;
        }

        public int debugCountDown()
        {
            return count;
        }


        public int castNum()
        {
            return newCast;
        }

        public int baitNum()
        {
            newBait--;
            if (newBait == 0)
            {
                IsBait = false;
            }
            return newBait;
        }

        public int debugBaitNum()
        {
            return newBait;
        }

        public bool bait()
        {
            return IsBait;
        }

        public void PlayGame()
        {
            // if the count down equals the random number AND bait equals true - you win
            if (debugCountDown() == castNum() && bait() == true)
            {
                //picFish.Visible = true;
                fish = true;
                MessageBox.Show("You win!");
                //GameControlsHidden();
            }
            // if the count down equals the random number AND bait equals false - you lose
            else if (debugCountDown() == castNum() && bait() == false)
            {
                //picBoot.Visible = true;
                boot = true;
                MessageBox.Show("You lose!");
                //GameControlsHidden();
            }
            else
            {
                countDown();
            }
        }

        public bool fishVisible()
        {
            return fish;
        }

        public bool bootVisible()
        {
            return boot;
        }


        // Sounds

        // Stop Sound of River Playing
        public static void StopSoundRiver()
        {
            riverSound.Stop();
        }




    }
}
