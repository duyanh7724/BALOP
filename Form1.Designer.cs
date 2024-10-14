namespace GUI
{
    partial class Form1
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.picAvata = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(418, 62);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 62;
            this.dgvStudent.RowTemplate.Height = 28;
            this.dgvStudent.Size = new System.Drawing.Size(445, 425);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(712, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(151, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "chua dang ki CN";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(122, 62);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(180, 26);
            this.txtMaSV.TabIndex = 2;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(122, 211);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(152, 26);
            this.txtDTB.TabIndex = 3;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(122, 111);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(180, 26);
            this.txtTenSV.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add/Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(243, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 54);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // picAvata
            // 
            this.picAvata.Location = new System.Drawing.Point(289, 349);
            this.picAvata.Name = "picAvata";
            this.picAvata.Size = new System.Drawing.Size(42, 24);
            this.picAvata.TabIndex = 12;
            this.picAvata.Text = "...";
            this.picAvata.UseVisualStyleBackColor = true;
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(122, 321);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(131, 76);
            this.pic.TabIndex = 13;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chucNangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 33);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.chucNangToolStripMenuItem.Text = "Chuc Nang";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(122, 153);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(180, 28);
            this.cmbFaculty.TabIndex = 16;
            // 
            // cmbMajor
            // 
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Location = new System.Drawing.Point(122, 262);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(180, 28);
            this.cmbMajor.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 512);
            this.Controls.Add(this.cmbMajor);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.picAvata);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button picAvata;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.ComboBox cmbMajor;
    }
}

