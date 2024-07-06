namespace BallGamesWinFormsApp
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
            stopButton = new Button();
            startButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // stopButton
            // 
            stopButton.Location = new Point(992, 81);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(227, 52);
            stopButton.TabIndex = 2;
            stopButton.Text = "Остановить";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(992, 23);
            startButton.Name = "startButton";
            startButton.Size = new Size(227, 52);
            startButton.TabIndex = 3;
            startButton.Text = "Создать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(992, 139);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(227, 52);
            clearButton.TabIndex = 4;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 688);
            Controls.Add(clearButton);
            Controls.Add(startButton);
            Controls.Add(stopButton);
            Name = "MainForm";
            Text = "Мячики";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion
        private Button stopButton;
        private Button startButton;
        private Button clearButton;
    }
}
