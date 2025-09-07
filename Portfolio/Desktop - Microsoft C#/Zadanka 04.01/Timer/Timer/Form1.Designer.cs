namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.setAlarm = new System.Windows.Forms.Button();
            this.godziny = new System.Windows.Forms.NumericUpDown();
            this.minuty = new System.Windows.Forms.NumericUpDown();
            this.sekundy = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hourPic1 = new System.Windows.Forms.PictureBox();
            this.hourPic2 = new System.Windows.Forms.PictureBox();
            this.minutePic1 = new System.Windows.Forms.PictureBox();
            this.minutePic2 = new System.Windows.Forms.PictureBox();
            this.secondPic2 = new System.Windows.Forms.PictureBox();
            this.secondPic1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.godziny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekundy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutePic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutePic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPic1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(104, 182);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(185, 182);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(107, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "XX:XX:XX";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.secondPic1);
            this.groupBox1.Controls.Add(this.secondPic2);
            this.groupBox1.Controls.Add(this.minutePic2);
            this.groupBox1.Controls.Add(this.minutePic1);
            this.groupBox1.Controls.Add(this.hourPic2);
            this.groupBox1.Controls.Add(this.hourPic1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sekundy);
            this.groupBox1.Controls.Add(this.minuty);
            this.groupBox1.Controls.Add(this.godziny);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.setAlarm);
            this.groupBox1.Controls.Add(this.Timer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stop);
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Timer.ForeColor = System.Drawing.Color.OrangeRed;
            this.Timer.Location = new System.Drawing.Point(89, 12);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(181, 33);
            this.Timer.TabIndex = 3;
            this.Timer.Text = "Czasomierz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(490, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ustaw Budzik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(514, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "XX:XX:XX";
            // 
            // setAlarm
            // 
            this.setAlarm.Location = new System.Drawing.Point(553, 182);
            this.setAlarm.Name = "setAlarm";
            this.setAlarm.Size = new System.Drawing.Size(75, 23);
            this.setAlarm.TabIndex = 5;
            this.setAlarm.Text = "Set Budzik";
            this.setAlarm.UseVisualStyleBackColor = true;
            this.setAlarm.Click += new System.EventHandler(this.setAlarm_Click);
            // 
            // godziny
            // 
            this.godziny.Location = new System.Drawing.Point(553, 85);
            this.godziny.Name = "godziny";
            this.godziny.Size = new System.Drawing.Size(120, 20);
            this.godziny.TabIndex = 8;
            // 
            // minuty
            // 
            this.minuty.Location = new System.Drawing.Point(553, 111);
            this.minuty.Name = "minuty";
            this.minuty.Size = new System.Drawing.Size(120, 20);
            this.minuty.TabIndex = 9;
            // 
            // sekundy
            // 
            this.sekundy.Location = new System.Drawing.Point(553, 137);
            this.sekundy.Name = "sekundy";
            this.sekundy.Size = new System.Drawing.Size(120, 20);
            this.sekundy.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sekundy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Minuty:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Godziny:";
            // 
            // hourPic1
            // 
            this.hourPic1.Location = new System.Drawing.Point(64, 81);
            this.hourPic1.Name = "hourPic1";
            this.hourPic1.Size = new System.Drawing.Size(24, 36);
            this.hourPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hourPic1.TabIndex = 14;
            this.hourPic1.TabStop = false;
            // 
            // hourPic2
            // 
            this.hourPic2.Location = new System.Drawing.Point(94, 81);
            this.hourPic2.Name = "hourPic2";
            this.hourPic2.Size = new System.Drawing.Size(24, 36);
            this.hourPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hourPic2.TabIndex = 15;
            this.hourPic2.TabStop = false;
            // 
            // minutePic1
            // 
            this.minutePic1.Location = new System.Drawing.Point(154, 81);
            this.minutePic1.Name = "minutePic1";
            this.minutePic1.Size = new System.Drawing.Size(24, 36);
            this.minutePic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minutePic1.TabIndex = 16;
            this.minutePic1.TabStop = false;
            // 
            // minutePic2
            // 
            this.minutePic2.Location = new System.Drawing.Point(184, 81);
            this.minutePic2.Name = "minutePic2";
            this.minutePic2.Size = new System.Drawing.Size(24, 36);
            this.minutePic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minutePic2.TabIndex = 17;
            this.minutePic2.TabStop = false;
            // 
            // secondPic2
            // 
            this.secondPic2.Location = new System.Drawing.Point(274, 81);
            this.secondPic2.Name = "secondPic2";
            this.secondPic2.Size = new System.Drawing.Size(24, 36);
            this.secondPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondPic2.TabIndex = 18;
            this.secondPic2.TabStop = false;
            // 
            // secondPic1
            // 
            this.secondPic1.Location = new System.Drawing.Point(244, 81);
            this.secondPic1.Name = "secondPic1";
            this.secondPic1.Size = new System.Drawing.Size(24, 36);
            this.secondPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondPic1.TabIndex = 19;
            this.secondPic1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(124, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 33);
            this.label7.TabIndex = 20;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(214, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 33);
            this.label8.TabIndex = 21;
            this.label8.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.godziny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekundy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutePic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutePic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button setAlarm;
        private System.Windows.Forms.NumericUpDown sekundy;
        private System.Windows.Forms.NumericUpDown minuty;
        private System.Windows.Forms.NumericUpDown godziny;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox secondPic1;
        private System.Windows.Forms.PictureBox secondPic2;
        private System.Windows.Forms.PictureBox minutePic2;
        private System.Windows.Forms.PictureBox minutePic1;
        private System.Windows.Forms.PictureBox hourPic2;
        private System.Windows.Forms.PictureBox hourPic1;
        private System.Windows.Forms.Label label8;
    }
}

