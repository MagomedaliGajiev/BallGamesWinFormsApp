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
            leftLabel_1 = new Label();
            topLabel_1 = new Label();
            downLabel_1 = new Label();
            rightLabel_1 = new Label();
            leftLabel_2 = new Label();
            topLabel_2 = new Label();
            rightLabel_2 = new Label();
            downLabel_2 = new Label();
            SuspendLayout();
            // 
            // leftLabel_1
            // 
            leftLabel_1.AutoSize = true;
            leftLabel_1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            leftLabel_1.ForeColor = SystemColors.Highlight;
            leftLabel_1.Location = new Point(12, 324);
            leftLabel_1.Name = "leftLabel_1";
            leftLabel_1.Size = new Size(33, 37);
            leftLabel_1.TabIndex = 0;
            leftLabel_1.Text = "0";
            // 
            // topLabel_1
            // 
            topLabel_1.AutoSize = true;
            topLabel_1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            topLabel_1.ForeColor = SystemColors.Highlight;
            topLabel_1.Location = new Point(536, 9);
            topLabel_1.Name = "topLabel_1";
            topLabel_1.Size = new Size(33, 37);
            topLabel_1.TabIndex = 1;
            topLabel_1.Text = "0";
            // 
            // downLabel_1
            // 
            downLabel_1.AutoSize = true;
            downLabel_1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            downLabel_1.ForeColor = SystemColors.Highlight;
            downLabel_1.Location = new Point(536, 684);
            downLabel_1.Name = "downLabel_1";
            downLabel_1.Size = new Size(33, 37);
            downLabel_1.TabIndex = 2;
            downLabel_1.Text = "0";
            // 
            // rightLabel_1
            // 
            rightLabel_1.AutoSize = true;
            rightLabel_1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rightLabel_1.ForeColor = SystemColors.Highlight;
            rightLabel_1.Location = new Point(1212, 324);
            rightLabel_1.Name = "rightLabel_1";
            rightLabel_1.Size = new Size(33, 37);
            rightLabel_1.TabIndex = 3;
            rightLabel_1.Text = "0";
            // 
            // leftLabel_2
            // 
            leftLabel_2.AutoSize = true;
            leftLabel_2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            leftLabel_2.ForeColor = Color.Red;
            leftLabel_2.Location = new Point(12, 270);
            leftLabel_2.Name = "leftLabel_2";
            leftLabel_2.Size = new Size(33, 37);
            leftLabel_2.TabIndex = 4;
            leftLabel_2.Text = "0";
            // 
            // topLabel_2
            // 
            topLabel_2.AutoSize = true;
            topLabel_2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            topLabel_2.ForeColor = Color.Red;
            topLabel_2.Location = new Point(671, 9);
            topLabel_2.Name = "topLabel_2";
            topLabel_2.Size = new Size(33, 37);
            topLabel_2.TabIndex = 5;
            topLabel_2.Text = "0";
            // 
            // rightLabel_2
            // 
            rightLabel_2.AutoSize = true;
            rightLabel_2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rightLabel_2.ForeColor = Color.Red;
            rightLabel_2.Location = new Point(1212, 270);
            rightLabel_2.Name = "rightLabel_2";
            rightLabel_2.Size = new Size(33, 37);
            rightLabel_2.TabIndex = 6;
            rightLabel_2.Text = "0";
            // 
            // downLabel_2
            // 
            downLabel_2.AutoSize = true;
            downLabel_2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            downLabel_2.ForeColor = Color.Red;
            downLabel_2.Location = new Point(671, 684);
            downLabel_2.Name = "downLabel_2";
            downLabel_2.Size = new Size(33, 37);
            downLabel_2.TabIndex = 7;
            downLabel_2.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 730);
            Controls.Add(downLabel_2);
            Controls.Add(rightLabel_2);
            Controls.Add(topLabel_2);
            Controls.Add(leftLabel_2);
            Controls.Add(rightLabel_1);
            Controls.Add(downLabel_1);
            Controls.Add(topLabel_1);
            Controls.Add(leftLabel_1);
            Name = "MainForm";
            Text = "Billyard";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftLabel_1;
        private Label topLabel_1;
        private Label downLabel_1;
        private Label rightLabel_1;
        private Label leftLabel_2;
        private Label topLabel_2;
        private Label rightLabel_2;
        private Label downLabel_2;
    }
}
