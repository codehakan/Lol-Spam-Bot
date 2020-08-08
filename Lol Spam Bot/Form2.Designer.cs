namespace Lol_Spam_Bot
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuler = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.kucult = new System.Windows.Forms.Button();
            this.kapat = new System.Windows.Forms.Button();
            this.icerik = new System.Windows.Forms.Panel();
            this.menuler.SuspendLayout();
            this.logo.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuler
            // 
            this.menuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.menuler.Controls.Add(this.button1);
            this.menuler.Controls.Add(this.logo);
            this.menuler.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuler.Location = new System.Drawing.Point(0, 0);
            this.menuler.Name = "menuler";
            this.menuler.Size = new System.Drawing.Size(149, 483);
            this.menuler.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(0, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ana Sayfa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.logo.Controls.Add(this.label2);
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(149, 51);
            this.logo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(19, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lol Hack";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.kucult);
            this.header.Controls.Add(this.kapat);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(149, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(573, 51);
            this.header.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ana Sayfa";
            // 
            // kucult
            // 
            this.kucult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kucult.Location = new System.Drawing.Point(512, 12);
            this.kucult.Name = "kucult";
            this.kucult.Size = new System.Drawing.Size(22, 25);
            this.kucult.TabIndex = 1;
            this.kucult.Text = "-";
            this.kucult.UseVisualStyleBackColor = true;
            this.kucult.Click += new System.EventHandler(this.button3_Click);
            // 
            // kapat
            // 
            this.kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat.Location = new System.Drawing.Point(540, 11);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(22, 25);
            this.kapat.TabIndex = 0;
            this.kapat.Text = "X";
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.button2_Click);
            // 
            // icerik
            // 
            this.icerik.BackColor = System.Drawing.Color.Gainsboro;
            this.icerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icerik.Location = new System.Drawing.Point(149, 51);
            this.icerik.Name = "icerik";
            this.icerik.Size = new System.Drawing.Size(573, 432);
            this.icerik.TabIndex = 2;
            this.icerik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.icerik_MouseDown);
            this.icerik.MouseMove += new System.Windows.Forms.MouseEventHandler(this.icerik_MouseMove);
            this.icerik.MouseUp += new System.Windows.Forms.MouseEventHandler(this.icerik_MouseUp);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 483);
            this.Controls.Add(this.icerik);
            this.Controls.Add(this.header);
            this.Controls.Add(this.menuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoL*VIP Hack";
            this.menuler.ResumeLayout(false);
            this.logo.ResumeLayout(false);
            this.logo.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel icerik;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button kucult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}