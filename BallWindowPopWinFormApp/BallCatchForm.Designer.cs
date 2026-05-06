namespace BallWindowPopWinFormApp
{
    partial class BallWindowForm
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
            label1 = new Label();
            StartButton = new Button();
            StopButton = new Button();
            CountBalllabel = new Label();
            Maplabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 24);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "поймано:";
            // 
            // StartButton
            // 
            StartButton.Location = new Point(12, 16);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 1;
            StartButton.Text = "Начать";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(93, 16);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(86, 23);
            StopButton.TabIndex = 2;
            StopButton.Text = "остановить";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // CountBalllabel
            // 
            CountBalllabel.AutoSize = true;
            CountBalllabel.Location = new Point(344, 24);
            CountBalllabel.Name = "CountBalllabel";
            CountBalllabel.Size = new Size(13, 15);
            CountBalllabel.TabIndex = 4;
            CountBalllabel.Text = "0";
            // 
            // Maplabel
            // 
            Maplabel.BackColor = SystemColors.ActiveCaption;
            Maplabel.Location = new Point(57, 71);
            Maplabel.Name = "Maplabel";
            Maplabel.Size = new Size(579, 294);
            Maplabel.TabIndex = 5;
            // 
            // BallWindowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Maplabel);
            Controls.Add(CountBalllabel);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Controls.Add(label1);
            Name = "BallWindowForm";
            Text = "Поймай шарик в окне";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button StartButton;
        private Button StopButton;
        private Label CountBalllabel;
        private Label Maplabel;
    }
}
