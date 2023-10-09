namespace Test
{
    partial class bai02
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
            this.label4 = new System.Windows.Forms.Label();
            this.SonguyenX = new System.Windows.Forms.TextBox();
            this.SonguyenY = new System.Windows.Forms.TextBox();
            this.Ketqua = new System.Windows.Forms.TextBox();
            this.Cong = new System.Windows.Forms.Button();
            this.Nhan = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.Tru = new System.Windows.Forms.Button();
            this.Chia = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(62, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(62, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(62, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SonguyenX
            // 
            this.SonguyenX.Location = new System.Drawing.Point(139, 89);
            this.SonguyenX.Name = "SonguyenX";
            this.SonguyenX.Size = new System.Drawing.Size(199, 20);
            this.SonguyenX.TabIndex = 4;
            this.SonguyenX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SonguyenY
            // 
            this.SonguyenY.Location = new System.Drawing.Point(139, 133);
            this.SonguyenY.Name = "SonguyenY";
            this.SonguyenY.Size = new System.Drawing.Size(199, 20);
            this.SonguyenY.TabIndex = 5;
            // 
            // Ketqua
            // 
            this.Ketqua.Location = new System.Drawing.Point(139, 175);
            this.Ketqua.Name = "Ketqua";
            this.Ketqua.Size = new System.Drawing.Size(199, 20);
            this.Ketqua.TabIndex = 6;
            // 
            // Cong
            // 
            this.Cong.Location = new System.Drawing.Point(23, 235);
            this.Cong.Name = "Cong";
            this.Cong.Size = new System.Drawing.Size(75, 23);
            this.Cong.TabIndex = 7;
            this.Cong.Text = "Cộng";
            this.Cong.UseVisualStyleBackColor = true;
            this.Cong.Click += new System.EventHandler(this.Cong_Click);
            // 
            // Nhan
            // 
            this.Nhan.Location = new System.Drawing.Point(233, 235);
            this.Nhan.Name = "Nhan";
            this.Nhan.Size = new System.Drawing.Size(75, 23);
            this.Nhan.TabIndex = 8;
            this.Nhan.Text = "Nhân";
            this.Nhan.UseVisualStyleBackColor = true;
            this.Nhan.Click += new System.EventHandler(this.Nhan_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(255, 298);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(83, 43);
            this.reset.TabIndex = 10;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Tru
            // 
            this.Tru.Location = new System.Drawing.Point(128, 235);
            this.Tru.Name = "Tru";
            this.Tru.Size = new System.Drawing.Size(75, 23);
            this.Tru.TabIndex = 11;
            this.Tru.Text = "Trừ";
            this.Tru.UseVisualStyleBackColor = true;
            this.Tru.Click += new System.EventHandler(this.Tru_Click);
            // 
            // Chia
            // 
            this.Chia.Location = new System.Drawing.Point(339, 235);
            this.Chia.Name = "Chia";
            this.Chia.Size = new System.Drawing.Size(75, 23);
            this.Chia.TabIndex = 12;
            this.Chia.Text = "Chia";
            this.Chia.UseVisualStyleBackColor = true;
            this.Chia.Click += new System.EventHandler(this.Chia_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(120, 298);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(83, 43);
            this.exit.TabIndex = 13;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Chia);
            this.Controls.Add(this.Tru);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.Nhan);
            this.Controls.Add(this.Cong);
            this.Controls.Add(this.Ketqua);
            this.Controls.Add(this.SonguyenY);
            this.Controls.Add(this.SonguyenX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bai02";
            this.Text = "bai02";
            this.Load += new System.EventHandler(this.bai02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SonguyenX;
        private System.Windows.Forms.TextBox SonguyenY;
        private System.Windows.Forms.TextBox Ketqua;
        private System.Windows.Forms.Button Cong;
        private System.Windows.Forms.Button Nhan;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button Tru;
        private System.Windows.Forms.Button Chia;
        private System.Windows.Forms.Button exit;
    }
}