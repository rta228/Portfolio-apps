namespace Zadanko2
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
            this.dysk1 = new System.Windows.Forms.TextBox();
            this.sciezka1 = new System.Windows.Forms.TextBox();
            this.nazwaPliku = new System.Windows.Forms.TextBox();
            this.dysk2 = new System.Windows.Forms.TextBox();
            this.sciezka2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dysk1
            // 
            this.dysk1.Location = new System.Drawing.Point(70, 12);
            this.dysk1.Name = "dysk1";
            this.dysk1.Size = new System.Drawing.Size(190, 20);
            this.dysk1.TabIndex = 0;
            // 
            // sciezka1
            // 
            this.sciezka1.Location = new System.Drawing.Point(76, 38);
            this.sciezka1.Name = "sciezka1";
            this.sciezka1.Size = new System.Drawing.Size(190, 20);
            this.sciezka1.TabIndex = 1;
            // 
            // nazwaPliku
            // 
            this.nazwaPliku.Location = new System.Drawing.Point(59, 64);
            this.nazwaPliku.Name = "nazwaPliku";
            this.nazwaPliku.Size = new System.Drawing.Size(190, 20);
            this.nazwaPliku.TabIndex = 2;
            // 
            // dysk2
            // 
            this.dysk2.Location = new System.Drawing.Point(377, 12);
            this.dysk2.Name = "dysk2";
            this.dysk2.Size = new System.Drawing.Size(202, 20);
            this.dysk2.TabIndex = 3;
            // 
            // sciezka2
            // 
            this.sciezka2.Location = new System.Drawing.Point(377, 38);
            this.sciezka2.Name = "sciezka2";
            this.sciezka2.Size = new System.Drawing.Size(202, 20);
            this.sciezka2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naped 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sciezka 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nazwa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Naped 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sciezka 2:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sciezka2);
            this.Controls.Add(this.dysk2);
            this.Controls.Add(this.nazwaPliku);
            this.Controls.Add(this.sciezka1);
            this.Controls.Add(this.dysk1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dysk1;
        private System.Windows.Forms.TextBox sciezka1;
        private System.Windows.Forms.TextBox nazwaPliku;
        private System.Windows.Forms.TextBox dysk2;
        private System.Windows.Forms.TextBox sciezka2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}

