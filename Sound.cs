using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Reflection;

namespace OKF_Jelenetes
{
    class Sound
    {
        public static void PlaySound(string SoundName)
        {
            Stream file = Assembly.GetExecutingAssembly().GetManifestResourceStream(SoundName);
            var Player = new SoundPlayer(file);
            Player.Play();
        }

        public static void PlaySound(Stream SoundStream)
        {
            var Player = new SoundPlayer(SoundStream);
            Player.Play();
        }
    }
}
