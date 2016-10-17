namespace MovieQuiz.Views
{
    partial class QuestionView
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
            this.label1 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeoutLabel = new System.Windows.Forms.Label();
            this.answerPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Location = new System.Drawing.Point(83, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aus welchem Film stammt diese Aufnahme?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playButton.Image = global::MovieQuiz.Properties.Resources.playbutton;
            this.playButton.Location = new System.Drawing.Point(255, 90);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(106, 96);
            this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playButton.TabIndex = 1;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.timeoutLabel);
            this.panel1.Controls.Add(this.answerPanel);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 381);
            this.panel1.TabIndex = 5;
            // 
            // timeoutLabel
            // 
            this.timeoutLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeoutLabel.AutoSize = true;
            this.timeoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeoutLabel.Location = new System.Drawing.Point(387, 119);
            this.timeoutLabel.Name = "timeoutLabel";
            this.timeoutLabel.Size = new System.Drawing.Size(37, 39);
            this.timeoutLabel.TabIndex = 6;
            this.timeoutLabel.Text = "0";
            // 
            // answerPanel
            // 
            this.answerPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerPanel.AutoSize = true;
            this.answerPanel.Location = new System.Drawing.Point(143, 262);
            this.answerPanel.Name = "answerPanel";
            this.answerPanel.Size = new System.Drawing.Size(333, 116);
            this.answerPanel.TabIndex = 5;
            // 
            // QuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "QuestionView";
            this.Size = new System.Drawing.Size(619, 381);
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel answerPanel;
        private System.Windows.Forms.Label timeoutLabel;
    }
}
