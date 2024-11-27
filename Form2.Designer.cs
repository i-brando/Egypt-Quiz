namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSkips = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(12, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.DimGray;
            this.btnMainMenu.Location = new System.Drawing.Point(107, 388);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(190, 50);
            this.btnMainMenu.TabIndex = 4;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.Khaki;
            this.btnHint.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHint.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnHint.Location = new System.Drawing.Point(303, 388);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(97, 50);
            this.btnHint.TabIndex = 5;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Egypt Quiz™";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(330, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 38);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Question";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(190, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Answer :";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.LightGray;
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAnswer.Location = new System.Drawing.Point(338, 302);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(243, 20);
            this.txtAnswer.TabIndex = 9;
            this.txtAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightGreen;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnNext.Location = new System.Drawing.Point(691, 388);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(97, 50);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblQuestion.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblQuestion.Location = new System.Drawing.Point(14, 110);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(102, 30);
            this.lblQuestion.TabIndex = 11;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(631, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblScore.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblScore.Location = new System.Drawing.Point(740, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(33, 38);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "0";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.BackColor = System.Drawing.Color.Transparent;
            this.lblHint.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblHint.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHint.Location = new System.Drawing.Point(260, 325);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(269, 21);
            this.lblHint.TabIndex = 14;
            this.lblHint.Text = "Need a hint? Press the hint button";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHint.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSkip.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSkip.Location = new System.Drawing.Point(406, 388);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(97, 50);
            this.btnSkip.TabIndex = 15;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(553, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(509, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 38);
            this.label5.TabIndex = 17;
            this.label5.Text = "Skips:";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // lblSkips
            // 
            this.lblSkips.AutoSize = true;
            this.lblSkips.BackColor = System.Drawing.Color.Transparent;
            this.lblSkips.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSkips.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkips.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSkips.Location = new System.Drawing.Point(603, 394);
            this.lblSkips.Name = "lblSkips";
            this.lblSkips.Size = new System.Drawing.Size(33, 38);
            this.lblSkips.TabIndex = 18;
            this.lblSkips.Text = "5";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.sandstone_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSkips);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnExit);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSkips;
    }
}