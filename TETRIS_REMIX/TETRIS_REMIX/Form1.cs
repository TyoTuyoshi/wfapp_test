using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TETRIS_REMIX
{
    public partial class GameRoom : Form
    {
        //メイン画面にあるボタンリスト
        private List<Button> mainButton = new List<Button>();

        public GameRoom()
        {
            InitializeComponent();
            mainButton = new List<Button>() { PlayButton, SampleButton, OptionButton };
        }

        private void GameRoom_Load(object sender, EventArgs e)
        {

        }

        enum MAIN_BUTTON
        {
            PLAY,
            SAMPLE,
            OPTION
        }

        private void PlayClick(object sender, EventArgs e)
        {
            //sampleパネルの表示/非表示
            if (playPanel.Visible)
            {
                playPanel.Visible = false;
                ButtonEnableSwitching(true);
            }
            else
            {
                playPanel.Visible = true;
                ButtonEnableSwitching(false, MAIN_BUTTON.PLAY);
            }
        }

        private void SampleClick(object sender, EventArgs e)
        {
            //sampleパネルの表示/非表示
            if (samplePanel.Visible)
            {
                samplePanel.Visible = false;
                ButtonEnableSwitching(true);
            }
            else
            {
                samplePanel.Visible = true;
                ButtonEnableSwitching(false, MAIN_BUTTON.SAMPLE);
            }
        }

        private void OptionClick(object sender, EventArgs e)
        {
            //optionパネルの表示/非表示
            if (optionPanel.Visible)
            { 
                optionPanel.Visible = false;
                ButtonEnableSwitching(true);
            }
            else
            {
                optionPanel.Visible = true;
                ButtonEnableSwitching(false, MAIN_BUTTON.OPTION);
            }
        }

        /// <summary>
        /// ボタンの表示/非表示　切り替え関数
        /// List<Button> MainButton 専用
        /// </summary>
        /// <param name="swt">true:ボタン全表示,false:numのみ表示</param>
        /// <param name="name">表示させたいボタンのMAIN_BUTTON</param>
        private void ButtonEnableSwitching(bool swt, MAIN_BUTTON name = MAIN_BUTTON.OPTION)
        {
            if (swt)
                foreach (var button in mainButton) button.Enabled = true;
            else
            {
                for (int i = 0; i < mainButton.Count; i++)
                {
                    if (i == (int)name) continue;
                    mainButton[i].Enabled = false;
                }
            }
        }

        //GitHubのリンクに飛ぶ
        private void jump_github(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TyoTuyoshi");
        }

        //オプションの表示切り替え
        private void TimeObserver_Tick(object sender, EventArgs e)
        {
            check_se.Text = check_se.Checked ? "SE-ON" : "SE-OFF";
            check_bgm.Text = check_bgm.Checked ? "BGM-ON" : "BGM-OFF";
        }

        //Clockサンプル
        private void Clock_Click(object sender, EventArgs e)
        {
            Clock sample_clock = new Clock();
            sample_clock.Show();
        }

        //Jumpサンプル
        private void Jump_Click(object sender, EventArgs e)
        {
            JumpGame jump = new JumpGame();
            jump.Show();
        }
    }
}
