namespace SimulationGasWFApp
{
    partial class SimulationGasForm
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
            MapLabel = new Label();
            leftRedLabel = new Label();
            leftBlueLabel = new Label();
            rightRedLabel = new Label();
            rightBlueLabel = new Label();
            StartButton = new Button();
            StopButton = new Button();
            centerMapLabel = new Label();
            ClearButton = new Button();
            LeftBlueLocationlabel = new Label();
            LeftRedLocationlabel = new Label();
            RightBlueLocationlabel = new Label();
            RightRedLocationlabel = new Label();
            SuspendLayout();
            // 
            // MapLabel
            // 
            MapLabel.BackColor = Color.Wheat;
            MapLabel.BorderStyle = BorderStyle.FixedSingle;
            MapLabel.Location = new Point(56, 53);
            MapLabel.Name = "MapLabel";
            MapLabel.Size = new Size(288, 347);
            MapLabel.TabIndex = 0;
            // 
            // leftRedLabel
            // 
            leftRedLabel.AutoSize = true;
            leftRedLabel.BackColor = Color.IndianRed;
            leftRedLabel.ForeColor = Color.Black;
            leftRedLabel.Location = new Point(12, 200);
            leftRedLabel.Name = "leftRedLabel";
            leftRedLabel.Size = new Size(13, 15);
            leftRedLabel.TabIndex = 1;
            leftRedLabel.Text = "0";
            // 
            // leftBlueLabel
            // 
            leftBlueLabel.AutoSize = true;
            leftBlueLabel.BackColor = Color.Cyan;
            leftBlueLabel.ForeColor = Color.Black;
            leftBlueLabel.Location = new Point(12, 227);
            leftBlueLabel.Name = "leftBlueLabel";
            leftBlueLabel.Size = new Size(13, 15);
            leftBlueLabel.TabIndex = 2;
            leftBlueLabel.Text = "0";
            // 
            // rightRedLabel
            // 
            rightRedLabel.AutoSize = true;
            rightRedLabel.BackColor = Color.IndianRed;
            rightRedLabel.ForeColor = Color.Black;
            rightRedLabel.Location = new Point(350, 200);
            rightRedLabel.Name = "rightRedLabel";
            rightRedLabel.Size = new Size(13, 15);
            rightRedLabel.TabIndex = 3;
            rightRedLabel.Text = "0";
            // 
            // rightBlueLabel
            // 
            rightBlueLabel.AutoSize = true;
            rightBlueLabel.BackColor = Color.Cyan;
            rightBlueLabel.ForeColor = Color.Black;
            rightBlueLabel.Location = new Point(350, 227);
            rightBlueLabel.Name = "rightBlueLabel";
            rightBlueLabel.Size = new Size(13, 15);
            rightBlueLabel.TabIndex = 4;
            rightBlueLabel.Text = "0";
            // 
            // StartButton
            // 
            StartButton.Location = new Point(56, 12);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 6;
            StartButton.Text = "запуск";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(152, 12);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(98, 23);
            StopButton.TabIndex = 7;
            StopButton.Text = "остановить";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // centerMapLabel
            // 
            centerMapLabel.BackColor = Color.Silver;
            centerMapLabel.Location = new Point(199, 54);
            centerMapLabel.Name = "centerMapLabel";
            centerMapLabel.Size = new Size(3, 345);
            centerMapLabel.TabIndex = 8;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(269, 12);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 9;
            ClearButton.Text = "очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // LeftBlueLocationlabel
            // 
            LeftBlueLocationlabel.AutoSize = true;
            LeftBlueLocationlabel.BackColor = SystemColors.ActiveCaption;
            LeftBlueLocationlabel.Location = new Point(110, 400);
            LeftBlueLocationlabel.Name = "LeftBlueLocationlabel";
            LeftBlueLocationlabel.Size = new Size(13, 15);
            LeftBlueLocationlabel.TabIndex = 10;
            LeftBlueLocationlabel.Text = "0";
            // 
            // LeftRedLocationlabel
            // 
            LeftRedLocationlabel.AutoSize = true;
            LeftRedLocationlabel.BackColor = Color.IndianRed;
            LeftRedLocationlabel.Location = new Point(110, 415);
            LeftRedLocationlabel.Name = "LeftRedLocationlabel";
            LeftRedLocationlabel.Size = new Size(13, 15);
            LeftRedLocationlabel.TabIndex = 11;
            LeftRedLocationlabel.Text = "0";
            // 
            // RightBlueLocationlabel
            // 
            RightBlueLocationlabel.AutoSize = true;
            RightBlueLocationlabel.BackColor = SystemColors.ActiveCaption;
            RightBlueLocationlabel.Location = new Point(250, 400);
            RightBlueLocationlabel.Name = "RightBlueLocationlabel";
            RightBlueLocationlabel.Size = new Size(13, 15);
            RightBlueLocationlabel.TabIndex = 12;
            RightBlueLocationlabel.Text = "0";
            // 
            // RightRedLocationlabel
            // 
            RightRedLocationlabel.AutoSize = true;
            RightRedLocationlabel.BackColor = Color.IndianRed;
            RightRedLocationlabel.Location = new Point(250, 415);
            RightRedLocationlabel.Name = "RightRedLocationlabel";
            RightRedLocationlabel.Size = new Size(13, 15);
            RightRedLocationlabel.TabIndex = 13;
            RightRedLocationlabel.Text = "0";
            // 
            // SimulationGasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(RightRedLocationlabel);
            Controls.Add(RightBlueLocationlabel);
            Controls.Add(LeftRedLocationlabel);
            Controls.Add(LeftBlueLocationlabel);
            Controls.Add(ClearButton);
            Controls.Add(centerMapLabel);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Controls.Add(rightBlueLabel);
            Controls.Add(rightRedLabel);
            Controls.Add(leftBlueLabel);
            Controls.Add(leftRedLabel);
            Controls.Add(MapLabel);
            Name = "SimulationGasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MapLabel;
        private Label leftRedLabel;
        private Label leftBlueLabel;
        private Label rightRedLabel;
        private Label rightBlueLabel;
        private Button StartButton;
        private Button StopButton;
        private Label centerMapLabel;
        private Button ClearButton;
        private Label LeftBlueLocationlabel;
        private Label LeftRedLocationlabel;
        private Label RightBlueLocationlabel;
        private Label RightRedLocationlabel;
    }
}
