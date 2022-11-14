namespace Genetic
{
    partial class Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CorModelo = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SelecaoCor = new System.Windows.Forms.Button();
            this.BF1 = new System.Windows.Forms.Panel();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.timerSelecao = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BF2 = new System.Windows.Forms.Panel();
            this.BF3 = new System.Windows.Forms.Panel();
            this.BF4 = new System.Windows.Forms.Panel();
            this.BF5 = new System.Windows.Forms.Panel();
            this.WF1 = new System.Windows.Forms.Panel();
            this.WF2 = new System.Windows.Forms.Panel();
            this.WF3 = new System.Windows.Forms.Panel();
            this.WF4 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Aptidao = new System.Windows.Forms.GroupBox();
            this.CMB = new System.Windows.Forms.Label();
            this.CMG = new System.Windows.Forms.Label();
            this.CMR = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CutOff = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelGeracao = new System.Windows.Forms.Label();
            this.BFB = new System.Windows.Forms.Label();
            this.BFG = new System.Windows.Forms.Label();
            this.BFR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Aptidao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // CorModelo
            // 
            this.CorModelo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CorModelo.Location = new System.Drawing.Point(30, 29);
            this.CorModelo.Name = "CorModelo";
            this.CorModelo.Size = new System.Drawing.Size(50, 50);
            this.CorModelo.TabIndex = 2;
            // 
            // SelecaoCor
            // 
            this.SelecaoCor.Location = new System.Drawing.Point(30, 85);
            this.SelecaoCor.Name = "SelecaoCor";
            this.SelecaoCor.Size = new System.Drawing.Size(117, 25);
            this.SelecaoCor.TabIndex = 3;
            this.SelecaoCor.Text = "Selecione a cor";
            this.SelecaoCor.UseVisualStyleBackColor = true;
            this.SelecaoCor.Click += new System.EventHandler(this.SelecaoDeCor);
            // 
            // BF1
            // 
            this.BF1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BF1.Location = new System.Drawing.Point(45, 22);
            this.BF1.Name = "BF1";
            this.BF1.Size = new System.Drawing.Size(50, 50);
            this.BF1.TabIndex = 3;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(6, 19);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(98, 23);
            this.ButtonStart.TabIndex = 4;
            this.ButtonStart.Text = "Próxima geração";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // timerSelecao
            // 
            this.timerSelecao.Interval = 1000;
            this.timerSelecao.Tick += new System.EventHandler(this.timerSelecao_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "População:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(53, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "1024";
            // 
            // BF2
            // 
            this.BF2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BF2.Location = new System.Drawing.Point(42, 19);
            this.BF2.Name = "BF2";
            this.BF2.Size = new System.Drawing.Size(50, 50);
            this.BF2.TabIndex = 4;
            // 
            // BF3
            // 
            this.BF3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BF3.Location = new System.Drawing.Point(119, 19);
            this.BF3.Name = "BF3";
            this.BF3.Size = new System.Drawing.Size(50, 50);
            this.BF3.TabIndex = 5;
            // 
            // BF4
            // 
            this.BF4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BF4.Location = new System.Drawing.Point(42, 75);
            this.BF4.Name = "BF4";
            this.BF4.Size = new System.Drawing.Size(50, 50);
            this.BF4.TabIndex = 5;
            // 
            // BF5
            // 
            this.BF5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BF5.Location = new System.Drawing.Point(119, 75);
            this.BF5.Name = "BF5";
            this.BF5.Size = new System.Drawing.Size(50, 50);
            this.BF5.TabIndex = 5;
            // 
            // WF1
            // 
            this.WF1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.WF1.Location = new System.Drawing.Point(35, 21);
            this.WF1.Name = "WF1";
            this.WF1.Size = new System.Drawing.Size(50, 50);
            this.WF1.TabIndex = 6;
            // 
            // WF2
            // 
            this.WF2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.WF2.Location = new System.Drawing.Point(109, 21);
            this.WF2.Name = "WF2";
            this.WF2.Size = new System.Drawing.Size(50, 50);
            this.WF2.TabIndex = 7;
            // 
            // WF3
            // 
            this.WF3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.WF3.Location = new System.Drawing.Point(35, 77);
            this.WF3.Name = "WF3";
            this.WF3.Size = new System.Drawing.Size(50, 50);
            this.WF3.TabIndex = 8;
            // 
            // WF4
            // 
            this.WF4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.WF4.Location = new System.Drawing.Point(109, 77);
            this.WF4.Name = "WF4";
            this.WF4.Size = new System.Drawing.Size(50, 50);
            this.WF4.TabIndex = 8;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "2°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "3°";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "4°";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "5°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "1°";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "2°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "3°";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "4°";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "1°";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Aptidao
            // 
            this.Aptidao.Controls.Add(this.CMB);
            this.Aptidao.Controls.Add(this.CMG);
            this.Aptidao.Controls.Add(this.CMR);
            this.Aptidao.Controls.Add(this.CorModelo);
            this.Aptidao.Controls.Add(this.SelecaoCor);
            this.Aptidao.Location = new System.Drawing.Point(12, 8);
            this.Aptidao.Name = "Aptidao";
            this.Aptidao.Size = new System.Drawing.Size(200, 128);
            this.Aptidao.TabIndex = 16;
            this.Aptidao.TabStop = false;
            this.Aptidao.Text = "Modelo de Aptidão";
            // 
            // CMB
            // 
            this.CMB.AutoSize = true;
            this.CMB.Location = new System.Drawing.Point(106, 66);
            this.CMB.Name = "CMB";
            this.CMB.Size = new System.Drawing.Size(17, 13);
            this.CMB.TabIndex = 6;
            this.CMB.Text = "B:";
            // 
            // CMG
            // 
            this.CMG.AutoSize = true;
            this.CMG.Location = new System.Drawing.Point(106, 47);
            this.CMG.Name = "CMG";
            this.CMG.Size = new System.Drawing.Size(21, 13);
            this.CMG.TabIndex = 5;
            this.CMG.Text = "G: ";
            // 
            // CMR
            // 
            this.CMR.AutoSize = true;
            this.CMR.Location = new System.Drawing.Point(106, 29);
            this.CMR.Name = "CMR";
            this.CMR.Size = new System.Drawing.Size(21, 13);
            this.CMR.TabIndex = 4;
            this.CMR.Text = "R: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CutOff);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "População";
            // 
            // CutOff
            // 
            this.CutOff.Location = new System.Drawing.Point(126, 55);
            this.CutOff.Name = "CutOff";
            this.CutOff.Size = new System.Drawing.Size(21, 20);
            this.CutOff.TabIndex = 8;
            this.CutOff.Text = "5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Seleção: Cutoff em 1 /";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonStart);
            this.groupBox2.Location = new System.Drawing.Point(12, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BFB);
            this.groupBox3.Controls.Add(this.BFG);
            this.groupBox3.Controls.Add(this.BFR);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.BF1);
            this.groupBox3.Location = new System.Drawing.Point(639, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 79);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Indivíduo de melhor aptidão:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.BF3);
            this.groupBox4.Controls.Add(this.BF5);
            this.groupBox4.Controls.Add(this.BF4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.BF2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(639, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 131);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Indivíduos de melhor aptidão:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.WF1);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.WF2);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.WF3);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.WF4);
            this.groupBox5.Location = new System.Drawing.Point(639, 276);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 140);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Indivíduos de pior aptidão:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(218, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(410, 425);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "População gerada";
            // 
            // labelGeracao
            // 
            this.labelGeracao.AutoSize = true;
            this.labelGeracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeracao.Location = new System.Drawing.Point(634, 23);
            this.labelGeracao.Name = "labelGeracao";
            this.labelGeracao.Size = new System.Drawing.Size(63, 16);
            this.labelGeracao.TabIndex = 10;
            this.labelGeracao.Text = "Geração:";
            // 
            // BFB
            // 
            this.BFB.AutoSize = true;
            this.BFB.Location = new System.Drawing.Point(101, 58);
            this.BFB.Name = "BFB";
            this.BFB.Size = new System.Drawing.Size(17, 13);
            this.BFB.TabIndex = 13;
            this.BFB.Text = "B:";
            // 
            // BFG
            // 
            this.BFG.AutoSize = true;
            this.BFG.Location = new System.Drawing.Point(101, 39);
            this.BFG.Name = "BFG";
            this.BFG.Size = new System.Drawing.Size(21, 13);
            this.BFG.TabIndex = 12;
            this.BFG.Text = "G: ";
            // 
            // BFR
            // 
            this.BFR.AutoSize = true;
            this.BFR.Location = new System.Drawing.Point(101, 21);
            this.BFR.Name = "BFR";
            this.BFR.Size = new System.Drawing.Size(21, 13);
            this.BFR.TabIndex = 11;
            this.BFR.Text = "R: ";
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(846, 439);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Aptidao);
            this.Controls.Add(this.labelGeracao);
            this.Name = "Panel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Aptidao.ResumeLayout(false);
            this.Aptidao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel CorModelo;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button SelecaoCor;
        private System.Windows.Forms.Panel BF1;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Timer timerSelecao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel BF2;
        private System.Windows.Forms.Panel BF3;
        private System.Windows.Forms.Panel BF4;
        private System.Windows.Forms.Panel BF5;
        private System.Windows.Forms.Panel WF1;
        private System.Windows.Forms.Panel WF2;
        private System.Windows.Forms.Panel WF3;
        private System.Windows.Forms.Panel WF4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Aptidao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox CutOff;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label CMB;
        private System.Windows.Forms.Label CMG;
        private System.Windows.Forms.Label CMR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelGeracao;
        private System.Windows.Forms.Label BFB;
        private System.Windows.Forms.Label BFG;
        private System.Windows.Forms.Label BFR;
    }
}

