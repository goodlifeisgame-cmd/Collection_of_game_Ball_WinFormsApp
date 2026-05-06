namespace SalutGameWinFormsApp
{
    partial class SalutMainForm
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
            timerMove = new System.Windows.Forms.Timer(components);
            RunSalutButton = new Button();
            SuspendLayout();
            // 
            // MapLabel
            // 
            MapLabel.BackColor = Color.RoyalBlue;
            MapLabel.Location = new Point(43, 65);
            MapLabel.Name = "MapLabel";
            MapLabel.Size = new Size(679, 376);
            MapLabel.TabIndex = 0;
            MapLabel.MouseDown += MapLabel_MouseDown;
            // 
            // timerMove
            // 
            timerMove.Interval = 30;
            // 
            // RunSalutButton
            // 
            RunSalutButton.Location = new Point(43, 28);
            RunSalutButton.Name = "RunSalutButton";
            RunSalutButton.Size = new Size(75, 23);
            RunSalutButton.TabIndex = 1;
            RunSalutButton.Text = "Запустить салют";
            RunSalutButton.UseVisualStyleBackColor = true;
            RunSalutButton.Click += RunSalutButton_Click;
            // 
            // SalutMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RunSalutButton);
            Controls.Add(MapLabel);
            Name = "SalutMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Салют";
            ResumeLayout(false);
        }

        #endregion

        private Label MapLabel;
        private System.Windows.Forms.Timer timerMove;
        private Button RunSalutButton;
    }
}
