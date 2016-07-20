namespace MovieQuiz.Views
{
    partial class NewQuizView
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(35, 119);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Teamname:";
            // 
            // nameText
            // 
            this.nameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameText.Location = new System.Drawing.Point(104, 116);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(216, 20);
            this.nameText.TabIndex = 1;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // newGameButton
            // 
            this.newGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newGameButton.Enabled = false;
            this.newGameButton.Location = new System.Drawing.Point(38, 167);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(282, 23);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "Neues Spiel";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newGameButton);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 339);
            this.panel1.TabIndex = 2;
            // 
            // NewQuizView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "NewQuizView";
            this.Size = new System.Drawing.Size(363, 339);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Panel panel1;
    }
}
