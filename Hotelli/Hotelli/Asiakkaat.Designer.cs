
namespace Hotelli
{
    partial class Asiakkaat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asiakkaat));
            this.AsiakkaatDG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EtunimiTB = new System.Windows.Forms.TextBox();
            this.SukunimiTB = new System.Windows.Forms.TextBox();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.OsoiteTB = new System.Windows.Forms.TextBox();
            this.PnumTB = new System.Windows.Forms.TextBox();
            this.PtPaikkaTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.TyhjAsBT = new System.Windows.Forms.Button();
            this.TallAsBT = new System.Windows.Forms.Button();
            this.MuokAsBT = new System.Windows.Forms.Button();
            this.PoisAsBT = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.AsiakasIDTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AsiakkaatDG)).BeginInit();
            this.SuspendLayout();
            // 
            // AsiakkaatDG
            // 
            this.AsiakkaatDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsiakkaatDG.Location = new System.Drawing.Point(16, 260);
            this.AsiakkaatDG.Name = "AsiakkaatDG";
            this.AsiakkaatDG.RowHeadersWidth = 62;
            this.AsiakkaatDG.RowTemplate.Height = 28;
            this.AsiakkaatDG.Size = new System.Drawing.Size(1019, 244);
            this.AsiakkaatDG.TabIndex = 0;
            this.AsiakkaatDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AsiakkaatDG_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etunimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InfoText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sukunimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(711, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Käyttäjänimi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(354, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Postitoimipaikka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(354, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Postinumero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(354, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lähiosoite:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Desktop;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(711, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Salasana:";
            // 
            // EtunimiTB
            // 
            this.EtunimiTB.Location = new System.Drawing.Point(140, 73);
            this.EtunimiTB.Name = "EtunimiTB";
            this.EtunimiTB.Size = new System.Drawing.Size(208, 26);
            this.EtunimiTB.TabIndex = 8;
            // 
            // SukunimiTB
            // 
            this.SukunimiTB.Location = new System.Drawing.Point(140, 123);
            this.SukunimiTB.Name = "SukunimiTB";
            this.SukunimiTB.Size = new System.Drawing.Size(208, 26);
            this.SukunimiTB.TabIndex = 9;
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(854, 20);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(151, 26);
            this.KayttajaTB.TabIndex = 10;
            // 
            // OsoiteTB
            // 
            this.OsoiteTB.Location = new System.Drawing.Point(535, 17);
            this.OsoiteTB.Name = "OsoiteTB";
            this.OsoiteTB.Size = new System.Drawing.Size(170, 26);
            this.OsoiteTB.TabIndex = 11;
            // 
            // PnumTB
            // 
            this.PnumTB.Location = new System.Drawing.Point(535, 68);
            this.PnumTB.Name = "PnumTB";
            this.PnumTB.Size = new System.Drawing.Size(170, 26);
            this.PnumTB.TabIndex = 12;
            // 
            // PtPaikkaTB
            // 
            this.PtPaikkaTB.Location = new System.Drawing.Point(535, 123);
            this.PtPaikkaTB.Name = "PtPaikkaTB";
            this.PtPaikkaTB.Size = new System.Drawing.Size(170, 26);
            this.PtPaikkaTB.TabIndex = 13;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(854, 74);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(151, 26);
            this.SalasanaTB.TabIndex = 14;
            // 
            // TyhjAsBT
            // 
            this.TyhjAsBT.BackColor = System.Drawing.SystemColors.Desktop;
            this.TyhjAsBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TyhjAsBT.FlatAppearance.BorderSize = 10;
            this.TyhjAsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TyhjAsBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TyhjAsBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TyhjAsBT.Location = new System.Drawing.Point(627, 166);
            this.TyhjAsBT.Name = "TyhjAsBT";
            this.TyhjAsBT.Size = new System.Drawing.Size(155, 73);
            this.TyhjAsBT.TabIndex = 15;
            this.TyhjAsBT.Text = "Tyhjennä";
            this.TyhjAsBT.UseVisualStyleBackColor = false;
            this.TyhjAsBT.Click += new System.EventHandler(this.TyhjAsBT_Click);
            // 
            // TallAsBT
            // 
            this.TallAsBT.BackColor = System.Drawing.SystemColors.Desktop;
            this.TallAsBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TallAsBT.FlatAppearance.BorderSize = 10;
            this.TallAsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TallAsBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TallAsBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TallAsBT.Location = new System.Drawing.Point(43, 166);
            this.TallAsBT.Name = "TallAsBT";
            this.TallAsBT.Size = new System.Drawing.Size(145, 73);
            this.TallAsBT.TabIndex = 16;
            this.TallAsBT.Text = "Tallenna";
            this.TallAsBT.UseVisualStyleBackColor = false;
            this.TallAsBT.Click += new System.EventHandler(this.TallAsBT_Click);
            // 
            // MuokAsBT
            // 
            this.MuokAsBT.BackColor = System.Drawing.SystemColors.Desktop;
            this.MuokAsBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MuokAsBT.FlatAppearance.BorderSize = 10;
            this.MuokAsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuokAsBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MuokAsBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MuokAsBT.Location = new System.Drawing.Point(233, 167);
            this.MuokAsBT.Name = "MuokAsBT";
            this.MuokAsBT.Size = new System.Drawing.Size(151, 72);
            this.MuokAsBT.TabIndex = 17;
            this.MuokAsBT.Text = "Muokkaa";
            this.MuokAsBT.UseVisualStyleBackColor = false;
            this.MuokAsBT.Click += new System.EventHandler(this.MuokAsBT_Click);
            // 
            // PoisAsBT
            // 
            this.PoisAsBT.BackColor = System.Drawing.SystemColors.Desktop;
            this.PoisAsBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PoisAsBT.FlatAppearance.BorderSize = 10;
            this.PoisAsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PoisAsBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PoisAsBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PoisAsBT.Location = new System.Drawing.Point(433, 167);
            this.PoisAsBT.Name = "PoisAsBT";
            this.PoisAsBT.Size = new System.Drawing.Size(157, 73);
            this.PoisAsBT.TabIndex = 18;
            this.PoisAsBT.Text = "Poista";
            this.PoisAsBT.UseVisualStyleBackColor = false;
            this.PoisAsBT.Click += new System.EventHandler(this.PoisAsBT_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "AsiakasID:";
            // 
            // AsiakasIDTB
            // 
            this.AsiakasIDTB.BackColor = System.Drawing.SystemColors.Info;
            this.AsiakasIDTB.Location = new System.Drawing.Point(140, 22);
            this.AsiakasIDTB.Name = "AsiakasIDTB";
            this.AsiakasIDTB.ReadOnly = true;
            this.AsiakasIDTB.Size = new System.Drawing.Size(208, 26);
            this.AsiakasIDTB.TabIndex = 20;
            // 
            // Asiakkaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotelli.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1043, 516);
            this.Controls.Add(this.AsiakasIDTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PoisAsBT);
            this.Controls.Add(this.MuokAsBT);
            this.Controls.Add(this.TallAsBT);
            this.Controls.Add(this.TyhjAsBT);
            this.Controls.Add(this.SalasanaTB);
            this.Controls.Add(this.PtPaikkaTB);
            this.Controls.Add(this.PnumTB);
            this.Controls.Add(this.OsoiteTB);
            this.Controls.Add(this.KayttajaTB);
            this.Controls.Add(this.SukunimiTB);
            this.Controls.Add(this.EtunimiTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AsiakkaatDG);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Asiakkaat";
            this.Text = "Asiakkaat";
            this.Load += new System.EventHandler(this.Asiakkaat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AsiakkaatDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AsiakkaatDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EtunimiTB;
        private System.Windows.Forms.TextBox SukunimiTB;
        private System.Windows.Forms.TextBox KayttajaTB;
        private System.Windows.Forms.TextBox OsoiteTB;
        private System.Windows.Forms.TextBox PnumTB;
        private System.Windows.Forms.TextBox PtPaikkaTB;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.Button TyhjAsBT;
        private System.Windows.Forms.Button TallAsBT;
        private System.Windows.Forms.Button MuokAsBT;
        private System.Windows.Forms.Button PoisAsBT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AsiakasIDTB;
    }
}