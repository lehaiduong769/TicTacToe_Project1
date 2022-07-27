using Timer = System.Windows.Forms.Timer;
using System.Windows.Forms;

namespace tictactoe
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbPlayX = new System.Windows.Forms.Label();
            this.butX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.but0 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.butExit = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(28, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 160);
            this.button1.TabIndex = 2;
            this.button1.Tag = "play";
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.playerClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(211, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 160);
            this.button2.TabIndex = 3;
            this.button2.Tag = "play";
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.playerClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(394, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 160);
            this.button3.TabIndex = 4;
            this.button3.Tag = "play";
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.playerClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(28, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 160);
            this.button4.TabIndex = 5;
            this.button4.Tag = "play";
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.playerClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(211, 188);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 160);
            this.button5.TabIndex = 6;
            this.button5.Tag = "play";
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.playerClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(394, 188);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 160);
            this.button6.TabIndex = 7;
            this.button6.Tag = "play";
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.playerClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(28, 354);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(177, 160);
            this.button7.TabIndex = 8;
            this.button7.Tag = "play";
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.playerClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(211, 354);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(177, 160);
            this.button8.TabIndex = 9;
            this.button8.Tag = "play";
            this.button8.Text = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.playerClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(394, 354);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(177, 160);
            this.button9.TabIndex = 10;
            this.button9.Tag = "play";
            this.button9.Text = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.playerClick);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(26, 79);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(214, 51);
            this.button10.TabIndex = 11;
            this.button10.Text = "Reset";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 89);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(487, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "NEW GAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 549);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(626, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 549);
            this.panel3.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lbPlayX);
            this.panel5.Controls.Add(this.butX);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.but0);
            this.panel5.Location = new System.Drawing.Point(3, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(508, 160);
            this.panel5.TabIndex = 12;
            // 
            // lbPlayX
            // 
            this.lbPlayX.AutoSize = true;
            this.lbPlayX.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPlayX.Location = new System.Drawing.Point(51, 22);
            this.lbPlayX.Name = "lbPlayX";
            this.lbPlayX.Size = new System.Drawing.Size(144, 37);
            this.lbPlayX.TabIndex = 12;
            this.lbPlayX.Text = "Player X";
            this.lbPlayX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butX
            // 
            this.butX.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butX.Location = new System.Drawing.Point(243, 15);
            this.butX.Name = "butX";
            this.butX.Size = new System.Drawing.Size(227, 51);
            this.butX.TabIndex = 11;
            this.butX.Text = "0";
            this.butX.UseVisualStyleBackColor = true;
            this.butX.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Player O";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but0
            // 
            this.but0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.but0.Location = new System.Drawing.Point(243, 91);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(227, 44);
            this.but0.TabIndex = 11;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            this.but0.UseWaitCursor = true;
            this.but0.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button11);
            this.panel4.Controls.Add(this.butExit);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Location = new System.Drawing.Point(0, 354);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(511, 160);
            this.panel4.TabIndex = 12;
            // 
            // butExit
            // 
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butExit.Location = new System.Drawing.Point(264, 79);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(214, 51);
            this.butExit.TabIndex = 12;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(26, 10);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(452, 63);
            this.button11.TabIndex = 14;
            this.button11.Text = "Menu";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1159, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "TicTacToe_2Players";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Label lbPlayX;
        private Button but0;
        private Button butX;
        private Label label2;
        private Button butExit;
        private Button button11;
    }
}