namespace WinFormsApp1
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
            label1 = new Label();
            green = new Label();
            blue = new Label();
            red = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 15);
            label1.TabIndex = 0;
            label1.Text = "Siema siema, Stuu wita jak masz 14 lat to pisz. PDW";
            label1.Click += label1_Click;
            // 
            // green
            // 
            green.AutoSize = true;
            green.BackColor = Color.Green;
            green.ForeColor = Color.White;
            green.Location = new Point(305, 126);
            green.Name = "green";
            green.Size = new Size(46, 15);
            green.TabIndex = 1;
            green.Text = "Zielony";
            // 
            // blue
            // 
            blue.AutoSize = true;
            blue.BackColor = Color.Blue;
            blue.ForeColor = Color.White;
            blue.Location = new Point(352, 152);
            blue.Name = "blue";
            blue.Size = new Size(55, 15);
            blue.TabIndex = 2;
            blue.Text = "Niebieski";
            // 
            // red
            // 
            red.AutoSize = true;
            red.BackColor = Color.Red;
            red.ForeColor = Color.White;
            red.Location = new Point(365, 95);
            red.Name = "red";
            red.Size = new Size(59, 15);
            red.TabIndex = 3;
            red.Text = "Czerwony";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(red);
            Controls.Add(blue);
            Controls.Add(green);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label green;
        private Label blue;
        private Label red;
    }
}