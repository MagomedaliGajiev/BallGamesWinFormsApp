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
            SuspendLayout();
            // 
            // ballPaintButton
            // 
            ballPaintButton.Location = new Point(925, 50);
            ballPaintButton.Name = "ballPaintButton";
            ballPaintButton.Size = new Size(270, 69);
            ballPaintButton.TabIndex = 0;
            ballPaintButton.Text = "Рисовать шарик";
            ballPaintButton.UseVisualStyleBackColor = true;
            ballPaintButton.Click += ballPaintButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 688);
            Controls.Add(ballPaintButton);
            Name = "MainForm";
            Text = "Мячики";
            ResumeLayout(false);
        }

        #endregion

        private Button ballPaintButton;
    }
}
