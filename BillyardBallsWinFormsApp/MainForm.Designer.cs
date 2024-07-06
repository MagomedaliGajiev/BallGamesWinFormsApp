namespace BillyardBallsWinFormsApp
{
    partial class MainForm
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
            leftLabel = new Label();
            topLabel = new Label();
            downLabel = new Label();
            rightLabel = new Label();
            SuspendLayout();
            // 
            // leftLabel
            // 
            leftLabel.AutoSize = true;
            leftLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            leftLabel.Location = new Point(12, 324);
            leftLabel.Name = "leftLabel";
            leftLabel.Size = new Size(33, 37);
            leftLabel.TabIndex = 0;
            leftLabel.Text = "0";
            // 
            // topLabel
            // 
            topLabel.AutoSize = true;
            topLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            topLabel.Location = new Point(602, 9);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(33, 37);
            topLabel.TabIndex = 1;
            topLabel.Text = "0";
            // 
            // downLabel
            // 
            downLabel.AutoSize = true;
            downLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            downLabel.Location = new Point(602, 684);
            downLabel.Name = "downLabel";
            downLabel.Size = new Size(33, 37);
            downLabel.TabIndex = 2;
            downLabel.Text = "0";
            // 
            // rightLabel
            // 
            rightLabel.AutoSize = true;
            rightLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rightLabel.Location = new Point(1212, 324);
            rightLabel.Name = "rightLabel";
            rightLabel.Size = new Size(33, 37);
            rightLabel.TabIndex = 3;
            rightLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 730);
            Controls.Add(rightLabel);
            Controls.Add(downLabel);
            Controls.Add(topLabel);
            Controls.Add(leftLabel);
            Name = "MainForm";
            Text = "Billyard";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftLabel;
        private Label topLabel;
        private Label downLabel;
        private Label rightLabel;
    }
}
