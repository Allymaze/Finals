﻿namespace KiddieCare
{
    partial class frmPayment
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtAmountPay = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.cboPaymentType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataListPayment = new System.Windows.Forms.DataGridView();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTimeSched = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbAfternun = new System.Windows.Forms.RadioButton();
            this.cmbGradeLvl = new System.Windows.Forms.ComboBox();
            this.rbMorning = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataListPayment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(505, 82);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 36);
            this.btnSearch.TabIndex = 66;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPay.Location = new System.Drawing.Point(237, 31);
            this.txtTotalPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(296, 34);
            this.txtTotalPay.TabIndex = 65;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label5.Location = new System.Drawing.Point(23, 38);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(168, 22);
            this.Label5.TabIndex = 64;
            this.Label5.Text = "Current Payment";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(256, 199);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(296, 34);
            this.txtLastname.TabIndex = 63;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label20.Location = new System.Drawing.Point(41, 206);
            this.Label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(107, 22);
            this.Label20.TabIndex = 62;
            this.Label20.Text = "Last Name";
            // 
            // txtMI
            // 
            this.txtMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMI.Location = new System.Drawing.Point(256, 161);
            this.txtMI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(296, 34);
            this.txtMI.TabIndex = 61;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label19.Location = new System.Drawing.Point(41, 169);
            this.Label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(132, 22);
            this.Label19.TabIndex = 60;
            this.Label19.Text = "Middle Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(256, 123);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 34);
            this.txtName.TabIndex = 59;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label4.Location = new System.Drawing.Point(41, 127);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(66, 22);
            this.Label4.TabIndex = 58;
            this.Label4.Text = "Name";
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSearch.Location = new System.Drawing.Point(256, 85);
            this.txtIDSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(240, 34);
            this.txtIDSearch.TabIndex = 57;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label3.Location = new System.Drawing.Point(41, 92);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(128, 22);
            this.Label3.TabIndex = 56;
            this.Label3.Text = "Search Id No";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(279, 241);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(259, 55);
            this.btnPay.TabIndex = 55;
            this.btnPay.Text = "Save / Settle Payment";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtAmountPay
            // 
            this.txtAmountPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPay.Location = new System.Drawing.Point(237, 69);
            this.txtAmountPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmountPay.Name = "txtAmountPay";
            this.txtAmountPay.Size = new System.Drawing.Size(296, 34);
            this.txtAmountPay.TabIndex = 54;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label2.Location = new System.Drawing.Point(23, 73);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(149, 22);
            this.Label2.TabIndex = 53;
            this.Label2.Text = "Amount to Pay";
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.Items.AddRange(new object[] {
            "Partial Payment",
            "Full Payment"});
            this.cboPaymentType.Location = new System.Drawing.Point(815, 32);
            this.cboPaymentType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.Size = new System.Drawing.Size(320, 33);
            this.cboPaymentType.TabIndex = 67;
            this.cboPaymentType.SelectedIndexChanged += new System.EventHandler(this.cboPaymentType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(609, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 22);
            this.label6.TabIndex = 68;
            this.label6.Text = "Type of payment";
            // 
            // dataListPayment
            // 
            this.dataListPayment.AllowUserToAddRows = false;
            this.dataListPayment.AllowUserToDeleteRows = false;
            this.dataListPayment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataListPayment.ColumnHeadersHeight = 30;
            this.dataListPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid,
            this.n,
            this.mi,
            this.lname,
            this.gl,
            this.s,
            this.ts,
            this.room,
            this.p,
            this.ap,
            this.Column1,
            this.r});
            this.dataListPayment.Location = new System.Drawing.Point(615, 74);
            this.dataListPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataListPayment.Name = "dataListPayment";
            this.dataListPayment.ReadOnly = true;
            this.dataListPayment.RowHeadersWidth = 51;
            this.dataListPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListPayment.Size = new System.Drawing.Size(1112, 572);
            this.dataListPayment.TabIndex = 80;
            this.dataListPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListPayment_CellContentClick);
            // 
            // sid
            // 
            this.sid.HeaderText = "ID Number";
            this.sid.MinimumWidth = 6;
            this.sid.Name = "sid";
            this.sid.ReadOnly = true;
            this.sid.Width = 200;
            // 
            // n
            // 
            this.n.HeaderText = "Name";
            this.n.MinimumWidth = 6;
            this.n.Name = "n";
            this.n.ReadOnly = true;
            this.n.Width = 200;
            // 
            // mi
            // 
            this.mi.HeaderText = "Middle Name";
            this.mi.MinimumWidth = 6;
            this.mi.Name = "mi";
            this.mi.ReadOnly = true;
            this.mi.Width = 125;
            // 
            // lname
            // 
            this.lname.HeaderText = "Last Name";
            this.lname.MinimumWidth = 6;
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            this.lname.Width = 200;
            // 
            // gl
            // 
            this.gl.HeaderText = "Grade level";
            this.gl.MinimumWidth = 6;
            this.gl.Name = "gl";
            this.gl.ReadOnly = true;
            this.gl.Width = 125;
            // 
            // s
            // 
            this.s.HeaderText = "Session";
            this.s.MinimumWidth = 6;
            this.s.Name = "s";
            this.s.ReadOnly = true;
            this.s.Width = 125;
            // 
            // ts
            // 
            this.ts.HeaderText = "Time schedule";
            this.ts.MinimumWidth = 6;
            this.ts.Name = "ts";
            this.ts.ReadOnly = true;
            this.ts.Width = 125;
            // 
            // room
            // 
            this.room.HeaderText = "Rooms";
            this.room.MinimumWidth = 6;
            this.room.Name = "room";
            this.room.ReadOnly = true;
            this.room.Width = 125;
            // 
            // p
            // 
            this.p.HeaderText = "Current Payment";
            this.p.MinimumWidth = 6;
            this.p.Name = "p";
            this.p.ReadOnly = true;
            this.p.Width = 200;
            // 
            // ap
            // 
            this.ap.HeaderText = "Balance Payment";
            this.ap.MinimumWidth = 6;
            this.ap.Name = "ap";
            this.ap.ReadOnly = true;
            this.ap.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cash";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // r
            // 
            this.r.HeaderText = "Status";
            this.r.MinimumWidth = 6;
            this.r.Name = "r";
            this.r.ReadOnly = true;
            this.r.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbRoom);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbTimeSched);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rbAfternun);
            this.groupBox1.Controls.Add(this.cmbGradeLvl);
            this.groupBox1.Controls.Add(this.rbMorning);
            this.groupBox1.Location = new System.Drawing.Point(19, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(569, 369);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(25, 254);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 22);
            this.label11.TabIndex = 88;
            this.label11.Text = "Session";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(25, 327);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 22);
            this.label10.TabIndex = 87;
            this.label10.Text = "Rooms";
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Items.AddRange(new object[] {
            "Room 1",
            "Room 2",
            "Room 3",
            "Room 4"});
            this.cmbRoom.Location = new System.Drawing.Point(240, 324);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(296, 33);
            this.cmbRoom.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(25, 289);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 22);
            this.label9.TabIndex = 85;
            this.label9.Text = "Time Schedule";
            // 
            // cmbTimeSched
            // 
            this.cmbTimeSched.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTimeSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimeSched.FormattingEnabled = true;
            this.cmbTimeSched.Location = new System.Drawing.Point(240, 286);
            this.cmbTimeSched.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTimeSched.Name = "cmbTimeSched";
            this.cmbTimeSched.Size = new System.Drawing.Size(296, 33);
            this.cmbTimeSched.TabIndex = 84;
            this.cmbTimeSched.SelectedIndexChanged += new System.EventHandler(this.cmbTimeSched_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(25, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 22);
            this.label8.TabIndex = 83;
            this.label8.Text = "Year Level";
            // 
            // rbAfternun
            // 
            this.rbAfternun.AutoSize = true;
            this.rbAfternun.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAfternun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbAfternun.Location = new System.Drawing.Point(412, 250);
            this.rbAfternun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAfternun.Name = "rbAfternun";
            this.rbAfternun.Size = new System.Drawing.Size(122, 25);
            this.rbAfternun.TabIndex = 1;
            this.rbAfternun.TabStop = true;
            this.rbAfternun.Text = "Afternoon";
            this.rbAfternun.UseVisualStyleBackColor = true;
            this.rbAfternun.Visible = false;
            this.rbAfternun.CheckedChanged += new System.EventHandler(this.rbAfternun_CheckedChanged);
            // 
            // cmbGradeLvl
            // 
            this.cmbGradeLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradeLvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGradeLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradeLvl.FormattingEnabled = true;
            this.cmbGradeLvl.Items.AddRange(new object[] {
            "Kinder I",
            "Kinder II",
            "Nursery"});
            this.cmbGradeLvl.Location = new System.Drawing.Point(237, 207);
            this.cmbGradeLvl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGradeLvl.Name = "cmbGradeLvl";
            this.cmbGradeLvl.Size = new System.Drawing.Size(296, 33);
            this.cmbGradeLvl.TabIndex = 82;
            // 
            // rbMorning
            // 
            this.rbMorning.AutoSize = true;
            this.rbMorning.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMorning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbMorning.Location = new System.Drawing.Point(237, 250);
            this.rbMorning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMorning.Name = "rbMorning";
            this.rbMorning.Size = new System.Drawing.Size(102, 25);
            this.rbMorning.TabIndex = 0;
            this.rbMorning.TabStop = true;
            this.rbMorning.Text = "Morning";
            this.rbMorning.UseVisualStyleBackColor = true;
            this.rbMorning.Visible = false;
            this.rbMorning.CheckedChanged += new System.EventHandler(this.rbMorning_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBook);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtCash);
            this.groupBox2.Controls.Add(this.btnPay);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtChange);
            this.groupBox2.Controls.Add(this.Label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTotalPay);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Controls.Add(this.txtAmountPay);
            this.groupBox2.Location = new System.Drawing.Point(19, 409);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(567, 313);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtBook
            // 
            this.txtBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBook.Location = new System.Drawing.Point(237, 107);
            this.txtBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(296, 34);
            this.txtBook.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(23, 114);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 22);
            this.label12.TabIndex = 76;
            this.label12.Text = "Books";
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(237, 145);
            this.txtCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(296, 34);
            this.txtCash.TabIndex = 75;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 74;
            this.label1.Text = "Cash";
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(237, 183);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(296, 34);
            this.txtChange.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(23, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 72;
            this.label7.Text = "Change";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(1365, 686);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(137, 34);
            this.txtRemarks.TabIndex = 76;
            this.txtRemarks.Visible = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Yellow;
            this.lblDiscount.Location = new System.Drawing.Point(1149, 34);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(178, 32);
            this.lblDiscount.TabIndex = 81;
            this.lblDiscount.Text = "10% Discount";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1512, 666);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 55);
            this.button1.TabIndex = 77;
            this.button1.Text = "Issue Receipt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(1419, 33);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 22);
            this.label13.TabIndex = 83;
            this.label13.Text = "School year";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(1560, 30);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(165, 33);
            this.cmbYear.TabIndex = 82;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1744, 745);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.dataListPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboPaymentType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtIDSearch);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListPayment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.TextBox txtTotalPay;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtLastname;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.TextBox txtMI;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtIDSearch;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnPay;
        internal System.Windows.Forms.TextBox txtAmountPay;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ComboBox cboPaymentType;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataListPayment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtCash;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtChange;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label lblDiscount;
        internal System.Windows.Forms.TextBox txtRemarks;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTimeSched;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbAfternun;
        private System.Windows.Forms.ComboBox cmbGradeLvl;
        private System.Windows.Forms.RadioButton rbMorning;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn mi;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gl;
        private System.Windows.Forms.DataGridViewTextBoxColumn s;
        private System.Windows.Forms.DataGridViewTextBoxColumn ts;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn p;
        private System.Windows.Forms.DataGridViewTextBoxColumn ap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn r;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.TextBox txtBook;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbYear;
    }
}