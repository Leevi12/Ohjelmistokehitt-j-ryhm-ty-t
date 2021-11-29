
namespace Hotelli
{
    partial class HuoneidenHallinta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PuhelinTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HuoneTyyppiCB = new System.Windows.Forms.ComboBox();
            this.KyllaRB = new System.Windows.Forms.RadioButton();
            this.EiRB = new System.Windows.Forms.RadioButton();
            this.HuoneetDG = new System.Windows.Forms.DataGridView();
            this.UusiHuoneBT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HuoneetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(186, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huoneiden Hallinta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Huonetyyppi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puhelin:";
            // 
            // PuhelinTB
            // 
            this.PuhelinTB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuhelinTB.Location = new System.Drawing.Point(210, 181);
            this.PuhelinTB.Name = "PuhelinTB";
            this.PuhelinTB.Size = new System.Drawing.Size(151, 32);
            this.PuhelinTB.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vapaa:";
            // 
            // HuoneTyyppiCB
            // 
            this.HuoneTyyppiCB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneTyyppiCB.FormattingEnabled = true;
            this.HuoneTyyppiCB.Items.AddRange(new object[] {
            "1H",
            "2H",
            "2H+K"});
            this.HuoneTyyppiCB.Location = new System.Drawing.Point(210, 134);
            this.HuoneTyyppiCB.Name = "HuoneTyyppiCB";
            this.HuoneTyyppiCB.Size = new System.Drawing.Size(151, 30);
            this.HuoneTyyppiCB.TabIndex = 9;
            // 
            // KyllaRB
            // 
            this.KyllaRB.AutoSize = true;
            this.KyllaRB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KyllaRB.Location = new System.Drawing.Point(210, 239);
            this.KyllaRB.Name = "KyllaRB";
            this.KyllaRB.Size = new System.Drawing.Size(80, 26);
            this.KyllaRB.TabIndex = 10;
            this.KyllaRB.TabStop = true;
            this.KyllaRB.Text = "KYLLÄ";
            this.KyllaRB.UseVisualStyleBackColor = true;
            // 
            // EiRB
            // 
            this.EiRB.AutoSize = true;
            this.EiRB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EiRB.Location = new System.Drawing.Point(318, 239);
            this.EiRB.Name = "EiRB";
            this.EiRB.Size = new System.Drawing.Size(43, 26);
            this.EiRB.TabIndex = 11;
            this.EiRB.TabStop = true;
            this.EiRB.Text = "EI";
            this.EiRB.UseVisualStyleBackColor = true;
            // 
            // HuoneetDG
            // 
            this.HuoneetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HuoneetDG.Location = new System.Drawing.Point(400, 99);
            this.HuoneetDG.Name = "HuoneetDG";
            this.HuoneetDG.Size = new System.Drawing.Size(588, 313);
            this.HuoneetDG.TabIndex = 12;
            this.HuoneetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HuoneetDG_CellClick);
            // 
            // UusiHuoneBT
            // 
            this.UusiHuoneBT.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiHuoneBT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UusiHuoneBT.Location = new System.Drawing.Point(52, 310);
            this.UusiHuoneBT.MinimumSize = new System.Drawing.Size(0, 41);
            this.UusiHuoneBT.Name = "UusiHuoneBT";
            this.UusiHuoneBT.Size = new System.Drawing.Size(164, 41);
            this.UusiHuoneBT.TabIndex = 13;
            this.UusiHuoneBT.Text = "Lisää uusi huone";
            this.UusiHuoneBT.UseVisualStyleBackColor = true;
            this.UusiHuoneBT.Click += new System.EventHandler(this.UusiHuoneBT_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(52, 369);
            this.button2.MinimumSize = new System.Drawing.Size(0, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "Muokkaa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PoistaBT
            // 
            this.PoistaBT.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaBT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PoistaBT.Location = new System.Drawing.Point(260, 310);
            this.PoistaBT.MinimumSize = new System.Drawing.Size(0, 41);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(101, 41);
            this.PoistaBT.TabIndex = 15;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(194, 371);
            this.button4.MinimumSize = new System.Drawing.Size(0, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 41);
            this.button4.TabIndex = 16;
            this.button4.Text = "Tyhjennä kentät";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // HuoneidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1022, 445);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UusiHuoneBT);
            this.Controls.Add(this.HuoneetDG);
            this.Controls.Add(this.EiRB);
            this.Controls.Add(this.KyllaRB);
            this.Controls.Add(this.HuoneTyyppiCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PuhelinTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "HuoneidenHallinta";
            this.Text = "HuoneidenHallinta";
            this.Load += new System.EventHandler(this.HuoneidenHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HuoneetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PuhelinTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox HuoneTyyppiCB;
        private System.Windows.Forms.RadioButton KyllaRB;
        private System.Windows.Forms.RadioButton EiRB;
        private System.Windows.Forms.DataGridView HuoneetDG;
        private System.Windows.Forms.Button UusiHuoneBT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.Button button4;
    }
}