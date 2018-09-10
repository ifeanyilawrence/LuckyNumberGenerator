namespace LuckyNumber
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.lblLuckyNumbers = new System.Windows.Forms.Label();
            this.lbxLuckyNumbers = new System.Windows.Forms.ListBox();
            this.lblLargestNumber = new System.Windows.Forms.Label();
            this.tbxLargestNumber = new System.Windows.Forms.TextBox();
            this.tbxSmallestNumber = new System.Windows.Forms.TextBox();
            this.lblSmallestNumber = new System.Windows.Forms.Label();
            this.btnGenerateNumbers = new System.Windows.Forms.Button();
            this.btnClearNumbers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(42, 33);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(298, 33);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "How many numbers to guess?";
            // 
            // tbxNumber
            // 
            this.tbxNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNumber.Location = new System.Drawing.Point(346, 33);
            this.tbxNumber.Multiline = true;
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(121, 35);
            this.tbxNumber.TabIndex = 1;
            // 
            // lblLuckyNumbers
            // 
            this.lblLuckyNumbers.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuckyNumbers.Location = new System.Drawing.Point(42, 98);
            this.lblLuckyNumbers.Name = "lblLuckyNumbers";
            this.lblLuckyNumbers.Size = new System.Drawing.Size(298, 33);
            this.lblLuckyNumbers.TabIndex = 2;
            this.lblLuckyNumbers.Text = "Your lucky numbers:";
            // 
            // lbxLuckyNumbers
            // 
            this.lbxLuckyNumbers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxLuckyNumbers.FormattingEnabled = true;
            this.lbxLuckyNumbers.ItemHeight = 22;
            this.lbxLuckyNumbers.Location = new System.Drawing.Point(47, 150);
            this.lbxLuckyNumbers.Name = "lbxLuckyNumbers";
            this.lbxLuckyNumbers.Size = new System.Drawing.Size(178, 158);
            this.lbxLuckyNumbers.TabIndex = 3;
            // 
            // lblLargestNumber
            // 
            this.lblLargestNumber.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargestNumber.Location = new System.Drawing.Point(341, 150);
            this.lblLargestNumber.Name = "lblLargestNumber";
            this.lblLargestNumber.Size = new System.Drawing.Size(191, 35);
            this.lblLargestNumber.TabIndex = 4;
            this.lblLargestNumber.Text = "Largest number is:";
            // 
            // tbxLargestNumber
            // 
            this.tbxLargestNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLargestNumber.Location = new System.Drawing.Point(538, 150);
            this.tbxLargestNumber.Multiline = true;
            this.tbxLargestNumber.Name = "tbxLargestNumber";
            this.tbxLargestNumber.Size = new System.Drawing.Size(121, 35);
            this.tbxLargestNumber.TabIndex = 5;
            // 
            // tbxSmallestNumber
            // 
            this.tbxSmallestNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSmallestNumber.Location = new System.Drawing.Point(538, 224);
            this.tbxSmallestNumber.Multiline = true;
            this.tbxSmallestNumber.Name = "tbxSmallestNumber";
            this.tbxSmallestNumber.Size = new System.Drawing.Size(121, 35);
            this.tbxSmallestNumber.TabIndex = 7;
            // 
            // lblSmallestNumber
            // 
            this.lblSmallestNumber.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmallestNumber.Location = new System.Drawing.Point(341, 224);
            this.lblSmallestNumber.Name = "lblSmallestNumber";
            this.lblSmallestNumber.Size = new System.Drawing.Size(191, 33);
            this.lblSmallestNumber.TabIndex = 6;
            this.lblSmallestNumber.Text = "Smallest number is:";
            // 
            // btnGenerateNumbers
            // 
            this.btnGenerateNumbers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateNumbers.Location = new System.Drawing.Point(47, 376);
            this.btnGenerateNumbers.Name = "btnGenerateNumbers";
            this.btnGenerateNumbers.Size = new System.Drawing.Size(267, 39);
            this.btnGenerateNumbers.TabIndex = 8;
            this.btnGenerateNumbers.Text = "Generate And Save Numbers";
            this.btnGenerateNumbers.UseVisualStyleBackColor = true;
            this.btnGenerateNumbers.Click += new System.EventHandler(this.btnGenerateNumbers_Click);
            // 
            // btnClearNumbers
            // 
            this.btnClearNumbers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearNumbers.Location = new System.Drawing.Point(346, 376);
            this.btnClearNumbers.Name = "btnClearNumbers";
            this.btnClearNumbers.Size = new System.Drawing.Size(174, 39);
            this.btnClearNumbers.TabIndex = 9;
            this.btnClearNumbers.Text = "Clear Numbers";
            this.btnClearNumbers.UseVisualStyleBackColor = true;
            this.btnClearNumbers.Click += new System.EventHandler(this.btnClearNumbers_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(569, 399);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 39);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearNumbers);
            this.Controls.Add(this.btnGenerateNumbers);
            this.Controls.Add(this.tbxSmallestNumber);
            this.Controls.Add(this.lblSmallestNumber);
            this.Controls.Add(this.tbxLargestNumber);
            this.Controls.Add(this.lblLargestNumber);
            this.Controls.Add(this.lbxLuckyNumbers);
            this.Controls.Add(this.lblLuckyNumbers);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.lblNumber);
            this.Name = "Form1";
            this.Text = "Lucky Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label lblLuckyNumbers;
        private System.Windows.Forms.ListBox lbxLuckyNumbers;
        private System.Windows.Forms.Label lblLargestNumber;
        private System.Windows.Forms.TextBox tbxLargestNumber;
        private System.Windows.Forms.TextBox tbxSmallestNumber;
        private System.Windows.Forms.Label lblSmallestNumber;
        private System.Windows.Forms.Button btnGenerateNumbers;
        private System.Windows.Forms.Button btnClearNumbers;
        private System.Windows.Forms.Button btnExit;
    }
}

