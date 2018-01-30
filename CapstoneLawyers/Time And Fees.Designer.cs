namespace CapstoneLawyers
{
    partial class Time_And_Fees
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
            this.tab_Hours = new System.Windows.Forms.TabControl();
            this.tab_Fixedprice = new System.Windows.Forms.TabPage();
            this.lbl_total = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmd_delete = new System.Windows.Forms.Button();
            this.cmd_new = new System.Windows.Forms.Button();
            this.cmd_edit = new System.Windows.Forms.Button();
            this.txt_desF = new System.Windows.Forms.RichTextBox();
            this.cmd_save = new System.Windows.Forms.Button();
            this.dtp_F = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Fixed = new System.Windows.Forms.DataGridView();
            this.tab_ByHours = new System.Windows.Forms.TabPage();
            this.lbl_TotalH = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmd_newH = new System.Windows.Forms.Button();
            this.txt_Hours = new System.Windows.Forms.TextBox();
            this.cmd_DeleteH = new System.Windows.Forms.Button();
            this.cmd_EditH = new System.Windows.Forms.Button();
            this.txt_desH = new System.Windows.Forms.RichTextBox();
            this.cmd_saveH = new System.Windows.Forms.Button();
            this.dtp_H = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_hours = new System.Windows.Forms.DataGridView();
            this.tab_Hours.SuspendLayout();
            this.tab_Fixedprice.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fixed)).BeginInit();
            this.tab_ByHours.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hours)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Hours
            // 
            this.tab_Hours.Controls.Add(this.tab_Fixedprice);
            this.tab_Hours.Controls.Add(this.tab_ByHours);
            this.tab_Hours.Location = new System.Drawing.Point(12, 12);
            this.tab_Hours.Name = "tab_Hours";
            this.tab_Hours.SelectedIndex = 0;
            this.tab_Hours.Size = new System.Drawing.Size(777, 329);
            this.tab_Hours.TabIndex = 0;
            // 
            // tab_Fixedprice
            // 
            this.tab_Fixedprice.Controls.Add(this.lbl_total);
            this.tab_Fixedprice.Controls.Add(this.groupBox2);
            this.tab_Fixedprice.Controls.Add(this.groupBox1);
            this.tab_Fixedprice.Location = new System.Drawing.Point(4, 22);
            this.tab_Fixedprice.Name = "tab_Fixedprice";
            this.tab_Fixedprice.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Fixedprice.Size = new System.Drawing.Size(769, 303);
            this.tab_Fixedprice.TabIndex = 0;
            this.tab_Fixedprice.Text = "Fixed price";
            this.tab_Fixedprice.UseVisualStyleBackColor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(8, 278);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(78, 16);
            this.lbl_total.TabIndex = 2;
            this.lbl_total.Text = "Total Cost : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Amount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmd_delete);
            this.groupBox2.Controls.Add(this.cmd_new);
            this.groupBox2.Controls.Add(this.cmd_edit);
            this.groupBox2.Controls.Add(this.txt_desF);
            this.groupBox2.Controls.Add(this.cmd_save);
            this.groupBox2.Controls.Add(this.dtp_F);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(423, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 245);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculation";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(76, 153);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(242, 20);
            this.txt_Amount.TabIndex = 21;
            this.txt_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Amount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Amount";
            // 
            // cmd_delete
            // 
            this.cmd_delete.Image = global::CapstoneLawyers.Properties.Resources.bin;
            this.cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_delete.Location = new System.Drawing.Point(245, 188);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(73, 38);
            this.cmd_delete.TabIndex = 18;
            this.cmd_delete.Text = "&Delete";
            this.cmd_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_delete.UseVisualStyleBackColor = true;
            this.cmd_delete.Click += new System.EventHandler(this.cmd_delete_Click);
            // 
            // cmd_new
            // 
            this.cmd_new.Image = global::CapstoneLawyers.Properties.Resources.news;
            this.cmd_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_new.Location = new System.Drawing.Point(18, 188);
            this.cmd_new.Name = "cmd_new";
            this.cmd_new.Size = new System.Drawing.Size(67, 38);
            this.cmd_new.TabIndex = 17;
            this.cmd_new.Text = "&New";
            this.cmd_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_new.UseVisualStyleBackColor = true;
            this.cmd_new.Click += new System.EventHandler(this.cmd_new_Click);
            // 
            // cmd_edit
            // 
            this.cmd_edit.Image = global::CapstoneLawyers.Properties.Resources.Edit;
            this.cmd_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_edit.Location = new System.Drawing.Point(91, 188);
            this.cmd_edit.Name = "cmd_edit";
            this.cmd_edit.Size = new System.Drawing.Size(67, 38);
            this.cmd_edit.TabIndex = 17;
            this.cmd_edit.Text = "&Edit";
            this.cmd_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_edit.UseVisualStyleBackColor = true;
            this.cmd_edit.Click += new System.EventHandler(this.cmd_edit_Click);
            // 
            // txt_desF
            // 
            this.txt_desF.Location = new System.Drawing.Point(76, 74);
            this.txt_desF.Name = "txt_desF";
            this.txt_desF.Size = new System.Drawing.Size(242, 68);
            this.txt_desF.TabIndex = 2;
            this.txt_desF.Text = "";
            // 
            // cmd_save
            // 
            this.cmd_save.Image = global::CapstoneLawyers.Properties.Resources.Save;
            this.cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_save.Location = new System.Drawing.Point(164, 188);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(75, 38);
            this.cmd_save.TabIndex = 16;
            this.cmd_save.Text = "&Save";
            this.cmd_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_save.UseVisualStyleBackColor = true;
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // dtp_F
            // 
            this.dtp_F.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_F.Location = new System.Drawing.Point(201, 33);
            this.dtp_F.Name = "dtp_F";
            this.dtp_F.Size = new System.Drawing.Size(117, 20);
            this.dtp_F.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Fixed);
            this.groupBox1.Location = new System.Drawing.Point(6, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professional Fees";
            // 
            // dgv_Fixed
            // 
            this.dgv_Fixed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Fixed.Location = new System.Drawing.Point(6, 20);
            this.dgv_Fixed.Name = "dgv_Fixed";
            this.dgv_Fixed.ReadOnly = true;
            this.dgv_Fixed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Fixed.Size = new System.Drawing.Size(399, 219);
            this.dgv_Fixed.TabIndex = 0;
            this.dgv_Fixed.SelectionChanged += new System.EventHandler(this.dgv_Fixed_SelectionChanged);
            // 
            // tab_ByHours
            // 
            this.tab_ByHours.Controls.Add(this.lbl_TotalH);
            this.tab_ByHours.Controls.Add(this.groupBox3);
            this.tab_ByHours.Controls.Add(this.groupBox4);
            this.tab_ByHours.Location = new System.Drawing.Point(4, 22);
            this.tab_ByHours.Name = "tab_ByHours";
            this.tab_ByHours.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ByHours.Size = new System.Drawing.Size(769, 303);
            this.tab_ByHours.TabIndex = 1;
            this.tab_ByHours.Text = "By Hours";
            this.tab_ByHours.UseVisualStyleBackColor = true;
            // 
            // lbl_TotalH
            // 
            this.lbl_TotalH.AutoSize = true;
            this.lbl_TotalH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalH.Location = new System.Drawing.Point(9, 276);
            this.lbl_TotalH.Name = "lbl_TotalH";
            this.lbl_TotalH.Size = new System.Drawing.Size(78, 16);
            this.lbl_TotalH.TabIndex = 1;
            this.lbl_TotalH.Text = "Total Cost : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmd_newH);
            this.groupBox3.Controls.Add(this.txt_Hours);
            this.groupBox3.Controls.Add(this.cmd_DeleteH);
            this.groupBox3.Controls.Add(this.cmd_EditH);
            this.groupBox3.Controls.Add(this.txt_desH);
            this.groupBox3.Controls.Add(this.cmd_saveH);
            this.groupBox3.Controls.Add(this.dtp_H);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(424, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 245);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculation";
            // 
            // cmd_newH
            // 
            this.cmd_newH.Image = global::CapstoneLawyers.Properties.Resources.news;
            this.cmd_newH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_newH.Location = new System.Drawing.Point(18, 188);
            this.cmd_newH.Name = "cmd_newH";
            this.cmd_newH.Size = new System.Drawing.Size(67, 38);
            this.cmd_newH.TabIndex = 20;
            this.cmd_newH.Text = "&New";
            this.cmd_newH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_newH.UseVisualStyleBackColor = true;
            this.cmd_newH.Click += new System.EventHandler(this.cmd_newH_Click);
            // 
            // txt_Hours
            // 
            this.txt_Hours.Location = new System.Drawing.Point(79, 135);
            this.txt_Hours.Name = "txt_Hours";
            this.txt_Hours.Size = new System.Drawing.Size(239, 20);
            this.txt_Hours.TabIndex = 19;
            this.txt_Hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Amount_KeyPress);
            // 
            // cmd_DeleteH
            // 
            this.cmd_DeleteH.Image = global::CapstoneLawyers.Properties.Resources.bin;
            this.cmd_DeleteH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_DeleteH.Location = new System.Drawing.Point(245, 188);
            this.cmd_DeleteH.Name = "cmd_DeleteH";
            this.cmd_DeleteH.Size = new System.Drawing.Size(73, 38);
            this.cmd_DeleteH.TabIndex = 18;
            this.cmd_DeleteH.Text = "&Delete";
            this.cmd_DeleteH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_DeleteH.UseVisualStyleBackColor = true;
            this.cmd_DeleteH.Click += new System.EventHandler(this.cmd_DeleteH_Click);
            // 
            // cmd_EditH
            // 
            this.cmd_EditH.Image = global::CapstoneLawyers.Properties.Resources.Edit;
            this.cmd_EditH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_EditH.Location = new System.Drawing.Point(165, 188);
            this.cmd_EditH.Name = "cmd_EditH";
            this.cmd_EditH.Size = new System.Drawing.Size(68, 38);
            this.cmd_EditH.TabIndex = 17;
            this.cmd_EditH.Text = "&Edit";
            this.cmd_EditH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_EditH.UseVisualStyleBackColor = true;
            this.cmd_EditH.Click += new System.EventHandler(this.cmd_EditH_Click);
            // 
            // txt_desH
            // 
            this.txt_desH.Location = new System.Drawing.Point(79, 62);
            this.txt_desH.Name = "txt_desH";
            this.txt_desH.Size = new System.Drawing.Size(239, 63);
            this.txt_desH.TabIndex = 2;
            this.txt_desH.Text = "";
            // 
            // cmd_saveH
            // 
            this.cmd_saveH.Image = global::CapstoneLawyers.Properties.Resources.Save;
            this.cmd_saveH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_saveH.Location = new System.Drawing.Point(92, 188);
            this.cmd_saveH.Name = "cmd_saveH";
            this.cmd_saveH.Size = new System.Drawing.Size(67, 38);
            this.cmd_saveH.TabIndex = 16;
            this.cmd_saveH.Text = "&Save";
            this.cmd_saveH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_saveH.UseVisualStyleBackColor = true;
            this.cmd_saveH.Click += new System.EventHandler(this.cmd_saveH_Click);
            // 
            // dtp_H
            // 
            this.dtp_H.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_H.Location = new System.Drawing.Point(79, 32);
            this.dtp_H.Name = "dtp_H";
            this.dtp_H.Size = new System.Drawing.Size(122, 20);
            this.dtp_H.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_hours);
            this.groupBox4.Location = new System.Drawing.Point(7, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 245);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Professional Fees";
            // 
            // dgv_hours
            // 
            this.dgv_hours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hours.Location = new System.Drawing.Point(6, 20);
            this.dgv_hours.Name = "dgv_hours";
            this.dgv_hours.ReadOnly = true;
            this.dgv_hours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hours.Size = new System.Drawing.Size(399, 219);
            this.dgv_hours.TabIndex = 0;
            this.dgv_hours.SelectionChanged += new System.EventHandler(this.dgv_hours_SelectionChanged);
            // 
            // Time_And_Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 344);
            this.Controls.Add(this.tab_Hours);
            this.Name = "Time_And_Fees";
            this.Text = "Time And Fees";
            this.Load += new System.EventHandler(this.Time_And_Fees_Load);
            this.tab_Hours.ResumeLayout(false);
            this.tab_Fixedprice.ResumeLayout(false);
            this.tab_Fixedprice.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fixed)).EndInit();
            this.tab_ByHours.ResumeLayout(false);
            this.tab_ByHours.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Hours;
        private System.Windows.Forms.TabPage tab_Fixedprice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txt_desF;
        private System.Windows.Forms.DateTimePicker dtp_F;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tab_ByHours;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmd_delete;
        private System.Windows.Forms.Button cmd_edit;
        private System.Windows.Forms.Button cmd_save;
        private System.Windows.Forms.DataGridView dgv_Fixed;
        private System.Windows.Forms.Label lbl_TotalH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Hours;
        private System.Windows.Forms.Button cmd_DeleteH;
        private System.Windows.Forms.Button cmd_EditH;
        private System.Windows.Forms.RichTextBox txt_desH;
        private System.Windows.Forms.Button cmd_saveH;
        private System.Windows.Forms.DateTimePicker dtp_H;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_hours;
        private System.Windows.Forms.Button cmd_new;
        private System.Windows.Forms.Button cmd_newH;
    }
}