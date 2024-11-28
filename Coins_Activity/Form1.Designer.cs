using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Coins_Activity
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
            btnOpen = new Button();
            btnCount = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblCount = new Label();
            label3 = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.FromArgb(34, 34, 34);
            btnOpen.Cursor = Cursors.Hand;
            btnOpen.FlatAppearance.BorderSize = 0;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.ForeColor = SystemColors.ButtonHighlight;
            btnOpen.Location = new Point(22, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(157, 44);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnCount
            // 
            btnCount.BackColor = Color.FromArgb(34, 34, 34);
            btnCount.Cursor = Cursors.Hand;
            btnCount.FlatAppearance.BorderSize = 0;
            btnCount.FlatStyle = FlatStyle.Flat;
            btnCount.ForeColor = SystemColors.ButtonHighlight;
            btnCount.Location = new Point(185, 12);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(157, 44);
            btnCount.TabIndex = 1;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = false;
            btnCount.Click += btnCount_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(34, 34, 34);
            pictureBox1.Location = new Point(221, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(488, 598);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(814, 323);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 4;
            label1.Text = "Coin Counter:";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblCount.ForeColor = Color.Cyan;
            lblCount.Location = new Point(987, 323);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(25, 30);
            lblCount.TabIndex = 5;
            lblCount.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(838, 368);
            label3.Name = "label3";
            label3.Size = new Size(126, 30);
            label3.TabIndex = 6;
            label3.Text = "Total Value:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Cyan;
            lblTotal.Location = new Point(987, 368);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(25, 30);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1203, 748);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(lblCount);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCount);
            Controls.Add(btnOpen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpen;
        private Button btnCount;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblCount;
        private Label label3;
        private Label lblTotal;
    }
}
