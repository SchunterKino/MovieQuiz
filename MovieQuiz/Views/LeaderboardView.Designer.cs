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
            this.leaderboardBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.Location = new System.Drawing.Point(98, 186);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(181, 23);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Hauptmenü";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // leaderboardBox
            // 
            this.leaderboardBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leaderboardBox.Controls.Add(this.scrollPanel);
            this.leaderboardBox.Location = new System.Drawing.Point(3, 3);
            this.leaderboardBox.Name = "leaderboardBox";
            this.leaderboardBox.Size = new System.Drawing.Size(370, 177);
            this.leaderboardBox.TabIndex = 3;
            this.leaderboardBox.TabStop = false;
            this.leaderboardBox.Text = "Bestenliste";
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Location = new System.Drawing.Point(6, 13);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(347, 158);
            this.scrollPanel.TabIndex = 0;
            // 
            // LeaderboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.leaderboardBox);
            this.Controls.Add(this.menuButton);
            this.Name = "LeaderboardView";
            this.Size = new System.Drawing.Size(376, 212);
            this.leaderboardBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.GroupBox leaderboardBox;
        private System.Windows.Forms.Panel scrollPanel;
    }
}
