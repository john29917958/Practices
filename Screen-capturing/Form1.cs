using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, ref Rectangle bounds);

        private readonly Process _targetProcess;
        private bool _isCapturing;

        public Form1()
        {
            InitializeComponent();

            _targetProcess = Process.GetProcessesByName("notepad")[0];
        }

        private void RefreshScreen()
        {
            while (_isCapturing)
            {
                Thread.Sleep(1000);

                if (CaptureScreen.InvokeRequired)
                {
                    CaptureScreen.Invoke(new Action(RefreshScreen));
                }
                else
                {
                    Rectangle bounds = new Rectangle();
                    GetWindowRect(_targetProcess.MainWindowHandle, ref bounds);

                    using (Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb))
                    using (Graphics gfx = Graphics.FromImage(screenshot))
                    {
                        gfx.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);
                        CaptureScreen.Image = screenshot;
                        CaptureScreen.Update();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_isCapturing) return;

            _isCapturing = true;

            new Thread(RefreshScreen)
            {
                IsBackground = true
            }.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _isCapturing = false;
        }
    }
}
