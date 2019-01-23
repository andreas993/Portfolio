using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using CSCore.Streams;
using CSCore.Streams.Effects;
using CSCore.Visualization;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace MyMusicPlayerC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
  
    public partial class MainWindow : Window
    {
        bool isPlaying = false;
        public delegate void timerTick();
        DispatcherTimer ticks = new DispatcherTimer();
        timerTick tick;
        public MainWindow()
        {
            InitializeComponent();
            
        }


        public double GetPositionInSeconds()
        {
            return mediaElement1 != null ? mediaElement1.NaturalDuration.TimeSpan.Seconds : 0;
        }


        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OpenFolderButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                mediaElement1.LoadedBehavior = MediaState.Manual;
                mediaElement1.Source = new Uri(openFileDialog.FileName);
                mediaElement1.Play();

                // Automatically resize height and width relative to content
                this.SizeToContent = SizeToContent.Width;

                isPlaying = true;
            }
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (isPlaying == true)
            {
                mediaElement1.Stop();
                timelineSlider.Value = 0;
                mediaElement1.Play();
            }
 
                mediaElement1.Play();
                isPlaying = true;


        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Pause();
            isPlaying = false;
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            timelineSlider.Value = 0;
            mediaElement1.Stop();
            isPlaying = false;
        }

        private void ChangeMediaVolume(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            mediaElement1.Volume = (double)volumeSlider.Value;
        }

        // When the media opens, initialize the "Seek To" slider maximum value
        // to the total number of miliseconds in the length of the media clip.
        private void Element_MediaOpened(object sender, EventArgs e)
        {
            timelineSlider.Minimum = 0;
            timelineSlider.Maximum = mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds;
            mediaElement1.Position = new TimeSpan(0, 0, 0, 0, (int)timelineSlider.Value);
            ticks.Interval = TimeSpan.FromMilliseconds(1);
            ticks.Tick += ticks_Tick;
            tick = new timerTick(changeStatus);
            ticks.Start();
        }

        void ticks_Tick(object sender, object e)
        {
            Dispatcher.Invoke(tick);
        }

        void changeStatus()
        {
            /* If you want the Slider to Update Regularly Just UnComment the Line Below*/
            timelineSlider.Value = mediaElement1.Position.TotalMilliseconds;
            Duration.Text = Milliseconds_to_Minute((long)mediaElement1.Position.TotalMilliseconds);
        }

        public string Milliseconds_to_Minute(long milliseconds)
        {
            int minute = (int)(milliseconds / (1000 * 60));
            int seconds = (int)(milliseconds / 1000);
            return (minute + " : " + seconds);

        }

        private void DurationSlider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            /* Binds it to the Media Element */
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)timelineSlider.Value);
            mediaElement1.Position = ts;
        }


        private void Element_MediaEnded(object sender, EventArgs e)
        {
            mediaElement1.Stop();
        }


    }
}
