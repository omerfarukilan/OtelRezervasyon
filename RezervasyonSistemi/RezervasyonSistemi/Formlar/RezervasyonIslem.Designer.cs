namespace RezervasyonSistemi
{
    partial class RezervasyonIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonIslem));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriCmb = new System.Windows.Forms.ComboBox();
            this.odaCmb = new System.Windows.Forms.ComboBox();
            this.silBtn = new System.Windows.Forms.Button();
            this.rzvBtn = new System.Windows.Forms.Button();
            this.cikisPicker = new System.Windows.Forms.DateTimePicker();
            this.girisPicker = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toplamFiyatLbl = new System.Windows.Forms.Label();
            this.geriBtn = new System.Windows.Forms.Button();
            this.ileriBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 388);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(869, 213);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // musteriCmb
            // 
            this.musteriCmb.FormattingEnabled = true;
            this.musteriCmb.Location = new System.Drawing.Point(400, 74);
            this.musteriCmb.Name = "musteriCmb";
            this.musteriCmb.Size = new System.Drawing.Size(232, 24);
            this.musteriCmb.TabIndex = 12;
            // 
            // odaCmb
            // 
            this.odaCmb.FormattingEnabled = true;
            this.odaCmb.Location = new System.Drawing.Point(400, 130);
            this.odaCmb.Name = "odaCmb";
            this.odaCmb.Size = new System.Drawing.Size(232, 24);
            this.odaCmb.TabIndex = 13;
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silBtn.Location = new System.Drawing.Point(461, 311);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(152, 52);
            this.silBtn.TabIndex = 6;
            this.silBtn.Text = "Rezervasyon Sil";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // rzvBtn
            // 
            this.rzvBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rzvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rzvBtn.Location = new System.Drawing.Point(275, 311);
            this.rzvBtn.Name = "rzvBtn";
            this.rzvBtn.Size = new System.Drawing.Size(152, 52);
            this.rzvBtn.TabIndex = 7;
            this.rzvBtn.Text = "Rezervasyon Yap";
            this.rzvBtn.UseVisualStyleBackColor = false;
            this.rzvBtn.Click += new System.EventHandler(this.rzvBtn_Click);
            // 
            // cikisPicker
            // 
            this.cikisPicker.Location = new System.Drawing.Point(400, 243);
            this.cikisPicker.Name = "cikisPicker";
            this.cikisPicker.Size = new System.Drawing.Size(232, 22);
            this.cikisPicker.TabIndex = 10;
            // 
            // girisPicker
            // 
            this.girisPicker.Location = new System.Drawing.Point(400, 187);
            this.girisPicker.Name = "girisPicker";
            this.girisPicker.Size = new System.Drawing.Size(232, 22);
            this.girisPicker.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SlateBlue;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(869, 383);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Müşteri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateBlue;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Oda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SlateBlue;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Giriş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SlateBlue;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Çıkış Tarihi";
            // 
            // toplamFiyatLbl
            // 
            this.toplamFiyatLbl.AutoSize = true;
            this.toplamFiyatLbl.BackColor = System.Drawing.Color.SlateBlue;
            this.toplamFiyatLbl.ForeColor = System.Drawing.Color.SlateBlue;
            this.toplamFiyatLbl.Location = new System.Drawing.Point(743, 129);
            this.toplamFiyatLbl.Name = "toplamFiyatLbl";
            this.toplamFiyatLbl.Size = new System.Drawing.Size(44, 16);
            this.toplamFiyatLbl.TabIndex = 19;
            this.toplamFiyatLbl.Text = "label5";
            this.toplamFiyatLbl.Click += new System.EventHandler(this.toplamFiyatLbl_Click);
            // 
            // geriBtn
            // 
            this.geriBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriBtn.Location = new System.Drawing.Point(39, 24);
            this.geriBtn.Name = "geriBtn";
            this.geriBtn.Size = new System.Drawing.Size(44, 52);
            this.geriBtn.TabIndex = 20;
            this.geriBtn.Text = "← (Unicode: \\u2190";
            this.geriBtn.UseVisualStyleBackColor = false;
            this.geriBtn.Click += new System.EventHandler(this.geriBtn_Click);
            // 
            // ileriBtn
            // 
            this.ileriBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ileriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ileriBtn.Location = new System.Drawing.Point(838, 24);
            this.ileriBtn.Name = "ileriBtn";
            this.ileriBtn.Size = new System.Drawing.Size(44, 52);
            this.ileriBtn.TabIndex = 21;
            this.ileriBtn.Text = "→ (Unicode: \\u2192";
            this.ileriBtn.UseVisualStyleBackColor = false;
            this.ileriBtn.Click += new System.EventHandler(this.ileriBtn_Click);
            // 
            // RezervasyonIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(921, 628);
            this.Controls.Add(this.ileriBtn);
            this.Controls.Add(this.geriBtn);
            this.Controls.Add(this.toplamFiyatLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cikisPicker);
            this.Controls.Add(this.odaCmb);
            this.Controls.Add(this.girisPicker);
            this.Controls.Add(this.musteriCmb);
            this.Controls.Add(this.rzvBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RezervasyonIslem";
            this.Text = "BlueSwallow";
            this.Load += new System.EventHandler(this.RezervasyonIs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox musteriCmb;
        private System.Windows.Forms.ComboBox odaCmb;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button rzvBtn;
        private System.Windows.Forms.DateTimePicker cikisPicker;
        private System.Windows.Forms.DateTimePicker girisPicker;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label toplamFiyatLbl;
        private System.Windows.Forms.Button geriBtn;
        private System.Windows.Forms.Button ileriBtn;
    }
}