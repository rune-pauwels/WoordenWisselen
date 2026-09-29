namespace WoordenWisselen
{
    partial class Form1
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
            EersteEnLaatsteWoordLabel = new Label();
            EersteWoordLabel = new Label();
            ZinTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // EersteEnLaatsteWoordLabel
            // 
            EersteEnLaatsteWoordLabel.AutoSize = true;
            EersteEnLaatsteWoordLabel.BackColor = Color.Black;
            EersteEnLaatsteWoordLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EersteEnLaatsteWoordLabel.ForeColor = Color.White;
            EersteEnLaatsteWoordLabel.Location = new Point(12, 117);
            EersteEnLaatsteWoordLabel.Name = "EersteEnLaatsteWoordLabel";
            EersteEnLaatsteWoordLabel.Size = new Size(17, 21);
            EersteEnLaatsteWoordLabel.TabIndex = 0;
            EersteEnLaatsteWoordLabel.Text = "?";
            // 
            // EersteWoordLabel
            // 
            EersteWoordLabel.AutoSize = true;
            EersteWoordLabel.BackColor = Color.Black;
            EersteWoordLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EersteWoordLabel.ForeColor = Color.White;
            EersteWoordLabel.Location = new Point(12, 67);
            EersteWoordLabel.Name = "EersteWoordLabel";
            EersteWoordLabel.Size = new Size(17, 21);
            EersteWoordLabel.TabIndex = 1;
            EersteWoordLabel.Text = "?";
            // 
            // ZinTextBox
            // 
            ZinTextBox.Location = new Point(12, 12);
            ZinTextBox.Name = "ZinTextBox";
            ZinTextBox.Size = new Size(328, 23);
            ZinTextBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(12, 41);
            button1.Name = "button1";
            button1.Size = new Size(328, 23);
            button1.TabIndex = 5;
            button1.Text = "Verplaatst het eerste woord naar achter.";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 91);
            button2.Name = "button2";
            button2.Size = new Size(328, 23);
            button2.TabIndex = 6;
            button2.Text = "Wissel eerste en laatste woord van plaats.";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ZinTextBox);
            Controls.Add(EersteWoordLabel);
            Controls.Add(EersteEnLaatsteWoordLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EersteEnLaatsteWoordLabel;
        private Label EersteWoordLabel;
        private Button EersteEnLaatsteWoordButton;
        private Button EersteWoordButton;
        private TextBox ZinTextBox;
        private Button button1;
        private Button button2;
    }
}
