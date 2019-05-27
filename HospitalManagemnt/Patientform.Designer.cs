namespace HospitalManagemnt
{
    partial class Patientform
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
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label ssnLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label birth_placeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label birth_dateLabel;
            System.Windows.Forms.Label father_nameLabel;
            System.Windows.Forms.Label lbl_Seriousness;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label lbl_bloodgroup;
            this.tabControl = new System.Windows.Forms.TabControl();
            this.step1TabPage = new System.Windows.Forms.TabPage();
            this.comboBox_bloodgroup = new System.Windows.Forms.ComboBox();
            this.comboBox_Seriousness = new System.Windows.Forms.ComboBox();
            this.txtbx_Complaint = new System.Windows.Forms.TextBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Complaint = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.ssnTextBox1 = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.step2TabPage = new System.Windows.Forms.TabPage();
            this.btn_Back = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.father_nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.birth_placeTextBox = new System.Windows.Forms.TextBox();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.inspectionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.birth_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            surnameLabel = new System.Windows.Forms.Label();
            ssnLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            birth_placeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            birth_dateLabel = new System.Windows.Forms.Label();
            father_nameLabel = new System.Windows.Forms.Label();
            lbl_Seriousness = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            lbl_bloodgroup = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.step1TabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.step2TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            surnameLabel.Location = new System.Drawing.Point(60, 391);
            surnameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(143, 34);
            surnameLabel.TabIndex = 114;
            surnameLabel.Text = "Surname:";
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ssnLabel.Location = new System.Drawing.Point(60, 253);
            ssnLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new System.Drawing.Size(67, 34);
            ssnLabel.TabIndex = 112;
            ssnLabel.Text = "Ssn:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(60, 325);
            nameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(106, 34);
            nameLabel.TabIndex = 108;
            nameLabel.Text = "Name:";
            // 
            // birth_placeLabel
            // 
            birth_placeLabel.AutoSize = true;
            birth_placeLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birth_placeLabel.Location = new System.Drawing.Point(77, 177);
            birth_placeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            birth_placeLabel.Name = "birth_placeLabel";
            birth_placeLabel.Size = new System.Drawing.Size(167, 34);
            birth_placeLabel.TabIndex = 144;
            birth_placeLabel.Text = "Birth place:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(77, 311);
            phoneLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(109, 34);
            phoneLabel.TabIndex = 151;
            phoneLabel.Text = "Phone:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(674, 122);
            addressLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(131, 34);
            addressLabel.TabIndex = 146;
            addressLabel.Text = "Address:";
            // 
            // birth_dateLabel
            // 
            birth_dateLabel.AutoSize = true;
            birth_dateLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birth_dateLabel.Location = new System.Drawing.Point(77, 114);
            birth_dateLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            birth_dateLabel.Name = "birth_dateLabel";
            birth_dateLabel.Size = new System.Drawing.Size(150, 34);
            birth_dateLabel.TabIndex = 142;
            birth_dateLabel.Text = "Birth date:";
            // 
            // father_nameLabel
            // 
            father_nameLabel.AutoSize = true;
            father_nameLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            father_nameLabel.Location = new System.Drawing.Point(77, 243);
            father_nameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            father_nameLabel.Name = "father_nameLabel";
            father_nameLabel.Size = new System.Drawing.Size(193, 34);
            father_nameLabel.TabIndex = 148;
            father_nameLabel.Text = "Father name:";
            // 
            // lbl_Seriousness
            // 
            lbl_Seriousness.AutoSize = true;
            lbl_Seriousness.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Seriousness.Location = new System.Drawing.Point(623, 260);
            lbl_Seriousness.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            lbl_Seriousness.Name = "lbl_Seriousness";
            lbl_Seriousness.Size = new System.Drawing.Size(178, 34);
            lbl_Seriousness.TabIndex = 158;
            lbl_Seriousness.Text = "Seriousness:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexLabel.Location = new System.Drawing.Point(60, 452);
            sexLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(72, 34);
            sexLabel.TabIndex = 110;
            sexLabel.Text = "Sex:";
            // 
            // lbl_bloodgroup
            // 
            lbl_bloodgroup.AutoSize = true;
            lbl_bloodgroup.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_bloodgroup.Location = new System.Drawing.Point(60, 516);
            lbl_bloodgroup.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            lbl_bloodgroup.Name = "lbl_bloodgroup";
            lbl_bloodgroup.Size = new System.Drawing.Size(109, 68);
            lbl_bloodgroup.TabIndex = 160;
            lbl_bloodgroup.Text = "Blood\r\nGroup:";
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
            this.tabControl.Size = new System.Drawing.Size(1195, 700);
            this.tabControl.TabIndex = 107;
            // 
            // step1TabPage
            // 
            this.step1TabPage.Controls.Add(this.button1);
            this.step1TabPage.Controls.Add(lbl_bloodgroup);
            this.step1TabPage.Controls.Add(this.comboBox_bloodgroup);
            this.step1TabPage.Controls.Add(this.comboBox_Seriousness);
            this.step1TabPage.Controls.Add(this.txtbx_Complaint);
            this.step1TabPage.Controls.Add(this.doctorComboBox);
            this.step1TabPage.Controls.Add(lbl_Seriousness);
            this.step1TabPage.Controls.Add(this.label3);
            this.step1TabPage.Controls.Add(this.lbl_Complaint);
            this.step1TabPage.Controls.Add(nameLabel);
            this.step1TabPage.Controls.Add(this.nameTextBox);
            this.step1TabPage.Controls.Add(sexLabel);
            this.step1TabPage.Controls.Add(this.sexComboBox);
            this.step1TabPage.Controls.Add(ssnLabel);
            this.step1TabPage.Controls.Add(this.ssnTextBox1);
            this.step1TabPage.Controls.Add(surnameLabel);
            this.step1TabPage.Controls.Add(this.surnameTextBox);
            this.step1TabPage.Controls.Add(this.groupBox1);
            this.step1TabPage.Controls.Add(this.label10);
            this.step1TabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step1TabPage.Location = new System.Drawing.Point(4, 41);
            this.step1TabPage.Margin = new System.Windows.Forms.Padding(4);
            this.step1TabPage.Name = "step1TabPage";
            this.step1TabPage.Padding = new System.Windows.Forms.Padding(4);
            this.step1TabPage.Size = new System.Drawing.Size(1187, 655);
            this.step1TabPage.TabIndex = 0;
            this.step1TabPage.Text = "Step 1";
            this.step1TabPage.UseVisualStyleBackColor = true;
            // 
            // comboBox_bloodgroup
            // 
            this.comboBox_bloodgroup.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_bloodgroup.FormattingEnabled = true;
            this.comboBox_bloodgroup.Location = new System.Drawing.Point(236, 532);
            this.comboBox_bloodgroup.Margin = new System.Windows.Forms.Padding(8);
            this.comboBox_bloodgroup.Name = "comboBox_bloodgroup";
            this.comboBox_bloodgroup.Size = new System.Drawing.Size(269, 41);
            this.comboBox_bloodgroup.TabIndex = 161;
            // 
            // comboBox_Seriousness
            // 
            this.comboBox_Seriousness.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Seriousness.FormattingEnabled = true;
            this.comboBox_Seriousness.Items.AddRange(new object[] {
            "Normal",
            "Serious",
            "Very Serious"});
            this.comboBox_Seriousness.Location = new System.Drawing.Point(844, 260);
            this.comboBox_Seriousness.Name = "comboBox_Seriousness";
            this.comboBox_Seriousness.Size = new System.Drawing.Size(269, 41);
            this.comboBox_Seriousness.TabIndex = 159;
            // 
            // txtbx_Complaint
            // 
            this.txtbx_Complaint.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Complaint.Location = new System.Drawing.Point(844, 430);
            this.txtbx_Complaint.Margin = new System.Windows.Forms.Padding(8);
            this.txtbx_Complaint.Multiline = true;
            this.txtbx_Complaint.Name = "txtbx_Complaint";
            this.txtbx_Complaint.Size = new System.Drawing.Size(269, 122);
            this.txtbx_Complaint.TabIndex = 157;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(844, 344);
            this.doctorComboBox.Margin = new System.Windows.Forms.Padding(8);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(269, 41);
            this.doctorComboBox.TabIndex = 156;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(623, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 34);
            this.label3.TabIndex = 155;
            this.label3.Text = "Doctor:";
            // 
            // lbl_Complaint
            // 
            this.lbl_Complaint.AutoSize = true;
            this.lbl_Complaint.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Complaint.Location = new System.Drawing.Point(623, 431);
            this.lbl_Complaint.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_Complaint.Name = "lbl_Complaint";
            this.lbl_Complaint.Size = new System.Drawing.Size(164, 34);
            this.lbl_Complaint.TabIndex = 154;
            this.lbl_Complaint.Text = "Complaint:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(236, 317);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(269, 41);
            this.nameTextBox.TabIndex = 109;
            // 
            // sexComboBox
            // 
            this.sexComboBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(236, 445);
            this.sexComboBox.Margin = new System.Windows.Forms.Padding(8);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(269, 41);
            this.sexComboBox.TabIndex = 111;
            // 
            // ssnTextBox1
            // 
            this.ssnTextBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnTextBox1.Location = new System.Drawing.Point(236, 253);
            this.ssnTextBox1.Margin = new System.Windows.Forms.Padding(8);
            this.ssnTextBox1.Name = "ssnTextBox1";
            this.ssnTextBox1.Size = new System.Drawing.Size(269, 41);
            this.ssnTextBox1.TabIndex = 113;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTextBox.Location = new System.Drawing.Point(236, 381);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(269, 41);
            this.surnameTextBox.TabIndex = 115;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ssnTextBox);
            this.groupBox1.Controls.Add(this.checkButton);
            this.groupBox1.Location = new System.Drawing.Point(75, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(712, 142);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check whether the patient record by Ssn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ssn:";
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(134, 60);
            this.ssnTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(316, 38);
            this.ssnTextBox.TabIndex = 18;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(498, 54);
            this.checkButton.Margin = new System.Windows.Forms.Padding(8);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(182, 56);
            this.checkButton.TabIndex = 25;
            this.checkButton.Text = "CHECK";
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(69, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(546, 34);
            this.label10.TabIndex = 75;
            this.label10.Text = "Please before add staff, check records.";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // step2TabPage
            // 
            this.step2TabPage.Controls.Add(this.btn_Back);
            this.step2TabPage.Controls.Add(this.saveButton);
            this.step2TabPage.Controls.Add(addressLabel);
            this.step2TabPage.Controls.Add(this.addressTextBox);
            this.step2TabPage.Controls.Add(this.father_nameTextBox);
            this.step2TabPage.Controls.Add(phoneLabel);
            this.step2TabPage.Controls.Add(this.phoneTextBox);
            this.step2TabPage.Controls.Add(birth_placeLabel);
            this.step2TabPage.Controls.Add(this.birth_placeTextBox);
            this.step2TabPage.Controls.Add(this.deptComboBox);
            this.step2TabPage.Controls.Add(this.inspectionDateTimePicker);
            this.step2TabPage.Controls.Add(this.label2);
            this.step2TabPage.Controls.Add(this.label1);
            this.step2TabPage.Controls.Add(father_nameLabel);
            this.step2TabPage.Controls.Add(birth_dateLabel);
            this.step2TabPage.Controls.Add(this.birth_dateDateTimePicker);
            this.step2TabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step2TabPage.Location = new System.Drawing.Point(4, 41);
            this.step2TabPage.Margin = new System.Windows.Forms.Padding(4);
            this.step2TabPage.Name = "step2TabPage";
            this.step2TabPage.Padding = new System.Windows.Forms.Padding(4);
            this.step2TabPage.Size = new System.Drawing.Size(1187, 655);
            this.step2TabPage.TabIndex = 1;
            this.step2TabPage.Text = "Step 2";
            this.step2TabPage.UseVisualStyleBackColor = true;
            this.step2TabPage.Click += new System.EventHandler(this.step2TabPage_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(221, 593);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(182, 70);
            this.btn_Back.TabIndex = 154;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(889, 594);
            this.saveButton.Margin = new System.Windows.Forms.Padding(8);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(182, 70);
            this.saveButton.TabIndex = 153;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(885, 122);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(358, 148);
            this.addressTextBox.TabIndex = 147;
            // 
            // father_nameTextBox
            // 
            this.father_nameTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.father_nameTextBox.Location = new System.Drawing.Point(317, 244);
            this.father_nameTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.father_nameTextBox.Name = "father_nameTextBox";
            this.father_nameTextBox.Size = new System.Drawing.Size(259, 41);
            this.father_nameTextBox.TabIndex = 149;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(317, 314);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(259, 41);
            this.phoneTextBox.TabIndex = 152;
            // 
            // birth_placeTextBox
            // 
            this.birth_placeTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_placeTextBox.Location = new System.Drawing.Point(317, 178);
            this.birth_placeTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.birth_placeTextBox.Name = "birth_placeTextBox";
            this.birth_placeTextBox.Size = new System.Drawing.Size(259, 41);
            this.birth_placeTextBox.TabIndex = 145;
            this.birth_placeTextBox.TextChanged += new System.EventHandler(this.birth_placeTextBox_TextChanged_1);
            // 
            // deptComboBox
            // 
            this.deptComboBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(317, 488);
            this.deptComboBox.Margin = new System.Windows.Forms.Padding(8);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(259, 41);
            this.deptComboBox.TabIndex = 139;
            // 
            // inspectionDateTimePicker
            // 
            this.inspectionDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inspectionDateTimePicker.Location = new System.Drawing.Point(317, 393);
            this.inspectionDateTimePicker.Margin = new System.Windows.Forms.Padding(8);
            this.inspectionDateTimePicker.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.inspectionDateTimePicker.MinDate = new System.DateTime(2014, 9, 1, 0, 0, 0, 0);
            this.inspectionDateTimePicker.Name = "inspectionDateTimePicker";
            this.inspectionDateTimePicker.Size = new System.Drawing.Size(259, 41);
            this.inspectionDateTimePicker.TabIndex = 138;
            this.inspectionDateTimePicker.Value = new System.DateTime(2014, 12, 21, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 491);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 34);
            this.label2.TabIndex = 136;
            this.label2.Text = "Department:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 391);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 68);
            this.label1.TabIndex = 134;
            this.label1.Text = "Inspection \r\nDate:";
            // 
            // birth_dateDateTimePicker
            // 
            this.birth_dateDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birth_dateDateTimePicker.Location = new System.Drawing.Point(317, 114);
            this.birth_dateDateTimePicker.Margin = new System.Windows.Forms.Padding(8);
            this.birth_dateDateTimePicker.MaxDate = new System.DateTime(2014, 12, 15, 0, 0, 0, 0);
            this.birth_dateDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birth_dateDateTimePicker.Name = "birth_dateDateTimePicker";
            this.birth_dateDateTimePicker.Size = new System.Drawing.Size(259, 41);
            this.birth_dateDateTimePicker.TabIndex = 143;
            this.birth_dateDateTimePicker.Value = new System.DateTime(2014, 12, 15, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(902, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 37);
            this.button1.TabIndex = 162;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Back_Click_1);
            // 
            // Patientform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1195, 700);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Patientform";
            this.Text = "Patientform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Patientform_Load);
            this.tabControl.ResumeLayout(false);
            this.step1TabPage.ResumeLayout(false);
            this.step1TabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.step2TabPage.ResumeLayout(false);
            this.step2TabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage step1TabPage;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ssnTextBox1;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_Seriousness;
        private System.Windows.Forms.TextBox txtbx_Complaint;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Complaint;
        private System.Windows.Forms.TabPage step2TabPage;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox father_nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox birth_placeTextBox;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.DateTimePicker inspectionDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birth_dateDateTimePicker;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox comboBox_bloodgroup;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Button button1;
    }
}