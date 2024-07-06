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
            components = new System.ComponentModel.Container();
            randomBallPointButton = new Button();
            ballMoveStopButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            manyBallsButton = new Button();
            SuspendLayout();
            // 
            // randomBallPointButton
            // 
            randomBallPointButton.Location = new Point(580, 38);
            randomBallPointButton.Name = "randomBallPointButton";
            randomBallPointButton.Size = new Size(315, 52);
            randomBallPointButton.TabIndex = 1;
            randomBallPointButton.Text = "Рисовать случайный шарик";
            randomBallPointButton.UseVisualStyleBackColor = true;
            // 
            // ballMoveStopButton
            // 
            ballMoveStopButton.Location = new Point(901, 72);
            ballMoveStopButton.Name = "ballMoveStopButton";
            ballMoveStopButton.Size = new Size(289, 52);
            ballMoveStopButton.TabIndex = 2;
            ballMoveStopButton.Text = "Остановить все шарики";
            ballMoveStopButton.UseVisualStyleBackColor = true;
            ballMoveStopButton.Click += ballMoveStopButton_Click;
            // 
            // timer
            // 
            timer.Interval = 15;
            timer.Tick += timer_Tick;
            // 
            // manyBallsButton
            // 
            manyBallsButton.Location = new Point(580, 106);
            manyBallsButton.Name = "manyBallsButton";
            manyBallsButton.Size = new Size(315, 52);
            manyBallsButton.TabIndex = 3;
            manyBallsButton.Text = "Много шариков";
            manyBallsButton.UseVisualStyleBackColor = true;
            manyBallsButton.Click += manyBallsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 688);
            Controls.Add(manyBallsButton);
            Controls.Add(ballMoveStopButton);
            Controls.Add(randomBallPointButton);
            Name = "MainForm";
            Text = "Мячики";
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion
        private Button randomBallPointButton;
        private Button ballMoveStopButton;
        private System.Windows.Forms.Timer timer;
        private Button manyBallsButton;
    }
}
