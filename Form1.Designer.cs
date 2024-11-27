namespace WindowsFormsApp1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(305, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 69);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStart.Location = new System.Drawing.Point(305, 169);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 69);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(175, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(437, 90);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Egypt Quiz™";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruction.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblInstruction.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblInstruction.Location = new System.Drawing.Point(24, 157);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(241, 180);
            this.lblInstruction.TabIndex = 3;
            this.lblInstruction.Text = "To Begin The Quiz \r\nPlease Press \r\nThe Start Button\r\n\r\nBegin Each Answer\r\nWith A " +
    "Capital Letter";
            this.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInstruction.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.sandstone_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.ForeColor = System.Drawing.Color.SandyBrown;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstruction;
    }
}

