namespace MovieQuiz.Views
{
    partial class HighScoresView
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
            this.scorePanel = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scorePanel
            // 
            this.scorePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.scorePanel.AutoSize = true;
            this.scorePanel.Location = new System.Drawing.Point(3, 3);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(370, 177);
            this.scorePanel.TabIndex = 0;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(98, 186);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(181, 23);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Hauptmenü";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // HighScoresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.scorePanel);
            this.Name = "HighScoresView";
            this.Size = new System.Drawing.Size(376, 212);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.Button menuButton;
    }
}
