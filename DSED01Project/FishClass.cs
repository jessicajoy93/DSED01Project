using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED01Project
{
    class FishClass
    {
        //public TYPE Type { get; set; }
        private static Random random = new Random(DateTime.Now.Millisecond);
        private int newCast;
        private int count;
        private bool IsBait = true;
        private int newBait;
        //private int countdown = counter;

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

        // create countdown to count down from 6 to 1
        public int countDown()
        {
            count--;
            return count;
        }


        public int castNum()
        {
            newCast--;
            return newCast;
        }

        public int baitNum()
        {
            newBait--;
            if (newBait == 1)
            {
                IsBait = false;
            }
            return newBait;
        }

        public bool bait()
        {
            return IsBait;
        }

    }
}
