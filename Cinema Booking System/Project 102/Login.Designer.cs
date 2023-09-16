namespace Project_102
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Next0btn = new System.Windows.Forms.Button();
            this.Exit0btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SurnameTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Next0btn
            // 
            this.Next0btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Next0btn.Location = new System.Drawing.Point(346, 364);
            this.Next0btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Next0btn.Name = "Next0btn";
            this.Next0btn.Size = new System.Drawing.Size(118, 54);
            this.Next0btn.TabIndex = 28;
            this.Next0btn.Text = "Next";
            this.Next0btn.UseVisualStyleBackColor = false;
            this.Next0btn.Click += new System.EventHandler(this.Next0btn_Click);
            // 
            // Exit0btn
            // 
            this.Exit0btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Exit0btn.Location = new System.Drawing.Point(19, 364);
            this.Exit0btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit0btn.Name = "Exit0btn";
            this.Exit0btn.Size = new System.Drawing.Size(115, 54);
            this.Exit0btn.TabIndex = 27;
            this.Exit0btn.Text = "E&xit";
            this.Exit0btn.UseVisualStyleBackColor = false;
            this.Exit0btn.Click += new System.EventHandler(this.Exit0btn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 39);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name";
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(142, 273);
            this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTxtBox.Mask = "00000000";
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(79, 26);
            this.PasswordTxtBox.TabIndex = 30;
            this.PasswordTxtBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PasswordTxtBox_MaskInputRejected);
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(142, 161);
            this.NameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(210, 26);
            this.NameTxtBox.TabIndex = 31;
            this.NameTxtBox.TextChanged += new System.EventHandler(this.NameTxtBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(14, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(181, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 54);
            this.button1.TabIndex = 35;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SurnameTxtBox
            // 
            this.SurnameTxtBox.Location = new System.Drawing.Point(142, 216);
            this.SurnameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SurnameTxtBox.Name = "SurnameTxtBox";
            this.SurnameTxtBox.Size = new System.Drawing.Size(210, 26);
            this.SurnameTxtBox.TabIndex = 32;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(476, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurnameTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Next0btn);
            this.Controls.Add(this.Exit0btn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Next0btn;
        private System.Windows.Forms.Button Exit0btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SurnameTxtBox;
    }
}

