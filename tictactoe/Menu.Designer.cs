namespace tictactoe
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butHWP = new System.Windows.Forms.Button();
            this.butRecord = new System.Windows.Forms.Button();
            this.but2players = new System.Windows.Forms.Button();
            this.but1Player = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::tictactoe.Properties.Resources.background;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 663);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(469, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 658);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.butHWP);
            this.panel3.Controls.Add(this.butRecord);
            this.panel3.Controls.Add(this.but2players);
            this.panel3.Controls.Add(this.but1Player);
            this.panel3.Location = new System.Drawing.Point(7, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 503);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // butHWP
            // 
            this.butHWP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butHWP.ForeColor = System.Drawing.Color.Peru;
            this.butHWP.Location = new System.Drawing.Point(41, 350);
            this.butHWP.Name = "butHWP";
            this.butHWP.Size = new System.Drawing.Size(399, 59);
            this.butHWP.TabIndex = 0;
            this.butHWP.Text = "How To Play";
            this.butHWP.UseVisualStyleBackColor = true;
            this.butHWP.Click += new System.EventHandler(this.butHWP_Click);
            // 
            // butRecord
            // 
            this.butRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butRecord.ForeColor = System.Drawing.Color.Peru;
            this.butRecord.Location = new System.Drawing.Point(41, 256);
            this.butRecord.Name = "butRecord";
            this.butRecord.Size = new System.Drawing.Size(399, 59);
            this.butRecord.TabIndex = 0;
            this.butRecord.Text = "Record";
            this.butRecord.UseVisualStyleBackColor = true;
            this.butRecord.Click += new System.EventHandler(this.butRecord_Click);
            // 
            // but2players
            // 
            this.but2players.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.but2players.ForeColor = System.Drawing.Color.Peru;
            this.but2players.Location = new System.Drawing.Point(41, 159);
            this.but2players.Name = "but2players";
            this.but2players.Size = new System.Drawing.Size(399, 59);
            this.but2players.TabIndex = 0;
            this.but2players.Text = "2 Players";
            this.but2players.UseVisualStyleBackColor = true;
            this.but2players.Click += new System.EventHandler(this.but2players_Click);
            // 
            // but1Player
            // 
            this.but1Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.but1Player.ForeColor = System.Drawing.Color.Peru;
            this.but1Player.Location = new System.Drawing.Point(41, 64);
            this.but1Player.Name = "but1Player";
            this.but1Player.Size = new System.Drawing.Size(399, 59);
            this.but1Player.TabIndex = 0;
            this.but1Player.Text = "1 Player";
            this.but1Player.UseVisualStyleBackColor = true;
            this.but1Player.Click += new System.EventHandler(this.but1Player_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIC TAC TOE GAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 678);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "TicTacToe_Menu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private Panel panel1;

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Button but1Player;
        private Label label1;
        private Button butHWP;
        private Button butRecord;
        private Button but2players;
    }
}