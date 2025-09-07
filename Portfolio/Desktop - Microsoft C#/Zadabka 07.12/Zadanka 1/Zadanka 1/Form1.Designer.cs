namespace Zadanka_1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Liczba1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liczba2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liczba3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liczba4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liczba5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Liczba1,
            this.Liczba2,
            this.Liczba3,
            this.Liczba4,
            this.Liczba5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 46);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Liczba1
            // 
            this.Liczba1.HeaderText = "Liczba1";
            this.Liczba1.Name = "Liczba1";
            // 
            // Liczba2
            // 
            this.Liczba2.HeaderText = "Liczba2";
            this.Liczba2.Name = "Liczba2";
            // 
            // Liczba3
            // 
            this.Liczba3.HeaderText = "Liczba3";
            this.Liczba3.Name = "Liczba3";
            // 
            // Liczba4
            // 
            this.Liczba4.HeaderText = "Liczba4";
            this.Liczba4.Name = "Liczba4";
            // 
            // Liczba5
            // 
            this.Liczba5.HeaderText = "Liczba5";
            this.Liczba5.Name = "Liczba5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liczba1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liczba2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liczba3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liczba4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liczba5;
        private System.Windows.Forms.Label label1;
    }
}

