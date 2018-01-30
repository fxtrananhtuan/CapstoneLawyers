namespace CapstoneLawyers
{
    partial class Capstone_Lawyers
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
            this.components = new System.ComponentModel.Container();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.Matter_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matter_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gb_ClientDetail = new System.Windows.Forms.GroupBox();
            this.ckb_Hours = new System.Windows.Forms.CheckBox();
            this.cbx_suburb = new System.Windows.Forms.ComboBox();
            this.cbx_Status = new System.Windows.Forms.ComboBox();
            this.txt_comments = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Post_Code = new System.Windows.Forms.TextBox();
            this.txt_State = new System.Windows.Forms.TextBox();
            this.Txt_Phone = new System.Windows.Forms.TextBox();
            this.Txt_LName = new System.Windows.Forms.TextBox();
            this.txt_address2 = new System.Windows.Forms.TextBox();
            this.txt_address1 = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Disbursements = new System.Windows.Forms.TextBox();
            this.txt_GST = new System.Windows.Forms.TextBox();
            this.txt_Fees = new System.Windows.Forms.TextBox();
            this.txt_Matter_Des = new System.Windows.Forms.TextBox();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_Salutation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_MatterType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Error_Provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Ts_progess = new System.Windows.Forms.ToolStripStatusLabel();
            this.Cmd_OfficeAccountting = new System.Windows.Forms.Button();
            this.cmd_Time = new System.Windows.Forms.Button();
            this.cmd_OpenFloder = new System.Windows.Forms.Button();
            this.cmd_open = new System.Windows.Forms.Button();
            this.cmd_tax = new System.Windows.Forms.Button();
            this.cmd_Payment = new System.Windows.Forms.Button();
            this.cmd_Disclosure = new System.Windows.Forms.Button();
            this.cmd_Engagement = new System.Windows.Forms.Button();
            this.cmd_Cost_Agreement = new System.Windows.Forms.Button();
            this.cmd_delete = new System.Windows.Forms.Button();
            this.cmd_edit = new System.Windows.Forms.Button();
            this.cmd_save = new System.Windows.Forms.Button();
            this.cmd_create = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gb_ClientDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error_Provider)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Data
            // 
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matter_ID,
            this.FName,
            this.LName,
            this.Matter_Des,
            this.status});
            this.dgv_Data.Location = new System.Drawing.Point(6, 45);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(599, 541);
            this.dgv_Data.TabIndex = 1;
            this.dgv_Data.SelectionChanged += new System.EventHandler(this.dgv_Data_SelectionChanged);
            // 
            // Matter_ID
            // 
            this.Matter_ID.DataPropertyName = "Matter_ID";
            this.Matter_ID.HeaderText = "Matter No";
            this.Matter_ID.Name = "Matter_ID";
            this.Matter_ID.ReadOnly = true;
            // 
            // FName
            // 
            this.FName.DataPropertyName = "FirstName";
            this.FName.HeaderText = "First Name";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // LName
            // 
            this.LName.DataPropertyName = "LastName";
            this.LName.HeaderText = "Last Name";
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            // 
            // Matter_Des
            // 
            this.Matter_Des.DataPropertyName = "Matter_Des";
            this.Matter_Des.HeaderText = "Matter Description";
            this.Matter_Des.Name = "Matter_Des";
            this.Matter_Des.ReadOnly = true;
            this.Matter_Des.Width = 170;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_Search);
            this.groupBox1.Controls.Add(this.dgv_Data);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 598);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Customer";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(280, 16);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(236, 20);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.gb_ClientDetail);
            this.groupBox2.Controls.Add(this.cmd_create);
            this.groupBox2.Location = new System.Drawing.Point(637, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(701, 691);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create New Matter";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Cmd_OfficeAccountting);
            this.groupBox5.Controls.Add(this.cmd_Time);
            this.groupBox5.Location = new System.Drawing.Point(6, 625);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(689, 60);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmd_OpenFloder);
            this.groupBox4.Controls.Add(this.cmd_open);
            this.groupBox4.Controls.Add(this.cmd_tax);
            this.groupBox4.Controls.Add(this.cmd_Payment);
            this.groupBox4.Controls.Add(this.cmd_Disclosure);
            this.groupBox4.Controls.Add(this.cmd_Engagement);
            this.groupBox4.Controls.Add(this.cmd_Cost_Agreement);
            this.groupBox4.Location = new System.Drawing.Point(510, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 529);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Create Report";
            // 
            // gb_ClientDetail
            // 
            this.gb_ClientDetail.Controls.Add(this.ckb_Hours);
            this.gb_ClientDetail.Controls.Add(this.cbx_suburb);
            this.gb_ClientDetail.Controls.Add(this.cbx_Status);
            this.gb_ClientDetail.Controls.Add(this.cmd_delete);
            this.gb_ClientDetail.Controls.Add(this.cmd_edit);
            this.gb_ClientDetail.Controls.Add(this.cmd_save);
            this.gb_ClientDetail.Controls.Add(this.txt_comments);
            this.gb_ClientDetail.Controls.Add(this.label9);
            this.gb_ClientDetail.Controls.Add(this.txt_Post_Code);
            this.gb_ClientDetail.Controls.Add(this.txt_State);
            this.gb_ClientDetail.Controls.Add(this.Txt_Phone);
            this.gb_ClientDetail.Controls.Add(this.Txt_LName);
            this.gb_ClientDetail.Controls.Add(this.txt_address2);
            this.gb_ClientDetail.Controls.Add(this.txt_address1);
            this.gb_ClientDetail.Controls.Add(this.Txt_Email);
            this.gb_ClientDetail.Controls.Add(this.txt_Disbursements);
            this.gb_ClientDetail.Controls.Add(this.txt_GST);
            this.gb_ClientDetail.Controls.Add(this.txt_Fees);
            this.gb_ClientDetail.Controls.Add(this.txt_Matter_Des);
            this.gb_ClientDetail.Controls.Add(this.txt_FName);
            this.gb_ClientDetail.Controls.Add(this.label10);
            this.gb_ClientDetail.Controls.Add(this.label8);
            this.gb_ClientDetail.Controls.Add(this.label7);
            this.gb_ClientDetail.Controls.Add(this.label6);
            this.gb_ClientDetail.Controls.Add(this.label11);
            this.gb_ClientDetail.Controls.Add(this.label5);
            this.gb_ClientDetail.Controls.Add(this.label4);
            this.gb_ClientDetail.Controls.Add(this.label3);
            this.gb_ClientDetail.Controls.Add(this.cbx_Salutation);
            this.gb_ClientDetail.Controls.Add(this.label2);
            this.gb_ClientDetail.Controls.Add(this.cbx_MatterType);
            this.gb_ClientDetail.Controls.Add(this.label15);
            this.gb_ClientDetail.Controls.Add(this.label14);
            this.gb_ClientDetail.Controls.Add(this.label12);
            this.gb_ClientDetail.Controls.Add(this.label13);
            this.gb_ClientDetail.Controls.Add(this.label1);
            this.gb_ClientDetail.Location = new System.Drawing.Point(6, 92);
            this.gb_ClientDetail.Name = "gb_ClientDetail";
            this.gb_ClientDetail.Size = new System.Drawing.Size(498, 530);
            this.gb_ClientDetail.TabIndex = 4;
            this.gb_ClientDetail.TabStop = false;
            this.gb_ClientDetail.Text = "Client Detail";
            // 
            // ckb_Hours
            // 
            this.ckb_Hours.AutoSize = true;
            this.ckb_Hours.Location = new System.Drawing.Point(310, 445);
            this.ckb_Hours.Name = "ckb_Hours";
            this.ckb_Hours.Size = new System.Drawing.Size(122, 17);
            this.ckb_Hours.TabIndex = 19;
            this.ckb_Hours.Text = "Price to Hours Work";
            this.ckb_Hours.UseVisualStyleBackColor = true;
            this.ckb_Hours.CheckedChanged += new System.EventHandler(this.ckb_Hours_CheckedChanged);
            // 
            // cbx_suburb
            // 
            this.cbx_suburb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_suburb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_suburb.BackColor = System.Drawing.Color.White;
            this.cbx_suburb.ForeColor = System.Drawing.Color.Black;
            this.cbx_suburb.FormattingEnabled = true;
            this.cbx_suburb.Location = new System.Drawing.Point(129, 273);
            this.cbx_suburb.Name = "cbx_suburb";
            this.cbx_suburb.Size = new System.Drawing.Size(357, 21);
            this.cbx_suburb.TabIndex = 11;
            this.cbx_suburb.SelectedIndexChanged += new System.EventHandler(this.cbx_suburb_SelectedIndexChanged);
            // 
            // cbx_Status
            // 
            this.cbx_Status.BackColor = System.Drawing.Color.White;
            this.cbx_Status.FormattingEnabled = true;
            this.cbx_Status.Items.AddRange(new object[] {
            "Not Started",
            "In Progress",
            "Waiting",
            "Deferred",
            "Completed"});
            this.cbx_Status.Location = new System.Drawing.Point(129, 443);
            this.cbx_Status.Name = "cbx_Status";
            this.cbx_Status.Size = new System.Drawing.Size(121, 21);
            this.cbx_Status.TabIndex = 13;
            // 
            // txt_comments
            // 
            this.txt_comments.BackColor = System.Drawing.Color.White;
            this.txt_comments.Location = new System.Drawing.Point(129, 336);
            this.txt_comments.Name = "txt_comments";
            this.txt_comments.Size = new System.Drawing.Size(357, 96);
            this.txt_comments.TabIndex = 12;
            this.txt_comments.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "State";
            // 
            // txt_Post_Code
            // 
            this.txt_Post_Code.BackColor = System.Drawing.Color.White;
            this.txt_Post_Code.Location = new System.Drawing.Point(129, 301);
            this.txt_Post_Code.Name = "txt_Post_Code";
            this.txt_Post_Code.ReadOnly = true;
            this.txt_Post_Code.Size = new System.Drawing.Size(124, 20);
            this.txt_Post_Code.TabIndex = 17;
            // 
            // txt_State
            // 
            this.txt_State.BackColor = System.Drawing.Color.White;
            this.txt_State.Location = new System.Drawing.Point(317, 301);
            this.txt_State.Name = "txt_State";
            this.txt_State.ReadOnly = true;
            this.txt_State.Size = new System.Drawing.Size(168, 20);
            this.txt_State.TabIndex = 18;
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.BackColor = System.Drawing.Color.White;
            this.Txt_Phone.Location = new System.Drawing.Point(364, 180);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Size = new System.Drawing.Size(121, 20);
            this.Txt_Phone.TabIndex = 8;
            this.Txt_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Phone_KeyPress);
            // 
            // Txt_LName
            // 
            this.Txt_LName.BackColor = System.Drawing.Color.White;
            this.Txt_LName.Location = new System.Drawing.Point(364, 149);
            this.Txt_LName.Name = "Txt_LName";
            this.Txt_LName.Size = new System.Drawing.Size(121, 20);
            this.Txt_LName.TabIndex = 6;
            this.Txt_LName.TextChanged += new System.EventHandler(this.Txt_LName_TextChanged);
            // 
            // txt_address2
            // 
            this.txt_address2.BackColor = System.Drawing.Color.White;
            this.txt_address2.Location = new System.Drawing.Point(129, 242);
            this.txt_address2.Name = "txt_address2";
            this.txt_address2.Size = new System.Drawing.Size(357, 20);
            this.txt_address2.TabIndex = 10;
            // 
            // txt_address1
            // 
            this.txt_address1.BackColor = System.Drawing.Color.White;
            this.txt_address1.Location = new System.Drawing.Point(129, 211);
            this.txt_address1.Name = "txt_address1";
            this.txt_address1.Size = new System.Drawing.Size(357, 20);
            this.txt_address1.TabIndex = 9;
            // 
            // Txt_Email
            // 
            this.Txt_Email.BackColor = System.Drawing.Color.White;
            this.Txt_Email.Location = new System.Drawing.Point(129, 180);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(121, 20);
            this.Txt_Email.TabIndex = 7;
            this.Txt_Email.TextChanged += new System.EventHandler(this.Txt_Email_TextChanged);
            // 
            // txt_Disbursements
            // 
            this.txt_Disbursements.BackColor = System.Drawing.Color.White;
            this.txt_Disbursements.Location = new System.Drawing.Point(396, 86);
            this.txt_Disbursements.Name = "txt_Disbursements";
            this.txt_Disbursements.Size = new System.Drawing.Size(89, 20);
            this.txt_Disbursements.TabIndex = 3;
            this.txt_Disbursements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Disbursements.TextChanged += new System.EventHandler(this.txt_Disbursements_TextChanged);
            this.txt_Disbursements.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Fees_KeyPress);
            // 
            // txt_GST
            // 
            this.txt_GST.BackColor = System.Drawing.Color.White;
            this.txt_GST.Location = new System.Drawing.Point(256, 86);
            this.txt_GST.Name = "txt_GST";
            this.txt_GST.ReadOnly = true;
            this.txt_GST.Size = new System.Drawing.Size(52, 20);
            this.txt_GST.TabIndex = 16;
            this.txt_GST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Fees
            // 
            this.txt_Fees.BackColor = System.Drawing.Color.White;
            this.txt_Fees.Location = new System.Drawing.Point(129, 86);
            this.txt_Fees.Name = "txt_Fees";
            this.txt_Fees.Size = new System.Drawing.Size(80, 20);
            this.txt_Fees.TabIndex = 2;
            this.txt_Fees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Fees.TextChanged += new System.EventHandler(this.txt_Fees_TextChanged);
            this.txt_Fees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Fees_KeyPress);
            // 
            // txt_Matter_Des
            // 
            this.txt_Matter_Des.BackColor = System.Drawing.Color.White;
            this.txt_Matter_Des.ForeColor = System.Drawing.Color.Black;
            this.txt_Matter_Des.Location = new System.Drawing.Point(129, 55);
            this.txt_Matter_Des.Name = "txt_Matter_Des";
            this.txt_Matter_Des.Size = new System.Drawing.Size(356, 20);
            this.txt_Matter_Des.TabIndex = 1;
            this.txt_Matter_Des.TextChanged += new System.EventHandler(this.txt_Matter_Des_TextChanged);
            // 
            // txt_FName
            // 
            this.txt_FName.BackColor = System.Drawing.Color.White;
            this.txt_FName.Location = new System.Drawing.Point(129, 149);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(121, 20);
            this.txt_FName.TabIndex = 5;
            this.txt_FName.TextChanged += new System.EventHandler(this.txt_FName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "&Comments";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "&Post Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "&Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "&Phone Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 451);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "&Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "&Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&First Name";
            // 
            // cbx_Salutation
            // 
            this.cbx_Salutation.BackColor = System.Drawing.Color.White;
            this.cbx_Salutation.FormattingEnabled = true;
            this.cbx_Salutation.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms",
            "Miss",
            "Dr",
            "Prof",
            "Rev"});
            this.cbx_Salutation.Location = new System.Drawing.Point(129, 117);
            this.cbx_Salutation.Name = "cbx_Salutation";
            this.cbx_Salutation.Size = new System.Drawing.Size(121, 21);
            this.cbx_Salutation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salutation";
            // 
            // cbx_MatterType
            // 
            this.cbx_MatterType.BackColor = System.Drawing.Color.White;
            this.cbx_MatterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MatterType.FormattingEnabled = true;
            this.cbx_MatterType.Items.AddRange(new object[] {
            "Family",
            "Commercial",
            "Immigration",
            "Conveyance ",
            "Other"});
            this.cbx_MatterType.Location = new System.Drawing.Point(129, 23);
            this.cbx_MatterType.Name = "cbx_MatterType";
            this.cbx_MatterType.Size = new System.Drawing.Size(236, 21);
            this.cbx_MatterType.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(314, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Disbursements";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(221, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "GST";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Fees";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Matter Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matter Description";
            // 
            // Error_Provider
            // 
            this.Error_Provider.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ts_progess});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Ts_progess
            // 
            this.Ts_progess.Name = "Ts_progess";
            this.Ts_progess.Size = new System.Drawing.Size(26, 17);
            this.Ts_progess.Text = "text";
            // 
            // Cmd_OfficeAccountting
            // 
            this.Cmd_OfficeAccountting.Image = global::CapstoneLawyers.Properties.Resources.accounting1;
            this.Cmd_OfficeAccountting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cmd_OfficeAccountting.Location = new System.Drawing.Point(544, 13);
            this.Cmd_OfficeAccountting.Name = "Cmd_OfficeAccountting";
            this.Cmd_OfficeAccountting.Size = new System.Drawing.Size(133, 38);
            this.Cmd_OfficeAccountting.TabIndex = 1;
            this.Cmd_OfficeAccountting.Text = "Office Accounting";
            this.Cmd_OfficeAccountting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cmd_OfficeAccountting.UseVisualStyleBackColor = true;
            // 
            // cmd_Time
            // 
            this.cmd_Time.Image = global::CapstoneLawyers.Properties.Resources.Time;
            this.cmd_Time.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_Time.Location = new System.Drawing.Point(6, 13);
            this.cmd_Time.Name = "cmd_Time";
            this.cmd_Time.Size = new System.Drawing.Size(117, 38);
            this.cmd_Time.TabIndex = 0;
            this.cmd_Time.Text = "Time And Fees";
            this.cmd_Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_Time.UseVisualStyleBackColor = true;
            this.cmd_Time.Click += new System.EventHandler(this.cmd_Time_Click);
            // 
            // cmd_OpenFloder
            // 
            this.cmd_OpenFloder.Image = global::CapstoneLawyers.Properties.Resources.folder1;
            this.cmd_OpenFloder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_OpenFloder.Location = new System.Drawing.Point(14, 456);
            this.cmd_OpenFloder.Name = "cmd_OpenFloder";
            this.cmd_OpenFloder.Size = new System.Drawing.Size(159, 56);
            this.cmd_OpenFloder.TabIndex = 5;
            this.cmd_OpenFloder.Text = "Open Folder";
            this.cmd_OpenFloder.UseVisualStyleBackColor = true;
            this.cmd_OpenFloder.Click += new System.EventHandler(this.cmd_OpenFloder_Click);
            // 
            // cmd_open
            // 
            this.cmd_open.Image = global::CapstoneLawyers.Properties.Resources.outlook;
            this.cmd_open.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_open.Location = new System.Drawing.Point(14, 387);
            this.cmd_open.Name = "cmd_open";
            this.cmd_open.Size = new System.Drawing.Size(159, 56);
            this.cmd_open.TabIndex = 4;
            this.cmd_open.Text = "Open Outlook";
            this.cmd_open.UseVisualStyleBackColor = true;
            this.cmd_open.Click += new System.EventHandler(this.cmd_open_Click);
            // 
            // cmd_tax
            // 
            this.cmd_tax.Image = global::CapstoneLawyers.Properties.Resources.Invoice;
            this.cmd_tax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_tax.Location = new System.Drawing.Point(14, 316);
            this.cmd_tax.Name = "cmd_tax";
            this.cmd_tax.Size = new System.Drawing.Size(159, 56);
            this.cmd_tax.TabIndex = 4;
            this.cmd_tax.Text = "Tax Invoice";
            this.cmd_tax.UseVisualStyleBackColor = true;
            this.cmd_tax.Click += new System.EventHandler(this.cmd_tax_Click);
            // 
            // cmd_Payment
            // 
            this.cmd_Payment.Image = global::CapstoneLawyers.Properties.Resources.Payment;
            this.cmd_Payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_Payment.Location = new System.Drawing.Point(14, 241);
            this.cmd_Payment.Name = "cmd_Payment";
            this.cmd_Payment.Size = new System.Drawing.Size(159, 56);
            this.cmd_Payment.TabIndex = 3;
            this.cmd_Payment.Text = "Create Payment ";
            this.cmd_Payment.UseVisualStyleBackColor = true;
            this.cmd_Payment.Click += new System.EventHandler(this.cmd_Payment_Click);
            // 
            // cmd_Disclosure
            // 
            this.cmd_Disclosure.Image = global::CapstoneLawyers.Properties.Resources.Disclosure;
            this.cmd_Disclosure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_Disclosure.Location = new System.Drawing.Point(14, 170);
            this.cmd_Disclosure.Name = "cmd_Disclosure";
            this.cmd_Disclosure.Size = new System.Drawing.Size(159, 56);
            this.cmd_Disclosure.TabIndex = 2;
            this.cmd_Disclosure.Text = "Disclosure Statement";
            this.cmd_Disclosure.UseVisualStyleBackColor = true;
            this.cmd_Disclosure.Click += new System.EventHandler(this.cmd_Disclosure_Click);
            // 
            // cmd_Engagement
            // 
            this.cmd_Engagement.Image = global::CapstoneLawyers.Properties.Resources.Engagement;
            this.cmd_Engagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_Engagement.Location = new System.Drawing.Point(14, 97);
            this.cmd_Engagement.Name = "cmd_Engagement";
            this.cmd_Engagement.Size = new System.Drawing.Size(159, 56);
            this.cmd_Engagement.TabIndex = 1;
            this.cmd_Engagement.Text = "Engagement Letter";
            this.cmd_Engagement.UseVisualStyleBackColor = true;
            this.cmd_Engagement.Click += new System.EventHandler(this.cmd_Engagement_Click);
            // 
            // cmd_Cost_Agreement
            // 
            this.cmd_Cost_Agreement.Image = global::CapstoneLawyers.Properties.Resources.Cost;
            this.cmd_Cost_Agreement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_Cost_Agreement.Location = new System.Drawing.Point(14, 31);
            this.cmd_Cost_Agreement.Name = "cmd_Cost_Agreement";
            this.cmd_Cost_Agreement.Size = new System.Drawing.Size(159, 56);
            this.cmd_Cost_Agreement.TabIndex = 0;
            this.cmd_Cost_Agreement.Text = "Cost Agreement";
            this.cmd_Cost_Agreement.UseVisualStyleBackColor = true;
            this.cmd_Cost_Agreement.Click += new System.EventHandler(this.cmd_Cost_Agreement_Click);
            // 
            // cmd_delete
            // 
            this.cmd_delete.Image = global::CapstoneLawyers.Properties.Resources.bin;
            this.cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_delete.Location = new System.Drawing.Point(411, 474);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(73, 38);
            this.cmd_delete.TabIndex = 15;
            this.cmd_delete.Text = "&Delete";
            this.cmd_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_delete.UseVisualStyleBackColor = true;
            this.cmd_delete.Click += new System.EventHandler(this.cmd_delete_Click);
            // 
            // cmd_edit
            // 
            this.cmd_edit.Image = global::CapstoneLawyers.Properties.Resources.Edit;
            this.cmd_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_edit.Location = new System.Drawing.Point(273, 474);
            this.cmd_edit.Name = "cmd_edit";
            this.cmd_edit.Size = new System.Drawing.Size(80, 38);
            this.cmd_edit.TabIndex = 15;
            this.cmd_edit.Text = "&Edit";
            this.cmd_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_edit.UseVisualStyleBackColor = true;
            this.cmd_edit.Click += new System.EventHandler(this.cmd_edit_Click);
            // 
            // cmd_save
            // 
            this.cmd_save.Image = global::CapstoneLawyers.Properties.Resources.Save;
            this.cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_save.Location = new System.Drawing.Point(129, 474);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(89, 38);
            this.cmd_save.TabIndex = 14;
            this.cmd_save.Text = "&Save";
            this.cmd_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_save.UseVisualStyleBackColor = true;
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // cmd_create
            // 
            this.cmd_create.Image = global::CapstoneLawyers.Properties.Resources.Add_New;
            this.cmd_create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_create.Location = new System.Drawing.Point(6, 30);
            this.cmd_create.Name = "cmd_create";
            this.cmd_create.Size = new System.Drawing.Size(154, 56);
            this.cmd_create.TabIndex = 0;
            this.cmd_create.Text = "Create New Matter";
            this.cmd_create.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_create.UseVisualStyleBackColor = true;
            this.cmd_create.Click += new System.EventHandler(this.cmd_create_Click);
            // 
            // btn_search
            // 
            this.btn_search.Image = global::CapstoneLawyers.Properties.Resources.Search;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(522, 11);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 28);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapstoneLawyers.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Capstone_Lawyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Capstone_Lawyers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capstone_Lawyers";
            this.Load += new System.EventHandler(this.Capstone_Lawyers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gb_ClientDetail.ResumeLayout(false);
            this.gb_ClientDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error_Provider)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmd_create;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gb_ClientDetail;
        private System.Windows.Forms.TextBox Txt_Phone;
        private System.Windows.Forms.TextBox Txt_LName;
        private System.Windows.Forms.TextBox txt_address2;
        private System.Windows.Forms.TextBox txt_address1;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_Salutation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_State;
        private System.Windows.Forms.Button cmd_save;
        private System.Windows.Forms.RichTextBox txt_comments;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmd_edit;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cmd_Cost_Agreement;
        private System.Windows.Forms.ComboBox cbx_Status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmd_Engagement;
        private System.Windows.Forms.Button cmd_Disclosure;
        private System.Windows.Forms.Button cmd_tax;
        private System.Windows.Forms.Button cmd_Payment;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Cmd_OfficeAccountting;
        private System.Windows.Forms.Button cmd_Time;
        private System.Windows.Forms.TextBox txt_Fees;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button cmd_OpenFloder;
        private System.Windows.Forms.TextBox txt_Disbursements;
        private System.Windows.Forms.TextBox txt_GST;
        private System.Windows.Forms.TextBox txt_Matter_Des;
        private System.Windows.Forms.ComboBox cbx_MatterType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Post_Code;
        private System.Windows.Forms.ComboBox cbx_suburb;
        private System.Windows.Forms.ErrorProvider Error_Provider;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Ts_progess;
        private System.Windows.Forms.Button cmd_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matter_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matter_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.CheckBox ckb_Hours;
        private System.Windows.Forms.Button cmd_open;
    }
}