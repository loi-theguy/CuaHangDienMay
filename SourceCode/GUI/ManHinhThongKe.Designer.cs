﻿
namespace GUI
{
    partial class ManHinhThongKe
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
            this.btnThongKeDoanhThu = new System.Windows.Forms.Button();
            this.btnThongKeSanPham = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThongKeDoanhThu
            // 
            this.btnThongKeDoanhThu.Location = new System.Drawing.Point(12, 124);
            this.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            this.btnThongKeDoanhThu.Size = new System.Drawing.Size(175, 23);
            this.btnThongKeDoanhThu.TabIndex = 1;
            this.btnThongKeDoanhThu.Text = "Thong ke doanh thu";
            this.btnThongKeDoanhThu.UseVisualStyleBackColor = true;
            // 
            // btnThongKeSanPham
            // 
            this.btnThongKeSanPham.Location = new System.Drawing.Point(193, 124);
            this.btnThongKeSanPham.Name = "btnThongKeSanPham";
            this.btnThongKeSanPham.Size = new System.Drawing.Size(184, 23);
            this.btnThongKeSanPham.TabIndex = 2;
            this.btnThongKeSanPham.Text = "Thong ke san pham";
            this.btnThongKeSanPham.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHON CHUC NANG";
            // 
            // ManHinhThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThongKeSanPham);
            this.Controls.Add(this.btnThongKeDoanhThu);
            this.Name = "ManHinhThongKe";
            this.Text = "Thong Ke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThongKeDoanhThu;
        private System.Windows.Forms.Button btnThongKeSanPham;
        private System.Windows.Forms.Label label1;
    }
}