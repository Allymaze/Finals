namespace KiddieCare
{
    partial class frmListEnrolless
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
            this.cmbSy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrdelvl = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.enrolleesList = new System.Windows.Forms.ListView();
            this.eID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tSched = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.t = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dEnroll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSy
            // 
            this.cmbSy.BackColor = System.Drawing.Color.White;
            this.cmbSy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSy.FormattingEnabled = true;
            this.cmbSy.Location = new System.Drawing.Point(175, 47);
            this.cmbSy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSy.Name = "cmbSy";
            this.cmbSy.Size = new System.Drawing.Size(309, 31);
            this.cmbSy.TabIndex = 0;
            this.cmbSy.SelectedIndexChanged += new System.EventHandler(this.cmbSy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "School year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year Level";
            // 
            // cmbGrdelvl
            // 
            this.cmbGrdelvl.BackColor = System.Drawing.Color.White;
            this.cmbGrdelvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrdelvl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGrdelvl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrdelvl.FormattingEnabled = true;
            this.cmbGrdelvl.Location = new System.Drawing.Point(175, 90);
            this.cmbGrdelvl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGrdelvl.Name = "cmbGrdelvl";
            this.cmbGrdelvl.Size = new System.Drawing.Size(309, 31);
            this.cmbGrdelvl.TabIndex = 2;
            this.cmbGrdelvl.SelectedIndexChanged += new System.EventHandler(this.cmbGrdelvl_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Section";
            // 
            // cmbSection
            // 
            this.cmbSection.BackColor = System.Drawing.Color.White;
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(175, 133);
            this.cmbSection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(309, 31);
            this.cmbSection.TabIndex = 4;
            this.cmbSection.SelectedIndexChanged += new System.EventHandler(this.cmbSection_SelectedIndexChanged);
            // 
            // enrolleesList
            // 
            this.enrolleesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eID,
            this.sID,
            this.sName,
            this.tSched,
            this.r,
            this.t,
            this.dEnroll});
            this.enrolleesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enrolleesList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrolleesList.FullRowSelect = true;
            this.enrolleesList.GridLines = true;
            this.enrolleesList.HideSelection = false;
            this.enrolleesList.Location = new System.Drawing.Point(0, 0);
            this.enrolleesList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enrolleesList.Name = "enrolleesList";
            this.enrolleesList.Size = new System.Drawing.Size(1647, 482);
            this.enrolleesList.TabIndex = 112;
            this.enrolleesList.UseCompatibleStateImageBehavior = false;
            this.enrolleesList.View = System.Windows.Forms.View.Details;
            // 
            // eID
            // 
            this.eID.Text = "Enrollment ID";
            this.eID.Width = 200;
            // 
            // sID
            // 
            this.sID.Text = "Student ID";
            this.sID.Width = 200;
            // 
            // sName
            // 
            this.sName.Text = "Student Complete Name";
            this.sName.Width = 280;
            // 
            // tSched
            // 
            this.tSched.Text = "Time schedule";
            this.tSched.Width = 320;
            // 
            // r
            // 
            this.r.Text = "Room";
            this.r.Width = 150;
            // 
            // t
            // 
            this.t.Text = "Teacher";
            this.t.Width = 280;
            // 
            // dEnroll
            // 
            this.dEnroll.Text = "Date enrolled";
            this.dEnroll.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.enrolleesList);
            this.panel1.Location = new System.Drawing.Point(1, 247);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1647, 482);
            this.panel1.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(573, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(568, 39);
            this.label4.TabIndex = 115;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(611, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 31);
            this.label5.TabIndex = 116;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1648, 25);
            this.panel2.TabIndex = 117;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(20, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 21);
            this.label6.TabIndex = 118;
            this.label6.Text = "Search by name";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(209, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(371, 34);
            this.btnSearch.TabIndex = 119;
            this.btnSearch.TextChanged += new System.EventHandler(this.btnSearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(1, 187);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1645, 62);
            this.panel3.TabIndex = 118;
            // 
            // frmListEnrolless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1648, 730);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGrdelvl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListEnrolless";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmListEnrolless_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrdelvl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.ListView enrolleesList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader eID;
        private System.Windows.Forms.ColumnHeader sID;
        private System.Windows.Forms.ColumnHeader sName;
        private System.Windows.Forms.ColumnHeader tSched;
        private System.Windows.Forms.ColumnHeader r;
        private System.Windows.Forms.ColumnHeader t;
        private System.Windows.Forms.ColumnHeader dEnroll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox btnSearch;
        private System.Windows.Forms.Panel panel3;
    }
}