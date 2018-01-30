namespace CapstoneLawyers
{
    partial class Payment
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
            this.txt_ReceiptNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_payemnt = new System.Windows.Forms.GroupBox();
            this.cmd_edit = new System.Windows.Forms.Button();
            this.cmd_save = new System.Windows.Forms.Button();
            this.txt_GST = new System.Windows.Forms.TextBox();
            this.txt_Balance = new System.Windows.Forms.TextBox();
            this.txt_Payment = new System.Windows.Forms.TextBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.cmd_Payment = new System.Windows.Forms.Button();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_payemnt.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ReceiptNo
            // 
            this.txt_ReceiptNo.BackColor = System.Drawing.Color.White;
            this.txt_ReceiptNo.Location = new System.Drawing.Point(73, 34);
            this.txt_ReceiptNo.Name = "txt_ReceiptNo";
            this.txt_ReceiptNo.ReadOnly = true;
            this.txt_ReceiptNo.Size = new System.Drawing.Size(100, 20);
            this.txt_ReceiptNo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receipt No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "GST";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Payment Received";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "BALANCE DUE";
            // 
            // gb_payemnt
            // 
            this.gb_payemnt.Controls.Add(this.cmd_Payment);
            this.gb_payemnt.Controls.Add(this.cmd_edit);
            this.gb_payemnt.Controls.Add(this.cmd_save);
            this.gb_payemnt.Controls.Add(this.label1);
            this.gb_payemnt.Controls.Add(this.label5);
            this.gb_payemnt.Controls.Add(this.txt_GST);
            this.gb_payemnt.Controls.Add(this.label6);
            this.gb_payemnt.Controls.Add(this.label4);
            this.gb_payemnt.Controls.Add(this.txt_Balance);
            this.gb_payemnt.Controls.Add(this.txt_Description);
            this.gb_payemnt.Controls.Add(this.txt_Payment);
            this.gb_payemnt.Controls.Add(this.txt_Amount);
            this.gb_payemnt.Controls.Add(this.txt_ReceiptNo);
            this.gb_payemnt.Controls.Add(this.label3);
            this.gb_payemnt.Controls.Add(this.label2);
            this.gb_payemnt.Location = new System.Drawing.Point(12, 12);
            this.gb_payemnt.Name = "gb_payemnt";
            this.gb_payemnt.Size = new System.Drawing.Size(337, 282);
            this.gb_payemnt.TabIndex = 2;
            this.gb_payemnt.TabStop = false;
            this.gb_payemnt.Text = "Payment Information";
            // 
            // cmd_edit
            // 
            this.cmd_edit.Image = global::CapstoneLawyers.Properties.Resources.Edit;
            this.cmd_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_edit.Location = new System.Drawing.Point(9, 238);
            this.cmd_edit.Name = "cmd_edit";
            this.cmd_edit.Size = new System.Drawing.Size(80, 38);
            this.cmd_edit.TabIndex = 4;
            this.cmd_edit.Text = "&Edit";
            this.cmd_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_edit.UseVisualStyleBackColor = true;
            this.cmd_edit.Click += new System.EventHandler(this.cmd_edit_Click);
            // 
            // cmd_save
            // 
            this.cmd_save.Image = global::CapstoneLawyers.Properties.Resources.Save;
            this.cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_save.Location = new System.Drawing.Point(118, 238);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(89, 38);
            this.cmd_save.TabIndex = 3;
            this.cmd_save.Text = "&Save";
            this.cmd_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_save.UseVisualStyleBackColor = true;
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // txt_GST
            // 
            this.txt_GST.BackColor = System.Drawing.Color.White;
            this.txt_GST.Location = new System.Drawing.Point(226, 73);
            this.txt_GST.Name = "txt_GST";
            this.txt_GST.ReadOnly = true;
            this.txt_GST.Size = new System.Drawing.Size(100, 20);
            this.txt_GST.TabIndex = 7;
            this.txt_GST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Amount_KeyPress);
            // 
            // txt_Balance
            // 
            this.txt_Balance.BackColor = System.Drawing.Color.White;
            this.txt_Balance.Location = new System.Drawing.Point(109, 189);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.ReadOnly = true;
            this.txt_Balance.Size = new System.Drawing.Size(217, 20);
            this.txt_Balance.TabIndex = 8;
            // 
            // txt_Payment
            // 
            this.txt_Payment.BackColor = System.Drawing.Color.White;
            this.txt_Payment.Location = new System.Drawing.Point(109, 150);
            this.txt_Payment.Name = "txt_Payment";
            this.txt_Payment.ReadOnly = true;
            this.txt_Payment.Size = new System.Drawing.Size(217, 20);
            this.txt_Payment.TabIndex = 2;
            this.txt_Payment.TextChanged += new System.EventHandler(this.txt_Payment_TextChanged);
            // 
            // txt_Amount
            // 
            this.txt_Amount.BackColor = System.Drawing.Color.White;
            this.txt_Amount.Location = new System.Drawing.Point(73, 73);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.ReadOnly = true;
            this.txt_Amount.Size = new System.Drawing.Size(100, 20);
            this.txt_Amount.TabIndex = 0;
            this.txt_Amount.TextChanged += new System.EventHandler(this.txt_Amount_TextChanged);
            this.txt_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Amount_KeyPress);
            // 
            // cmd_Payment
            // 
            this.cmd_Payment.Image = global::CapstoneLawyers.Properties.Resources.Payment;
            this.cmd_Payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_Payment.Location = new System.Drawing.Point(236, 238);
            this.cmd_Payment.Name = "cmd_Payment";
            this.cmd_Payment.Size = new System.Drawing.Size(90, 38);
            this.cmd_Payment.TabIndex = 5;
            this.cmd_Payment.Text = "Receipt";
            this.cmd_Payment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_Payment.UseVisualStyleBackColor = true;
            this.cmd_Payment.Click += new System.EventHandler(this.cmd_Payment_Click);
            // 
            // txt_Description
            // 
            this.txt_Description.BackColor = System.Drawing.Color.White;
            this.txt_Description.Location = new System.Drawing.Point(73, 111);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ReadOnly = true;
            this.txt_Description.Size = new System.Drawing.Size(253, 20);
            this.txt_Description.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Description";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 306);
            this.Controls.Add(this.gb_payemnt);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.gb_payemnt.ResumeLayout(false);
            this.gb_payemnt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ReceiptNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_payemnt;
        private System.Windows.Forms.TextBox txt_GST;
        private System.Windows.Forms.TextBox txt_Balance;
        private System.Windows.Forms.TextBox txt_Payment;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Button cmd_save;
        private System.Windows.Forms.Button cmd_edit;
        private System.Windows.Forms.Button cmd_Payment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Description;
    }
}