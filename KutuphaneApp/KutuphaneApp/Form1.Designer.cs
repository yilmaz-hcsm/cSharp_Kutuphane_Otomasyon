
namespace KutuphaneApp
{
    partial class kutuphane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kutuphane));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.KayitTelTextBox = new System.Windows.Forms.TextBox();
            this.KayitSoyadTextBox = new System.Windows.Forms.TextBox();
            this.KayitAdTextBox = new System.Windows.Forms.TextBox();
            this.BasvuruButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.GirisUserSifreTextBox = new System.Windows.Forms.TextBox();
            this.GirisYapButton = new System.Windows.Forms.Button();
            this.GirisUserTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::KutuphaneApp.Properties.Resources.arkaplan;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 668);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.KayitTelTextBox);
            this.panel3.Controls.Add(this.KayitSoyadTextBox);
            this.panel3.Controls.Add(this.KayitAdTextBox);
            this.panel3.Controls.Add(this.BasvuruButton);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(499, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 284);
            this.panel3.TabIndex = 1;
            // 
            // KayitTelTextBox
            // 
            this.KayitTelTextBox.BackColor = System.Drawing.Color.White;
            this.KayitTelTextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitTelTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KayitTelTextBox.Location = new System.Drawing.Point(22, 176);
            this.KayitTelTextBox.Multiline = true;
            this.KayitTelTextBox.Name = "KayitTelTextBox";
            this.KayitTelTextBox.Size = new System.Drawing.Size(325, 45);
            this.KayitTelTextBox.TabIndex = 8;
            this.KayitTelTextBox.Text = "Telefon Numaranız";
            this.KayitTelTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KayitTelTextBox_MouseClick);
            // 
            // KayitSoyadTextBox
            // 
            this.KayitSoyadTextBox.BackColor = System.Drawing.Color.White;
            this.KayitSoyadTextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitSoyadTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KayitSoyadTextBox.Location = new System.Drawing.Point(22, 125);
            this.KayitSoyadTextBox.Multiline = true;
            this.KayitSoyadTextBox.Name = "KayitSoyadTextBox";
            this.KayitSoyadTextBox.Size = new System.Drawing.Size(325, 45);
            this.KayitSoyadTextBox.TabIndex = 7;
            this.KayitSoyadTextBox.Text = "Soyadınız";
            this.KayitSoyadTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KayitSoyadTextBox_MouseClick);
            // 
            // KayitAdTextBox
            // 
            this.KayitAdTextBox.BackColor = System.Drawing.Color.White;
            this.KayitAdTextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitAdTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KayitAdTextBox.Location = new System.Drawing.Point(22, 74);
            this.KayitAdTextBox.Multiline = true;
            this.KayitAdTextBox.Name = "KayitAdTextBox";
            this.KayitAdTextBox.Size = new System.Drawing.Size(325, 45);
            this.KayitAdTextBox.TabIndex = 6;
            this.KayitAdTextBox.Text = "Adınız";
            this.KayitAdTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KayitAdTextBox_MouseClick);
            // 
            // BasvuruButton
            // 
            this.BasvuruButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BasvuruButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BasvuruButton.ForeColor = System.Drawing.Color.Black;
            this.BasvuruButton.Location = new System.Drawing.Point(22, 227);
            this.BasvuruButton.Name = "BasvuruButton";
            this.BasvuruButton.Size = new System.Drawing.Size(325, 48);
            this.BasvuruButton.TabIndex = 5;
            this.BasvuruButton.Text = "Başvuru Gönder";
            this.BasvuruButton.UseVisualStyleBackColor = false;
            this.BasvuruButton.Click += new System.EventHandler(this.BasvuruButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kayıt Ol";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.GirisUserSifreTextBox);
            this.panel2.Controls.Add(this.GirisYapButton);
            this.panel2.Controls.Add(this.GirisUserTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(49, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 444);
            this.panel2.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(32, 262);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Şifreyi göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GirisUserSifreTextBox
            // 
            this.GirisUserSifreTextBox.BackColor = System.Drawing.Color.White;
            this.GirisUserSifreTextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisUserSifreTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GirisUserSifreTextBox.Location = new System.Drawing.Point(32, 211);
            this.GirisUserSifreTextBox.Multiline = true;
            this.GirisUserSifreTextBox.Name = "GirisUserSifreTextBox";
            this.GirisUserSifreTextBox.PasswordChar = '*';
            this.GirisUserSifreTextBox.Size = new System.Drawing.Size(325, 45);
            this.GirisUserSifreTextBox.TabIndex = 5;
            this.GirisUserSifreTextBox.Text = "Şifre";
            this.GirisUserSifreTextBox.UseSystemPasswordChar = true;
            this.GirisUserSifreTextBox.UseWaitCursor = true;
            this.GirisUserSifreTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GirisUserSifreTextBox_MouseClick);
            this.GirisUserSifreTextBox.TextChanged += new System.EventHandler(this.GirisUserSifreTextBox_TextChanged);
            // 
            // GirisYapButton
            // 
            this.GirisYapButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.GirisYapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisYapButton.ForeColor = System.Drawing.Color.Black;
            this.GirisYapButton.Location = new System.Drawing.Point(32, 300);
            this.GirisYapButton.Name = "GirisYapButton";
            this.GirisYapButton.Size = new System.Drawing.Size(325, 48);
            this.GirisYapButton.TabIndex = 4;
            this.GirisYapButton.Text = "GİRİŞ";
            this.GirisYapButton.UseVisualStyleBackColor = false;
            this.GirisYapButton.Click += new System.EventHandler(this.GirisYapButton_Click);
            // 
            // GirisUserTextBox
            // 
            this.GirisUserTextBox.BackColor = System.Drawing.Color.White;
            this.GirisUserTextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisUserTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GirisUserTextBox.Location = new System.Drawing.Point(32, 138);
            this.GirisUserTextBox.Multiline = true;
            this.GirisUserTextBox.Name = "GirisUserTextBox";
            this.GirisUserTextBox.Size = new System.Drawing.Size(325, 45);
            this.GirisUserTextBox.TabIndex = 1;
            this.GirisUserTextBox.Text = "TC\'Nizi Giriniz";
            this.GirisUserTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GirisUserTextBox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(111, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Yap";
            // 
            // kutuphane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 668);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kutuphane";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyonu";
            this.Load += new System.EventHandler(this.kutuphane_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button GirisYapButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BasvuruButton;
        private System.Windows.Forms.TextBox GirisUserTextBox;
        private System.Windows.Forms.TextBox KayitTelTextBox;
        private System.Windows.Forms.TextBox KayitSoyadTextBox;
        private System.Windows.Forms.TextBox KayitAdTextBox;
        private System.Windows.Forms.TextBox GirisUserSifreTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

