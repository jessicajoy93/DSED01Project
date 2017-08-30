using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace DSED01Project
{
    class SoundsClass
    {
        private static SoundPlayer riverSound = new SoundPlayer(
            @"C:\Users\Jessica Anderson\Dropbox\DSED01Project\DSED01Project\Resources\flowing_water.wav");

        private static SoundPlayer reelSound = new SoundPlayer(
            @"C:\Users\Jessica Anderson\Dropbox\DSED01Project\DSED01Project\Resources\reel.wav");

        private static SoundPlayer winSound = new SoundPlayer(
            @"C:\Users\Jessica Anderson\Dropbox\DSED01Project\DSED01Project\Resources\win.wav");

        private static SoundPlayer loseSound = new SoundPlayer(
            @"C:\Users\Jessica Anderson\Dropbox\DSED01Project\DSED01Project\Resources\lose.wav");

        // Play Sound of River
        public static void PlayRiverSound()
        {
            riverSound.PlayLooping();
        }

        // Stop Sound of River
        public static void StopRiverSound()
        {
            riverSound.Stop();
        }

        // Play Sound of Reel
        public static void PlayReelSound()
        {
            reelSound.Play();
        }

        // Stop Sound of Reel
        public static void StopReelSound()
        {
            reelSound.Stop();
        }

        // Play Sound of Win
        public static void PlayWinSound()
        {
            winSound.Play();
        }

        // Stop Sound of Win
        public static void StopWinSound()
        {
            winSound.Stop();
        }

        // Play Sound of Win
        public static void PlayLoseSound()
        {
            loseSound.Play();
        }

        // Stop Sound of Win
        public static void StopLoseSound()
        {
            loseSound.Stop();
        }
    }
}
