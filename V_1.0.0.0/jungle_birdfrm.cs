using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AxWMPLib;

namespace Test01
{
    public partial class jungle_birdfrm : Form
    {
        WMPLib.WindowsMediaPlayer player_shark = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player_owl = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player_antelope = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player_Rhino = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player_Squirrel = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player_Duck = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player_fox = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player_Dog = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player_ground = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player_quit_game = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player_menu_button = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player_coins = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player_default = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player_highscore = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player_checkpoint = new WMPLib.WindowsMediaPlayer();
        Random rnd = new Random();
        string[] ground_creatures = {
            "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\Mechanical_Fish-removebg-preview.png",
            "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\blue_Rhino-removebg-preview.png",
            "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\blue_Dog-removebg-preview.png",
            "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\blue_Fox-removebg-preview.png",
            "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\Dog-removebg-preview.png",
            "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\fx94_5dti_201103-removebg-preview.png",
            "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\Mech_Dog-removebg-preview.png",
            "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\Mechanical_Fox-removebg-preview.png",
            "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\Red_Antelope-removebg-preview.png",
            "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\Red_Fox-removebg-preview.png",
            "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\blue_Owl-removebg-preview.png",
            "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\Mechanical_Duck-removebg-preview.png",
            "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\Red_Owl-removebg-preview.png",
            "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\Red_Squirrel-removebg-preview.png"};

        public jungle_birdfrm()
        {

            InitializeComponent();
            lbl_pause.Text = "Pause";
            btn_pause.ImageLocation = "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\pause.png";
            //player_menu_button.URL = "C:\\Users\\DX7\\Music\\Game_music\\Click_Menu.mp3";
            //player_menu_button.settings.autoStart = false;
            //player_coins.URL = "C:\\Users\\DX7\\Music\\Game_music\\coins.wav";
            //player_coins.settings.autoStart = false;
            //player_default.URL = "C:\\Users\\DX7\\Music\\Game_music\\African.mp3";
            //player_default.settings.autoStart = false;
            //player_checkpoint.URL = "C:\\Users\\DX7\\Music\\Game_music\\checkpoint.mp3";
            SqlConnection con = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=Flappy_Game;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from High_Score", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                db_cached_high_score = reader.GetInt32(1);
                break;
            }
            con.Close();
            lbl_HighestScore.Text = "Highest Score : " + db_cached_high_score.ToString();

