namespace SQLLiteTEst
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PersonelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PersonelSoyadi = new System.Windows.Forms.TextBox();
            this.btn_PersonelInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Adı";
            // 
            // txt_PersonelName
            // 
            this.txt_PersonelName.Location = new System.Drawing.Point(15, 25);
            this.txt_PersonelName.Name = "txt_PersonelName";
            this.txt_PersonelName.Size = new System.Drawing.Size(121, 20);
            this.txt_PersonelName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel SoyAdı";
            // 
            // txt_PersonelSoyadi
            // 
            this.txt_PersonelSoyadi.Location = new System.Drawing.Point(147, 25);
            this.txt_PersonelSoyadi.Name = "txt_PersonelSoyadi";
            this.txt_PersonelSoyadi.Size = new System.Drawing.Size(121, 20);
            this.txt_PersonelSoyadi.TabIndex = 2;
            // 
            // btn_PersonelInsert
            // 
            this.btn_PersonelInsert.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PersonelInsert.Location = new System.Drawing.Point(274, 9);
            this.btn_PersonelInsert.Name = "btn_PersonelInsert";
            this.btn_PersonelInsert.Size = new System.Drawing.Size(284, 37);
            this.btn_PersonelInsert.TabIndex = 3;
            this.btn_PersonelInsert.Text = "Personel Kayıt";
            this.btn_PersonelInsert.UseVisualStyleBackColor = true;
            this.btn_PersonelInsert.Click += new System.EventHandler(this.btn_PersonelInsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 190);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 253);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_PersonelInsert);
            this.Controls.Add(this.txt_PersonelSoyadi);
            this.Controls.Add(this.txt_PersonelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PersonelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PersonelSoyadi;
        private System.Windows.Forms.Button btn_PersonelInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

