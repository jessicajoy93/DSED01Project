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

        private static Random random = new Random(DateTime.Now.Millisecond);

        public int newCast;
        private int count;
        private bool IsBait = true;
        private int newBait;
        private bool fish;
        private bool boot;

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
            // if the count down equals the random number AND bait equals true - you lose
            if (debugCountDown() == castNum() && bait() == false)
            {
                SoundsClass.PlayLoseSound();
                boot = true;
                //MessageBox.Show("You lose!");

            }
            // if the count down equals the random number AND bait equals false - you win
            else if ((debugCountDown() == castNum() && bait() == true))
            {

                SoundsClass.PlayWinSound();
                fish = true;
                //MessageBox.Show("You win!");

            }
            // else countsdown by 1
            else
            {
                SoundsClass.PlayReelSound();
                countDown();
            }
        }

        // checking if pic of fish is visible
        public bool Fish()
        {
            return fish = false;
        }

        public bool fishVisible()
        {
            return fish;
        }

        // checking if boot is visible
        public bool Boot()
        {
            return boot = false;
        }

        public bool bootVisible()
        {
            return boot;
        }
    }
}
