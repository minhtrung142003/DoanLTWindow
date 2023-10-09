namespace Test
{
    partial class Bai07
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.Them = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtHoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTuoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Out = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btFile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tuổi";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(115, 320);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(191, 22);
            this.tbId.TabIndex = 44;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(115, 352);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(243, 22);
            this.tbName.TabIndex = 45;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(115, 386);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(191, 22);
            this.tbAge.TabIndex = 46;
            this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
            // 
            // Them
            // 
            this.Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Them.Location = new System.Drawing.Point(460, 323);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(75, 40);
            this.Them.TabIndex = 47;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Xoa.Location = new System.Drawing.Point(571, 323);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 40);
            this.Xoa.TabIndex = 48;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Edit.Location = new System.Drawing.Point(688, 323);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 40);
            this.Edit.TabIndex = 49;
            this.Edit.Text = "Sửa";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // ckGender
            // 
            this.ckGender.AutoSize = true;
            this.ckGender.Location = new System.Drawing.Point(144, 418);
            this.ckGender.Name = "ckGender";
            this.ckGender.Size = new System.Drawing.Size(58, 20);
            this.ckGender.TabIndex = 52;
            this.ckGender.Text = "Nam";
            this.ckGender.UseVisualStyleBackColor = true;
            this.ckGender.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.txtId,
            this.txtHoten,
            this.txtTuoi,
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(49, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(528, 222);
            this.listView1.TabIndex = 53;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Text = "Mã";
            // 
            // txtHoten
            // 
            this.txtHoten.Text = "Hoten";
            // 
            // txtTuoi
            // 
            this.txtTuoi.Text = "Tuoi";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Giới tính";
            // 
            // Out
            // 
            this.Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Out.Location = new System.Drawing.Point(502, 386);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(75, 40);
            this.Out.TabIndex = 54;
            this.Out.Text = "Thoát";
            this.Out.UseVisualStyleBackColor = true;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(641, 57);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(122, 152);
            this.btFile.TabIndex = 56;
            this.btFile.TabStop = false;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.button1.Location = new System.Drawing.Point(652, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 57;
            this.button1.Text = "Thêm ảnh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Reset.Location = new System.Drawing.Point(629, 386);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 40);
            this.Reset.TabIndex = 58;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click_1);
            // 
            // Bai07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai07";
            this.Text = "Bai07";
            this.Load += new System.EventHandler(this.Bai07_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader txtId;
        private System.Windows.Forms.ColumnHeader txtHoten;
        private System.Windows.Forms.ColumnHeader txtTuoi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button Out;
        private System.Windows.Forms.PictureBox btFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Reset;
    }
}