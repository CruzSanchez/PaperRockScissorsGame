namespace RockPaperScissorsGame
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.paper = new System.Windows.Forms.PictureBox();
            this.rock = new System.Windows.Forms.PictureBox();
            this.scissors = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.computerScore = new System.Windows.Forms.Label();
            this.drawScore = new System.Windows.Forms.Label();
            this.computerPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // paper
            // 
            this.paper.Image = ((System.Drawing.Image)(resources.GetObject("paper.Image")));
            this.paper.Location = new System.Drawing.Point(67, 48);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(130, 130);
            this.paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.paper.TabIndex = 0;
            this.paper.TabStop = false;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // rock
            // 
            this.rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rock.Image = ((System.Drawing.Image)(resources.GetObject("rock.Image")));
            this.rock.Location = new System.Drawing.Point(67, 184);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(130, 130);
            this.rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rock.TabIndex = 1;
            this.rock.TabStop = false;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // scissors
            // 
            this.scissors.Image = ((System.Drawing.Image)(resources.GetObject("scissors.Image")));
            this.scissors.Location = new System.Drawing.Point(67, 320);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(130, 130);
            this.scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scissors.TabIndex = 2;
            this.scissors.TabStop = false;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose your play!";
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(709, 415);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(79, 36);
            this.reset.TabIndex = 5;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Computer played:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "You won/lost!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Player Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Computer Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Draws:";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.Location = new System.Drawing.Point(467, 359);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(24, 26);
            this.playerScore.TabIndex = 11;
            this.playerScore.Text = "0";
            // 
            // computerScore
            // 
            this.computerScore.AutoSize = true;
            this.computerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerScore.Location = new System.Drawing.Point(467, 385);
            this.computerScore.Name = "computerScore";
            this.computerScore.Size = new System.Drawing.Size(24, 26);
            this.computerScore.TabIndex = 12;
            this.computerScore.Text = "0";
            // 
            // drawScore
            // 
            this.drawScore.AutoSize = true;
            this.drawScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawScore.Location = new System.Drawing.Point(467, 411);
            this.drawScore.Name = "drawScore";
            this.drawScore.Size = new System.Drawing.Size(24, 26);
            this.drawScore.TabIndex = 13;
            this.drawScore.Text = "0";
            // 
            // computerPicture
            // 
            this.computerPicture.Image = ((System.Drawing.Image)(resources.GetObject("computerPicture.Image")));
            this.computerPicture.Location = new System.Drawing.Point(313, 123);
            this.computerPicture.Name = "computerPicture";
            this.computerPicture.Size = new System.Drawing.Size(130, 130);
            this.computerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.computerPicture.TabIndex = 14;
            this.computerPicture.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.computerPicture);
            this.Controls.Add(this.drawScore);
            this.Controls.Add(this.computerScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.paper);
            this.Name = "MainWindow";
            this.Text = "Paper, Rock, Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paper;
        private System.Windows.Forms.PictureBox rock;
        private System.Windows.Forms.PictureBox scissors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label computerScore;
        private System.Windows.Forms.Label drawScore;
        private System.Windows.Forms.PictureBox computerPicture;
    }
}

