namespace BallGamesWinFormsApp
{
    partial class BallPopForm
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
            startStopbutton = new Button();
            generateButton = new Button();
            MapLabel = new Label();
            label1 = new Label();
            Hitlabel = new Label();
            SuspendLayout();
            // 
            // startStopbutton
            // 
            startStopbutton.Location = new Point(12, 12);
            startStopbutton.Name = "startStopbutton";
            startStopbutton.Size = new Size(85, 23);
            startStopbutton.TabIndex = 0;
            startStopbutton.Text = "Сарт\\Пауза";
            startStopbutton.UseVisualStyleBackColor = true;
            startStopbutton.Click += startStopbutton_Click;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(117, 12);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(163, 23);
            generateButton.TabIndex = 1;
            generateButton.Text = "Сгенерировать шары";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // MapLabel
            // 
            MapLabel.BackColor = SystemColors.ActiveBorder;
            MapLabel.Location = new Point(74, 83);
            MapLabel.Name = "MapLabel";
            MapLabel.Size = new Size(496, 274);
            MapLabel.TabIndex = 2;
            MapLabel.MouseDown += MapLabel_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 16);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "Сбитых шаров:";
            // 
            // Hitlabel
            // 
            Hitlabel.AutoSize = true;
            Hitlabel.Location = new Point(383, 16);
            Hitlabel.Name = "Hitlabel";
            Hitlabel.Size = new Size(13, 15);
            Hitlabel.TabIndex = 4;
            Hitlabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 410);
            Controls.Add(Hitlabel);
            Controls.Add(label1);
            Controls.Add(MapLabel);
            Controls.Add(generateButton);
            Controls.Add(startStopbutton);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startStopbutton;
        private Button generateButton;
        private Label MapLabel;
        private Label label1;
        private Label Hitlabel;
    }
}
