namespace Test
{
    partial class bai04
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
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_Faculty
            // 
            this.cb_Faculty.FormattingEnabled = true;
            this.cb_Faculty.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Điện ",
            "Cơ khí",
            "Cơ khí động lực",
            "Quản trị kinh doanh",
            "Ngoại ngữ",
            "Kế toán"});
            this.cb_Faculty.Location = new System.Drawing.Point(175, 40);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(238, 21);
            this.cb_Faculty.TabIndex = 0;
            this.cb_Faculty.SelectedIndexChanged += new System.EventHandler(this.cb_Faculty_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(324, 139);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbDisplay.Location = new System.Drawing.Point(175, 79);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(238, 20);
            this.tbDisplay.TabIndex = 3;
            this.tbDisplay.TextChanged += new System.EventHandler(this.tbDisplay_TextChanged);
            // 
            // bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_Faculty);
            this.Name = "bai04";
            this.Text = "bai04";
            this.Load += new System.EventHandler(this.bai04_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbDisplay;
    }
}