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
            ballPaintButton = new Button();
            randomBallPaintButton = new Button();
            SuspendLayout();
            // 
            // ballPaintButton
            // 
            ballPaintButton.Location = new Point(991, 38);
            ballPaintButton.Name = "ballPaintButton";
            ballPaintButton.Size = new Size(212, 52);
            ballPaintButton.TabIndex = 0;
            ballPaintButton.Text = "Рисовать шарик";
            ballPaintButton.UseVisualStyleBackColor = true;
            ballPaintButton.Click += ballPaintButton_Click;
            // 
            // randomBallPaintButton
            // 
            randomBallPaintButton.Location = new Point(657, 38);
            randomBallPaintButton.Name = "randomBallPaintButton";
            randomBallPaintButton.Size = new Size(315, 52);
            randomBallPaintButton.TabIndex = 1;
            randomBallPaintButton.Text = "Рисовать случайный шарик";
            randomBallPaintButton.UseVisualStyleBackColor = true;
            randomBallPaintButton.Click += randomBallPaintButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 688);
            Controls.Add(randomBallPaintButton);
            Controls.Add(ballPaintButton);
            Name = "MainForm";
            Text = "Мячики";
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button ballPaintButton;
        private Button randomBallPaintButton;
    }
}
