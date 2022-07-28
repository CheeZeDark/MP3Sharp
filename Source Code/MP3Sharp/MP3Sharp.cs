using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;

namespace MP3Sharp
{
    public class InitMP3Sharp
    {
        public IWavePlayer player;
        public AudioFileReader audioFile;
        public void PlayMP3(string filemp3)
        {
            player = new WaveOut();
            audioFile = new AudioFileReader(filemp3);
            player.Init(audioFile);
            player.Play();
        }
        public void StopMP3()
        {
            player.Stop();
            audioFile.Dispose();
            player.Dispose();
        }
    }
}
