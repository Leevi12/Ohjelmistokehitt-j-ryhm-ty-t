
namespace Hotelli
{
    partial class Varaukset
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
            this.VarauksetDG = new System.Windows.Forms.DataGridView();
            this.PoisVrBT = new System.Windows.Forms.Button();
            this.MuokVrBT = new System.Windows.Forms.Button();
            this.TallVrBT = new System.Windows.Forms.Button();
            this.TyhjVrBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VrNumeroTB = new System.Windows.Forms.TextBox();
            this.SisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.UlosDTP = new System.Windows.Forms.DateTimePicker();
            this.HuoneTyyppiCB = new System.Windows.Forms.ComboBox();
            this.AsiakasCB = new System.Windows.Forms.ComboBox();
            this.HuoneNroCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // VarauksetDG
            // 
            this.VarauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VarauksetDG.Location = new System.Drawing.Point(15, 252);
            this.VarauksetDG.Name = "VarauksetDG";
            this.VarauksetDG.RowHeadersWidth = 62;
            this.VarauksetDG.RowTemplate.Height = 28;
            this.VarauksetDG.Size = new System.Drawing.Size(1149, 239);
            this.VarauksetDG.TabIndex = 0;
            // 
            // PoisVrBT
            // 
            this.PoisVrBT.Location = new System.Drawing.Point(447, 177);
            this.PoisVrBT.Name = "PoisVrBT";
            this.PoisVrBT.Size = new System.Drawing.Size(82, 33);
            this.PoisVrBT.TabIndex = 36;
            this.PoisVrBT.Text = "Poista";
            this.PoisVrBT.UseVisualStyleBackColor = true;
            // 
            // MuokVrBT
            // 
            this.MuokVrBT.Location = new System.Drawing.Point(310, 177);
            this.MuokVrBT.Name = "MuokVrBT";
            this.MuokVrBT.Size = new System.Drawing.Size(82, 33);
            this.MuokVrBT.TabIndex = 35;
            this.MuokVrBT.Text = "Muokkaa";
            this.MuokVrBT.UseVisualStyleBackColor = true;
            // 
            // TallVrBT
            // 
            this.TallVrBT.Location = new System.Drawing.Point(171, 177);
            this.TallVrBT.Name = "TallVrBT";
            this.TallVrBT.Size = new System.Drawing.Size(82, 33);
            this.TallVrBT.TabIndex = 34;
            this.TallVrBT.Text = "Tallenna";
            this.TallVrBT.UseVisualStyleBackColor = true;
            // 
            // TyhjVrBT
            // 
            this.TyhjVrBT.Location = new System.Drawing.Point(32, 177);
            this.TyhjVrBT.Name = "TyhjVrBT";
            this.TyhjVrBT.Size = new System.Drawing.Size(82, 33);
            this.TyhjVrBT.TabIndex = 33;
            this.TyhjVrBT.Text = "Tyhjennä";
            this.TyhjVrBT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Huonetyyppi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Varausnumero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ulos (pvm):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sisään (pvm):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Huoneen numero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Asiakas:";
            // 
            // VrNumeroTB
            // 
            this.VrNumeroTB.Location = new System.Drawing.Point(321, 21);
            this.VrNumeroTB.Name = "VrNumeroTB";
            this.VrNumeroTB.Size = new System.Drawing.Size(208, 26);
            this.VrNumeroTB.TabIndex = 27;
            // 
            // SisaanDTP
            // 
            this.SisaanDTP.Location = new System.Drawing.Point(735, 75);
            this.SisaanDTP.Name = "SisaanDTP";
            this.SisaanDTP.Size = new System.Drawing.Size(208, 26);
            this.SisaanDTP.TabIndex = 38;
            // 
            // UlosDTP
            // 
            this.UlosDTP.Location = new System.Drawing.Point(735, 121);
            this.UlosDTP.Name = "UlosDTP";
            this.UlosDTP.Size = new System.Drawing.Size(208, 26);
            this.UlosDTP.TabIndex = 39;
            // 
            // HuoneTyyppiCB
            // 
            this.HuoneTyyppiCB.FormattingEnabled = true;
            this.HuoneTyyppiCB.Location = new System.Drawing.Point(321, 121);
            this.HuoneTyyppiCB.Name = "HuoneTyyppiCB";
            this.HuoneTyyppiCB.Size = new System.Drawing.Size(208, 28);
            this.HuoneTyyppiCB.TabIndex = 40;
            // 
            // AsiakasCB
            // 
            this.AsiakasCB.FormattingEnabled = true;
            this.AsiakasCB.Location = new System.Drawing.Point(321, 66);
            this.AsiakasCB.Name = "AsiakasCB";
            this.AsiakasCB.Size = new System.Drawing.Size(208, 28);
            this.AsiakasCB.TabIndex = 41;
            // 
            // HuoneNroCB
            // 
            this.HuoneNroCB.FormattingEnabled = true;
            this.HuoneNroCB.Location = new System.Drawing.Point(735, 12);
            this.HuoneNroCB.Name = "HuoneNroCB";
            this.HuoneNroCB.Size = new System.Drawing.Size(208, 28);
            this.HuoneNroCB.TabIndex = 42;
            // 
            // Varaukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 521);
            this.Controls.Add(this.HuoneNroCB);
            this.Controls.Add(this.AsiakasCB);
            this.Controls.Add(this.HuoneTyyppiCB);
            this.Controls.Add(this.UlosDTP);
            this.Controls.Add(this.SisaanDTP);
            this.Controls.Add(this.PoisVrBT);
            this.Controls.Add(this.MuokVrBT);
            this.Controls.Add(this.TallVrBT);
            this.Controls.Add(this.TyhjVrBT);
            this.Controls.Add(this.VrNumeroTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VarauksetDG);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "Varaukset";
            this.Text = "Varaukset";
            this.Load += new System.EventHandler(this.Varaukset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VarauksetDG;
        private System.Windows.Forms.Button PoisVrBT;
        private System.Windows.Forms.Button MuokVrBT;
        private System.Windows.Forms.Button TallVrBT;
        private System.Windows.Forms.Button TyhjVrBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VrNumeroTB;
        private System.Windows.Forms.DateTimePicker SisaanDTP;
        private System.Windows.Forms.DateTimePicker UlosDTP;
        private System.Windows.Forms.ComboBox HuoneTyyppiCB;
        private System.Windows.Forms.ComboBox AsiakasCB;
        private System.Windows.Forms.ComboBox HuoneNroCB;
    }
}