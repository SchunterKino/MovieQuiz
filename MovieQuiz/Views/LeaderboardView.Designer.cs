namespace MovieQuiz.Views
{
    partial class LeaderboardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuButton = new System.Windows.Forms.Button();
            this.leaderboardBox = new System.Windows.Forms.GroupBox();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leaderboardBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuButton.Location = new System.Drawing.Point(95, 237);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(366, 39);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Hauptmenü";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // leaderboardBox
            // 
            this.leaderboardBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leaderboardBox.Controls.Add(this.scrollPanel);
            this.leaderboardBox.Location = new System.Drawing.Point(95, 27);
            this.leaderboardBox.Name = "leaderboardBox";
            this.leaderboardBox.Size = new System.Drawing.Size(366, 177);
            this.leaderboardBox.TabIndex = 3;
            this.leaderboardBox.TabStop = false;
            this.leaderboardBox.Text = "Bestenliste";
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.AutoSize = true;
            this.scrollPanel.Location = new System.Drawing.Point(6, 16);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(354, 158);
            this.scrollPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Controls.Add(this.leaderboardBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 368);
            this.panel1.TabIndex = 4;
            // 
            // LeaderboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "LeaderboardView";
            this.Size = new System.Drawing.Size(557, 368);
            this.leaderboardBox.ResumeLayout(false);
            this.leaderboardBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.GroupBox leaderboardBox;
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.Panel panel1;
    }
}
