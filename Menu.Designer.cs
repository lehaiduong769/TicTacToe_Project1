namespace TicTocToe_Project1
{
    partial class FMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.but2players = new System.Windows.Forms.Button();
            this.but1Player = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.butHowToPlay = new System.Windows.Forms.Button();
            this.lbTenGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but2players
            // 
            resources.ApplyResources(this.but2players, "but2players");
            this.but2players.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.but2players.Name = "but2players";
            this.but2players.UseVisualStyleBackColor = true;
            this.but2players.Click += new System.EventHandler(this.but2players_Click);
            // 
            // but1Player
            // 
            resources.ApplyResources(this.but1Player, "but1Player");
            this.but1Player.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.but1Player.Name = "but1Player";
            this.but1Player.UseVisualStyleBackColor = true;
            this.but1Player.Click += new System.EventHandler(this.but1Player_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // butHowToPlay
            // 
            resources.ApplyResources(this.butHowToPlay, "butHowToPlay");
            this.butHowToPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butHowToPlay.Name = "butHowToPlay";
            this.butHowToPlay.UseVisualStyleBackColor = true;
            this.butHowToPlay.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbTenGame
            // 
            resources.ApplyResources(this.lbTenGame, "lbTenGame");
            this.lbTenGame.BackColor = System.Drawing.Color.Gold;
            this.lbTenGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbTenGame.Name = "lbTenGame";
            // 
            // FMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTocToe_Project1.Properties.Resources.background;
            this.CausesValidation = false;
            this.Controls.Add(this.lbTenGame);
            this.Controls.Add(this.butHowToPlay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.but1Player);
            this.Controls.Add(this.but2players);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Name = "FMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button but2players;
        private Button but1Player;
        private Button button2;
        private Button butHowToPlay;
        private Label lbTenGame;
    }
}