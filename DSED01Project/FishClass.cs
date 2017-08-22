using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED01Project
{
    class FishClass
    {
        //public TYPE Type { get; set; }
        private static Random random = new Random(DateTime.Now.Millisecond);

        public static int baitRandom = random.Next(1, 7);
        public int bait = baitRandom;
        public static int counter = 7;
        public int countdown = counter;

        public int count()
        {
            counter--;
            return counter;
        }


        public int baitNum()
        {
            bait = bait - 1;
            return bait;
        }

        //public string bait()
        //{
        //    baitNum = baitNum - 1;
        //    return baitNum.ToString();
        //}

        //public string count()
        //{
        //    counter--;
        //    return counter.ToString();
        //}

        public void playGame() { }

    }
}
