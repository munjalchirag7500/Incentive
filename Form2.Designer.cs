namespace Incentive
{
    partial class Form2
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
            this.codeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.memnbernameText = new System.Windows.Forms.TextBox();
            this.F = new System.Windows.Forms.Label();
            this.fhnameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.mobileText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.aadharText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bankText = new System.Windows.Forms.TextBox();
            this.accountText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ifscText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.incentiveRadioButton = new System.Windows.Forms.RadioButton();
            this.paymentRadioButton = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // codeText
            // 
            this.codeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeText.Location = new System.Drawing.Point(268, 111);
            this.codeText.Margin = new System.Windows.Forms.Padding(2);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(234, 35);
            this.codeText.TabIndex = 1;
            this.codeText.TextChanged += new System.EventHandler(this.codeText_TextChanged);
            this.codeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codeText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Member Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // memnbernameText
            // 
            this.memnbernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memnbernameText.Location = new System.Drawing.Point(787, 112);
            this.memnbernameText.Margin = new System.Windows.Forms.Padding(2);
            this.memnbernameText.Name = "memnbernameText";
            this.memnbernameText.Size = new System.Drawing.Size(361, 35);
            this.memnbernameText.TabIndex = 3;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F.Location = new System.Drawing.Point(642, 194);
            this.F.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(123, 29);
            this.F.TabIndex = 4;
            this.F.Text = "FH Name";
            this.F.Click += new System.EventHandler(this.label3_Click);
            // 
            // fhnameText
            // 
            this.fhnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fhnameText.Location = new System.Drawing.Point(787, 192);
            this.fhnameText.Margin = new System.Windows.Forms.Padding(2);
            this.fhnameText.Name = "fhnameText";
            this.fhnameText.Size = new System.Drawing.Size(361, 35);
            this.fhnameText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "DOB";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(305, 195);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 35);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mobile Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // mobileText
            // 
            this.mobileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileText.Location = new System.Drawing.Point(233, 287);
            this.mobileText.Margin = new System.Windows.Forms.Padding(2);
            this.mobileText.Name = "mobileText";
            this.mobileText.Size = new System.Drawing.Size(269, 35);
            this.mobileText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(591, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Aadhaar Card";
            // 
            // aadharText
            // 
            this.aadharText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aadharText.Location = new System.Drawing.Point(787, 273);
            this.aadharText.Margin = new System.Windows.Forms.Padding(2);
            this.aadharText.Name = "aadharText";
            this.aadharText.Size = new System.Drawing.Size(361, 35);
            this.aadharText.TabIndex = 11;
            this.aadharText.TextChanged += new System.EventHandler(this.aadharText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(546, 465);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Account Number";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(623, 370);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bank Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // bankText
            // 
            this.bankText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankText.Location = new System.Drawing.Point(787, 370);
            this.bankText.Margin = new System.Windows.Forms.Padding(2);
            this.bankText.Name = "bankText";
            this.bankText.Size = new System.Drawing.Size(361, 35);
            this.bankText.TabIndex = 14;
            // 
            // accountText
            // 
            this.accountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountText.Location = new System.Drawing.Point(787, 461);
            this.accountText.Margin = new System.Windows.Forms.Padding(2);
            this.accountText.Name = "accountText";
            this.accountText.Size = new System.Drawing.Size(361, 35);
            this.accountText.TabIndex = 15;
            this.accountText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 400);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "IFSC Code";
            // 
            // ifscText
            // 
            this.ifscText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ifscText.Location = new System.Drawing.Point(212, 394);
            this.ifscText.Margin = new System.Windows.Forms.Padding(2);
            this.ifscText.Name = "ifscText";
            this.ifscText.Size = new System.Drawing.Size(290, 35);
            this.ifscText.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 581);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 58);
            this.button1.TabIndex = 18;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(523, 581);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 58);
            this.button2.TabIndex = 19;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(747, 581);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(115, 58);
            this.resetButton.TabIndex = 20;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // incentiveRadioButton
            // 
            this.incentiveRadioButton.AutoSize = true;
            this.incentiveRadioButton.Checked = true;
            this.incentiveRadioButton.Location = new System.Drawing.Point(268, 48);
            this.incentiveRadioButton.Name = "incentiveRadioButton";
            this.incentiveRadioButton.Size = new System.Drawing.Size(82, 17);
            this.incentiveRadioButton.TabIndex = 21;
            this.incentiveRadioButton.TabStop = true;
            this.incentiveRadioButton.Text = "INCENTIVE";
            this.incentiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // paymentRadioButton
            // 
            this.paymentRadioButton.AutoSize = true;
            this.paymentRadioButton.Location = new System.Drawing.Point(396, 48);
            this.paymentRadioButton.Name = "paymentRadioButton";
            this.paymentRadioButton.Size = new System.Drawing.Size(77, 17);
            this.paymentRadioButton.TabIndex = 22;
            this.paymentRadioButton.Text = "PAYMENT";
            this.paymentRadioButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(103, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 29);
            this.label10.TabIndex = 24;
            this.label10.Text = "MODE";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 682);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.paymentRadioButton);
            this.Controls.Add(this.incentiveRadioButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ifscText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.accountText);
            this.Controls.Add(this.bankText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aadharText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mobileText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fhnameText);
            this.Controls.Add(this.F);
            this.Controls.Add(this.memnbernameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox memnbernameText;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.TextBox fhnameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mobileText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox aadharText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bankText;
        private System.Windows.Forms.TextBox accountText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ifscText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.RadioButton incentiveRadioButton;
        private System.Windows.Forms.RadioButton paymentRadioButton;
        private System.Windows.Forms.Label label10;
    }
}