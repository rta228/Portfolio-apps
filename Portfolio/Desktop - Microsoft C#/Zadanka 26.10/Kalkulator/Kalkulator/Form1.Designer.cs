namespace Kalkulator
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
            this.dodawanie = new System.Windows.Forms.Button();
            this.odejmowanie = new System.Windows.Forms.Button();
            this.mnozenie = new System.Windows.Forms.Button();
            this.dzielenie = new System.Windows.Forms.Button();
            this.znak = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.liczba1 = new System.Windows.Forms.TextBox();
            this.liczba2 = new System.Windows.Forms.TextBox();
            this.wynik = new System.Windows.Forms.TextBox();
            this.blad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodawanie
            // 
            this.dodawanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dodawanie.Location = new System.Drawing.Point(235, 270);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(75, 35);
            this.dodawanie.TabIndex = 0;
            this.dodawanie.Text = "+";
            this.dodawanie.UseVisualStyleBackColor = true;
            this.dodawanie.Click += new System.EventHandler(this.dodawanie_Click);
            // 
            // odejmowanie
            // 
            this.odejmowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.odejmowanie.Location = new System.Drawing.Point(316, 270);
            this.odejmowanie.Name = "odejmowanie";
            this.odejmowanie.Size = new System.Drawing.Size(75, 35);
            this.odejmowanie.TabIndex = 1;
            this.odejmowanie.Text = "-";
            this.odejmowanie.UseVisualStyleBackColor = true;
            this.odejmowanie.Click += new System.EventHandler(this.odejmowanie_Click);
            // 
            // mnozenie
            // 
            this.mnozenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mnozenie.Location = new System.Drawing.Point(397, 270);
            this.mnozenie.Name = "mnozenie";
            this.mnozenie.Size = new System.Drawing.Size(75, 35);
            this.mnozenie.TabIndex = 2;
            this.mnozenie.Text = "*";
            this.mnozenie.UseVisualStyleBackColor = true;
            this.mnozenie.Click += new System.EventHandler(this.mnozenie_Click);
            // 
            // dzielenie
            // 
            this.dzielenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzielenie.Location = new System.Drawing.Point(478, 270);
            this.dzielenie.Name = "dzielenie";
            this.dzielenie.Size = new System.Drawing.Size(75, 35);
            this.dzielenie.TabIndex = 3;
            this.dzielenie.Text = "/";
            this.dzielenie.UseVisualStyleBackColor = true;
            this.dzielenie.Click += new System.EventHandler(this.dzielenie_Click);
            // 
            // znak
            // 
            this.znak.AutoSize = true;
            this.znak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.znak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.znak.Location = new System.Drawing.Point(235, 58);
            this.znak.MinimumSize = new System.Drawing.Size(75, 45);
            this.znak.Name = "znak";
            this.znak.Size = new System.Drawing.Size(75, 45);
            this.znak.TabIndex = 4;
            this.znak.Text = "label1";
            this.znak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(478, 58);
            this.label2.MinimumSize = new System.Drawing.Size(75, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // liczba1
            // 
            this.liczba1.Location = new System.Drawing.Point(75, 72);
            this.liczba1.MinimumSize = new System.Drawing.Size(154, 45);
            this.liczba1.Name = "liczba1";
            this.liczba1.Size = new System.Drawing.Size(154, 45);
            this.liczba1.TabIndex = 6;
            // 
            // liczba2
            // 
            this.liczba2.Location = new System.Drawing.Point(318, 72);
            this.liczba2.MinimumSize = new System.Drawing.Size(154, 45);
            this.liczba2.Name = "liczba2";
            this.liczba2.Size = new System.Drawing.Size(154, 45);
            this.liczba2.TabIndex = 7;
            // 
            // wynik
            // 
            this.wynik.Enabled = false;
            this.wynik.Location = new System.Drawing.Point(559, 72);
            this.wynik.MinimumSize = new System.Drawing.Size(154, 45);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(154, 45);
            this.wynik.TabIndex = 8;
            // 
            // blad
            // 
            this.blad.AutoSize = true;
            this.blad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blad.Location = new System.Drawing.Point(156, 133);
            this.blad.MinimumSize = new System.Drawing.Size(154, 45);
            this.blad.Name = "blad";
            this.blad.Size = new System.Drawing.Size(154, 45);
            this.blad.TabIndex = 9;
            this.blad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blad);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.liczba2);
            this.Controls.Add(this.liczba1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.znak);
            this.Controls.Add(this.dzielenie);
            this.Controls.Add(this.mnozenie);
            this.Controls.Add(this.odejmowanie);
            this.Controls.Add(this.dodawanie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodawanie;
        private System.Windows.Forms.Button odejmowanie;
        private System.Windows.Forms.Button mnozenie;
        private System.Windows.Forms.Button dzielenie;
        private System.Windows.Forms.Label znak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox liczba1;
        private System.Windows.Forms.TextBox liczba2;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Label blad;
    }
}

