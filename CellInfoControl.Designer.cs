namespace VoltorbSolver
{
    partial class CellInfoControl
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
            this.SafetyLabel = new System.Windows.Forms.Label();
            this.BombLabel = new System.Windows.Forms.Label();
            this.ScoreOneLabel = new System.Windows.Forms.Label();
            this.ScoreTwoLabel = new System.Windows.Forms.Label();
            this.ScoreThreeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SafetyLabel
            // 
            this.SafetyLabel.AutoSize = true;
            this.SafetyLabel.Location = new System.Drawing.Point(9, 80);
            this.SafetyLabel.Name = "SafetyLabel";
            this.SafetyLabel.Size = new System.Drawing.Size(67, 15);
            this.SafetyLabel.TabIndex = 0;
            this.SafetyLabel.Text = "SafetyLabel";
            // 
            // BombLabel
            // 
            this.BombLabel.AutoSize = true;
            this.BombLabel.Location = new System.Drawing.Point(9, 6);
            this.BombLabel.Name = "BombLabel";
            this.BombLabel.Size = new System.Drawing.Size(67, 15);
            this.BombLabel.TabIndex = 1;
            this.BombLabel.Text = "BombLabel";
            // 
            // ScoreOneLabel
            // 
            this.ScoreOneLabel.AutoSize = true;
            this.ScoreOneLabel.Location = new System.Drawing.Point(9, 21);
            this.ScoreOneLabel.Name = "ScoreOneLabel";
            this.ScoreOneLabel.Size = new System.Drawing.Size(86, 15);
            this.ScoreOneLabel.TabIndex = 2;
            this.ScoreOneLabel.Text = "ScoreOneLabel";
            // 
            // ScoreTwoLabel
            // 
            this.ScoreTwoLabel.AutoSize = true;
            this.ScoreTwoLabel.Location = new System.Drawing.Point(10, 36);
            this.ScoreTwoLabel.Name = "ScoreTwoLabel";
            this.ScoreTwoLabel.Size = new System.Drawing.Size(85, 15);
            this.ScoreTwoLabel.TabIndex = 3;
            this.ScoreTwoLabel.Text = "ScoreTwoLabel";
            // 
            // ScoreThreeLabel
            // 
            this.ScoreThreeLabel.AutoSize = true;
            this.ScoreThreeLabel.Location = new System.Drawing.Point(9, 51);
            this.ScoreThreeLabel.Name = "ScoreThreeLabel";
            this.ScoreThreeLabel.Size = new System.Drawing.Size(93, 15);
            this.ScoreThreeLabel.TabIndex = 4;
            this.ScoreThreeLabel.Text = "ScoreThreeLabel";
            // 
            // CellInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScoreThreeLabel);
            this.Controls.Add(this.ScoreTwoLabel);
            this.Controls.Add(this.ScoreOneLabel);
            this.Controls.Add(this.BombLabel);
            this.Controls.Add(this.SafetyLabel);
            this.Name = "CellInfoControl";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(229, 106);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label BombLabel;
        private Label ScoreOneLabel;
        private Label ScoreTwoLabel;
        private Label ScoreThreeLabel;
        private Label SafetyLabel;
    }
}
