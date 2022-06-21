namespace TicTocToe_Project1
{
    partial class FHowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHowToPlay));
            this.lbTenGame = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.butMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTenGame
            // 
            this.lbTenGame.AutoSize = true;
            this.lbTenGame.BackColor = System.Drawing.Color.Gold;
            this.lbTenGame.Font = new System.Drawing.Font("Segoe UI Symbol", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTenGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbTenGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTenGame.Location = new System.Drawing.Point(344, 9);
            this.lbTenGame.Name = "lbTenGame";
            this.lbTenGame.Size = new System.Drawing.Size(271, 50);
            this.lbTenGame.TabIndex = 7;
            this.lbTenGame.Text = "HOW TO PLAY";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Gold;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.richTextBox1.Location = new System.Drawing.Point(60, 151);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(886, 334);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // butMenu
            // 
            this.butMenu.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butMenu.Location = new System.Drawing.Point(12, 549);
            this.butMenu.Name = "butMenu";
            this.butMenu.Size = new System.Drawing.Size(137, 39);
            this.butMenu.TabIndex = 23;
            this.butMenu.Text = "MENU";
            this.butMenu.UseVisualStyleBackColor = true;
            this.butMenu.Click += new System.EventHandler(this.butMenu_Click);
            // 
            // FHowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(997, 600);
            this.Controls.Add(this.butMenu);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbTenGame);
            this.Name = "FHowToPlay";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Tic_Tac_Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTenGame;
        private RichTextBox richTextBox1;
        private Button butMenu;
    }
}