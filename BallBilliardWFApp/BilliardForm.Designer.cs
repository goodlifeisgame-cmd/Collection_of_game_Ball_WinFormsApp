namespace BallBilliardWFApp
{
    partial class BilliardForm
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
            topLabel = new Label();
            leftLabel = new Label();
            rightLabel = new Label();
            downLabel = new Label();
            SpawnButton = new Button();
            ClearButton = new Button();
            ResecScpreButton = new Button();
            SuspendLayout();
            // 
            // MapLabel
            // 
            MapLabel.BackColor = Color.ForestGreen;
            MapLabel.Location = new Point(60, 85);
            MapLabel.Name = "MapLabel";
            MapLabel.Size = new Size(625, 308);
            MapLabel.TabIndex = 0;
            // 
            // topLabel
            // 
            topLabel.AutoSize = true;
            topLabel.Location = new Point(367, 59);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(13, 15);
            topLabel.TabIndex = 1;
            topLabel.Text = "0";
            // 
            // leftLabel
            // 
            leftLabel.AutoSize = true;
            leftLabel.Location = new Point(41, 214);
            leftLabel.Name = "leftLabel";
            leftLabel.Size = new Size(13, 15);
            leftLabel.TabIndex = 2;
            leftLabel.Text = "0";
            // 
            // rightLabel
            // 
            rightLabel.AutoSize = true;
            rightLabel.Location = new Point(691, 224);
            rightLabel.Name = "rightLabel";
            rightLabel.Size = new Size(13, 15);
            rightLabel.TabIndex = 3;
            rightLabel.Text = "0";
            // 
            // downLabel
            // 
            downLabel.AutoSize = true;
            downLabel.Location = new Point(367, 402);
            downLabel.Name = "downLabel";
            downLabel.Size = new Size(13, 15);
            downLabel.TabIndex = 4;
            downLabel.Text = "0";
            // 
            // SpawnButton
            // 
            SpawnButton.Location = new Point(22, 26);
            SpawnButton.Name = "SpawnButton";
            SpawnButton.Size = new Size(75, 23);
            SpawnButton.TabIndex = 5;
            SpawnButton.Text = "Заспавнить";
            SpawnButton.UseVisualStyleBackColor = true;
            SpawnButton.Click += SpawnButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(103, 26);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ResecScpreButton
            // 
            ResecScpreButton.Location = new Point(184, 26);
            ResecScpreButton.Name = "ResecScpreButton";
            ResecScpreButton.Size = new Size(87, 23);
            ResecScpreButton.TabIndex = 7;
            ResecScpreButton.Text = "сброс очков";
            ResecScpreButton.UseVisualStyleBackColor = true;
            ResecScpreButton.Click += ResecScpreButton_Click;
            // 
            // BilliardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResecScpreButton);
            Controls.Add(ClearButton);
            Controls.Add(SpawnButton);
            Controls.Add(downLabel);
            Controls.Add(rightLabel);
            Controls.Add(leftLabel);
            Controls.Add(topLabel);
            Controls.Add(MapLabel);
            Name = "BilliardForm";
            Text = "Бильярд";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MapLabel;
        private Label topLabel;
        private Label leftLabel;
        private Label rightLabel;
        private Label downLabel;
        private Button SpawnButton;
        private Button ClearButton;
        private Button ResecScpreButton;
    }
}
