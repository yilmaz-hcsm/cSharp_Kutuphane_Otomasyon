
namespace KutuphaneApp
{
    partial class KullaniciEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciEkran));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGrindPanel = new System.Windows.Forms.Panel();
            this.ListeleDataGrind = new System.Windows.Forms.DataGridView();
            this.KullaniciEkranGeriButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KitapIadeButton = new System.Windows.Forms.Button();
            this.KitapAlButton = new System.Windows.Forms.Button();
            this.KitapListeleButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.DataGrindPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeleDataGrind)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::KutuphaneApp.Properties.Resources.arkaplan;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.DataGrindPanel);
            this.panel1.Controls.Add(this.KullaniciEkranGeriButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.KitapIadeButton);
            this.panel1.Controls.Add(this.KitapAlButton);
            this.panel1.Controls.Add(this.KitapListeleButton);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 665);
            this.panel1.TabIndex = 0;
            // 
            // DataGrindPanel
            // 
            this.DataGrindPanel.BackColor = System.Drawing.Color.Transparent;
            this.DataGrindPanel.Controls.Add(this.ListeleDataGrind);
            this.DataGrindPanel.Location = new System.Drawing.Point(3, 283);
            this.DataGrindPanel.Name = "DataGrindPanel";
            this.DataGrindPanel.Size = new System.Drawing.Size(817, 379);
            this.DataGrindPanel.TabIndex = 21;
            // 
            // ListeleDataGrind
            // 
            this.ListeleDataGrind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeleDataGrind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeleDataGrind.Location = new System.Drawing.Point(0, 0);
            this.ListeleDataGrind.Name = "ListeleDataGrind";
            this.ListeleDataGrind.Size = new System.Drawing.Size(817, 379);
            this.ListeleDataGrind.TabIndex = 0;
            // 
            // KullaniciEkranGeriButton
            // 
            this.KullaniciEkranGeriButton.BackgroundImage = global::KutuphaneApp.Properties.Resources.geri;
            this.KullaniciEkranGeriButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.KullaniciEkranGeriButton.Location = new System.Drawing.Point(0, 0);
            this.KullaniciEkranGeriButton.Name = "KullaniciEkranGeriButton";
            this.KullaniciEkranGeriButton.Size = new System.Drawing.Size(65, 56);
            this.KullaniciEkranGeriButton.TabIndex = 20;
            this.KullaniciEkranGeriButton.UseVisualStyleBackColor = true;
            this.KullaniciEkranGeriButton.Click += new System.EventHandler(this.KullaniciEkranGeriButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(630, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kitapları İade Et";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(490, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kitap Al";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(271, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kitaplarımı Listele";
            // 
            // KitapIadeButton
            // 
            this.KitapIadeButton.BackgroundImage = global::KutuphaneApp.Properties.Resources.KitapVerme;
            this.KitapIadeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KitapIadeButton.Location = new System.Drawing.Point(622, 21);
            this.KitapIadeButton.Name = "KitapIadeButton";
            this.KitapIadeButton.Size = new System.Drawing.Size(146, 126);
            this.KitapIadeButton.TabIndex = 2;
            this.KitapIadeButton.UseVisualStyleBackColor = true;
            this.KitapIadeButton.Click += new System.EventHandler(this.KitapIadeButton_Click);
            // 
            // KitapAlButton
            // 
            this.KitapAlButton.BackgroundImage = global::KutuphaneApp.Properties.Resources.KitapAl;
            this.KitapAlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KitapAlButton.Location = new System.Drawing.Point(452, 21);
            this.KitapAlButton.Name = "KitapAlButton";
            this.KitapAlButton.Size = new System.Drawing.Size(146, 126);
            this.KitapAlButton.TabIndex = 1;
            this.KitapAlButton.UseVisualStyleBackColor = true;
            this.KitapAlButton.Click += new System.EventHandler(this.KitapAlButton_Click);
            // 
            // KitapListeleButton
            // 
            this.KitapListeleButton.BackColor = System.Drawing.Color.Transparent;
            this.KitapListeleButton.BackgroundImage = global::KutuphaneApp.Properties.Resources.KitapListele;
            this.KitapListeleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KitapListeleButton.Location = new System.Drawing.Point(258, 21);
            this.KitapListeleButton.Name = "KitapListeleButton";
            this.KitapListeleButton.Size = new System.Drawing.Size(148, 126);
            this.KitapListeleButton.TabIndex = 0;
            this.KitapListeleButton.UseVisualStyleBackColor = false;
            this.KitapListeleButton.Click += new System.EventHandler(this.KitapListeleButton_Click);
            // 
            // KullaniciEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 668);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciEkran";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane/Kullanıcı Ekranı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DataGrindPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeleDataGrind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button KitapListeleButton;
        private System.Windows.Forms.Button KitapAlButton;
        private System.Windows.Forms.Button KitapIadeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel DataGrindPanel;
        private System.Windows.Forms.DataGridView ListeleDataGrind;
        private System.Windows.Forms.Button KullaniciEkranGeriButton;
    }
}