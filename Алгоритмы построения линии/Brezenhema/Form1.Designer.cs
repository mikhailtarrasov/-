namespace Brezenhema
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.X0 = new System.Windows.Forms.TextBox();
            this.Y0 = new System.Windows.Forms.TextBox();
            this.X1 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Brez = new System.Windows.Forms.RadioButton();
            this.DDA = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 280);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Координаты начала";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Координаты конца";
            // 
            // X0
            // 
            this.X0.Location = new System.Drawing.Point(329, 29);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(77, 20);
            this.X0.TabIndex = 3;
            // 
            // Y0
            // 
            this.Y0.Location = new System.Drawing.Point(329, 56);
            this.Y0.Name = "Y0";
            this.Y0.Size = new System.Drawing.Size(77, 20);
            this.Y0.TabIndex = 4;
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(329, 100);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(77, 20);
            this.X1.TabIndex = 5;
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(329, 127);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(77, 20);
            this.Y1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Y";
            // 
            // Brez
            // 
            this.Brez.AutoSize = true;
            this.Brez.Location = new System.Drawing.Point(312, 153);
            this.Brez.Name = "Brez";
            this.Brez.Size = new System.Drawing.Size(81, 17);
            this.Brez.TabIndex = 11;
            this.Brez.TabStop = true;
            this.Brez.Text = "Брезенхэм";
            this.Brez.UseVisualStyleBackColor = true;
            // 
            // DDA
            // 
            this.DDA.AutoSize = true;
            this.DDA.Location = new System.Drawing.Point(312, 176);
            this.DDA.Name = "DDA";
            this.DDA.Size = new System.Drawing.Size(67, 17);
            this.DDA.TabIndex = 12;
            this.DDA.TabStop = true;
            this.DDA.Text = "DDA line";
            this.DDA.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 280);
            this.Controls.Add(this.DDA);
            this.Controls.Add(this.Brez);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.Y0);
            this.Controls.Add(this.X0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox X0;
        private System.Windows.Forms.TextBox Y0;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Brez;
        private System.Windows.Forms.RadioButton DDA;
    }
}

