using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Threading;
using AForge.Video.FFMPEG;

namespace Blind
{
    public class ScreenRecorder
    {
        private int frameRate = 20;

        private int interval = 50;

        private Rectangle rect;

        private ConcurrentQueue<Bitmap> queue;

        private VideoFileWriter videoWriter;
        private VideoCodec videoCodec = VideoCodec.MSMPEG4v2;

        public int BitRate { get; set; } = 3000000;

        public int TotalFrame { get; private set; } = 0;

        public RecoderStatus Status { get; private set; } = RecoderStatus.Stop;

        private string filePath;

        private Thread thread;

        private ManualResetEvent stopSignal;

        void init()
        {
            queue = new ConcurrentQueue<Bitmap>();
            videoWriter = new VideoFileWriter();
            TotalFrame = 0;
            Status = RecoderStatus.Strat;
            stopSignal = new ManualResetEvent(false);
            interval = 1000 / frameRate;
        }

        private Bitmap CaptureScreen()
        {
            Bitmap img = new Bitmap(rect.Width, rect.Height);
            Graphics graphics = Graphics.FromImage(img);
            graphics.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size);
            return img;
        }

        public void Start(Rectangle rect)
        {
            this.rect = rect;
            this.filePath = $"{DateTime.Now:MMddHHmmss}" + ".avi";
            //this.filePath = "d:/qwe.avi";
            init();
            thread = new Thread(Run);
            videoWriter.Open(filePath,rect.Width,rect.Height,frameRate, videoCodec, BitRate);
            thread.Start();
        }

        private void Run()
        {
            Bitmap img = new Bitmap(rect.Width, rect.Height);
            Graphics graphics = Graphics.FromImage(img);
            while (!this.stopSignal.WaitOne(0, false))
            {
                DateTime now = DateTime.Now;
                try
                {
                    graphics.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size);
                    // queue.Enqueue(frame);
                    videoWriter.WriteVideoFrame(img);
                    TotalFrame++;
                    int time = interval - (int)DateTime.Now.Subtract(now).TotalMilliseconds;
                    if (time > 0)
                    {
                        if (this.stopSignal.WaitOne(time, false))
                            break;
                    }
                }
                catch (ThreadAbortException abort)
                {
                    break;
                }
                catch (Exception e)
                {
                    break;
                }
            }
            graphics.Dispose();
            img.Dispose();
        }

        public void Stop()
        {
            if (Status == RecoderStatus.Stop) return;
            stopSignal.Set();
            thread.Abort();
            thread.Join();
            stopSignal.Close();
            videoWriter.Close();
            Status = RecoderStatus.Stop;
        }

    }

    public enum RecoderStatus
    {
        Strat,
        Stop
    }
}