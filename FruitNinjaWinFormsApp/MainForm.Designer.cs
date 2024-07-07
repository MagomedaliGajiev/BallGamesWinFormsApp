namespace FruitNinjaWinFormsApp
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
            scoreLabel = new Label();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(12, 9);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(27, 32);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 713);
            Controls.Add(scoreLabel);
            Name = "MainForm";
            Text = "FruitNinja";
            Load += MainForm_Load;
            MouseMove += MainForm_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreLabel;
    }
}
