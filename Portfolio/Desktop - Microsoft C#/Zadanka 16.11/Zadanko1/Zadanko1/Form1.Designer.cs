namespace Zadanko1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UnBlock = new System.Windows.Forms.Button();
            this.ReWrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imie1 = new System.Windows.Forms.TextBox();
            this.nazwisko1 = new System.Windows.Forms.TextBox();
            this.miasto1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imie2 = new System.Windows.Forms.TextBox();
            this.nazwisko2 = new System.Windows.Forms.TextBox();
            this.miasto2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dysk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.miasto1);
            this.groupBox1.Controls.Add(this.nazwisko1);
            this.groupBox1.Controls.Add(this.imie1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // UnBlock
            // 
            this.UnBlock.Location = new System.Drawing.Point(309, 415);
            this.UnBlock.Name = "UnBlock";
            this.UnBlock.Size = new System.Drawing.Size(75, 23);
            this.UnBlock.TabIndex = 2;
            this.UnBlock.Text = "UnBlock";
            this.UnBlock.UseVisualStyleBackColor = true;
            this.UnBlock.Click += new System.EventHandler(this.UnBlock_Click);
            // 
            // ReWrite
            // 
            this.ReWrite.Location = new System.Drawing.Point(416, 415);
            this.ReWrite.Name = "ReWrite";
            this.ReWrite.Size = new System.Drawing.Size(75, 23);
            this.ReWrite.TabIndex = 3;
            this.ReWrite.Text = "ReWrite";
            this.ReWrite.UseVisualStyleBackColor = true;
            this.ReWrite.Click += new System.EventHandler(this.ReWrite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miasto: ";
            // 
            // imie1
            // 
            this.imie1.Location = new System.Drawing.Point(56, 41);
            this.imie1.Name = "imie1";
            this.imie1.Size = new System.Drawing.Size(100, 20);
            this.imie1.TabIndex = 3;
            this.imie1.TextChanged += new System.EventHandler(this.imie1_TextChanged);
            // 
            // nazwisko1
            // 
            this.nazwisko1.Location = new System.Drawing.Point(86, 72);
            this.nazwisko1.Name = "nazwisko1";
            this.nazwisko1.Size = new System.Drawing.Size(100, 20);
            this.nazwisko1.TabIndex = 4;
            this.nazwisko1.TextChanged += new System.EventHandler(this.nazwisko1_TextChanged);
            // 
            // miasto1
            // 
            this.miasto1.Location = new System.Drawing.Point(71, 103);
            this.miasto1.Name = "miasto1";
            this.miasto1.Size = new System.Drawing.Size(100, 20);
            this.miasto1.TabIndex = 5;
            this.miasto1.TextChanged += new System.EventHandler(this.miasto1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Imie: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nazwisko: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Miasto: ";
            // 
            // imie2
            // 
            this.imie2.Location = new System.Drawing.Point(60, 41);
            this.imie2.Name = "imie2";
            this.imie2.Size = new System.Drawing.Size(100, 20);
            this.imie2.TabIndex = 9;
            // 
            // nazwisko2
            // 
            this.nazwisko2.Location = new System.Drawing.Point(87, 72);
            this.nazwisko2.Name = "nazwisko2";
            this.nazwisko2.Size = new System.Drawing.Size(100, 20);
            this.nazwisko2.TabIndex = 10;
            // 
            // miasto2
            // 
            this.miasto2.Location = new System.Drawing.Point(72, 103);
            this.miasto2.Name = "miasto2";
            this.miasto2.Size = new System.Drawing.Size(100, 20);
            this.miasto2.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.miasto2);
            this.groupBox2.Controls.Add(this.nazwisko2);
            this.groupBox2.Controls.Add(this.imie2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(416, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "UnBlock Disk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dysk
            // 
            this.dysk.Enabled = false;
            this.dysk.Location = new System.Drawing.Point(352, 283);
            this.dysk.Name = "dysk";
            this.dysk.Size = new System.Drawing.Size(312, 20);
            this.dysk.TabIndex = 5;
            this.dysk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dysk_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dysk: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dysk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReWrite);
            this.Controls.Add(this.UnBlock);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox miasto1;
        private System.Windows.Forms.TextBox nazwisko1;
        private System.Windows.Forms.TextBox imie1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UnBlock;
        private System.Windows.Forms.Button ReWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imie2;
        private System.Windows.Forms.TextBox nazwisko2;
        private System.Windows.Forms.TextBox miasto2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dysk;
        private System.Windows.Forms.Label label7;
    }
}

