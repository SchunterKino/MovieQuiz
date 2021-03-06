﻿namespace MovieQuiz.Views
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.questionCountLabel = new System.Windows.Forms.Label();
            this.jokerButton = new System.Windows.Forms.PictureBox();
            this.timeoutLabel = new System.Windows.Forms.Label();
            this.answerPanel = new System.Windows.Forms.Panel();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jokerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Location = new System.Drawing.Point(166, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(904, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aus welchem Film stammt diese Aufnahme?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.questionCountLabel);
            this.panel1.Controls.Add(this.jokerButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.timeoutLabel);
            this.panel1.Controls.Add(this.answerPanel);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 733);
            this.panel1.TabIndex = 5;
            // 
            // questionCountLabel
            // 
            this.questionCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.questionCountLabel.AutoSize = true;
            this.questionCountLabel.Location = new System.Drawing.Point(560, 35);
            this.questionCountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.questionCountLabel.Name = "questionCountLabel";
            this.questionCountLabel.Size = new System.Drawing.Size(116, 25);
            this.questionCountLabel.TabIndex = 8;
            this.questionCountLabel.Text = "Frage 1/10";
            // 
            // jokerButton
            // 
            this.jokerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.jokerButton.Image = global::MovieQuiz.Properties.Resources.joker;
            this.jokerButton.Location = new System.Drawing.Point(318, 225);
            this.jokerButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.jokerButton.Name = "jokerButton";
            this.jokerButton.Size = new System.Drawing.Size(100, 75);
            this.jokerButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jokerButton.TabIndex = 7;
            this.jokerButton.TabStop = false;
            this.jokerButton.Click += new System.EventHandler(this.jokerButton_Click);
            // 
            // timeoutLabel
            // 
            this.timeoutLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeoutLabel.AutoSize = true;
            this.timeoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeoutLabel.Location = new System.Drawing.Point(830, 250);
            this.timeoutLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timeoutLabel.Name = "timeoutLabel";
            this.timeoutLabel.Size = new System.Drawing.Size(74, 79);
            this.timeoutLabel.TabIndex = 6;
            this.timeoutLabel.Text = "0";
            this.timeoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerPanel
            // 
            this.answerPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerPanel.AutoSize = true;
            this.answerPanel.Location = new System.Drawing.Point(286, 504);
            this.answerPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.answerPanel.Name = "answerPanel";
            this.answerPanel.Size = new System.Drawing.Size(666, 223);
            this.answerPanel.TabIndex = 5;
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playButton.Image = global::MovieQuiz.Properties.Resources.playbutton;
            this.playButton.Location = new System.Drawing.Point(510, 173);
            this.playButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(212, 185);
            this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playButton.TabIndex = 1;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // QuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "QuestionView";
            this.Size = new System.Drawing.Size(1238, 733);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jokerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel answerPanel;
        private System.Windows.Forms.Label timeoutLabel;
        private System.Windows.Forms.PictureBox jokerButton;
        private System.Windows.Forms.Label questionCountLabel;
    }
}
