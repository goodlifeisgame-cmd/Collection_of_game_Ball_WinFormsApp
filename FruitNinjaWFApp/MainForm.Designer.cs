namespace FruitNinjaWFApp
{
    partial class FruitNinjaForm
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
            button1 = new Button();
            CoreLabel = new Label();
            CountCoreLabel = new Label();
            TimerSpawnFruit = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            LifeBallLabel = new Label();
            CursorSizeTimer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SlowMoTimelabel = new Label();
            Secondtimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // MapLabel
            // 
            MapLabel.BackColor = SystemColors.ActiveCaption;
            MapLabel.Location = new Point(12, 44);
            MapLabel.Name = "MapLabel";
            MapLabel.Size = new Size(776, 388);
            MapLabel.TabIndex = 0;
            MapLabel.MouseMove += MapLabel_MouseMove;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Рестарт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CoreLabel
            // 
            CoreLabel.AutoSize = true;
            CoreLabel.Location = new Point(118, 20);
            CoreLabel.Name = "CoreLabel";
            CoreLabel.Size = new Size(84, 15);
            CoreLabel.TabIndex = 2;
            CoreLabel.Text = "кол-во очков:";
            // 
            // CountCoreLabel
            // 
            CountCoreLabel.AutoSize = true;
            CountCoreLabel.Location = new Point(208, 20);
            CountCoreLabel.Name = "CountCoreLabel";
            CountCoreLabel.Size = new Size(13, 15);
            CountCoreLabel.TabIndex = 3;
            CountCoreLabel.Text = "0";
            // 
            // TimerSpawnFruit
            // 
            TimerSpawnFruit.Interval = 2000;
            TimerSpawnFruit.Tick += TimerSpawnFruit_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(519, 22);
            label1.Name = "label1";
            label1.Size = new Size(231, 15);
            label1.TabIndex = 4;
            label1.Text = "кол-во существующих шаров в массиве";
            // 
            // LifeBallLabel
            // 
            LifeBallLabel.AutoSize = true;
            LifeBallLabel.Location = new Point(756, 22);
            LifeBallLabel.Name = "LifeBallLabel";
            LifeBallLabel.Size = new Size(13, 15);
            LifeBallLabel.TabIndex = 5;
            LifeBallLabel.Text = "0";
            // 
            // CursorSizeTimer
            // 
            CursorSizeTimer.Enabled = true;
            CursorSizeTimer.Interval = 20;
            CursorSizeTimer.Tick += CursorSizeTimer_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 22);
            label2.Name = "label2";
            label2.Size = new Size(170, 15);
            label2.TabIndex = 6;
            label2.Text = "Осталось секунд замедления:";
            // 
            // SlowMoTimelabel
            // 
            SlowMoTimelabel.AutoSize = true;
            SlowMoTimelabel.Location = new Point(438, 22);
            SlowMoTimelabel.Name = "SlowMoTimelabel";
            SlowMoTimelabel.Size = new Size(13, 15);
            SlowMoTimelabel.TabIndex = 7;
            SlowMoTimelabel.Text = "0";
            // 
            // Secondtimer
            // 
            Secondtimer.Tick += Secondtimer_Tick;
            // 
            // FruitNinjaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SlowMoTimelabel);
            Controls.Add(label2);
            Controls.Add(LifeBallLabel);
            Controls.Add(label1);
            Controls.Add(CountCoreLabel);
            Controls.Add(CoreLabel);
            Controls.Add(button1);
            Controls.Add(MapLabel);
            Name = "FruitNinjaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "I NINJA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MapLabel;
        private Button button1;
        private Label CoreLabel;
        private Label CountCoreLabel;
        private System.Windows.Forms.Timer TimerSpawnFruit;
        private Label label1;
        private Label LifeBallLabel;
        private System.Windows.Forms.Timer CursorSizeTimer;
        private Label label2;
        private Label SlowMoTimelabel;
        private System.Windows.Forms.Timer Secondtimer;
    }
}
