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
            ballMoveButton = new Button();
            randomBallPointButton = new Button();
            pointBallMoveButton = new Button();
            SuspendLayout();
            // 
            // ballMoveButton
            // 
            ballMoveButton.Location = new Point(991, 38);
            ballMoveButton.Name = "ballMoveButton";
            ballMoveButton.Size = new Size(212, 52);
            ballMoveButton.TabIndex = 0;
            ballMoveButton.Text = "Двигать";
            ballMoveButton.UseVisualStyleBackColor = true;
            ballMoveButton.Click += ballMoveButton_Click;
            // 
            // randomBallPointButton
            // 
            randomBallPointButton.Location = new Point(657, 38);
            randomBallPointButton.Name = "randomBallPointButton";
            randomBallPointButton.Size = new Size(315, 52);
            randomBallPointButton.TabIndex = 1;
            randomBallPointButton.Text = "Рисовать случайный шарик";
            randomBallPointButton.UseVisualStyleBackColor = true;
            randomBallPointButton.Click += randomBallPointButton_Click;
            // 
            // pointBallMoveButton
            // 
            pointBallMoveButton.Location = new Point(991, 106);
            pointBallMoveButton.Name = "pointBallMoveButton";
            pointBallMoveButton.Size = new Size(212, 52);
            pointBallMoveButton.TabIndex = 2;
            pointBallMoveButton.Text = "Двигать";
            pointBallMoveButton.UseVisualStyleBackColor = true;
            pointBallMoveButton.Click += pointBallMoveButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 688);
            Controls.Add(pointBallMoveButton);
            Controls.Add(randomBallPointButton);
            Controls.Add(ballMoveButton);
            Name = "MainForm";
            Text = "Мячики";
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button ballMoveButton;
        private Button randomBallPointButton;
        private Button pointBallMoveButton;
    }
}
