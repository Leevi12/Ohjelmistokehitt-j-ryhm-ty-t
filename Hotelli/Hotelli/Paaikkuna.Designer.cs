
namespace Hotelli
{
    partial class Paaikkuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paaikkuna));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ikkunaYksi = new System.Windows.Forms.ToolStripMenuItem();
            this.ikkunaKaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.ikkunaKolme = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ikkunaYksi,
            this.ikkunaKaksi,
            this.ikkunaKolme});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ikkunaYksi
            // 
            this.ikkunaYksi.Name = "ikkunaYksi";
            this.ikkunaYksi.Size = new System.Drawing.Size(92, 32);
            this.ikkunaYksi.Text = "ikkuna1";
            this.ikkunaYksi.Click += new System.EventHandler(this.ikkunaYksi_Click);
            // 
            // ikkunaKaksi
            // 
            this.ikkunaKaksi.Name = "ikkunaKaksi";
            this.ikkunaKaksi.Size = new System.Drawing.Size(92, 32);
            this.ikkunaKaksi.Text = "ikkuna2";
            this.ikkunaKaksi.Click += new System.EventHandler(this.ikkunaKaksi_Click);
            // 
            // ikkunaKolme
            // 
            this.ikkunaKolme.Name = "ikkunaKolme";
            this.ikkunaKolme.Size = new System.Drawing.Size(189, 32);
            this.ikkunaKolme.Text = "Huoneiden hallinta";
            this.ikkunaKolme.Click += new System.EventHandler(this.ikkunaKolme_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotelli.Properties.Resources.hotel;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tervetuloa hotelliimme";
            // 
            // Paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paaikkuna";
            this.Text = "Pääikkuna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ikkunaYksi;
        private System.Windows.Forms.ToolStripMenuItem ikkunaKaksi;
        private System.Windows.Forms.ToolStripMenuItem ikkunaKolme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}