            SqlConnection coin_fetch = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=Flappy_Game;Integrated Security=True;Pooling=False");
            coin_fetch.Open();
            SqlCommand cf = new SqlCommand("select * from Game_Data", coin_fetch);
            SqlDataReader cf_reader = cf.ExecuteReader();
            while (cf_reader.Read())
            {
                db_cached_coins = cf_reader.GetInt32(2);
                break;
            }
            coin_fetch.Close();
            coins = db_cached_coins;
            lbl_Coins.Text = "Coins : " + coins.ToString();

        }
        int gravity = 10;
        int obstacle_Speed = 10;
        int score = 0;
        int coins = 0;
        bool mute_status = true;
        int db_cached_high_score = 0;
        int db_cached_coins = 0;
        bool check_point_reached = false;
        private void Update_Db_GameData()
        {

            SqlConnection con = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=Flappy_Game;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand coins_fetch = new SqlCommand("Select * from Game_Data", con);
            SqlCommand cmd = new SqlCommand("update Game_Data set score=@Score,coins=@Coins", con);
            cmd.Parameters.AddWithValue("@Score", score);
            cmd.Parameters.AddWithValue("@Coins", coins);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        private void HighestScore()
        {
            if (score > db_cached_high_score)
            {
                //player_highscore.URL = "C:\\Users\\DX7\\Music\\Game_music\\High_score.mp3";
                //player_highscore.settings.autoStart = false;
                //player_highscore.controls.play();
                lbl_HighestScore.Text = "Highest Score : " + score.ToString();
                SqlConnection pt = new SqlConnection("Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=Flappy_Game;Integrated Security=True;Pooling=False");
                pt.Open();
                SqlCommand del = new SqlCommand("delete High_Score", pt);
                del.ExecuteNonQuery();
                SqlCommand insert = new SqlCommand("Insert into High_Score values(@Highest)", pt);
                insert.Parameters.AddWithValue("@Highest", score);
                insert.ExecuteNonQuery();
                pt.Close();
            }

        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void when_hover(object sender, EventArgs e)
        {
            lbl_close.Visible = true;
        }

        private void hover_finished(object sender, EventArgs e)
        {
            lbl_maximize.Visible=false;
        }

        private void maximize_hover(object sender, EventArgs e)
        {
            lbl_maximize.Visible=true;
        }

        private void close_hover(object sender, EventArgs e)
        {
            lbl_close.Visible = true;
        }

        private void close_hover_finished(object sender, EventArgs e)
        {
            lbl_close.Visible =false;
        }

        private void minimize_hover(object sender, EventArgs e)
        {
            lbl_minimize.Visible=true;
        }

        private void minimize_finished(object sender, EventArgs e)
        {
            lbl_minimize.Visible = false;
        }

        private void playhover(object sender, EventArgs e)
        {
            lbl_pause.Visible=true;
        }

        private void playfinished(object sender, EventArgs e)
        {
            lbl_pause.Visible = false;
        }

        private void mutehover(object sender, EventArgs e)
        {
        }

        private void mutefinished(object sender, EventArgs e)
        {
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                gravity = +10;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                gravity = -15;
            }
        }

        private void gametimerEvent(object sender, EventArgs e)
        {
            //player_default.controls.play();
            Bird.Top += gravity;
            ground_animal.Left -= obstacle_Speed;
            pipe.Left -= obstacle_Speed;
            if (pipe.Left < -50)
            {
                pipe.Left = 800;
                score += 1;
                lbl_Score.Text = "Score : " + score.ToString();
                if (score > db_cached_high_score && check_point_reached == false)
                {
                    //player_checkpoint.controls.play();
                    check_point_reached = true;
                }
                coins += 2;
                //player_coins.controls.play();
                lbl_Coins.Text = "Coins : " + coins.ToString();
            }
            if (ground_animal.Left < -70)
            {
                ground_animal.ImageLocation = ground_creatures[rnd.Next(ground_creatures.Length)];
                ground_animal.Left = 900;
                score += 1;
                lbl_Score.Text = "Score : " + score.ToString();
                if (score > db_cached_high_score && check_point_reached == false)
                {
                    //player_checkpoint.controls.play();
                    check_point_reached = true;
                }
                coins += 2;
                //player_coins.controls.play();
                lbl_Coins.Text = "Coins : " + coins.ToString();
            }
            if (Bird.Bounds.IntersectsWith(ground_animal.Bounds) ||
            Bird.Bounds.IntersectsWith(ground.Bounds) ||
            Bird.Bounds.IntersectsWith(pipe.Bounds) || Bird.Bounds.IntersectsWith(Menu_bar.Bounds) ||
            Bird.Bounds.IntersectsWith(Menu_bar.Bounds))
            {
                if (Bird.Bounds.IntersectsWith(ground.Bounds) || Bird.Bounds.IntersectsWith(pipe.Bounds) || Bird.Bounds.IntersectsWith(Menu_bar.Bounds))
                {
                    Endgame(0);
                }
                if (ground_animal.ImageLocation == ground_creatures[0])
                {
                    Endgame(8);
                }
                else if (ground_animal.ImageLocation == ground_creatures[1])
                {
                    Endgame(3);
                }
                else if (ground_animal.ImageLocation == ground_creatures[2] || ground_animal.ImageLocation == ground_creatures[4] || ground_animal.ImageLocation == ground_creatures[6])
                {
                    Endgame(7);
                }
                else if (ground_animal.ImageLocation == ground_creatures[3] || ground_animal.ImageLocation == ground_creatures[7])
                {
                    Endgame(6);
                }
                else if (ground_animal.ImageLocation == ground_creatures[5] || ground_animal.ImageLocation == ground_creatures[8])
                {
                    Endgame(2);
                }
            }
        }
        private void Endgame(int value = 0)
        {
            switch (value)
            {
                case 0:
                    {
                        //player_ground.URL = "C:\\Users\\DX7\\Music\\Game_music\\Block_hit.wav";
                        //player_ground.controls.play();
                        GameTimer.Stop();
                        Update_Db_GameData();
                        HighestScore();
                        break;
                    }
                case 1:
                    {
                        //player_owl.URL = "C:\\Users\\DX7\\Music\\Game_music\\Owl_Sound.mp3";
                        //player_owl.controls.play();
                        GameTimer.Stop();
                        Update_Db_GameData();
                        HighestScore();

                        break;
                    }
                case 2:
                    {
                        //player_antelope.URL = "C:\\Users\\DX7\\Music\\Game_music\\Antelope.mp3";
                        //player_antelope.controls.play();
                        GameTimer.Stop();
                        Update_Db_GameData();
                        HighestScore();
                        break;
                    }
                case 3:
                    {
                        //player_Rhino.URL = "C:\\Users\\DX7\\Music\\Game_music\\Rhino.mp3";
                        //player_Rhino.controls.play();
                        GameTimer.Stop();
                        Update_Db_GameData();
                        HighestScore();
                        break;
                    }
                case 4:
                    {
                        //player_Squirrel.URL = "C:\\Users\\DX7\\Music\\Game_music\\Squirrel.mp3";
                        //player_Squirrel.controls.play();
                        GameTimer.Stop();
                        Update_Db_GameData();
                        HighestScore();
                        break;
                    }
                case 5:
                    {
                        //player_Duck.URL = "C:\\Users\\DX7\\Music\\Game_music\\Duck.mp3";
                        //player_Duck.controls.play();
                        GameTimer.Stop();
                        Update_Db_GameData();
                        HighestScore();
                        break;
                    }
                case 6:
                    {
                        //player_fox.URL = "C:\\Users\\DX7\\Music\\Game_music\\Angry_Fox.mp3";
                        //player_fox.controls.play();
                        GameTimer.Stop();
                        Update_Db_GameData();
                        HighestScore();
                        break;
                    }
                case 7:
                    {
                        //player_Dog.URL = "C:\\Users\\DX7\\Music\\Game_music\\Dog_Bark.mp3";
                        //player_Dog.controls.play();
                        GameTimer.Stop();
                        Update_Db_GameData();
                        HighestScore();
                        break;
                    }
                case 8:
                    {
                        //player_shark.URL = "C:\\Users\\DX7\\Music\\Game_music\\Shark_Noise.mp3";
                        //player_shark.controls.play();
                        GameTimer.Stop();
                        Update_Db_GameData();
                        HighestScore();
                        break;
                    }
            }
        }

        private void closeclicked(object sender, EventArgs e)
        {
            //player_menu_button.controls.play();
            GameTimer.Enabled = false;
            if (MessageBox.Show("You are about to Quit the game", "Quitting game", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                GameTimer.Enabled = true;
            }
            else
            {
                //player_quit_game.URL = "C:\\Users\\DX7\\Music\\Game_music\\End_Game.wav";
                //player_quit_game.settings.autoStart = false;
                //player_quit_game.controls.play();
                this.Close();
            }

        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            //player_menu_button.controls.play();
            if (GameTimer.Enabled)
            {
                GameTimer.Enabled = false;
                btn_pause.ImageLocation = "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\play.png";
                lbl_pause.Text = "PLay";
            }
            else
            {
                GameTimer.Enabled = true;
                btn_pause.ImageLocation = "X:\\Programming\\Projects\\School_Project\\Project parts\\Games\\Flappy_Bird\\testfinal10\\Resources\\pause.png";
                lbl_pause.Text = "Pause";
            }

        }

        private void btn_mute_Click(object sender, EventArgs e)
        {
            //player_menu_button.controls.play();
            //if (mute_status == false)
            //{
            //    player_shark.settings.mute = true;
            //    player_owl.settings.mute = true;
            //    player_antelope.settings.mute = true;
            //    player_Rhino.settings.mute = true;
            //    player_Squirrel.settings.mute = true;
            //    player_Duck.settings.mute = true;
            //    player_fox.settings.mute = true;
            //    player_Dog.settings.mute = true;
            //    player_ground.settings.mute = true;
            //    player_quit_game.settings.mute = true;
            //    player_menu_button.settings.mute = true;
            //    player_coins.settings.mute = true;
            //    player_default.settings.mute = true;
            //    player_highscore.settings.mute = true;
            //    player_checkpoint.settings.mute = true;
            //    mute_status = true;

            //}
            //else
            //{
            //    player_shark.settings.mute = false;
            //    player_owl.settings.mute = false;
            //    player_antelope.settings.mute = false;
            //    player_Rhino.settings.mute = false;
            //    player_Squirrel.settings.mute = false;
            //    player_Duck.settings.mute = false;
            //    player_fox.settings.mute = false;
            //    player_Dog.settings.mute = false;
            //    player_ground.settings.mute = false;
            //    player_quit_game.settings.mute = false;
            //    player_menu_button.settings.mute = false;
            //    player_coins.settings.mute = false;
            //    player_default.settings.mute = false;
            //    player_highscore.settings.mute = false;
            //    player_checkpoint.settings.mute = false;
            //    mute_status = false;
            //}

        }
    }
}
