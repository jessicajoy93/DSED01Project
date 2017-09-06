using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSED01Project;

namespace FishingUnitTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void RandomNumberTest()
        {
            //  Random random = new Random(DateTime.Now.Millisecond);
            FishClass myFishClass = new FishClass();

            //myFishClass.newCast = ;
            int result = myFishClass.Cast();
            Assert.IsTrue(result > 0 && result < 7);

        }

        [TestMethod]
        public void CountTest()
        {
            //  Random random = new Random(DateTime.Now.Millisecond);
            FishClass myFishClass = new FishClass();

            //myFishClass.newCast = ;
            int result = myFishClass.Count();
            Assert.IsTrue(result > 0 && result < 7);

        }

        [TestMethod]
        public void BaitTest()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            FishClass myFishClass = new FishClass();

            //myFishClass.newCast = ;
            int result = myFishClass.Bait();
            Assert.IsTrue(result > 0 && result < 3);

        }
    }
}
