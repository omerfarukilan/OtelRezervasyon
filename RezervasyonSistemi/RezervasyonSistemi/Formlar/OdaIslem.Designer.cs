namespace RezervasyonSistemi.DAO
{
    partial class OdaIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaIslem));
            this.odaDGV = new System.Windows.Forms.DataGridView();
            this.odaTurTxt = new System.Windows.Forms.TextBox();
            this.odaFiyatTxt = new System.Windows.Forms.TextBox();
            this.odaNoTxt = new System.Windows.Forms.TextBox();
            this.odaDurumTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ekleTxt = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.geriBtn = new System.Windows.Forms.Button();
            this.ileriBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.odaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // odaDGV
            // 
            this.odaDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.odaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odaDGV.Location = new System.Drawing.Point(12, 381);
            this.odaDGV.Name = "odaDGV";
            this.odaDGV.RowHeadersWidth = 51;
            this.odaDGV.RowTemplate.Height = 24;
            this.odaDGV.Size = new System.Drawing.Size(896, 208);
            this.odaDGV.TabIndex = 0;
            this.odaDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.odaDGV_CellContentClick);
            // 
            // odaTurTxt
            // 
            this.odaTurTxt.Location = new System.Drawing.Point(384, 63);
            this.odaTurTxt.Name = "odaTurTxt";
            this.odaTurTxt.Size = new System.Drawing.Size(295, 22);
            this.odaTurTxt.TabIndex = 1;
            // 
            // odaFiyatTxt
            // 
            this.odaFiyatTxt.Location = new System.Drawing.Point(384, 184);
            this.odaFiyatTxt.Name = "odaFiyatTxt";
            this.odaFiyatTxt.Size = new System.Drawing.Size(295, 22);
            this.odaFiyatTxt.TabIndex = 2;
            // 
            // odaNoTxt
            // 
            this.odaNoTxt.Location = new System.Drawing.Point(384, 124);
            this.odaNoTxt.Name = "odaNoTxt";
            this.odaNoTxt.Size = new System.Drawing.Size(295, 22);
            this.odaNoTxt.TabIndex = 2;
            // 
            // odaDurumTxt
            // 
            this.odaDurumTxt.Location = new System.Drawing.Point(384, 243);
            this.odaDurumTxt.Name = "odaDurumTxt";
            this.odaDurumTxt.Size = new System.Drawing.Size(295, 22);
            this.odaDurumTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Oda Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateBlue;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Oda Numarası";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SlateBlue;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oda Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SlateBlue;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oda Durumu";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SlateBlue;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(895, 373);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ekleTxt
            // 
            this.ekleTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ekleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleTxt.Location = new System.Drawing.Point(252, 292);
            this.ekleTxt.Name = "ekleTxt";
            this.ekleTxt.Size = new System.Drawing.Size(162, 47);
            this.ekleTxt.TabIndex = 9;
            this.ekleTxt.Text = "Oda Ekle";
            this.ekleTxt.UseVisualStyleBackColor = false;
            this.ekleTxt.Click += new System.EventHandler(this.ekleTxt_Click);
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silBtn.Location = new System.Drawing.Point(471, 292);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(162, 47);
            this.silBtn.TabIndex = 10;
            this.silBtn.Text = "Oda Sil";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // geriBtn
            // 
            this.geriBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriBtn.Location = new System.Drawing.Point(27, 22);
            this.geriBtn.Name = "geriBtn";
            this.geriBtn.Size = new System.Drawing.Size(43, 54);
            this.geriBtn.TabIndex = 11;
            this.geriBtn.Text = "← (Unicode: \\u2190";
            this.geriBtn.UseVisualStyleBackColor = false;
            this.geriBtn.Click += new System.EventHandler(this.geriBtn_Click);
            // 
            // ileriBtn
            // 
            this.ileriBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ileriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ileriBtn.Location = new System.Drawing.Point(851, 21);
            this.ileriBtn.Name = "ileriBtn";
            this.ileriBtn.Size = new System.Drawing.Size(43, 55);
            this.ileriBtn.TabIndex = 12;
            this.ileriBtn.Text = "→ (Unicode: \\u2192";
            this.ileriBtn.UseVisualStyleBackColor = false;
            this.ileriBtn.Click += new System.EventHandler(this.ileriBtn_Click);
            // 
            // OdaIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(918, 601);
            this.Controls.Add(this.ileriBtn);
            this.Controls.Add(this.geriBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.ekleTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odaDurumTxt);
            this.Controls.Add(this.odaNoTxt);
            this.Controls.Add(this.odaFiyatTxt);
            this.Controls.Add(this.odaTurTxt);
            this.Controls.Add(this.odaDGV);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OdaIslem";
            this.Text = "BlueSwallow";
            ((System.ComponentModel.ISupportInitialize)(this.odaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView odaDGV;
        private System.Windows.Forms.TextBox odaTurTxt;
        private System.Windows.Forms.TextBox odaFiyatTxt;
        private System.Windows.Forms.TextBox odaNoTxt;
        private System.Windows.Forms.TextBox odaDurumTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ekleTxt;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button geriBtn;
        private System.Windows.Forms.Button ileriBtn;
    }
}