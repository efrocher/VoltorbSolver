namespace VoltorbSolver
{
    partial class CellControl
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
            this.ValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValueLabel
            // 
            this.ValueLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ValueLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ValueLabel.Location = new System.Drawing.Point(0, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(56, 56);
            this.ValueLabel.TabIndex = 0;
            this.ValueLabel.Text = "NotSet";
            this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ValueLabel.MouseEnter += new System.EventHandler(this.ValueLabel_MouseEnter);
            this.ValueLabel.MouseLeave += new System.EventHandler(this.ValueLabel_MouseLeave);
            this.ValueLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ValueLabel_Click);
            // 
            // CellControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.ValueLabel);
            this.Name = "CellControl";
            this.Size = new System.Drawing.Size(56, 56);
            this.ResumeLayout(false);

        }

        #endregion

        private Label ValueLabel;
    }
}
