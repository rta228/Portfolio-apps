namespace RockPaperScisors
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
            this.rockPB = new System.Windows.Forms.PictureBox();
            this.paperPB = new System.Windows.Forms.PictureBox();
            this.scisorsPB = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.PictureBox();
            this.opponent = new System.Windows.Forms.PictureBox();
            this.outcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wynPla = new System.Windows.Forms.Label();
            this.wynOpp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.computerCoins = new System.Windows.Forms.Label();
            this.playerCoins = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zaklad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zakladComp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.roundCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rockPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scisorsPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponent)).BeginInit();
            this.SuspendLayout();
            // 
            // rockPB
            // 
            this.rockPB.Enabled = false;
            this.rockPB.Image = global::RockPaperScisors.Properties.Resources.rock;
            this.rockPB.Location = new System.Drawing.Point(238, 302);
            this.rockPB.MinimumSize = new System.Drawing.Size(80, 80);
            this.rockPB.Name = "rockPB";
            this.rockPB.Size = new System.Drawing.Size(80, 80);
            this.rockPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rockPB.TabIndex = 0;
            this.rockPB.TabStop = false;
            this.rockPB.Click += new System.EventHandler(this.rock_Click);
            // 
            // paperPB
            // 
            this.paperPB.Enabled = false;
            this.paperPB.Image = global::RockPaperScisors.Properties.Resources.paper;
            this.paperPB.Location = new System.Drawing.Point(355, 302);
            this.paperPB.MinimumSize = new System.Drawing.Size(80, 80);
            this.paperPB.Name = "paperPB";
            this.paperPB.Size = new System.Drawing.Size(80, 80);
            this.paperPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paperPB.TabIndex = 1;
            this.paperPB.TabStop = false;
            this.paperPB.Click += new System.EventHandler(this.paper_Click);
            // 
            // scisorsPB
            // 
            this.scisorsPB.Enabled = false;
            this.scisorsPB.Image = global::RockPaperScisors.Properties.Resources.scisors;
            this.scisorsPB.Location = new System.Drawing.Point(470, 302);
            this.scisorsPB.MinimumSize = new System.Drawing.Size(80, 80);
            this.scisorsPB.Name = "scisorsPB";
            this.scisorsPB.Size = new System.Drawing.Size(80, 80);
            this.scisorsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scisorsPB.TabIndex = 2;
            this.scisorsPB.TabStop = false;
            this.scisorsPB.Click += new System.EventHandler(this.scisors_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.PapayaWhip;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reset.ForeColor = System.Drawing.Color.RoyalBlue;
            this.reset.Location = new System.Drawing.Point(238, 388);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(312, 50);
            this.reset.TabIndex = 3;
            this.reset.Text = "Nowa Gra";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // player
            // 
            this.player.Location = new System.Drawing.Point(169, 131);
            this.player.MinimumSize = new System.Drawing.Size(150, 150);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(150, 150);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // opponent
            // 
            this.opponent.Location = new System.Drawing.Point(479, 131);
            this.opponent.MinimumSize = new System.Drawing.Size(150, 150);
            this.opponent.Name = "opponent";
            this.opponent.Size = new System.Drawing.Size(150, 150);
            this.opponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opponent.TabIndex = 5;
            this.opponent.TabStop = false;
            this.opponent.Click += new System.EventHandler(this.opponent_Click);
            // 
            // outcome
            // 
            this.outcome.AutoSize = true;
            this.outcome.BackColor = System.Drawing.Color.Snow;
            this.outcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outcome.Location = new System.Drawing.Point(325, 66);
            this.outcome.MinimumSize = new System.Drawing.Size(150, 0);
            this.outcome.Name = "outcome";
            this.outcome.Size = new System.Drawing.Size(150, 55);
            this.outcome.TabIndex = 6;
            this.outcome.Text = "Play";
            this.outcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.MinimumSize = new System.Drawing.Size(466, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rock Paper Scisors";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wynPla
            // 
            this.wynPla.AutoSize = true;
            this.wynPla.BackColor = System.Drawing.Color.Snow;
            this.wynPla.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynPla.Location = new System.Drawing.Point(269, 85);
            this.wynPla.MinimumSize = new System.Drawing.Size(50, 0);
            this.wynPla.Name = "wynPla";
            this.wynPla.Size = new System.Drawing.Size(50, 39);
            this.wynPla.TabIndex = 8;
            this.wynPla.Text = "#";
            this.wynPla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wynOpp
            // 
            this.wynOpp.AutoSize = true;
            this.wynOpp.BackColor = System.Drawing.Color.Snow;
            this.wynOpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynOpp.Location = new System.Drawing.Point(481, 85);
            this.wynOpp.MinimumSize = new System.Drawing.Size(50, 0);
            this.wynOpp.Name = "wynOpp";
            this.wynOpp.Size = new System.Drawing.Size(50, 39);
            this.wynOpp.TabIndex = 9;
            this.wynOpp.Text = "#";
            this.wynOpp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.MinimumSize = new System.Drawing.Size(150, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Player";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(612, 44);
            this.label5.MinimumSize = new System.Drawing.Size(150, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Opponent";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerCoins
            // 
            this.computerCoins.AutoSize = true;
            this.computerCoins.BackColor = System.Drawing.Color.Snow;
            this.computerCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computerCoins.Location = new System.Drawing.Point(667, 85);
            this.computerCoins.MinimumSize = new System.Drawing.Size(80, 0);
            this.computerCoins.Name = "computerCoins";
            this.computerCoins.Size = new System.Drawing.Size(80, 39);
            this.computerCoins.TabIndex = 12;
            this.computerCoins.Text = "###";
            this.computerCoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerCoins
            // 
            this.playerCoins.AutoSize = true;
            this.playerCoins.BackColor = System.Drawing.Color.Snow;
            this.playerCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerCoins.Location = new System.Drawing.Point(47, 85);
            this.playerCoins.MinimumSize = new System.Drawing.Size(80, 0);
            this.playerCoins.Name = "playerCoins";
            this.playerCoins.Size = new System.Drawing.Size(80, 39);
            this.playerCoins.TabIndex = 13;
            this.playerCoins.Text = "###";
            this.playerCoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 334);
            this.label2.MinimumSize = new System.Drawing.Size(150, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Zaklad Play";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zaklad
            // 
            this.zaklad.Location = new System.Drawing.Point(12, 362);
            this.zaklad.MaxLength = 1;
            this.zaklad.Name = "zaklad";
            this.zaklad.Size = new System.Drawing.Size(150, 20);
            this.zaklad.TabIndex = 15;
            this.zaklad.TextChanged += new System.EventHandler(this.zaklad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(638, 334);
            this.label3.MinimumSize = new System.Drawing.Size(150, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Zaklad Opp";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zakladComp
            // 
            this.zakladComp.Enabled = false;
            this.zakladComp.Location = new System.Drawing.Point(638, 362);
            this.zakladComp.MaxLength = 1;
            this.zakladComp.Name = "zakladComp";
            this.zakladComp.Size = new System.Drawing.Size(150, 20);
            this.zakladComp.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Snow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(325, 147);
            this.label6.MinimumSize = new System.Drawing.Size(150, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ilosc Rund";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundCount
            // 
            this.roundCount.Location = new System.Drawing.Point(325, 175);
            this.roundCount.MaxLength = 1;
            this.roundCount.Name = "roundCount";
            this.roundCount.Size = new System.Drawing.Size(150, 20);
            this.roundCount.TabIndex = 19;
            this.roundCount.TextChanged += new System.EventHandler(this.roundCount_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zakladComp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zaklad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerCoins);
            this.Controls.Add(this.computerCoins);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wynOpp);
            this.Controls.Add(this.wynPla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outcome);
            this.Controls.Add(this.opponent);
            this.Controls.Add(this.player);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.scisorsPB);
            this.Controls.Add(this.paperPB);
            this.Controls.Add(this.rockPB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rockPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scisorsPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rockPB;
        private System.Windows.Forms.PictureBox paperPB;
        private System.Windows.Forms.PictureBox scisorsPB;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox opponent;
        private System.Windows.Forms.Label outcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wynPla;
        private System.Windows.Forms.Label wynOpp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label computerCoins;
        private System.Windows.Forms.Label playerCoins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox zaklad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zakladComp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox roundCount;
    }
}

