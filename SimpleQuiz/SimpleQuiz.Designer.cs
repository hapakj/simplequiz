namespace SimpleQuiz
{
    partial class SimpleQuiz
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
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.UserAnswerLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.UserAnwerTextBox = new System.Windows.Forms.TextBox();
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.AnswerTextLabel = new System.Windows.Forms.Label();
            this.ShowAnswerBtn = new System.Windows.Forms.Button();
            this.NextProblemBtn = new System.Windows.Forms.Button();
            this.ProblemCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuestionLabel.Location = new System.Drawing.Point(76, 83);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(63, 20);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "Kérdés:";
            // 
            // UserAnswerLabel
            // 
            this.UserAnswerLabel.AutoSize = true;
            this.UserAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserAnswerLabel.Location = new System.Drawing.Point(78, 141);
            this.UserAnswerLabel.Name = "UserAnswerLabel";
            this.UserAnswerLabel.Size = new System.Drawing.Size(61, 20);
            this.UserAnswerLabel.TabIndex = 1;
            this.UserAnswerLabel.Text = "Válasz:";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AnswerLabel.Location = new System.Drawing.Point(30, 193);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(109, 20);
            this.AnswerLabel.TabIndex = 2;
            this.AnswerLabel.Text = "Helyes válasz:";
            // 
            // UserAnwerTextBox
            // 
            this.UserAnwerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserAnwerTextBox.Location = new System.Drawing.Point(172, 135);
            this.UserAnwerTextBox.Name = "UserAnwerTextBox";
            this.UserAnwerTextBox.Size = new System.Drawing.Size(723, 26);
            this.UserAnwerTextBox.TabIndex = 4;
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.AutoSize = true;
            this.QuestionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuestionTextLabel.Location = new System.Drawing.Point(168, 83);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(70, 20);
            this.QuestionTextLabel.TabIndex = 5;
            this.QuestionTextLabel.Text = "question";
            // 
            // AnswerTextLabel
            // 
            this.AnswerTextLabel.AutoSize = true;
            this.AnswerTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AnswerTextLabel.Location = new System.Drawing.Point(168, 193);
            this.AnswerTextLabel.Name = "AnswerTextLabel";
            this.AnswerTextLabel.Size = new System.Drawing.Size(60, 20);
            this.AnswerTextLabel.TabIndex = 6;
            this.AnswerTextLabel.Text = "answer";
            // 
            // ShowAnswerBtn
            // 
            this.ShowAnswerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowAnswerBtn.Location = new System.Drawing.Point(658, 242);
            this.ShowAnswerBtn.Name = "ShowAnswerBtn";
            this.ShowAnswerBtn.Size = new System.Drawing.Size(93, 46);
            this.ShowAnswerBtn.TabIndex = 7;
            this.ShowAnswerBtn.Text = "Mutasd!";
            this.ShowAnswerBtn.UseVisualStyleBackColor = true;
            this.ShowAnswerBtn.Click += new System.EventHandler(this.ShowAnswerBtn_Click);
            // 
            // NextProblemBtn
            // 
            this.NextProblemBtn.Enabled = false;
            this.NextProblemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NextProblemBtn.Location = new System.Drawing.Point(790, 242);
            this.NextProblemBtn.Name = "NextProblemBtn";
            this.NextProblemBtn.Size = new System.Drawing.Size(105, 46);
            this.NextProblemBtn.TabIndex = 8;
            this.NextProblemBtn.Text = "Következő";
            this.NextProblemBtn.UseVisualStyleBackColor = true;
            this.NextProblemBtn.Click += new System.EventHandler(this.NextProblemBtn_Click);
            // 
            // ProblemCounter
            // 
            this.ProblemCounter.AutoSize = true;
            this.ProblemCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProblemCounter.Location = new System.Drawing.Point(82, 23);
            this.ProblemCounter.Name = "ProblemCounter";
            this.ProblemCounter.Size = new System.Drawing.Size(64, 33);
            this.ProblemCounter.TabIndex = 9;
            this.ProblemCounter.Text = "n/m";
            // 
            // SimpleQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 334);
            this.Controls.Add(this.ProblemCounter);
            this.Controls.Add(this.NextProblemBtn);
            this.Controls.Add(this.ShowAnswerBtn);
            this.Controls.Add(this.AnswerTextLabel);
            this.Controls.Add(this.QuestionTextLabel);
            this.Controls.Add(this.UserAnwerTextBox);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.UserAnswerLabel);
            this.Controls.Add(this.QuestionLabel);
            this.Name = "SimpleQuiz";
            this.Text = "SimpleQuiz";
            this.Load += new System.EventHandler(this.SimpleQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label UserAnswerLabel;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.TextBox UserAnwerTextBox;
        private System.Windows.Forms.Label QuestionTextLabel;
        private System.Windows.Forms.Label AnswerTextLabel;
        private System.Windows.Forms.Button ShowAnswerBtn;
        private System.Windows.Forms.Button NextProblemBtn;
        private System.Windows.Forms.Label ProblemCounter;
    }
}

