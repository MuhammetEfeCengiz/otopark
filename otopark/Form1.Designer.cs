
namespace otopark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.txt_kulladı = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(346, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 36);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_kulladı
            // 
            this.txt_kulladı.BackColor = System.Drawing.Color.Gray;
            this.txt_kulladı.ForeColor = System.Drawing.Color.Silver;
            this.txt_kulladı.Location = new System.Drawing.Point(48, 222);
            this.txt_kulladı.Name = "txt_kulladı";
            this.txt_kulladı.Size = new System.Drawing.Size(272, 20);
            this.txt_kulladı.TabIndex = 1;
            this.txt_kulladı.Text = "Kullanıcıadı";
            // 
            // txt_sifre
            // 
            this.txt_sifre.BackColor = System.Drawing.Color.Gray;
            this.txt_sifre.ForeColor = System.Drawing.Color.Silver;
            this.txt_sifre.Location = new System.Drawing.Point(55, 344);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(265, 20);
            this.txt_sifre.TabIndex = 2;
            this.txt_sifre.Text = "Şifre";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button2.Location = new System.Drawing.Point(273, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Giriş";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 492);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kulladı);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_kulladı;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button button2;
    }
}

