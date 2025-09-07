namespace Kolory
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.red = new System.Windows.Forms.TextBox();
            this.green = new System.Windows.Forms.TextBox();
            this.blue = new System.Windows.Forms.TextBox();
            this.labelRed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.blad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(194, 74);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(200, 20);
            this.red.TabIndex = 0;
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(194, 100);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(200, 20);
            this.green.TabIndex = 1;
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(194, 126);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(200, 20);
            this.blue.TabIndex = 2;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRed.Location = new System.Drawing.Point(149, 75);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(39, 16);
            this.labelRed.TabIndex = 3;
            this.labelRed.Text = "RED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(128, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "GREEN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(142, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "BLUE";
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeButton.Location = new System.Drawing.Point(194, 152);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(200, 45);
            this.changeButton.TabIndex = 6;
            this.changeButton.Text = "Change BG";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // blad
            // 
            this.blad.AutoSize = true;
            this.blad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.blad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blad.ForeColor = System.Drawing.Color.DarkRed;
            this.blad.Location = new System.Drawing.Point(191, 228);
            this.blad.Name = "blad";
            this.blad.Size = new System.Drawing.Size(2, 15);
            this.blad.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blad);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox red;
        private System.Windows.Forms.TextBox green;
        private System.Windows.Forms.TextBox blue;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label blad;
    }
}

