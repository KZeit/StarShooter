namespace StarShooter
{
    partial class frmStarShooter
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
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.tmerGame = new System.Windows.Forms.Timer(this.components);
            this.picEnemyAlien = new System.Windows.Forms.PictureBox();
            this.picEnemyShip = new System.Windows.Forms.PictureBox();
            this.picStarsTop = new System.Windows.Forms.PictureBox();
            this.picStarsBottom = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyAlien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStarsTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStarsBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::StarShooter.Properties.Resources.player_img;
            this.picPlayer.Location = new System.Drawing.Point(219, 371);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(46, 45);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            this.picPlayer.Tag = "player";
            // 
            // tmerGame
            // 
            this.tmerGame.Enabled = true;
            this.tmerGame.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picEnemyAlien
            // 
            this.picEnemyAlien.Image = global::StarShooter.Properties.Resources.alien_gif;
            this.picEnemyAlien.Location = new System.Drawing.Point(45, 60);
            this.picEnemyAlien.Name = "picEnemyAlien";
            this.picEnemyAlien.Size = new System.Drawing.Size(60, 60);
            this.picEnemyAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnemyAlien.TabIndex = 1;
            this.picEnemyAlien.TabStop = false;
            this.picEnemyAlien.Tag = "enemy";
            this.picEnemyAlien.Click += new System.EventHandler(this.picEnemy_Click);
            // 
            // picEnemyShip
            // 
            this.picEnemyShip.Image = global::StarShooter.Properties.Resources.ship_gif;
            this.picEnemyShip.Location = new System.Drawing.Point(387, 140);
            this.picEnemyShip.Name = "picEnemyShip";
            this.picEnemyShip.Size = new System.Drawing.Size(50, 27);
            this.picEnemyShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnemyShip.TabIndex = 2;
            this.picEnemyShip.TabStop = false;
            this.picEnemyShip.Tag = "enemy";
            // 
            // picStarsTop
            // 
            this.picStarsTop.Image = global::StarShooter.Properties.Resources.Stars_img;
            this.picStarsTop.Location = new System.Drawing.Point(12, 38);
            this.picStarsTop.Name = "picStarsTop";
            this.picStarsTop.Size = new System.Drawing.Size(460, 172);
            this.picStarsTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStarsTop.TabIndex = 3;
            this.picStarsTop.TabStop = false;
            this.picStarsTop.Tag = "stars";
            // 
            // picStarsBottom
            // 
            this.picStarsBottom.Image = global::StarShooter.Properties.Resources.Stars_img;
            this.picStarsBottom.Location = new System.Drawing.Point(12, 264);
            this.picStarsBottom.Name = "picStarsBottom";
            this.picStarsBottom.Size = new System.Drawing.Size(460, 172);
            this.picStarsBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStarsBottom.TabIndex = 4;
            this.picStarsBottom.TabStop = false;
            this.picStarsBottom.Tag = "stars";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblScore.Location = new System.Drawing.Point(22, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(113, 32);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score: 0";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("High Tower Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(66, 204);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(353, 57);
            this.lblGameOver.TabIndex = 6;
            this.lblGameOver.Text = "GAME OVER!";
            // 
            // frmStarShooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picEnemyShip);
            this.Controls.Add(this.picEnemyAlien);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picStarsTop);
            this.Controls.Add(this.picStarsBottom);
            this.Name = "frmStarShooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Star Shooter";
            this.Load += new System.EventHandler(this.frmStarShooter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStarShooter_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmStarShooter_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyAlien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStarsTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStarsBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer tmerGame;
        private System.Windows.Forms.PictureBox picEnemyAlien;
        private System.Windows.Forms.PictureBox picEnemyShip;
        private System.Windows.Forms.PictureBox picStarsTop;
        private System.Windows.Forms.PictureBox picStarsBottom;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGameOver;
    }
}

