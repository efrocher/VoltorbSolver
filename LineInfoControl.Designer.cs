namespace VoltorbSolver
{
    partial class LineInfoControl
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
            this.LabelLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BombTotalLabel = new System.Windows.Forms.Label();
            this.PointToalLabel = new System.Windows.Forms.Label();
            this.LabelLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelLayout
            // 
            this.LabelLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.LabelLayout.ColumnCount = 1;
            this.LabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelLayout.Controls.Add(this.BombTotalLabel, 0, 1);
            this.LabelLayout.Controls.Add(this.PointToalLabel, 0, 0);
            this.LabelLayout.Location = new System.Drawing.Point(3, 3);
            this.LabelLayout.Name = "LabelLayout";
            this.LabelLayout.RowCount = 2;
            this.LabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelLayout.Size = new System.Drawing.Size(54, 54);
            this.LabelLayout.TabIndex = 0;
            // 
            // BombTotalLabel
            // 
            this.BombTotalLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BombTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BombTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BombTotalLabel.Location = new System.Drawing.Point(5, 28);
            this.BombTotalLabel.Name = "BombTotalLabel";
            this.BombTotalLabel.Size = new System.Drawing.Size(44, 24);
            this.BombTotalLabel.TabIndex = 1;
            this.BombTotalLabel.Text = "NotSet";
            this.BombTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BombTotalLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BombTotalLabel_MouseUp);
            // 
            // PointToalLabel
            // 
            this.PointToalLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PointToalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointToalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PointToalLabel.Location = new System.Drawing.Point(5, 2);
            this.PointToalLabel.Name = "PointToalLabel";
            this.PointToalLabel.Size = new System.Drawing.Size(44, 24);
            this.PointToalLabel.TabIndex = 0;
            this.PointToalLabel.Text = "NotSet";
            this.PointToalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PointToalLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PointToalLabel_MouseUp);
            // 
            // LineInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelLayout);
            this.Name = "LineInfoControl";
            this.Size = new System.Drawing.Size(60, 60);
            this.LabelLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel LabelLayout;
        private Label BombTotalLabel;
        private Label PointToalLabel;
    }
}
