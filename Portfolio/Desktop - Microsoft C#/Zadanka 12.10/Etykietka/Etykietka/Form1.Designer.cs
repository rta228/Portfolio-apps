namespace Etykietka
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
            this.textHW = new System.Windows.Forms.Label();
            this.buttonEng = new System.Windows.Forms.Button();
            this.buttonNiem = new System.Windows.Forms.Button();
            this.buttonHis = new System.Windows.Forms.Button();
            this.buttonPL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textHW
            // 
            this.textHW.AutoSize = true;
            this.textHW.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textHW.Location = new System.Drawing.Point(191, 9);
            this.textHW.MinimumSize = new System.Drawing.Size(300, 90);
            this.textHW.Name = "textHW";
            this.textHW.Size = new System.Drawing.Size(430, 90);
            this.textHW.TabIndex = 0;
            this.textHW.Text = "Witaj Swiecie!";
            this.textHW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textHW.Click += new System.EventHandler(this.textHW_Click);
            // 
            // buttonEng
            // 
            this.buttonEng.Location = new System.Drawing.Point(12, 398);
            this.buttonEng.Name = "buttonEng";
            this.buttonEng.Size = new System.Drawing.Size(200, 40);
            this.buttonEng.TabIndex = 1;
            this.buttonEng.Text = "Angielski";
            this.buttonEng.UseVisualStyleBackColor = true;
            this.buttonEng.Click += new System.EventHandler(this.buttonEng_Click);
            // 
            // buttonNiem
            // 
            this.buttonNiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNiem.Location = new System.Drawing.Point(307, 398);
            this.buttonNiem.Name = "buttonNiem";
            this.buttonNiem.Size = new System.Drawing.Size(200, 40);
            this.buttonNiem.TabIndex = 2;
            this.buttonNiem.Text = "Niemiecki";
            this.buttonNiem.UseVisualStyleBackColor = true;
            this.buttonNiem.Click += new System.EventHandler(this.buttonNiem_Click);
            // 
            // buttonHis
            // 
            this.buttonHis.Location = new System.Drawing.Point(588, 398);
            this.buttonHis.Name = "buttonHis";
            this.buttonHis.Size = new System.Drawing.Size(200, 40);
            this.buttonHis.TabIndex = 3;
            this.buttonHis.Text = "Hiszpanski";
            this.buttonHis.UseVisualStyleBackColor = true;
            this.buttonHis.Click += new System.EventHandler(this.buttonHis_Click);
            // 
            // buttonPL
            // 
            this.buttonPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPL.Location = new System.Drawing.Point(307, 315);
            this.buttonPL.Name = "buttonPL";
            this.buttonPL.Size = new System.Drawing.Size(200, 40);
            this.buttonPL.TabIndex = 4;
            this.buttonPL.Text = "Polski";
            this.buttonPL.UseVisualStyleBackColor = true;
            this.buttonPL.Click += new System.EventHandler(this.buttonPL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPL);
            this.Controls.Add(this.buttonHis);
            this.Controls.Add(this.buttonNiem);
            this.Controls.Add(this.buttonEng);
            this.Controls.Add(this.textHW);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEng;
        private System.Windows.Forms.Button buttonNiem;
        private System.Windows.Forms.Button buttonHis;
        private System.Windows.Forms.Label textHW;
        private System.Windows.Forms.Button buttonPL;
    }
}

