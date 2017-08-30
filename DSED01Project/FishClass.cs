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
        SoundsClass mySoundClass = new SoundsClass();
        //public TYPE Type { get; set; }
        private static Random random = new Random(DateTime.Now.Millisecond);

        public int newCast;
        private int count;
        private bool IsBait = true;
        private int newBait;
        public bool fish = false;
        public bool boot = false;

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

        // create a button click code where you can change bait two times only
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

        // BaitIsTrue, checking to see whether Bait Button has been clicked 2 times. Boolean - either true or false. When True, button still visible. When false, button is hidden.
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
                SoundsClass.PlayWinSound();
                fish = true;
                //MessageBox.Show("You win!");

            }
            // if the count down equals the random number AND bait equals false - you lose
            else if (debugCountDown() == castNum() && bait() == false)
            {
                SoundsClass.PlayLoseSound();
                boot = true;
                //MessageBox.Show("You lose!");

            }
            // else countsdown by 1
            else
            {
                SoundsClass.PlayReelSound();
                countDown();
            }
        }

        // checking if pic of fish is visible
        public bool fishVisible()
        {
            return fish;
        }

        // checking if boot is visible
        public bool bootVisible()
        {
            return boot;
        }
    }
}
