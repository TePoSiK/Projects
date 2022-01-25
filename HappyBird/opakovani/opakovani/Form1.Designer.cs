namespace opakovani
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.pbDolniHlava = new System.Windows.Forms.PictureBox();
            this.pbDolniTrubka = new System.Windows.Forms.PictureBox();
            this.pbHorniHlava = new System.Windows.Forms.PictureBox();
            this.pbHorniTrubka = new System.Windows.Forms.PictureBox();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.zrychleni = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDolniHlava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDolniTrubka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorniHlava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorniTrubka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pauseBtn);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.pbDolniHlava);
            this.panel1.Controls.Add(this.pbDolniTrubka);
            this.panel1.Controls.Add(this.pbHorniHlava);
            this.panel1.Controls.Add(this.pbHorniTrubka);
            this.panel1.Controls.Add(this.pbBird);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 565);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pauseBtn.Location = new System.Drawing.Point(3, 3);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(40, 40);
            this.pauseBtn.TabIndex = 5;
            this.pauseBtn.Text = "|  |";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Visible = false;
            this.pauseBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.startBtn.Location = new System.Drawing.Point(96, 288);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(133, 54);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click_1);
            // 
            // pbDolniHlava
            // 
            this.pbDolniHlava.BackColor = System.Drawing.Color.Green;
            this.pbDolniHlava.Location = new System.Drawing.Point(225, 400);
            this.pbDolniHlava.Name = "pbDolniHlava";
            this.pbDolniHlava.Size = new System.Drawing.Size(50, 15);
            this.pbDolniHlava.TabIndex = 4;
            this.pbDolniHlava.TabStop = false;
            this.pbDolniHlava.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pbDolniHlava.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pbDolniTrubka
            // 
            this.pbDolniTrubka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbDolniTrubka.Location = new System.Drawing.Point(230, 415);
            this.pbDolniTrubka.Name = "pbDolniTrubka";
            this.pbDolniTrubka.Size = new System.Drawing.Size(40, 400);
            this.pbDolniTrubka.TabIndex = 3;
            this.pbDolniTrubka.TabStop = false;
            this.pbDolniTrubka.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pbDolniTrubka.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pbHorniHlava
            // 
            this.pbHorniHlava.BackColor = System.Drawing.Color.Green;
            this.pbHorniHlava.Location = new System.Drawing.Point(225, 150);
            this.pbHorniHlava.Name = "pbHorniHlava";
            this.pbHorniHlava.Size = new System.Drawing.Size(50, 15);
            this.pbHorniHlava.TabIndex = 2;
            this.pbHorniHlava.TabStop = false;
            this.pbHorniHlava.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pbHorniHlava.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pbHorniTrubka
            // 
            this.pbHorniTrubka.BackColor = System.Drawing.Color.LimeGreen;
            this.pbHorniTrubka.Location = new System.Drawing.Point(230, -250);
            this.pbHorniTrubka.Name = "pbHorniTrubka";
            this.pbHorniTrubka.Size = new System.Drawing.Size(40, 400);
            this.pbHorniTrubka.TabIndex = 1;
            this.pbHorniTrubka.TabStop = false;
            this.pbHorniTrubka.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pbHorniTrubka.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pbBird
            // 
            this.pbBird.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pbBird.Image = global::opakovani.Properties.Resources.main2;
            this.pbBird.Location = new System.Drawing.Point(28, 257);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(40, 40);
            this.pbBird.TabIndex = 0;
            this.pbBird.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(226, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score: 0";
            // 
            // zrychleni
            // 
            this.zrychleni.Interval = 10000;
            this.zrychleni.Tick += new System.EventHandler(this.zrychleni_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Rekordy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Výsledky";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.Location = new System.Drawing.Point(96, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 54);
            this.button3.TabIndex = 1;
            this.button3.Text = "Restart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 617);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDolniHlava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDolniTrubka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorniHlava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorniTrubka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.PictureBox pbHorniHlava;
        private System.Windows.Forms.PictureBox pbHorniTrubka;
        private System.Windows.Forms.PictureBox pbDolniHlava;
        private System.Windows.Forms.PictureBox pbDolniTrubka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Timer zrychleni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

