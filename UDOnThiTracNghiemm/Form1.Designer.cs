namespace UDOnThiTracNghiemm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_NopBai = new System.Windows.Forms.Button();
            this.btn_TrangCuoi = new System.Windows.Forms.Button();
            this.btn_TrangTruoc = new System.Windows.Forms.Button();
            this.btn_TrangTiep = new System.Windows.Forms.Button();
            this.btn_TrangDau = new System.Windows.Forms.Button();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_NopBai);
            this.groupBox1.Controls.Add(this.btn_TrangCuoi);
            this.groupBox1.Controls.Add(this.btn_TrangTruoc);
            this.groupBox1.Controls.Add(this.btn_TrangTiep);
            this.groupBox1.Controls.Add(this.btn_TrangDau);
            this.groupBox1.Controls.Add(this.rdD);
            this.groupBox1.Controls.Add(this.rdC);
            this.groupBox1.Controls.Add(this.rdB);
            this.groupBox1.Controls.Add(this.rdA);
            this.groupBox1.Location = new System.Drawing.Point(-1, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_NopBai
            // 
            this.btn_NopBai.Location = new System.Drawing.Point(696, 294);
            this.btn_NopBai.Name = "btn_NopBai";
            this.btn_NopBai.Size = new System.Drawing.Size(93, 38);
            this.btn_NopBai.TabIndex = 2;
            this.btn_NopBai.Text = "Nộp bài";
            this.btn_NopBai.UseVisualStyleBackColor = true;
            this.btn_NopBai.Click += new System.EventHandler(this.btn_NopBai_Click);
            // 
            // btn_TrangCuoi
            // 
            this.btn_TrangCuoi.Location = new System.Drawing.Point(556, 294);
            this.btn_TrangCuoi.Name = "btn_TrangCuoi";
            this.btn_TrangCuoi.Size = new System.Drawing.Size(99, 38);
            this.btn_TrangCuoi.TabIndex = 1;
            this.btn_TrangCuoi.Text = "Trang cuối";
            this.btn_TrangCuoi.UseVisualStyleBackColor = true;
            this.btn_TrangCuoi.Click += new System.EventHandler(this.btn_TrangCuoi_Click);
            // 
            // btn_TrangTruoc
            // 
            this.btn_TrangTruoc.Location = new System.Drawing.Point(405, 294);
            this.btn_TrangTruoc.Name = "btn_TrangTruoc";
            this.btn_TrangTruoc.Size = new System.Drawing.Size(88, 38);
            this.btn_TrangTruoc.TabIndex = 1;
            this.btn_TrangTruoc.Text = "Trang trước";
            this.btn_TrangTruoc.UseVisualStyleBackColor = true;
            this.btn_TrangTruoc.Click += new System.EventHandler(this.btn_TrangTruoc_Click);
            // 
            // btn_TrangTiep
            // 
            this.btn_TrangTiep.Location = new System.Drawing.Point(244, 294);
            this.btn_TrangTiep.Name = "btn_TrangTiep";
            this.btn_TrangTiep.Size = new System.Drawing.Size(90, 38);
            this.btn_TrangTiep.TabIndex = 1;
            this.btn_TrangTiep.Text = "Trang tiếp";
            this.btn_TrangTiep.UseVisualStyleBackColor = true;
            this.btn_TrangTiep.Click += new System.EventHandler(this.btn_TrangTiep_Click);
            // 
            // btn_TrangDau
            // 
            this.btn_TrangDau.Location = new System.Drawing.Point(87, 294);
            this.btn_TrangDau.Name = "btn_TrangDau";
            this.btn_TrangDau.Size = new System.Drawing.Size(97, 38);
            this.btn_TrangDau.TabIndex = 1;
            this.btn_TrangDau.Text = "Trang đầu";
            this.btn_TrangDau.UseVisualStyleBackColor = true;
            this.btn_TrangDau.Click += new System.EventHandler(this.btn_TrangDau_Click);
            // 
            // rdD
            // 
            this.rdD.AutoSize = true;
            this.rdD.Location = new System.Drawing.Point(87, 228);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(38, 20);
            this.rdD.TabIndex = 0;
            this.rdD.Text = "D";
            this.rdD.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Location = new System.Drawing.Point(87, 112);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(37, 20);
            this.rdC.TabIndex = 0;
            this.rdC.TabStop = true;
            this.rdC.Text = "B";
            this.rdC.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Location = new System.Drawing.Point(87, 170);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(37, 20);
            this.rdB.TabIndex = 0;
            this.rdB.Text = "C";
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Location = new System.Drawing.Point(87, 52);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(37, 20);
            this.rdA.TabIndex = 0;
            this.rdA.Text = "A";
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian: 00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_TrangCuoi;
        private System.Windows.Forms.Button btn_TrangTruoc;
        private System.Windows.Forms.Button btn_TrangTiep;
        private System.Windows.Forms.Button btn_TrangDau;
        private System.Windows.Forms.Button btn_NopBai;
        private System.Windows.Forms.Label label2;
    }
}

