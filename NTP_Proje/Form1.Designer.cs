
namespace NTP_Proje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OyunTimer = new System.Windows.Forms.Timer(this.components);
            this.puanText = new System.Windows.Forms.Label();
            this.kusAnimasyon = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kus = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kus)).BeginInit();
            this.SuspendLayout();
            // 
            // OyunTimer
            // 
            this.OyunTimer.Interval = 70;
            this.OyunTimer.Tick += new System.EventHandler(this.OyunTick);
            // 
            // puanText
            // 
            this.puanText.AutoSize = true;
            this.puanText.BackColor = System.Drawing.Color.Transparent;
            this.puanText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.puanText.ForeColor = System.Drawing.Color.Blue;
            this.puanText.Location = new System.Drawing.Point(354, 429);
            this.puanText.Name = "puanText";
            this.puanText.Size = new System.Drawing.Size(102, 29);
            this.puanText.TabIndex = 6;
            this.puanText.Text = "Score: 0";
            this.puanText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kusAnimasyon
            // 
            this.kusAnimasyon.Interval = 30;
            this.kusAnimasyon.Tick += new System.EventHandler(this.kusAnimasyon_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bitti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(367, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tekrar Oynamak İçin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NTP_Proje.Properties.Resources.buton;
            this.pictureBox1.Location = new System.Drawing.Point(309, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // kus
            // 
            this.kus.Image = global::NTP_Proje.Properties.Resources._1;
            this.kus.Location = new System.Drawing.Point(39, 158);
            this.kus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kus.Name = "kus";
            this.kus.Size = new System.Drawing.Size(40, 48);
            this.kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kus.TabIndex = 0;
            this.kus.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(413, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Başla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(390, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tuşuna Basınız";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(801, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.puanText);
            this.Controls.Add(this.kus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusBasildi);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TusBirakildi);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kus;
        private System.Windows.Forms.Timer OyunTimer;
        private System.Windows.Forms.Label puanText;
        private System.Windows.Forms.Timer kusAnimasyon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

