using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PlayGame
{
    public partial class BackGroundImage1 : Form
    {
        public BackGroundImage1()
        {
            InitializeComponent();
        }

        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            PlayGameButton.Text = "";
           
            SoundPlayer alertplayer = new SoundPlayer(Properties.Resources._91926__tim_kahn__ding);
            GameStartsIn1.ForeColor = Color.White;
           
            Refresh();
            Thread.Sleep(1000);
          
            GameStartsIn1.Text = "Game Starts In 3";

            
            
            Refresh();
            alertplayer.Play();
            Thread.Sleep(1000);

            GameStartsIn1.Text = "Game Starts In 2";

            
            Refresh();
            alertplayer.Play();
            Thread.Sleep(1000);

            GameStartsIn1.Text = "Game Starts In 1";
            
            Refresh();
            alertplayer.Play();
            Thread.Sleep(1000); 
          
            GameStartsIn1.Text = "GO!";
            




        }

        private void GameStartsIn1_Click(object sender, EventArgs e)
        {

        }
    }
        }
    


