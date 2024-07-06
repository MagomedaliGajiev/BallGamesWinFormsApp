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
            ballPointButton = new Button();
            randomBallPointButton = new Button();
            SuspendLayout();
            // 
            // ballPointButton
            // 
            ballPointButton.Location = new Point(991, 38);
            ballPointButton.Name = "ballPointButton";
            ballPointButton.Size = new Size(212, 52);
            ballPointButton.TabIndex = 0;
            ballPointButton.Text = "Рисовать шарик";
            ballPointButton.UseVisualStyleBackColor = true;
            ballPointButton.Click += ballPointButton_Click;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 688);
            Controls.Add(randomBallPointButton);
            Controls.Add(ballPointButton);
            Name = "MainForm";
            Text = "Мячики";
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button ballPointButton;
        private Button randomBallPointButton;
    }
}
