using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TETRIS_REMIX
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }
        private Color penColor = new Color();
        private int time_rgb = 0;

        private void TimeObserver_Tick(object sender, EventArgs e)
        {
            //デジタル時計
            DateTime dateTime = DateTime.Now;
            int second = dateTime.Second;
            int minute = dateTime.Minute;
            int hour = dateTime.Hour;
            DateLabel.Text = $"{dateTime.Month}/{dateTime.Day} ({dateTime.DayOfWeek})";
            TimeLabel.Text = $"{hour.ToString("00")}:{minute.ToString("00")}:{second.ToString("00")}";

            //アナログ時計
            penColor = Color.FromArgb(time_rgb, 50, time_rgb);
            //penColor = Color.FromArgb(100, 100, 100);

            Pen pen = new Pen(penColor, 2);

            //キャンバス
            int width = ClockImage.Width;
            int height = ClockImage.Height;
            Bitmap canvas = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(canvas);

            int r = (int)(200 * Math.Cos(2 * 3.14 * second / 60));//時計盤半径
            int r2 = (int)(240 * Math.Sin(2 * 3.14 * second / 60));

            int sec_len = 120;//秒針
            int min_len = 75;//分針
            int hor_len = 50;//時針
            int offset = -15;//時間のオフセット
            //時間分秒
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawLine(pen, width / 2, height / 2,
               width / 2 - (int)(hor_len * Math.Cos(2 * 3.14 * ((hour % 12) + 3) / 12)),
               height / 2 - (int)(hor_len * Math.Sin(2 * 3.14 * ((hour % 12) + 3) / 12)));
            g.DrawLine(pen, width / 2, height / 2,
               width / 2 + (int)(min_len * Math.Cos(2 * 3.14 * (minute + offset) / 60)),
               height / 2 + (int)(min_len * Math.Sin(2 * 3.14 * (minute + offset) / 60)));
            g.DrawLine(pen, width / 2, height / 2,
                width / 2 + (int)(sec_len * Math.Cos(2 * 3.14 * (second + offset) / 60)),
                height / 2 + (int)(sec_len * Math.Sin(2 * 3.14 * (second + offset) / 60)));
            g.DrawEllipse(pen, width / 2 - r / 2, height / 2 - r / 2, r, r);
            g.DrawEllipse(pen, width / 2 - r2 / 2, height / 2 - r2 / 2, r2, r2);
            g.Dispose();

            ClockImage.Image = canvas;
            ClockImage.Invalidate();
            time_rgb++;
            time_rgb %= 256;
        }

        private void Clock_Load(object sender, EventArgs e)
        {

        }
    }
}
