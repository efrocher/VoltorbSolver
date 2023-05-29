namespace VoltorbSolver
{
    partial class SolverForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AnalysisTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ColumnInfosLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RowInfosLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GameGridLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AnalyseButton = new System.Windows.Forms.Button();
            this.CellInfos = new VoltorbSolver.CellInfoControl();
            this.MainPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CellInfos);
            this.MainPanel.Controls.Add(this.statusStrip1);
            this.MainPanel.Controls.Add(this.ColumnInfosLayout);
            this.MainPanel.Controls.Add(this.RowInfosLayout);
            this.MainPanel.Controls.Add(this.GameGridLayout);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 65);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(10);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(706, 555);
            this.MainPanel.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnalysisTimeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(706, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AnalysisTimeLabel
            // 
            this.AnalysisTimeLabel.Name = "AnalysisTimeLabel";
            this.AnalysisTimeLabel.Size = new System.Drawing.Size(59, 17);
            this.AnalysisTimeLabel.Text = "Analysis : ";
            // 
            // ColumnInfosLayout
            // 
            this.ColumnInfosLayout.ColumnCount = 5;
            this.ColumnInfosLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ColumnInfosLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ColumnInfosLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ColumnInfosLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ColumnInfosLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ColumnInfosLayout.Location = new System.Drawing.Point(248, 414);
            this.ColumnInfosLayout.Name = "ColumnInfosLayout";
            this.ColumnInfosLayout.RowCount = 1;
            this.ColumnInfosLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ColumnInfosLayout.Size = new System.Drawing.Size(350, 70);
            this.ColumnInfosLayout.TabIndex = 2;
            // 
            // RowInfosLayout
            // 
            this.RowInfosLayout.ColumnCount = 1;
            this.RowInfosLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RowInfosLayout.Location = new System.Drawing.Point(604, 58);
            this.RowInfosLayout.Name = "RowInfosLayout";
            this.RowInfosLayout.RowCount = 5;
            this.RowInfosLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RowInfosLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RowInfosLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RowInfosLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RowInfosLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RowInfosLayout.Size = new System.Drawing.Size(70, 350);
            this.RowInfosLayout.TabIndex = 1;
            // 
            // GameGridLayout
            // 
            this.GameGridLayout.ColumnCount = 5;
            this.GameGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GameGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GameGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GameGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GameGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GameGridLayout.Location = new System.Drawing.Point(248, 58);
            this.GameGridLayout.Name = "GameGridLayout";
            this.GameGridLayout.RowCount = 5;
            this.GameGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GameGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GameGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GameGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GameGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GameGridLayout.Size = new System.Drawing.Size(350, 350);
            this.GameGridLayout.TabIndex = 0;
            // 
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Location = new System.Drawing.Point(12, 12);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(123, 38);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AnalyseButton
            // 
            this.AnalyseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnalyseButton.Location = new System.Drawing.Point(141, 12);
            this.AnalyseButton.Name = "AnalyseButton";
            this.AnalyseButton.Size = new System.Drawing.Size(123, 38);
            this.AnalyseButton.TabIndex = 1;
            this.AnalyseButton.Text = "Analyse";
            this.AnalyseButton.UseVisualStyleBackColor = true;
            this.AnalyseButton.Click += new System.EventHandler(this.AnalyseButton_Click);
            // 
            // CellInfos
            // 
            this.CellInfos.Location = new System.Drawing.Point(28, 130);
            this.CellInfos.Name = "CellInfos";
            this.CellInfos.Size = new System.Drawing.Size(193, 102);
            this.CellInfos.TabIndex = 4;
            // 
            // SolverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 620);
            this.Controls.Add(this.AnalyseButton);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ResetButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SolverForm";
            this.Text = "Voltorb";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel MainPanel;
        private TableLayoutPanel ColumnInfosLayout;
        private TableLayoutPanel RowInfosLayout;
        private TableLayoutPanel GameGridLayout;
        private Button ResetButton;
        private Button AnalyseButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel AnalysisTimeLabel;
        private CellInfoControl CellInfos;
    }
}