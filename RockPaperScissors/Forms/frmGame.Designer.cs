namespace RockPaperScissors
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblWins = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoses = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWinsTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLosesTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.smiGame = new System.Windows.Forms.ToolStripMenuItem();
            this.smiResetScores = new System.Windows.Forms.ToolStripMenuItem();
            this.smiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb1.Image = global::RockPaperScissors.Properties.Resources.None;
            this.pb1.Location = new System.Drawing.Point(12, 36);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(174, 174);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.Location = new System.Drawing.Point(192, 105);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(122, 37);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "vs";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pb2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb2.Image = global::RockPaperScissors.Properties.Resources.None;
            this.pb2.Location = new System.Drawing.Point(320, 36);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(174, 174);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblWins,
            this.lblLoses,
            this.lblWinsTotal,
            this.lblLosesTotal});
            this.statusStrip.Location = new System.Drawing.Point(0, 269);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(506, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblWins
            // 
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(45, 17);
            this.lblWins.Text = "Wins: 0";
            // 
            // lblLoses
            // 
            this.lblLoses.Name = "lblLoses";
            this.lblLoses.Size = new System.Drawing.Size(48, 17);
            this.lblLoses.Text = "Loses: 0";
            // 
            // lblWinsTotal
            // 
            this.lblWinsTotal.Name = "lblWinsTotal";
            this.lblWinsTotal.Size = new System.Drawing.Size(75, 17);
            this.lblWinsTotal.Text = "Total Wins: 0";
            // 
            // lblLosesTotal
            // 
            this.lblLosesTotal.Name = "lblLosesTotal";
            this.lblLosesTotal.Size = new System.Drawing.Size(78, 17);
            this.lblLosesTotal.Text = "Total Loses: 0";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiGame,
            this.smiAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(506, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // smiGame
            // 
            this.smiGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiResetScores,
            this.smiUpdate});
            this.smiGame.Name = "smiGame";
            this.smiGame.Size = new System.Drawing.Size(50, 20);
            this.smiGame.Text = "Game";
            // 
            // smiResetScores
            // 
            this.smiResetScores.Name = "smiResetScores";
            this.smiResetScores.Size = new System.Drawing.Size(170, 22);
            this.smiResetScores.Text = "Reset scores";
            this.smiResetScores.Click += new System.EventHandler(this.smiResetScores_Click);
            // 
            // smiUpdate
            // 
            this.smiUpdate.Name = "smiUpdate";
            this.smiUpdate.Size = new System.Drawing.Size(170, 22);
            this.smiUpdate.Text = "Check for updates";
            this.smiUpdate.Click += new System.EventHandler(this.smiUpdate_Click);
            // 
            // smiAbout
            // 
            this.smiAbout.Name = "smiAbout";
            this.smiAbout.Size = new System.Drawing.Size(52, 20);
            this.smiAbout.Text = "About";
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(103, 224);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(96, 32);
            this.btnRock.TabIndex = 5;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(205, 224);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(96, 32);
            this.btnPaper.TabIndex = 6;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(307, 224);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(96, 32);
            this.btnScissors.TabIndex = 7;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 291);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblWins;
        private System.Windows.Forms.ToolStripStatusLabel lblLoses;
        private System.Windows.Forms.ToolStripStatusLabel lblWinsTotal;
        private System.Windows.Forms.ToolStripStatusLabel lblLosesTotal;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem smiGame;
        private System.Windows.Forms.ToolStripMenuItem smiResetScores;
        private System.Windows.Forms.ToolStripMenuItem smiAbout;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.ToolStripMenuItem smiUpdate;
    }
}

