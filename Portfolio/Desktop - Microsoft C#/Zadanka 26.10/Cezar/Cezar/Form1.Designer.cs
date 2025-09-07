namespace Cezar
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
            this.szyfruj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tekstDoZakodowania = new System.Windows.Forms.TextBox();
            this.wynikSzyfru = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.klucz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.blad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // szyfruj
            // 
            this.szyfruj.Location = new System.Drawing.Point(287, 187);
            this.szyfruj.Name = "szyfruj";
            this.szyfruj.Size = new System.Drawing.Size(75, 23);
            this.szyfruj.TabIndex = 0;
            this.szyfruj.Text = "Szyfruj";
            this.szyfruj.UseVisualStyleBackColor = true;
            this.szyfruj.Click += new System.EventHandler(this.szyfruj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tekst do zakodowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tekst zakodowany";
            // 
            // tekstDoZakodowania
            // 
            this.tekstDoZakodowania.Location = new System.Drawing.Point(229, 72);
            this.tekstDoZakodowania.Name = "tekstDoZakodowania";
            this.tekstDoZakodowania.Size = new System.Drawing.Size(200, 20);
            this.tekstDoZakodowania.TabIndex = 3;
            // 
            // wynikSzyfru
            // 
            this.wynikSzyfru.Enabled = false;
            this.wynikSzyfru.Location = new System.Drawing.Point(229, 128);
            this.wynikSzyfru.Name = "wynikSzyfru";
            this.wynikSzyfru.Size = new System.Drawing.Size(200, 20);
            this.wynikSzyfru.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Przesuniecie o";
            // 
            // klucz
            // 
            this.klucz.Location = new System.Drawing.Point(229, 100);
            this.klucz.MaxLength = 2;
            this.klucz.Name = "klucz";
            this.klucz.Size = new System.Drawing.Size(40, 20);
            this.klucz.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "znakow";
            // 
            // blad
            // 
            this.blad.AutoSize = true;
            this.blad.Location = new System.Drawing.Point(226, 162);
            this.blad.Name = "blad";
            this.blad.Size = new System.Drawing.Size(0, 13);
            this.blad.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.klucz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wynikSzyfru);
            this.Controls.Add(this.tekstDoZakodowania);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szyfruj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button szyfruj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tekstDoZakodowania;
        private System.Windows.Forms.TextBox wynikSzyfru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox klucz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label blad;
    }
}

