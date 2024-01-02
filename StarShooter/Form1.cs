using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarShooter
{
    public partial class frmStarShooter : Form
    {
        bool right, left, space;
        int score;

        void Game_Result() //Method for game result
        {
            foreach(Control i in this.Controls)
            {
                foreach(Control j in this.Controls)
                {
                    if(i is PictureBox && i.Tag=="bullet")
                    {
                        if(j is PictureBox && j.Tag=="enemy")
                        {
                            if(i.Bounds.IntersectsWith(j.Bounds)) 
                            {
                                j.Top = -100; //If bullet hits any of the enemy's, then send that enemy to the form top -100 to look like the enemy disappeared
                                ((PictureBox)i).Image = Properties.Resources.explosion; //Change bullet image into explosion
                                score++;
                                lblScore.Text = $"Score: {score}"; //If bullet hits an enemy, increase and display score by +1 
                            }
                        }
                    }
                }
            }
        }

        void Star_Movement() //Method for star movement
        {
            foreach(Control i in this.Controls)
            {
                if (i is PictureBox && i.Tag=="stars")
                {
                    i.Top += 10; //Move stars from top to bottom
                    if(i.Top>400)
                    {
                        i.Top = 0;
                    }
                }
            }
        }

        void Add_Bullet() //Method for bullet properties
            //Define how the bullet will look; size, location, tag, etc.
        {
            PictureBox bullet = new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.Image = Properties.Resources.bullet_img;
            bullet.BackColor = System.Drawing.Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Left = picPlayer.Left + 15;
            bullet.Top = picPlayer.Top - 30;
            this.Controls.Add(bullet);
            bullet.BringToFront();        
        }

        void Bullet_Movement() //Method for bullet movement
        {
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag =="bullet") //Tag bullet from the Add_Bullet method then move bullet from bottom to top
                {
                    x.Top -= 10;
                    if(x.Top<60) //If bullet location is less than 100 then remove the bullet. 
                    {
                        this.Controls.Remove(x);
                    }
                }    
            }

            if (picPlayer.Bounds.IntersectsWith(picEnemyShip.Bounds) || picPlayer.Bounds.IntersectsWith(picEnemyAlien.Bounds))
            {   //If player hits any of the enemies, then display GAME OVER and stop the timer
                tmerGame.Stop();
                lblGameOver.Show();
                lblGameOver.BringToFront();
            }
        }

        void Enemy_Movement() //Method for random enemy movement
        {
            Random rnd = new Random();
            int x, y; //Coordinates for 2D??
            if (picEnemyAlien.Top>=500)
            {
                x = rnd.Next(0, 300); //If alien location is greater than or equal to 500, then change the alien location
                picEnemyAlien.Location = new Point(x, 0); // Represents an ordered pair of integer x and y coordinates that defines a point in a 2D plane.
            }
            if (picEnemyShip.Top>=500)
            {
                y = rnd.Next(0, 300); //If ship location is greater than or equal to 500, then change the ship location
                picEnemyShip.Location = new Point(y, 0);
            }
            else //Move alien and ship from top to bottom
            {
                picEnemyAlien.Top += 20; //Speeds
                picEnemyShip.Top += 15;
            }
        }

        void Arrow_key_Movement() //Method to access bool value to move player right and left
        {
            if (right == true)
            {
                if (picPlayer.Left < 425) //If right bool is true, then move player to the right direction
                {
                    picPlayer.Left += 30; //Speed
                }
            }
            if (left == true)
            {
                if (picPlayer.Left > 10) //If left bool value is true, then move player to the left direction
                {
                    picPlayer.Left -= 30;
                }
            }
        }
        public frmStarShooter()
        {
            InitializeComponent();
            lblGameOver.Hide(); //Hide the Game Over label 
        }

        private void frmStarShooter_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) //Call methods to start the timer
        {
            Arrow_key_Movement(); //Call the arrow movement method to start the timer as soon as the user hits one of the arrows
            Enemy_Movement(); //Call the enemy movement method to start the timer
            Bullet_Movement();
            Star_Movement();
            Game_Result();
        }

        private void picEnemy_Click(object sender, EventArgs e)
        {

        }

        private void frmStarShooter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) //If right arrow key is pressed, then the right bool value will be true
            {
                right = true;
            }
            else if (e.KeyCode == Keys.Left) //Else if left arrow key is pressed, then the left bool value will be true
            {
                left = true;
            }
            else if (e.KeyCode == Keys.Space) //Else if spacebar key is pressed, then the space bool value will be true
            {
                space = true;
                Add_Bullet(); //Bullet method will be accessed when spacebar is pressed
            }
        }

        private void frmStarShooter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) 
            {
                right = false;
            }
            else if (e.KeyCode == Keys.Left) 
            {
                left = false;
            }
            else if (e.KeyCode == Keys.Space) 
            {
                space = false;
            }
        }
    }
}
