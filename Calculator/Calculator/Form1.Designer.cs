namespace Calculator
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
            this.Number1 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.NumericUpDown();
            this.txtNumber2 = new System.Windows.Forms.NumericUpDown();
            this.Number2 = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnMultipl = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // Number1
            // 
            this.Number1.AutoSize = true;
            this.Number1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number1.Location = new System.Drawing.Point(374, 35);
            this.Number1.Name = "Number1";
            this.Number1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Number1.Size = new System.Drawing.Size(73, 25);
            this.Number1.TabIndex = 1;
            this.Number1.Text = "عدد اول :";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber1.Location = new System.Drawing.Point(26, 30);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumber1.Size = new System.Drawing.Size(342, 33);
            this.txtNumber1.TabIndex = 2;
            this.txtNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber2.Location = new System.Drawing.Point(26, 77);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumber2.Size = new System.Drawing.Size(342, 33);
            this.txtNumber2.TabIndex = 4;
            this.txtNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Number2
            // 
            this.Number2.AutoSize = true;
            this.Number2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number2.Location = new System.Drawing.Point(374, 82);
            this.Number2.Name = "Number2";
            this.Number2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Number2.Size = new System.Drawing.Size(76, 25);
            this.Number2.TabIndex = 3;
            this.Number2.Text = "عدد دوم :";
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMinus.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(203, 126);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(165, 35);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTotal.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(32, 126);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(165, 35);
            this.btnTotal.TabIndex = 6;
            this.btnTotal.Text = "+";
            this.btnTotal.UseVisualStyleBackColor = false;
            // 
            // btnMultipl
            // 
            this.btnMultipl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMultipl.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultipl.Location = new System.Drawing.Point(32, 167);
            this.btnMultipl.Name = "btnMultipl";
            this.btnMultipl.Size = new System.Drawing.Size(165, 35);
            this.btnMultipl.TabIndex = 7;
            this.btnMultipl.Text = "*";
            this.btnMultipl.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDivide.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(203, 167);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(165, 35);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 218);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultipl);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.Number1);
            this.Name = "Form1";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.NumericUpDown txtNumber1;
        private System.Windows.Forms.NumericUpDown txtNumber2;
        private System.Windows.Forms.Label Number2;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnMultipl;
        private System.Windows.Forms.Button btnDivide;
    }
}

