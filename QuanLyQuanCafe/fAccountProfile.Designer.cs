namespace QuanLyQuanCafe
{
    partial class fAccountProfile
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
            panel2 = new Panel();
            txbDisplayName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txbUserName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbPassWord = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbNewPass = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbReEnterPass = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbDisplayName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 66);
            panel2.TabIndex = 1;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(191, 17);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.ReadOnly = true;
            txbDisplayName.Size = new Size(525, 27);
            txbDisplayName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 20);
            label1.Name = "label1";
            label1.Size = new Size(152, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbUserName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(18, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 66);
            panel1.TabIndex = 2;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(191, 17);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(525, 27);
            txbUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 20);
            label2.Name = "label2";
            label2.Size = new Size(122, 24);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(18, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 66);
            panel3.TabIndex = 3;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(191, 17);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.ReadOnly = true;
            txbPassWord.Size = new Size(525, 27);
            txbPassWord.TabIndex = 1;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 20);
            label3.Name = "label3";
            label3.Size = new Size(97, 24);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            label3.Click += label3_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewPass);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(18, 228);
            panel4.Name = "panel4";
            panel4.Size = new Size(770, 66);
            panel4.TabIndex = 4;
            // 
            // txbNewPass
            // 
            txbNewPass.Location = new Point(191, 17);
            txbNewPass.Name = "txbNewPass";
            txbNewPass.ReadOnly = true;
            txbNewPass.Size = new Size(525, 27);
            txbNewPass.TabIndex = 1;
            txbNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 20);
            label4.Name = "label4";
            label4.Size = new Size(139, 24);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới";
            label4.Click += label4_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReEnterPass);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(18, 300);
            panel5.Name = "panel5";
            panel5.Size = new Size(770, 66);
            panel5.TabIndex = 5;
            // 
            // txbReEnterPass
            // 
            txbReEnterPass.Location = new Point(191, 17);
            txbReEnterPass.Name = "txbReEnterPass";
            txbReEnterPass.ReadOnly = true;
            txbReEnterPass.Size = new Size(525, 27);
            txbReEnterPass.TabIndex = 1;
            txbReEnterPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(33, 20);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(86, 24);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(412, 385);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(162, 53);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhập";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(591, 385);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(162, 53);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            Load += fAccountProfile_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txbDisplayName;
        private Label label1;
        private Panel panel1;
        private TextBox txbUserName;
        private Label label2;
        private Panel panel3;
        private TextBox txbPassWord;
        private Label label3;
        private Panel panel4;
        private TextBox txbNewPass;
        private Label label4;
        private Panel panel5;
        private TextBox txbReEnterPass;
        private Label label5;
        private Button btnUpdate;
        private Button btnExit;
    }
}