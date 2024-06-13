namespace KiddieCare
{
    partial class frmGradeLvlMaintenance
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
            this.btnDel = new System.Windows.Forms.Button();
            this.txtGradeLvl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddLvl = new System.Windows.Forms.Button();
            this.listGradeLvl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDel.Location = new System.Drawing.Point(76, 345);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(104, 49);
            this.btnDel.TabIndex = 119;
            this.btnDel.Text = "Update";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtGradeLvl
            // 
            this.txtGradeLvl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeLvl.Location = new System.Drawing.Point(159, 18);
            this.txtGradeLvl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGradeLvl.Name = "txtGradeLvl";
            this.txtGradeLvl.Size = new System.Drawing.Size(247, 32);
            this.txtGradeLvl.TabIndex = 118;
            this.txtGradeLvl.TextChanged += new System.EventHandler(this.txtGradeLvl_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 117;
            this.label2.Text = "Year Level";
            // 
            // btnAddLvl
            // 
            this.btnAddLvl.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddLvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLvl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddLvl.Location = new System.Drawing.Point(188, 345);
            this.btnAddLvl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddLvl.Name = "btnAddLvl";
            this.btnAddLvl.Size = new System.Drawing.Size(105, 49);
            this.btnAddLvl.TabIndex = 116;
            this.btnAddLvl.Text = "Save";
            this.btnAddLvl.UseVisualStyleBackColor = false;
            this.btnAddLvl.Click += new System.EventHandler(this.btnAddLvl_Click);
            // 
            // listGradeLvl
            // 
            this.listGradeLvl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.gr});
            this.listGradeLvl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listGradeLvl.FullRowSelect = true;
            this.listGradeLvl.GridLines = true;
            this.listGradeLvl.HideSelection = false;
            this.listGradeLvl.Location = new System.Drawing.Point(20, 63);
            this.listGradeLvl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listGradeLvl.Name = "listGradeLvl";
            this.listGradeLvl.Size = new System.Drawing.Size(385, 274);
            this.listGradeLvl.TabIndex = 115;
            this.listGradeLvl.UseCompatibleStateImageBehavior = false;
            this.listGradeLvl.View = System.Windows.Forms.View.Details;
            this.listGradeLvl.SelectedIndexChanged += new System.EventHandler(this.listGradeLvl_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 0;
            // 
            // gr
            // 
            this.gr.DisplayIndex = 0;
            this.gr.Text = "Grade level";
            this.gr.Width = 280;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.txtGradeLvl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAddLvl);
            this.panel1.Controls.Add(this.listGradeLvl);
            this.panel1.Location = new System.Drawing.Point(15, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 413);
            this.panel1.TabIndex = 120;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(301, 345);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 49);
            this.btnClear.TabIndex = 120;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // frmGradeLvlMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(457, 442);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGradeLvlMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Year Level";
            this.Load += new System.EventHandler(this.frmGradeLvlMaintenance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtGradeLvl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddLvl;
        private System.Windows.Forms.ListView listGradeLvl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader gr;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnClear;
    }
}