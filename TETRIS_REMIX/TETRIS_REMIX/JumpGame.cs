using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TETRIS_REMIX
{
    public partial class JumpGame : Form
    {
        Point pPos;
        public JumpGame()
        {
            InitializeComponent();
            //damage.Parent = player;
            this.KeyDown += JumpGame_KeyDown;
            player.Location = new Point(60, 300);
        }
        private double mim = 0.0f;
        private bool jump = false;

        private void JumpGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Up:
                    jump = true;
                    //player.Location = new Point(60, 200);
                    break;
                case Keys.Down:
                    //player.Location = new Point(60, 300);
                    break;
                default:
                    //jump = false;
                    //mim = 0.001f;
                    break;
            }
        }
        private int i = 1;
        private float t = 0;
        private int time = 0;
        private int v0 = 60;

        private void update_Tick(object sender, EventArgs e)
        {
            damage.Location = new Point(500 - i, 300);
            i += 6;
            i %= 500;

            double y = v0 * t - 0.5 * 9.8 * t * t;

            if (time % 1000 == 0)
            {
                update.Interval /= 2 + 1;
            }

            if (i % 60 < 30)
            {
                player.BackgroundImage = Properties.Resources.img_face1;
            }
            else
            {
                player.BackgroundImage = Properties.Resources.img_face2;
            }

            //鉛直投げ上げ(ジャンプ)
            if (jump)
            {
                if (y < 0)
                {
                    y = 0;
                    t = 0;
                    jump = false;
                }
                player.Location = new Point(60, 300 - (int)y);
                t += 0.5f;
            }

            //円の当たり判定
            Point playerPos = new Point(player.Location.X, player.Location.Y);
            Point damagePos = new Point(damage.Location.X, damage.Location.Y);

            int p_radius = player.Width / 2;
            int d_radius = damage.Height / 2;

            int dist_x = p_radius * (playerPos.X + p_radius) - d_radius * (damagePos.X + d_radius);
            int dist_y = p_radius * (playerPos.Y + p_radius) - d_radius * (damagePos.Y + d_radius);

            int distance = (int)Math.Sqrt(dist_x * dist_x + dist_y * dist_y) / 10;

            bool hit = (distance <= (p_radius + d_radius) * 1.5);
            bool hit2 = (Math.Abs(playerPos.X + p_radius * 2 - damagePos.X) < 1);

            if (hit || hit2)
            {
                player.BackgroundImage = Properties.Resources.img_face3;

                update.Enabled = false;
                label1.Text = "GAMEOVER";
            }

            label2.Text = hit.ToString();
            label3.Text =
                $"P :{player.Location.X}, {player.Location.Y}" +
                $"\nC :{damage.Location.X}, {damage.Location.Y}" +
                $"\nD :{distance}";
            time += 1;
        }

        private void JumpGame_Load(object sender, EventArgs e)
        {

        }
    }
}
