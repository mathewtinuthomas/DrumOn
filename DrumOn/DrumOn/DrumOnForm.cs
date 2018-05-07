using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace DrumOn
{
    public partial class DrumOnForm : Form
    {
        MediaPlayer qBassPlayer;
        MediaPlayer wBassPlayer;
        MediaPlayer eSnarePlayer;
        MediaPlayer rSnarePlayer;
        MediaPlayer pHihatPlayer;
        MediaPlayer xHihatPlayer;
        MediaPlayer iOHihatPlayer;
        MediaPlayer cOHihatPlayer;
        MediaPlayer tTom1Player;
        MediaPlayer yTom1Player;
        MediaPlayer gTom2Player;
        MediaPlayer hTom2Player;
        MediaPlayer bFloortomPlayer;
        MediaPlayer nFloortomPlayer;
        MediaPlayer oCrashPlayer;
        MediaPlayer uCrashPlayer;
        MediaPlayer lRidePlayer;
        MediaPlayer mRidePlayer;
        MediaPlayer kRidecupPlayer;
        MediaPlayer jRidecupPlayer;
        MediaPlayer dotChinaPlayer;
        MediaPlayer zChinaPlayer;
        MediaPlayer commaSplashPlayer;
        MediaPlayer aSplashPlayer;

        string path = string.Empty;
        string filename = string.Empty;
        string extension = string.Empty;
        public DrumOnForm()
        {
            InitializeComponent();
            qBassPlayer = new MediaPlayer();
            wBassPlayer = new MediaPlayer();
            eSnarePlayer = new MediaPlayer();
            rSnarePlayer = new MediaPlayer();
            pHihatPlayer = new MediaPlayer();
            xHihatPlayer = new MediaPlayer();
            iOHihatPlayer = new MediaPlayer();
            cOHihatPlayer = new MediaPlayer();
            tTom1Player = new MediaPlayer();
            yTom1Player = new MediaPlayer();
            gTom2Player = new MediaPlayer();
            hTom2Player = new MediaPlayer();
            bFloortomPlayer = new MediaPlayer();
            nFloortomPlayer = new MediaPlayer();
            oCrashPlayer = new MediaPlayer();
            uCrashPlayer = new MediaPlayer();
            lRidePlayer = new MediaPlayer();
            mRidePlayer = new MediaPlayer();
            kRidecupPlayer = new MediaPlayer();
            jRidecupPlayer = new MediaPlayer();
            dotChinaPlayer = new MediaPlayer();
            zChinaPlayer = new MediaPlayer();
            commaSplashPlayer = new MediaPlayer();
            aSplashPlayer = new MediaPlayer();
        }

        private void DrumOnForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Q:
                    SetUriPathVariables("DrumSounds/", "Bass", ".wav");
                    Play(qBassPlayer);
                    break;
                case Keys.W:
                    SetUriPathVariables("DrumSounds/", "Bass", ".wav");
                    Play(wBassPlayer);
                    break;

                case Keys.E:
                    SetUriPathVariables("DrumSounds/", "Snare", ".wav");
                    Play(eSnarePlayer);
                    break;

                case Keys.R:
                    SetUriPathVariables("DrumSounds/", "Snare", ".wav");
                    Play(rSnarePlayer);
                    break;

                case Keys.P:
                    Stop(iOHihatPlayer);
                    Stop(cOHihatPlayer);
                    SetUriPathVariables("DrumSounds/", "HiHat", ".wav");
                    Play(pHihatPlayer);
                    break;
                case Keys.X:
                    Stop(iOHihatPlayer);
                    Stop(cOHihatPlayer);
                    SetUriPathVariables("DrumSounds/", "HiHat", ".wav");
                    Play(xHihatPlayer);
                    break;

                case Keys.I:
                    SetUriPathVariables("DrumSounds/", "OHiHat", ".wav");
                    Play(iOHihatPlayer);
                    break;
                case Keys.C:
                    SetUriPathVariables("DrumSounds/", "OHiHat", ".wav");
                    Play(cOHihatPlayer);
                    break;

                case Keys.T:
                    SetUriPathVariables("DrumSounds/", "Tom1", ".wav");
                    Play(tTom1Player);
                    break;
                case Keys.Y:
                    SetUriPathVariables("DrumSounds/", "Tom1", ".wav");
                    Play(yTom1Player);
                    break;

                case Keys.G:
                    SetUriPathVariables("DrumSounds/", "Tom2", ".wav");
                    Play(gTom2Player);
                    break;
                case Keys.H:
                    SetUriPathVariables("DrumSounds/", "Tom2", ".wav");
                    Play(hTom2Player);
                    break;

                case Keys.B:
                    SetUriPathVariables("DrumSounds/", "FloorTom", ".wav");
                    Play(bFloortomPlayer);
                    break;
                case Keys.N:
                    SetUriPathVariables("DrumSounds/", "FloorTom", ".wav");
                    Play(nFloortomPlayer);
                    break;

                case Keys.O:
                    SetUriPathVariables("DrumSounds/", "Crash", ".wav");
                    Play(oCrashPlayer);
                    break;
                case Keys.U:
                    SetUriPathVariables("DrumSounds/", "Crash", ".wav");
                    Play(uCrashPlayer);
                    break;

                case Keys.L:
                    SetUriPathVariables("DrumSounds/", "Ride", ".wav");
                    Play(lRidePlayer);
                    break;
                case Keys.M:
                    SetUriPathVariables("DrumSounds/", "Ride", ".wav");
                    Play(mRidePlayer);
                    break;

                case Keys.K:
                    SetUriPathVariables("DrumSounds/", "RideCup", ".wav");
                    Play(kRidecupPlayer);
                    break;
                case Keys.J:
                    SetUriPathVariables("DrumSounds/", "RideCup", ".wav");
                    Play(jRidecupPlayer);
                    break;

                case Keys.OemPeriod:
                    SetUriPathVariables("DrumSounds/", "China", ".wav");
                    Play(dotChinaPlayer);
                    break;
                case Keys.Z:
                    SetUriPathVariables("DrumSounds/", "China", ".wav");
                    Play(zChinaPlayer);
                    break;

                case Keys.Oemcomma:
                    SetUriPathVariables("DrumSounds/", "Splash", ".wav");
                    Play(commaSplashPlayer);
                    break;
                case Keys.A:
                    SetUriPathVariables("DrumSounds/", "Splash", ".wav");
                    Play(aSplashPlayer);
                    break;
            }
        }


        void Play(MediaPlayer player)
        {
            Uri uriSource = new Uri(CreatePath(path, filename, extension), UriKind.Relative);
            player.Open(uriSource);
            player.Play();
        }

        void Stop(MediaPlayer player)
        {
            player.Stop();
        }

        string CreatePath(string path, string filename, string extension)
        {
            return path + filename + extension;
        }

        void SetUriPathVariables(string pPath, string pFilename, string pExtension)
        {
            path = pPath;
            filename = pFilename;
            extension = pExtension;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 1.0\nCrafted By: Mathew Tinu Thomas\nDrop your comments to mathewtinuthomas@gmail.com.\nHappy drumming! :)","DrumOn");
        }
    }
}
