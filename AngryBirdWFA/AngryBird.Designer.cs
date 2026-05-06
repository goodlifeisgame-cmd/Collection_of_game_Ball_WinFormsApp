namespace AngryBirdWFA
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
            MapLabel = new Label();
            label2 = new Label();
            ScoreLabel = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            StartPointLabel = new Label();
            label6 = new Label();
            SpawnTimerBall = new System.Windows.Forms.Timer(components);
            SpawnPigTimer = new System.Windows.Forms.Timer(components);
            CollisionCheckTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // MapLabel
            // 
            MapLabel.BackColor = SystemColors.GradientActiveCaption;
            MapLabel.Location = new Point(45, 62);
            MapLabel.Name = "MapLabel";
            MapLabel.Size = new Size(885, 690);
            MapLabel.TabIndex = 0;
            MapLabel.MouseDown += MapLabel_MouseDown;
            MapLabel.MouseMove += MapLabel_MouseMove;
            MapLabel.MouseUp += MapLabel_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 35);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Очки:";
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Location = new Point(80, 35);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(13, 15);
            ScoreLabel.TabIndex = 2;
            ScoreLabel.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(125, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Рестарт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Peru;
            label3.Location = new Point(245, 549);
            label3.Name = "label3";
            label3.Size = new Size(18, 61);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.BackColor = Color.Peru;
            label4.Location = new Point(249, 610);
            label4.Name = "label4";
            label4.Size = new Size(10, 142);
            label4.TabIndex = 5;
            // 
            // StartPointLabel
            // 
            StartPointLabel.BackColor = Color.Sienna;
            StartPointLabel.Location = new Point(245, 561);
            StartPointLabel.Name = "StartPointLabel";
            StartPointLabel.Size = new Size(18, 19);
            StartPointLabel.TabIndex = 6;
            // 
            // label6
            // 
            label6.BackColor = Color.LimeGreen;
            label6.Location = new Point(45, 752);
            label6.Name = "label6";
            label6.Size = new Size(885, 44);
            label6.TabIndex = 7;
            // 
            // SpawnTimerBall
            // 
            SpawnTimerBall.Enabled = true;
            SpawnTimerBall.Interval = 500;
            SpawnTimerBall.Tick += SpawnTimerBall_Tick;
            // 
            // SpawnPigTimer
            // 
            SpawnPigTimer.Enabled = true;
            SpawnPigTimer.Interval = 500;
            SpawnPigTimer.Tick += SpawnPigTimer_Tick;
            // 
            // CollisionCheckTimer
            // 
            CollisionCheckTimer.Interval = 10;
            CollisionCheckTimer.Tick += CheckState;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 805);
            Controls.Add(label6);
            Controls.Add(StartPointLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(ScoreLabel);
            Controls.Add(label2);
            Controls.Add(MapLabel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Злая птичКО";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MapLabel;
        private Label label2;
        private Label ScoreLabel;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label StartPointLabel;
        private Label label6;
        private System.Windows.Forms.Timer SpawnTimerBall;
        private System.Windows.Forms.Timer SpawnPigTimer;
        private System.Windows.Forms.Timer CollisionCheckTimer;
    }
}
