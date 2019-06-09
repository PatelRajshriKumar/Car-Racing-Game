namespace RacingGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.RoadMover = new System.Windows.Forms.Timer(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.left_move = new System.Windows.Forms.Timer(this.components);
            this.right_move = new System.Windows.Forms.Timer(this.components);
            this.Enemycar1 = new System.Windows.Forms.PictureBox();
            this.Enemycar2 = new System.Windows.Forms.PictureBox();
            this.Enemycar3 = new System.Windows.Forms.PictureBox();
            this.enemy1_move = new System.Windows.Forms.Timer(this.components);
            this.enemy2_move = new System.Windows.Forms.Timer(this.components);
            this.enemy3_move = new System.Windows.Forms.Timer(this.components);
            this.End_text = new System.Windows.Forms.Label();
            this.Score_text = new System.Windows.Forms.Label();
            this.replay_btn = new System.Windows.Forms.Button();
            this.speed_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemycar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemycar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemycar3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(93, -42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 99);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(199, -45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 102);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Location = new System.Drawing.Point(199, 94);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(14, 102);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Location = new System.Drawing.Point(93, 97);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(14, 99);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // RoadMover
            // 
            this.RoadMover.Enabled = true;
            this.RoadMover.Interval = 10;
            this.RoadMover.Tick += new System.EventHandler(this.RoadMover_Tick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox6.Location = new System.Drawing.Point(93, 249);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(14, 99);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.Location = new System.Drawing.Point(199, 246);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(14, 102);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox7.Location = new System.Drawing.Point(199, 418);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(14, 102);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox8.Location = new System.Drawing.Point(93, 418);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(14, 99);
            this.pictureBox8.TabIndex = 6;
            this.pictureBox8.TabStop = false;
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(129, 342);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(58, 102);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 8;
            this.car.TabStop = false;
            this.car.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.car_PreviewKeyDown);
            // 
            // left_move
            // 
            this.left_move.Interval = 10;
            this.left_move.Tick += new System.EventHandler(this.left_move_Tick);
            // 
            // right_move
            // 
            this.right_move.Interval = 10;
            this.right_move.Tick += new System.EventHandler(this.right_move_Tick);
            // 
            // Enemycar1
            // 
            this.Enemycar1.Image = ((System.Drawing.Image)(resources.GetObject("Enemycar1.Image")));
            this.Enemycar1.Location = new System.Drawing.Point(1, 202);
            this.Enemycar1.Name = "Enemycar1";
            this.Enemycar1.Size = new System.Drawing.Size(47, 94);
            this.Enemycar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemycar1.TabIndex = 9;
            this.Enemycar1.TabStop = false;
            // 
            // Enemycar2
            // 
            this.Enemycar2.Image = ((System.Drawing.Image)(resources.GetObject("Enemycar2.Image")));
            this.Enemycar2.Location = new System.Drawing.Point(129, -37);
            this.Enemycar2.Name = "Enemycar2";
            this.Enemycar2.Size = new System.Drawing.Size(47, 94);
            this.Enemycar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemycar2.TabIndex = 10;
            this.Enemycar2.TabStop = false;
            // 
            // Enemycar3
            // 
            this.Enemycar3.Image = ((System.Drawing.Image)(resources.GetObject("Enemycar3.Image")));
            this.Enemycar3.Location = new System.Drawing.Point(254, 74);
            this.Enemycar3.Name = "Enemycar3";
            this.Enemycar3.Size = new System.Drawing.Size(47, 80);
            this.Enemycar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemycar3.TabIndex = 11;
            this.Enemycar3.TabStop = false;
            // 
            // enemy1_move
            // 
            this.enemy1_move.Enabled = true;
            this.enemy1_move.Interval = 10;
            this.enemy1_move.Tick += new System.EventHandler(this.enemy1_move_Tick);
            // 
            // enemy2_move
            // 
            this.enemy2_move.Enabled = true;
            this.enemy2_move.Interval = 10;
            this.enemy2_move.Tick += new System.EventHandler(this.enemy2_move_Tick);
            // 
            // enemy3_move
            // 
            this.enemy3_move.Enabled = true;
            this.enemy3_move.Interval = 10;
            this.enemy3_move.Tick += new System.EventHandler(this.enemy3_move_Tick);
            // 
            // End_text
            // 
            this.End_text.AutoSize = true;
            this.End_text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.End_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_text.ForeColor = System.Drawing.Color.Red;
            this.End_text.Location = new System.Drawing.Point(64, 128);
            this.End_text.Name = "End_text";
            this.End_text.Size = new System.Drawing.Size(173, 36);
            this.End_text.TabIndex = 12;
            this.End_text.Text = "Game Over";
            this.End_text.Visible = false;
            // 
            // Score_text
            // 
            this.Score_text.AutoSize = true;
            this.Score_text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Score_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_text.ForeColor = System.Drawing.Color.Green;
            this.Score_text.Location = new System.Drawing.Point(-3, -1);
            this.Score_text.Name = "Score_text";
            this.Score_text.Size = new System.Drawing.Size(82, 24);
            this.Score_text.TabIndex = 13;
            this.Score_text.Text = "Score 0";
            // 
            // replay_btn
            // 
            this.replay_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay_btn.ForeColor = System.Drawing.Color.Green;
            this.replay_btn.Location = new System.Drawing.Point(54, 221);
            this.replay_btn.Name = "replay_btn";
            this.replay_btn.Size = new System.Drawing.Size(203, 47);
            this.replay_btn.TabIndex = 14;
            this.replay_btn.Text = "Replay";
            this.replay_btn.UseVisualStyleBackColor = true;
            this.replay_btn.Visible = false;
            this.replay_btn.Click += new System.EventHandler(this.replay_btn_Click);
            // 
            // speed_text
            // 
            this.speed_text.AutoSize = true;
            this.speed_text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.speed_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_text.ForeColor = System.Drawing.Color.Green;
            this.speed_text.Location = new System.Drawing.Point(219, -1);
            this.speed_text.Name = "speed_text";
            this.speed_text.Size = new System.Drawing.Size(88, 24);
            this.speed_text.TabIndex = 15;
            this.speed_text.Text = "Speed 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(302, 473);
            this.Controls.Add(this.speed_text);
            this.Controls.Add(this.replay_btn);
            this.Controls.Add(this.Score_text);
            this.Controls.Add(this.End_text);
            this.Controls.Add(this.Enemycar3);
            this.Controls.Add(this.Enemycar2);
            this.Controls.Add(this.Enemycar1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(320, 520);
            this.MinimumSize = new System.Drawing.Size(320, 520);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemycar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemycar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemycar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer RoadMover;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Timer left_move;
        private System.Windows.Forms.Timer right_move;
        private System.Windows.Forms.PictureBox Enemycar1;
        private System.Windows.Forms.PictureBox Enemycar2;
        private System.Windows.Forms.PictureBox Enemycar3;
        private System.Windows.Forms.Timer enemy1_move;
        private System.Windows.Forms.Timer enemy2_move;
        private System.Windows.Forms.Timer enemy3_move;
        private System.Windows.Forms.Label End_text;
        private System.Windows.Forms.Label Score_text;
        private System.Windows.Forms.Button replay_btn;
        private System.Windows.Forms.Label speed_text;
    }
}

