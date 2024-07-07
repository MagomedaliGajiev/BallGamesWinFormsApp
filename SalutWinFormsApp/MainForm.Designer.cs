namespace SalutWinFormsApp
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
            startSalutButton = new Button();
            SuspendLayout();
            // 
            // startSalutButton
            // 
            startSalutButton.Location = new Point(625, 27);
            startSalutButton.Name = "startSalutButton";
            startSalutButton.Size = new Size(150, 46);
            startSalutButton.TabIndex = 0;
            startSalutButton.Text = "Запустить салют";
            startSalutButton.UseVisualStyleBackColor = true;
            startSalutButton.Click += startSalutButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(startSalutButton);
            Name = "MainForm";
            Text = "Salut";
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button startSalutButton;
    }
}
