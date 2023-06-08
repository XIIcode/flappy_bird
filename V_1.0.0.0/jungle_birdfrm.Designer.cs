namespace Test01
{
    partial class jungle_birdfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu_bar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Coins = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_HighestScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_maximize = new System.Windows.Forms.Label();
            this.lbl_minimize = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.btn_maximize = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.lbl_pause = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipe = new System.Windows.Forms.PictureBox();
            this.btn_pause = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.ground_animal = new System.Windows.Forms.PictureBox();
            this.Menu_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground_animal)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_bar
            // 
            this.Menu_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Menu_bar.Controls.Add(this.label1);
            this.Menu_bar.Controls.Add(this.pictureBox3);
            this.Menu_bar.Controls.Add(this.pictureBox2);
            this.Menu_bar.Controls.Add(this.pictureBox1);
            this.Menu_bar.Controls.Add(this.lbl_Coins);
            this.Menu_bar.Controls.Add(this.lbl_Score);
            this.Menu_bar.Controls.Add(this.lbl_HighestScore);
            this.Menu_bar.Controls.Add(this.label3);
            this.Menu_bar.Controls.Add(this.lbl_close);
            this.Menu_bar.Controls.Add(this.lbl_maximize);
            this.Menu_bar.Controls.Add(this.lbl_minimize);
            this.Menu_bar.Controls.Add(this.btn_close);
            this.Menu_bar.Controls.Add(this.btn_maximize);
            this.Menu_bar.Controls.Add(this.btn_minimize);
            this.Menu_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu_bar.Location = new System.Drawing.Point(0, 0);
            this.Menu_bar.Name = "Menu_bar";
            this.Menu_bar.Size = new System.Drawing.Size(1256, 132);
            this.Menu_bar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(739, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 41);
            this.label1.TabIndex = 19;
            this.label1.Text = "use W to fly";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Test01.Properties.Resources.Bird_2_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(373, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Test01.Properties.Resources.Bird_2_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Test01.Properties.Resources._54767_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(3, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Coins
            // 
            this.lbl_Coins.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Coins.AutoSize = true;
            this.lbl_Coins.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Coins.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Coins.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Coins.Location = new System.Drawing.Point(76, 82);
            this.lbl_Coins.Name = "lbl_Coins";
            this.lbl_Coins.Size = new System.Drawing.Size(131, 41);
            this.lbl_Coins.TabIndex = 18;
            this.lbl_Coins.Text = "Coins : 0";
            // 
            // lbl_Score
            // 
            this.lbl_Score.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Score.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Score.Location = new System.Drawing.Point(76, 9);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(131, 41);
            this.lbl_Score.TabIndex = 17;
            this.lbl_Score.Text = "Score : 0";
            // 
            // lbl_HighestScore
            // 
            this.lbl_HighestScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_HighestScore.AutoSize = true;
            this.lbl_HighestScore.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HighestScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HighestScore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_HighestScore.Location = new System.Drawing.Point(437, 82);
            this.lbl_HighestScore.Name = "lbl_HighestScore";
            this.lbl_HighestScore.Size = new System.Drawing.Size(241, 41);
            this.lbl_HighestScore.TabIndex = 16;
            this.lbl_HighestScore.Text = "Highest Score : 0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(416, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 41);
            this.label3.TabIndex = 14;
            this.label3.Text = "Go Travel - Jungle  Bird\r\n";
            // 
            // lbl_close
            // 
            this.lbl_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(1178, 95);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(59, 28);
            this.lbl_close.TabIndex = 3;
            this.lbl_close.Text = "Close";
            this.lbl_close.Visible = false;
            // 
            // lbl_maximize
            // 
            this.lbl_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_maximize.AutoSize = true;
            this.lbl_maximize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maximize.ForeColor = System.Drawing.Color.White;
            this.lbl_maximize.Location = new System.Drawing.Point(1064, 95);
            this.lbl_maximize.Name = "lbl_maximize";
            this.lbl_maximize.Size = new System.Drawing.Size(95, 28);
            this.lbl_maximize.TabIndex = 2;
            this.lbl_maximize.Text = "Maximize";
            this.lbl_maximize.Visible = false;
            // 
            // lbl_minimize
            // 
            this.lbl_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_minimize.AutoSize = true;
            this.lbl_minimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimize.ForeColor = System.Drawing.Color.White;
            this.lbl_minimize.Location = new System.Drawing.Point(966, 95);
            this.lbl_minimize.Name = "lbl_minimize";
            this.lbl_minimize.Size = new System.Drawing.Size(92, 28);
            this.lbl_minimize.TabIndex = 1;
            this.lbl_minimize.Text = "Minimize";
            this.lbl_minimize.Visible = false;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Image = global::Test01.Properties.Resources.Close2;
            this.btn_close.Location = new System.Drawing.Point(1183, 21);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(61, 62);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_close.TabIndex = 2;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.closeclicked);
            this.btn_close.MouseLeave += new System.EventHandler(this.close_hover_finished);
            this.btn_close.MouseHover += new System.EventHandler(this.close_hover);
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.Image = global::Test01.Properties.Resources.maximize_2;
            this.btn_maximize.Location = new System.Drawing.Point(1078, 21);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(61, 62);
            this.btn_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_maximize.TabIndex = 2;
            this.btn_maximize.TabStop = false;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            this.btn_maximize.MouseLeave += new System.EventHandler(this.hover_finished);
            this.btn_maximize.MouseHover += new System.EventHandler(this.maximize_hover);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.Image = global::Test01.Properties.Resources.minimize_21;
            this.btn_minimize.Location = new System.Drawing.Point(978, 21);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(61, 62);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            this.btn_minimize.MouseLeave += new System.EventHandler(this.minimize_finished);
            this.btn_minimize.MouseHover += new System.EventHandler(this.minimize_hover);
            // 
            // lbl_pause
            // 
            this.lbl_pause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_pause.AutoSize = true;
            this.lbl_pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.lbl_pause.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pause.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_pause.Location = new System.Drawing.Point(640, 629);
            this.lbl_pause.Name = "lbl_pause";
            this.lbl_pause.Size = new System.Drawing.Size(61, 28);
            this.lbl_pause.TabIndex = 14;
            this.lbl_pause.Text = "Pause";
            this.lbl_pause.Visible = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.gametimerEvent);
            // 
            // pipe
            // 
            this.pipe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pipe.Image = global::Test01.Properties.Resources.pipedown;
            this.pipe.Location = new System.Drawing.Point(470, 130);
            this.pipe.Name = "pipe";
            this.pipe.Size = new System.Drawing.Size(51, 206);
            this.pipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe.TabIndex = 16;
            this.pipe.TabStop = false;
            // 
            // btn_pause
            // 
            this.btn_pause.AllowFocused = false;
            this.btn_pause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_pause.AutoSizeHeight = true;
            this.btn_pause.BorderRadius = 29;
            this.btn_pause.Image = global::Test01.Properties.Resources.pause;
            this.btn_pause.IsCircle = true;
            this.btn_pause.Location = new System.Drawing.Point(631, 661);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(58, 58);
            this.btn_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_pause.TabIndex = 4;
            this.btn_pause.TabStop = false;
            this.btn_pause.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            this.btn_pause.MouseLeave += new System.EventHandler(this.playfinished);
            this.btn_pause.MouseHover += new System.EventHandler(this.playhover);
            // 
            // Bird
            // 
            this.Bird.Image = global::Test01.Properties.Resources.Bird_Right_position;
            this.Bird.Location = new System.Drawing.Point(21, 202);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(115, 114);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 2;
            this.Bird.TabStop = false;
            // 
            // ground
            // 
            this.ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ground.Image = global::Test01.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 605);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1256, 115);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // ground_animal
            // 
            this.ground_animal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ground_animal.Image = global::Test01.Properties.Resources.Mechanical_Fox_removebg_preview;
            this.ground_animal.Location = new System.Drawing.Point(642, 369);
            this.ground_animal.Name = "ground_animal";
            this.ground_animal.Size = new System.Drawing.Size(280, 269);
            this.ground_animal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground_animal.TabIndex = 15;
            this.ground_animal.TabStop = false;
            // 
            // jungle_birdfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 720);
            this.Controls.Add(this.pipe);
            this.Controls.Add(this.lbl_pause);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.Menu_bar);
            this.Controls.Add(this.ground_animal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "jungle_birdfrm";
            this.Text = "jungle_birdfrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            this.Menu_bar.ResumeLayout(false);
            this.Menu_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground_animal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Menu_bar;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_maximize;
        private System.Windows.Forms.Label lbl_minimize;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.PictureBox btn_maximize;
        private System.Windows.Forms.PictureBox btn_minimize;
        private System.Windows.Forms.Label lbl_Coins;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_HighestScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Bird;
        private Bunifu.UI.WinForms.BunifuPictureBox btn_pause;
        private System.Windows.Forms.Label lbl_pause;
        private System.Windows.Forms.PictureBox ground_animal;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pipe;
    }
}