
namespace TETRIS_REMIX
{
    partial class GameRoom
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlayButton = new System.Windows.Forms.Button();
            this.OptionButton = new System.Windows.Forms.Button();
            this.SampleButton = new System.Windows.Forms.Button();
            this.gitlink = new System.Windows.Forms.LinkLabel();
            this.check_se = new System.Windows.Forms.CheckBox();
            this.volume_se = new System.Windows.Forms.TrackBar();
            this.check_bgm = new System.Windows.Forms.CheckBox();
            this.optionPanel = new System.Windows.Forms.Panel();
            this.OptionClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.volume_bgm = new System.Windows.Forms.TrackBar();
            this.samplePanel = new System.Windows.Forms.Panel();
            this.Clock = new System.Windows.Forms.Button();
            this.SampleClose = new System.Windows.Forms.Button();
            this.playPanel = new System.Windows.Forms.Panel();
            this.PlayClose = new System.Windows.Forms.Button();
            this.Invader = new System.Windows.Forms.Button();
            this.Jump = new System.Windows.Forms.Button();
            this.Tetoris = new System.Windows.Forms.Button();
            this.TimeObserver = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.volume_se)).BeginInit();
            this.optionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bgm)).BeginInit();
            this.samplePanel.SuspendLayout();
            this.playPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.Image = global::TETRIS_REMIX.Properties.Resources.Title;
            this.PlayButton.Location = new System.Drawing.Point(95, 378);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(181, 78);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayClick);
            // 
            // OptionButton
            // 
            this.OptionButton.BackColor = System.Drawing.Color.Transparent;
            this.OptionButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OptionButton.ForeColor = System.Drawing.Color.White;
            this.OptionButton.Image = global::TETRIS_REMIX.Properties.Resources.Title;
            this.OptionButton.Location = new System.Drawing.Point(544, 378);
            this.OptionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OptionButton.Name = "OptionButton";
            this.OptionButton.Size = new System.Drawing.Size(181, 78);
            this.OptionButton.TabIndex = 1;
            this.OptionButton.Text = "Option";
            this.OptionButton.UseVisualStyleBackColor = false;
            this.OptionButton.Click += new System.EventHandler(this.OptionClick);
            // 
            // SampleButton
            // 
            this.SampleButton.BackColor = System.Drawing.Color.Transparent;
            this.SampleButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SampleButton.ForeColor = System.Drawing.Color.White;
            this.SampleButton.Image = global::TETRIS_REMIX.Properties.Resources.Title;
            this.SampleButton.Location = new System.Drawing.Point(315, 378);
            this.SampleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SampleButton.Name = "SampleButton";
            this.SampleButton.Size = new System.Drawing.Size(181, 78);
            this.SampleButton.TabIndex = 2;
            this.SampleButton.Text = "Sample";
            this.SampleButton.UseVisualStyleBackColor = false;
            this.SampleButton.Click += new System.EventHandler(this.SampleClick);
            // 
            // gitlink
            // 
            this.gitlink.AutoSize = true;
            this.gitlink.BackColor = System.Drawing.Color.Transparent;
            this.gitlink.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gitlink.LinkColor = System.Drawing.Color.Cyan;
            this.gitlink.Location = new System.Drawing.Point(486, 517);
            this.gitlink.Name = "gitlink";
            this.gitlink.Size = new System.Drawing.Size(268, 25);
            this.gitlink.TabIndex = 3;
            this.gitlink.TabStop = true;
            this.gitlink.Text = "developed by tuyoshi a.k.a 244";
            this.gitlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.jump_github);
            // 
            // check_se
            // 
            this.check_se.AutoSize = true;
            this.check_se.Location = new System.Drawing.Point(21, 46);
            this.check_se.Name = "check_se";
            this.check_se.Size = new System.Drawing.Size(60, 16);
            this.check_se.TabIndex = 4;
            this.check_se.Text = "SE-ON";
            this.check_se.UseVisualStyleBackColor = true;
            // 
            // volume_se
            // 
            this.volume_se.Location = new System.Drawing.Point(107, 46);
            this.volume_se.Name = "volume_se";
            this.volume_se.Size = new System.Drawing.Size(200, 45);
            this.volume_se.TabIndex = 5;
            // 
            // check_bgm
            // 
            this.check_bgm.AutoSize = true;
            this.check_bgm.Location = new System.Drawing.Point(21, 151);
            this.check_bgm.Name = "check_bgm";
            this.check_bgm.Size = new System.Drawing.Size(71, 16);
            this.check_bgm.TabIndex = 6;
            this.check_bgm.Text = "BGM-ON";
            this.check_bgm.UseVisualStyleBackColor = true;
            // 
            // optionPanel
            // 
            this.optionPanel.BackColor = System.Drawing.Color.White;
            this.optionPanel.Controls.Add(this.OptionClose);
            this.optionPanel.Controls.Add(this.label3);
            this.optionPanel.Controls.Add(this.label2);
            this.optionPanel.Controls.Add(this.label1);
            this.optionPanel.Controls.Add(this.volume_bgm);
            this.optionPanel.Controls.Add(this.check_bgm);
            this.optionPanel.Controls.Add(this.volume_se);
            this.optionPanel.Controls.Add(this.check_se);
            this.optionPanel.Location = new System.Drawing.Point(234, 130);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(348, 226);
            this.optionPanel.TabIndex = 7;
            this.optionPanel.Visible = false;
            // 
            // OptionClose
            // 
            this.OptionClose.Location = new System.Drawing.Point(262, 11);
            this.OptionClose.Name = "OptionClose";
            this.OptionClose.Size = new System.Drawing.Size(75, 23);
            this.OptionClose.TabIndex = 8;
            this.OptionClose.Text = "Close";
            this.OptionClose.UseVisualStyleBackColor = true;
            this.OptionClose.Click += new System.EventHandler(this.OptionClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Option";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Volume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Volume";
            // 
            // volume_bgm
            // 
            this.volume_bgm.Location = new System.Drawing.Point(107, 141);
            this.volume_bgm.Name = "volume_bgm";
            this.volume_bgm.Size = new System.Drawing.Size(200, 45);
            this.volume_bgm.TabIndex = 7;
            // 
            // samplePanel
            // 
            this.samplePanel.BackColor = System.Drawing.Color.White;
            this.samplePanel.Controls.Add(this.Clock);
            this.samplePanel.Controls.Add(this.SampleClose);
            this.samplePanel.Location = new System.Drawing.Point(234, 130);
            this.samplePanel.Name = "samplePanel";
            this.samplePanel.Size = new System.Drawing.Size(348, 226);
            this.samplePanel.TabIndex = 8;
            this.samplePanel.Visible = false;
            // 
            // Clock
            // 
            this.Clock.BackColor = System.Drawing.Color.Transparent;
            this.Clock.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Clock.ForeColor = System.Drawing.Color.White;
            this.Clock.Image = global::TETRIS_REMIX.Properties.Resources.Title;
            this.Clock.Location = new System.Drawing.Point(84, 88);
            this.Clock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(181, 78);
            this.Clock.TabIndex = 12;
            this.Clock.Text = "Clock";
            this.Clock.UseVisualStyleBackColor = false;
            this.Clock.Click += new System.EventHandler(this.Clock_Click);
            // 
            // SampleClose
            // 
            this.SampleClose.Location = new System.Drawing.Point(258, 11);
            this.SampleClose.Name = "SampleClose";
            this.SampleClose.Size = new System.Drawing.Size(75, 23);
            this.SampleClose.TabIndex = 11;
            this.SampleClose.Text = "Close";
            this.SampleClose.UseVisualStyleBackColor = true;
            this.SampleClose.Click += new System.EventHandler(this.SampleClick);
            // 
            // playPanel
            // 
            this.playPanel.BackColor = System.Drawing.Color.White;
            this.playPanel.Controls.Add(this.PlayClose);
            this.playPanel.Controls.Add(this.Invader);
            this.playPanel.Controls.Add(this.Jump);
            this.playPanel.Controls.Add(this.Tetoris);
            this.playPanel.Location = new System.Drawing.Point(265, 44);
            this.playPanel.Name = "playPanel";
            this.playPanel.Size = new System.Drawing.Size(293, 329);
            this.playPanel.TabIndex = 9;
            this.playPanel.Visible = false;
            // 
            // PlayClose
            // 
            this.PlayClose.Location = new System.Drawing.Point(201, 16);
            this.PlayClose.Name = "PlayClose";
            this.PlayClose.Size = new System.Drawing.Size(75, 23);
            this.PlayClose.TabIndex = 16;
            this.PlayClose.Text = "Close";
            this.PlayClose.UseVisualStyleBackColor = true;
            this.PlayClose.Click += new System.EventHandler(this.PlayClick);
            // 
            // Invader
            // 
            this.Invader.BackColor = System.Drawing.Color.Transparent;
            this.Invader.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Invader.ForeColor = System.Drawing.Color.White;
            this.Invader.Image = global::TETRIS_REMIX.Properties.Resources.Title;
            this.Invader.Location = new System.Drawing.Point(53, 237);
            this.Invader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Invader.Name = "Invader";
            this.Invader.Size = new System.Drawing.Size(181, 78);
            this.Invader.TabIndex = 15;
            this.Invader.Text = "Invader";
            this.Invader.UseVisualStyleBackColor = false;
            // 
            // Jump
            // 
            this.Jump.BackColor = System.Drawing.Color.Transparent;
            this.Jump.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Jump.ForeColor = System.Drawing.Color.White;
            this.Jump.Image = global::TETRIS_REMIX.Properties.Resources.Title;
            this.Jump.Location = new System.Drawing.Point(53, 144);
            this.Jump.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Jump.Name = "Jump";
            this.Jump.Size = new System.Drawing.Size(181, 78);
            this.Jump.TabIndex = 14;
            this.Jump.Text = "Jump";
            this.Jump.UseVisualStyleBackColor = false;
            this.Jump.Click += new System.EventHandler(this.Jump_Click);
            // 
            // Tetoris
            // 
            this.Tetoris.BackColor = System.Drawing.Color.Transparent;
            this.Tetoris.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tetoris.ForeColor = System.Drawing.Color.White;
            this.Tetoris.Image = global::TETRIS_REMIX.Properties.Resources.Title;
            this.Tetoris.Location = new System.Drawing.Point(53, 59);
            this.Tetoris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tetoris.Name = "Tetoris";
            this.Tetoris.Size = new System.Drawing.Size(181, 78);
            this.Tetoris.TabIndex = 13;
            this.Tetoris.Text = "Tetoris";
            this.Tetoris.UseVisualStyleBackColor = false;
            // 
            // TimeObserver
            // 
            this.TimeObserver.Enabled = true;
            this.TimeObserver.Tick += new System.EventHandler(this.TimeObserver_Tick);
            // 
            // GameRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TETRIS_REMIX.Properties.Resources.Title;
            this.ClientSize = new System.Drawing.Size(784, 559);
            this.Controls.Add(this.playPanel);
            this.Controls.Add(this.gitlink);
            this.Controls.Add(this.SampleButton);
            this.Controls.Add(this.OptionButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.samplePanel);
            this.Controls.Add(this.optionPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(800, 598);
            this.MinimumSize = new System.Drawing.Size(800, 598);
            this.Name = "GameRoom";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volume_se)).EndInit();
            this.optionPanel.ResumeLayout(false);
            this.optionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bgm)).EndInit();
            this.samplePanel.ResumeLayout(false);
            this.playPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button OptionButton;
        private System.Windows.Forms.Button SampleButton;
        private System.Windows.Forms.LinkLabel gitlink;
        private System.Windows.Forms.CheckBox check_se;
        private System.Windows.Forms.TrackBar volume_se;
        private System.Windows.Forms.CheckBox check_bgm;
        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar volume_bgm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OptionClose;
        private System.Windows.Forms.Panel samplePanel;
        private System.Windows.Forms.Button SampleClose;
        private System.Windows.Forms.Button Clock;
        private System.Windows.Forms.Panel playPanel;
        private System.Windows.Forms.Button Invader;
        private System.Windows.Forms.Button Jump;
        private System.Windows.Forms.Button Tetoris;
        private System.Windows.Forms.Button PlayClose;
        private System.Windows.Forms.Timer TimeObserver;
    }
}

