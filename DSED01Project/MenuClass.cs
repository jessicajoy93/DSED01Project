﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED01Project
{
    public class MenuClass
    {
        public void menuExit()
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public void menuAbout()
        {
            MessageBox.Show("Can you catch the fish? \n You have 2 chances to put new bait on your hook, if you run out of bait you will end up catching a boot.");
        }

    }
}
