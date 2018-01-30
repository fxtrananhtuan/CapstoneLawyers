namespace CapstoneLawyers
{
    partial class Send_Email
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
            this.ckb_Cost = new System.Windows.Forms.CheckBox();
            this.ckb_Eng = new System.Windows.Forms.CheckBox();
            this.ckb_Dis = new System.Windows.Forms.CheckBox();
            this.cbk_Payment = new System.Windows.Forms.CheckBox();
            this.ckb_tax = new System.Windows.Forms.CheckBox();
            this.cmd_open = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckb_Cost
            // 
            this.ckb_Cost.AutoSize = true;
            this.ckb_Cost.Location = new System.Drawing.Point(19, 27);
            this.ckb_Cost.Name = "ckb_Cost";
            this.ckb_Cost.Size = new System.Drawing.Size(101, 17);
            this.ckb_Cost.TabIndex = 0;
            this.ckb_Cost.Text = "Cost Agreement";
            this.ckb_Cost.UseVisualStyleBackColor = true;
            this.ckb_Cost.CheckedChanged += new System.EventHandler(this.ckb_Cost_CheckedChanged);
            // 
            // ckb_Eng
            // 
            this.ckb_Eng.AutoSize = true;
            this.ckb_Eng.Location = new System.Drawing.Point(153, 27);
            this.ckb_Eng.Name = "ckb_Eng";
            this.ckb_Eng.Size = new System.Drawing.Size(116, 17);
            this.ckb_Eng.TabIndex = 0;
            this.ckb_Eng.Text = "Engagement Letter";
            this.ckb_Eng.UseVisualStyleBackColor = true;
            this.ckb_Eng.CheckedChanged += new System.EventHandler(this.ckb_Eng_CheckedChanged);
            // 
            // ckb_Dis
            // 
            this.ckb_Dis.AutoSize = true;
            this.ckb_Dis.Location = new System.Drawing.Point(19, 61);
            this.ckb_Dis.Name = "ckb_Dis";
            this.ckb_Dis.Size = new System.Drawing.Size(126, 17);
            this.ckb_Dis.TabIndex = 0;
            this.ckb_Dis.Text = "Disclosure Statement";
            this.ckb_Dis.UseVisualStyleBackColor = true;
            this.ckb_Dis.CheckedChanged += new System.EventHandler(this.ckb_Dis_CheckedChanged);
            // 
            // cbk_Payment
            // 
            this.cbk_Payment.AutoSize = true;
            this.cbk_Payment.Location = new System.Drawing.Point(153, 61);
            this.cbk_Payment.Name = "cbk_Payment";
            this.cbk_Payment.Size = new System.Drawing.Size(107, 17);
            this.cbk_Payment.TabIndex = 0;
            this.cbk_Payment.Text = "Payment Receipt";
            this.cbk_Payment.UseVisualStyleBackColor = true;
            this.cbk_Payment.CheckedChanged += new System.EventHandler(this.cbk_Payment_CheckedChanged);
            // 
            // ckb_tax
            // 
            this.ckb_tax.AutoSize = true;
            this.ckb_tax.Location = new System.Drawing.Point(292, 27);
            this.ckb_tax.Name = "ckb_tax";
            this.ckb_tax.Size = new System.Drawing.Size(82, 17);
            this.ckb_tax.TabIndex = 0;
            this.ckb_tax.Text = "Tax Invoice";
            this.ckb_tax.UseVisualStyleBackColor = true;
            this.ckb_tax.CheckedChanged += new System.EventHandler(this.ckb_tax_CheckedChanged);
            // 
            // cmd_open
            // 
            this.cmd_open.Location = new System.Drawing.Point(298, 122);
            this.cmd_open.Name = "cmd_open";
            this.cmd_open.Size = new System.Drawing.Size(111, 23);
            this.cmd_open.TabIndex = 1;
            this.cmd_open.Text = "Open OutLook";
            this.cmd_open.UseVisualStyleBackColor = true;
            this.cmd_open.Click += new System.EventHandler(this.cmd_open_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckb_Dis);
            this.groupBox1.Controls.Add(this.ckb_Cost);
            this.groupBox1.Controls.Add(this.cbk_Payment);
            this.groupBox1.Controls.Add(this.ckb_tax);
            this.groupBox1.Controls.Add(this.ckb_Eng);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose  Attachment ";
            // 
            // Send_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 160);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmd_open);
            this.Name = "Send_Email";
            this.Text = "Send Email";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ckb_Cost;
        private System.Windows.Forms.CheckBox ckb_Eng;
        private System.Windows.Forms.CheckBox ckb_Dis;
        private System.Windows.Forms.CheckBox cbk_Payment;
        private System.Windows.Forms.CheckBox ckb_tax;
        private System.Windows.Forms.Button cmd_open;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}