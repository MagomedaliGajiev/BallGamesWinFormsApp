namespace CatchMe2WinFormsApp
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
            startButton = new Button();
            clearButton = new Button();
            countBallsLabel = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(842, 21);
            startButton.Name = "startButton";
            startButton.Size = new Size(150, 46);
            startButton.TabIndex = 0;
            startButton.Text = "Создать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(842, 90);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(150, 46);
            clearButton.TabIndex = 1;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // countBallsLabel
            // 
            countBallsLabel.AutoSize = true;
            countBallsLabel.Location = new Point(768, 28);
            countBallsLabel.Name = "countBallsLabel";
            countBallsLabel.Size = new Size(27, 32);
            countBallsLabel.TabIndex = 2;
            countBallsLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 539);
            Controls.Add(countBallsLabel);
            Controls.Add(clearButton);
            Controls.Add(startButton);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Button clearButton;
        private Label countBallsLabel;
    }
}
