using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;

namespace KringleCon2018
{
    /// <summary>
    /// Interaction logic for BaseWindow.xaml
    /// </summary>
    public partial class BaseWindow
    {
        public List<string> Songs = new List<string> {
            "Brandenburgh #3",
            "Christmas in Hollis",
            "Dreidel",
            "Jingle Bells",
            "Let it Snow"
        };
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWindow"/> class
        /// </summary>
        public BaseWindow()
        {
            InitializeComponent();
            PlaySound(Songs[0]);
        }
        public void PlaySound(string song, Action done = null)
        {
            var ms = File.OpenRead($@"{Environment.CurrentDirectory}/Resources/Songs/{song}.mp3");
            var rdr = new Mp3FileReader(ms);
            var wavStream = WaveFormatConversionStream.CreatePcmStream(rdr);
            var baStream = new BlockAlignReductionStream(wavStream);
            var waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback());
            waveOut.Init(baStream);
            waveOut.Play();
            var bw = new BackgroundWorker();            
            bw.DoWork += (s, o) => {
                while (waveOut.PlaybackState == PlaybackState.Playing) { Thread.Sleep(100); }
                waveOut.Dispose();
                baStream.Dispose();
                wavStream.Dispose();
                rdr.Dispose();
                ms.Dispose();
                done?.Invoke();
                o.Result = o.Argument;
            };
            bw.RunWorkerAsync(song);
            bw.RunWorkerCompleted += ((s, o) => {
                var nextSong = Songs.IndexOf((string)o.Result) + 1;
                if (nextSong > (Songs.Count - 1)) { nextSong = 0; }
                PlaySound(Songs[nextSong]);
            });
        }
    }
}