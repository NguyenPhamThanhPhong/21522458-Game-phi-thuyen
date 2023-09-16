namespace _21522458_Game_phi_thuyen
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
            this.timer_appear = new System.Windows.Forms.Timer(this.components);
            this.timer_fall = new System.Windows.Forms.Timer(this.components);
            this.timer_move = new System.Windows.Forms.Timer(this.components);
            this.timer_shoot = new System.Windows.Forms.Timer(this.components);
            this.timer_explode = new System.Windows.Forms.Timer(this.components);
            this.label_score = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_appear
            // 
            this.timer_appear.Interval = 1000;
            this.timer_appear.Tick += new System.EventHandler(this.timer_appear_Tick);
            // 
            // timer_fall
            // 
            this.timer_fall.Interval = 50;
            this.timer_fall.Tick += new System.EventHandler(this.timer_fall_Tick);
            // 
            // timer_move
            // 
            this.timer_move.Interval = 7;
            this.timer_move.Tick += new System.EventHandler(this.timer_move_Tick);
            // 
            // timer_shoot
            // 
            this.timer_shoot.Interval = 20;
            this.timer_shoot.Tick += new System.EventHandler(this.timer_shoot_Tick);
            // 
            // timer_explode
            // 
            this.timer_explode.Interval = 70;
            this.timer_explode.Tick += new System.EventHandler(this.timer_explode_Tick);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.Color.Yellow;
            this.label_score.Location = new System.Drawing.Point(12, 9);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(100, 34);
            this.label_score.TabIndex = 1;
            this.label_score.Text = "Score: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::_21522458_Game_phi_thuyen.Properties.Resources.spacecraft;
            this.pictureBox1.Location = new System.Drawing.Point(532, 422);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::_21522458_Game_phi_thuyen.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1111, 554);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_appear;
        private System.Windows.Forms.Timer timer_fall;
        private System.Windows.Forms.Timer timer_move;
        private System.Windows.Forms.Timer timer_shoot;
        private System.Windows.Forms.Timer timer_explode;
        private System.Windows.Forms.Label label_score;
    }
}

