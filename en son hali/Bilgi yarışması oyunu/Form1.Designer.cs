namespace Bilgi_yarışması_oyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnbaslat = new System.Windows.Forms.Button();
            this.lblsüre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sorukısmı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(44, 211);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(133, 50);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "a";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(241, 211);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(148, 50);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "b";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(44, 287);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(133, 45);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "c";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(241, 287);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(148, 45);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "d";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnbaslat
            // 
            this.btnbaslat.Location = new System.Drawing.Point(479, 50);
            this.btnbaslat.Name = "btnbaslat";
            this.btnbaslat.Size = new System.Drawing.Size(160, 57);
            this.btnbaslat.TabIndex = 4;
            this.btnbaslat.Text = "BAŞLAT";
            this.btnbaslat.UseVisualStyleBackColor = true;
            this.btnbaslat.Click += new System.EventHandler(this.btnbaslat_Click);
            // 
            // lblsüre
            // 
            this.lblsüre.AutoSize = true;
            this.lblsüre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsüre.Location = new System.Drawing.Point(479, 110);
            this.lblsüre.Name = "lblsüre";
            this.lblsüre.Size = new System.Drawing.Size(131, 41);
            this.lblsüre.TabIndex = 6;
            this.lblsüre.Text = "PUAN =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "label 4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "label 5";
            this.label5.Visible = false;
            // 
            // sorukısmı
            // 
            this.sorukısmı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sorukısmı.Location = new System.Drawing.Point(44, 65);
            this.sorukısmı.Multiline = true;
            this.sorukısmı.Name = "sorukısmı";
            this.sorukısmı.Size = new System.Drawing.Size(353, 110);
            this.sorukısmı.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "BİLGİ YARİŞMASİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPuan.Location = new System.Drawing.Point(596, 110);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(43, 50);
            this.lblPuan.TabIndex = 12;
            this.lblPuan.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(704, 361);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sorukısmı);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblsüre);
            this.Controls.Add(this.btnbaslat);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Name = "Form1";
            this.Text = "Bilgi yarışması oyunu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnbaslat;
        private Label lblsüre;
        private Label label4;
        private Label label5;
        private TextBox sorukısmı;
        private Label label1;
        private Label lblPuan;
    }
}