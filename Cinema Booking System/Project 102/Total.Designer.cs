namespace Project_102
{
    partial class Total
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Total));
            this.ReceiptTxtbx = new System.Windows.Forms.TextBox();
            this.Back3btn = new System.Windows.Forms.Button();
            this.Checkout3btn = new System.Windows.Forms.Button();
            this.Confirm3btn = new System.Windows.Forms.Button();
            this.AmountTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeTxtBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TotalTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReceiptTxtbx
            // 
            this.ReceiptTxtbx.Enabled = false;
            this.ReceiptTxtbx.Location = new System.Drawing.Point(313, 48);
            this.ReceiptTxtbx.Multiline = true;
            this.ReceiptTxtbx.Name = "ReceiptTxtbx";
            this.ReceiptTxtbx.Size = new System.Drawing.Size(278, 405);
            this.ReceiptTxtbx.TabIndex = 0;
            this.ReceiptTxtbx.TextChanged += new System.EventHandler(this.ReceiptTxtbx_TextChanged);
            // 
            // Back3btn
            // 
            this.Back3btn.Location = new System.Drawing.Point(37, 487);
            this.Back3btn.Name = "Back3btn";
            this.Back3btn.Size = new System.Drawing.Size(150, 58);
            this.Back3btn.TabIndex = 1;
            this.Back3btn.Text = "Back";
            this.Back3btn.UseVisualStyleBackColor = true;
            this.Back3btn.Click += new System.EventHandler(this.Back3btn_Click);
            // 
            // Checkout3btn
            // 
            this.Checkout3btn.Location = new System.Drawing.Point(242, 487);
            this.Checkout3btn.Name = "Checkout3btn";
            this.Checkout3btn.Size = new System.Drawing.Size(150, 58);
            this.Checkout3btn.TabIndex = 2;
            this.Checkout3btn.Text = "Checkout";
            this.Checkout3btn.UseVisualStyleBackColor = true;
            this.Checkout3btn.Click += new System.EventHandler(this.Checkout3btn_Click);
            // 
            // Confirm3btn
            // 
            this.Confirm3btn.Location = new System.Drawing.Point(441, 487);
            this.Confirm3btn.Name = "Confirm3btn";
            this.Confirm3btn.Size = new System.Drawing.Size(150, 58);
            this.Confirm3btn.TabIndex = 3;
            this.Confirm3btn.Text = "Confirm";
            this.Confirm3btn.UseVisualStyleBackColor = true;
            this.Confirm3btn.Click += new System.EventHandler(this.Confirm3btn_Click);
            // 
            // AmountTxtBox
            // 
            this.AmountTxtBox.Location = new System.Drawing.Point(166, 319);
            this.AmountTxtBox.Name = "AmountTxtBox";
            this.AmountTxtBox.Size = new System.Drawing.Size(100, 26);
            this.AmountTxtBox.TabIndex = 4;
            this.AmountTxtBox.TextChanged += new System.EventHandler(this.AmountTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Amount";
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(37, 367);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(229, 35);
            this.ChangeBtn.TabIndex = 6;
            this.ChangeBtn.Text = "Calculate change";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Change  :";
            // 
            // ChangeTxtBox
            // 
            this.ChangeTxtBox.Enabled = false;
            this.ChangeTxtBox.Location = new System.Drawing.Point(166, 427);
            this.ChangeTxtBox.Name = "ChangeTxtBox";
            this.ChangeTxtBox.Size = new System.Drawing.Size(100, 26);
            this.ChangeTxtBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TotalTxtBox
            // 
            this.TotalTxtBox.Enabled = false;
            this.TotalTxtBox.Location = new System.Drawing.Point(166, 270);
            this.TotalTxtBox.Name = "TotalTxtBox";
            this.TotalTxtBox.Size = new System.Drawing.Size(100, 26);
            this.TotalTxtBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total+VAT";
            // 
            // Total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalTxtBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ChangeTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmountTxtBox);
            this.Controls.Add(this.Confirm3btn);
            this.Controls.Add(this.Checkout3btn);
            this.Controls.Add(this.Back3btn);
            this.Controls.Add(this.ReceiptTxtbx);
            this.Name = "Total";
            this.Text = "Total";
            this.Load += new System.EventHandler(this.Total_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReceiptTxtbx;
        private System.Windows.Forms.Button Back3btn;
        private System.Windows.Forms.Button Checkout3btn;
        private System.Windows.Forms.Button Confirm3btn;
        private System.Windows.Forms.TextBox AmountTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ChangeTxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TotalTxtBox;
        private System.Windows.Forms.Label label3;
    }
}