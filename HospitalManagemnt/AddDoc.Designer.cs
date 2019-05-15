namespace HospitalManagemnt
{
    partial class AddDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDoc));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.step1TabPage = new System.Windows.Forms.TabPage();
            this.btn_Back = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.password2TextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordcontrolLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.step2TabPage = new System.Windows.Forms.TabPage();
            this.close2Button = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_DocID = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.DocIDTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.step1TabPage.SuspendLayout();
            this.step2TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.step1TabPage);
            this.tabControl.Controls.Add(this.step2TabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1578, 670);
            this.tabControl.TabIndex = 1;
            // 
            // step1TabPage
            // 
            this.step1TabPage.Controls.Add(this.btn_Back);
            this.step1TabPage.Controls.Add(this.closeButton);
            this.step1TabPage.Controls.Add(this.continueButton);
            this.step1TabPage.Controls.Add(this.userNameTextBox);
            this.step1TabPage.Controls.Add(this.passwordTextBox);
            this.step1TabPage.Controls.Add(this.emailTextBox);
            this.step1TabPage.Controls.Add(this.password2TextBox);
            this.step1TabPage.Controls.Add(this.emailLabel);
            this.step1TabPage.Controls.Add(this.passwordcontrolLabel);
            this.step1TabPage.Controls.Add(this.passwordLabel);
            this.step1TabPage.Controls.Add(this.usernameLabel);
            this.step1TabPage.Controls.Add(this.label9);
            this.step1TabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step1TabPage.Location = new System.Drawing.Point(4, 25);
            this.step1TabPage.Margin = new System.Windows.Forms.Padding(4);
            this.step1TabPage.Name = "step1TabPage";
            this.step1TabPage.Padding = new System.Windows.Forms.Padding(4);
            this.step1TabPage.Size = new System.Drawing.Size(1570, 641);
            this.step1TabPage.TabIndex = 0;
            this.step1TabPage.Text = "Step 1";
            this.step1TabPage.UseVisualStyleBackColor = true;
            this.step1TabPage.Click += new System.EventHandler(this.step1TabPage_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(32, 535);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(145, 57);
            this.btn_Back.TabIndex = 107;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(780, 13);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(43, 38);
            this.closeButton.TabIndex = 5;
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // continueButton
            // 
            this.continueButton.FlatAppearance.BorderSize = 0;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.continueButton.Image = ((System.Drawing.Image)(resources.GetObject("continueButton.Image")));
            this.continueButton.Location = new System.Drawing.Point(653, 549);
            this.continueButton.Margin = new System.Windows.Forms.Padding(4);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(124, 26);
            this.continueButton.TabIndex = 4;
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameTextBox.Location = new System.Drawing.Point(336, 144);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(173, 41);
            this.userNameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.Location = new System.Drawing.Point(336, 228);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(173, 41);
            this.passwordTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailTextBox.Location = new System.Drawing.Point(336, 386);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(173, 41);
            this.emailTextBox.TabIndex = 3;
            // 
            // password2TextBox
            // 
            this.password2TextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password2TextBox.Location = new System.Drawing.Point(336, 312);
            this.password2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.password2TextBox.Name = "password2TextBox";
            this.password2TextBox.Size = new System.Drawing.Size(173, 41);
            this.password2TextBox.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(35, 388);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(111, 32);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "E-mail:";
            // 
            // passwordcontrolLabel
            // 
            this.passwordcontrolLabel.AutoSize = true;
            this.passwordcontrolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordcontrolLabel.Location = new System.Drawing.Point(35, 315);
            this.passwordcontrolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordcontrolLabel.Name = "passwordcontrolLabel";
            this.passwordcontrolLabel.Size = new System.Drawing.Size(156, 32);
            this.passwordcontrolLabel.TabIndex = 3;
            this.passwordcontrolLabel.Text = "Password:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(35, 231);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(156, 32);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(35, 147);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(162, 32);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(35, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(433, 47);
            this.label9.TabIndex = 0;
            this.label9.Text = "LOGIN INFORMATION";
            // 
            // step2TabPage
            // 
            this.step2TabPage.Controls.Add(this.close2Button);
            this.step2TabPage.Controls.Add(this.previousButton);
            this.step2TabPage.Controls.Add(this.label8);
            this.step2TabPage.Controls.Add(this.label4);
            this.step2TabPage.Controls.Add(this.lbl_DocID);
            this.step2TabPage.Controls.Add(this.saveButton);
            this.step2TabPage.Controls.Add(this.label2);
            this.step2TabPage.Controls.Add(this.label3);
            this.step2TabPage.Controls.Add(this.deptComboBox);
            this.step2TabPage.Controls.Add(this.addressTextBox);
            this.step2TabPage.Controls.Add(this.phoneTextBox);
            this.step2TabPage.Controls.Add(this.label6);
            this.step2TabPage.Controls.Add(this.label7);
            this.step2TabPage.Controls.Add(this.txt_Name);
            this.step2TabPage.Controls.Add(this.DocIDTextBox);
            this.step2TabPage.Controls.Add(this.surnameTextBox);
            this.step2TabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step2TabPage.Location = new System.Drawing.Point(4, 25);
            this.step2TabPage.Margin = new System.Windows.Forms.Padding(4);
            this.step2TabPage.Name = "step2TabPage";
            this.step2TabPage.Padding = new System.Windows.Forms.Padding(4);
            this.step2TabPage.Size = new System.Drawing.Size(1570, 641);
            this.step2TabPage.TabIndex = 1;
            this.step2TabPage.Text = "Step 2";
            this.step2TabPage.UseVisualStyleBackColor = true;
            this.step2TabPage.Click += new System.EventHandler(this.step2TabPage_Click);
            // 
            // close2Button
            // 
            this.close2Button.BackColor = System.Drawing.Color.White;
            this.close2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close2Button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.close2Button.FlatAppearance.BorderSize = 0;
            this.close2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close2Button.Image = ((System.Drawing.Image)(resources.GetObject("close2Button.Image")));
            this.close2Button.Location = new System.Drawing.Point(802, 18);
            this.close2Button.Margin = new System.Windows.Forms.Padding(4);
            this.close2Button.Name = "close2Button";
            this.close2Button.Size = new System.Drawing.Size(43, 38);
            this.close2Button.TabIndex = 24;
            this.close2Button.UseVisualStyleBackColor = false;
            // 
            // previousButton
            // 
            this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousButton.Image = ((System.Drawing.Image)(resources.GetObject("previousButton.Image")));
            this.previousButton.Location = new System.Drawing.Point(28, 555);
            this.previousButton.Margin = new System.Windows.Forms.Padding(4);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 49);
            this.previousButton.TabIndex = 7;
            this.previousButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(39, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(473, 47);
            this.label8.TabIndex = 2;
            this.label8.Text = "DOCTOR INFORMATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(42, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 34);
            this.label4.TabIndex = 17;
            this.label4.Text = "Name:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_DocID
            // 
            this.lbl_DocID.AutoSize = true;
            this.lbl_DocID.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DocID.Location = new System.Drawing.Point(42, 109);
            this.lbl_DocID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DocID.Name = "lbl_DocID";
            this.lbl_DocID.Size = new System.Drawing.Size(142, 34);
            this.lbl_DocID.TabIndex = 17;
            this.lbl_DocID.Text = "Doctor ID";
            this.lbl_DocID.Click += new System.EventHandler(this.label1_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Location = new System.Drawing.Point(750, 571);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 61);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 34);
            this.label3.TabIndex = 19;
            this.label3.Text = "Department:";
            // 
            // deptComboBox
            // 
            this.deptComboBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(371, 313);
            this.deptComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(168, 41);
            this.deptComboBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addressTextBox.Location = new System.Drawing.Point(371, 471);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(168, 62);
            this.addressTextBox.TabIndex = 4;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneTextBox.Location = new System.Drawing.Point(371, 397);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(168, 41);
            this.phoneTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(42, 397);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 34);
            this.label6.TabIndex = 2;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(42, 471);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 34);
            this.label7.TabIndex = 23;
            this.label7.Text = "Address:";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Name.Location = new System.Drawing.Point(371, 175);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(168, 41);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // DocIDTextBox
            // 
            this.DocIDTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DocIDTextBox.Location = new System.Drawing.Point(371, 109);
            this.DocIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DocIDTextBox.Name = "DocIDTextBox";
            this.DocIDTextBox.Size = new System.Drawing.Size(168, 41);
            this.DocIDTextBox.TabIndex = 0;
            this.DocIDTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameTextBox.Location = new System.Drawing.Point(371, 239);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(168, 41);
            this.surnameTextBox.TabIndex = 1;
            // 
            // AddDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1578, 670);
            this.Controls.Add(this.tabControl);
            this.Name = "AddDoc";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddDoc_Load);
            this.tabControl.ResumeLayout(false);
            this.step1TabPage.ResumeLayout(false);
            this.step1TabPage.PerformLayout();
            this.step2TabPage.ResumeLayout(false);
            this.step2TabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage step1TabPage;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox password2TextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordcontrolLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage step2TabPage;
        private System.Windows.Forms.Button close2Button;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_DocID;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DocIDTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Back;
    }
}

