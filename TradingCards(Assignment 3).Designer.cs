namespace TradingCards_Assignment_3_
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblAssists = new System.Windows.Forms.Label();
            this.lblSteals = new System.Windows.Forms.Label();
            this.lblRebounds = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "Michael Jordan",
            "Magic Johnson",
            "Larry Bird",
            "Shaquille O\'Neal",
            "Tim Duncan",
            "Allen Iverson",
            "Kobe Bryant",
            "Kevin Garnett",
            "Dwyane Wade",
            "Dirk Nowitzki"});
            this.listBox1.Location = new System.Drawing.Point(21, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 254);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(621, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 42);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.Location = new System.Drawing.Point(621, 132);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(117, 42);
            this.lblTeam.TabIndex = 3;
            this.lblTeam.Text = "Team";
            // 
            // lblAssists
            // 
            this.lblAssists.AutoSize = true;
            this.lblAssists.Location = new System.Drawing.Point(584, 614);
            this.lblAssists.Name = "lblAssists";
            this.lblAssists.Size = new System.Drawing.Size(81, 25);
            this.lblAssists.TabIndex = 4;
            this.lblAssists.Text = "Assists";
            // 
            // lblSteals
            // 
            this.lblSteals.AutoSize = true;
            this.lblSteals.Location = new System.Drawing.Point(697, 687);
            this.lblSteals.Name = "lblSteals";
            this.lblSteals.Size = new System.Drawing.Size(72, 25);
            this.lblSteals.TabIndex = 5;
            this.lblSteals.Text = "Steals";
            // 
            // lblRebounds
            // 
            this.lblRebounds.AutoSize = true;
            this.lblRebounds.Location = new System.Drawing.Point(796, 614);
            this.lblRebounds.Name = "lblRebounds";
            this.lblRebounds.Size = new System.Drawing.Size(110, 25);
            this.lblRebounds.TabIndex = 6;
            this.lblRebounds.Text = "Rebounds";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(916, 678);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(72, 25);
            this.lblPoints.TabIndex = 7;
            this.lblPoints.Text = "Points";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(532, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlayer
            // 
            this.btnPlayer.Location = new System.Drawing.Point(490, 742);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(175, 122);
            this.btnPlayer.TabIndex = 8;
            this.btnPlayer.Text = "Add Player";
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(828, 742);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(175, 122);
            this.btnRemovePlayer.TabIndex = 9;
            this.btnRemovePlayer.Text = "Remove Player";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1305, 1043);
            this.Controls.Add(this.btnRemovePlayer);
            this.Controls.Add(this.btnPlayer);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblRebounds);
            this.Controls.Add(this.lblSteals);
            this.Controls.Add(this.lblAssists);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblAssists;
        private System.Windows.Forms.Label lblSteals;
        private System.Windows.Forms.Label lblRebounds;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button btnRemovePlayer;
    }
}

