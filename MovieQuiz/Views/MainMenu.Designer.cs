namespace MovieQuiz.Views
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.logo = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.newQuizView = new MovieQuiz.Views.MainMenuView();
            this.questionView = new MovieQuiz.Views.QuestionView();
            this.leaderboardView = new MovieQuiz.Views.LeaderboardView();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.Image = global::MovieQuiz.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(7, 9);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(471, 98);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // newQuizView
            // 
            this.newQuizView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newQuizView.Location = new System.Drawing.Point(42, 110);
            this.newQuizView.Name = "newQuizView";
            this.newQuizView.Size = new System.Drawing.Size(400, 340);
            this.newQuizView.TabIndex = 1;
            // 
            // questionView
            // 
            this.questionView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.questionView.Location = new System.Drawing.Point(42, 110);
            this.questionView.Name = "questionView";
            this.questionView.Size = new System.Drawing.Size(400, 340);
            this.questionView.TabIndex = 2;
            this.questionView.Visible = false;
            // 
            // leaderboardView
            // 
            this.leaderboardView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leaderboardView.Location = new System.Drawing.Point(42, 110);
            this.leaderboardView.Name = "leaderboardView";
            this.leaderboardView.Size = new System.Drawing.Size(400, 340);
            this.leaderboardView.TabIndex = 3;
            this.leaderboardView.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.newQuizView);
            this.Controls.Add(this.questionView);
            this.Controls.Add(this.leaderboardView);
            this.Controls.Add(this.logo);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainMenu";
            this.Text = "Filmquiz";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Timer timer;
        private MainMenuView newQuizView;
        private QuestionView questionView;
        private MovieQuiz.Views.LeaderboardView leaderboardView;
    }
}

