namespace HospitalManagemnt
{
    partial class DeleteRecordsForm
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
            System.Windows.Forms.Label ssnLabel;
            this.dataGridView_DeleteRecords = new System.Windows.Forms.DataGridView();
            this.lbl_DeleteRecords = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            ssnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DeleteRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_DeleteRecords
            // 
            this.dataGridView_DeleteRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DeleteRecords.Location = new System.Drawing.Point(87, 186);
            this.dataGridView_DeleteRecords.Name = "dataGridView_DeleteRecords";
            this.dataGridView_DeleteRecords.RowTemplate.Height = 24;
            this.dataGridView_DeleteRecords.Size = new System.Drawing.Size(1099, 397);
            this.dataGridView_DeleteRecords.TabIndex = 0;
            this.dataGridView_DeleteRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DeleteRecords_CellClick);
            this.dataGridView_DeleteRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DeleteRecords_CellContentClick);
            // 
            // lbl_DeleteRecords
            // 
            this.lbl_DeleteRecords.AutoSize = true;
            this.lbl_DeleteRecords.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeleteRecords.Location = new System.Drawing.Point(94, 65);
            this.lbl_DeleteRecords.Name = "lbl_DeleteRecords";
            this.lbl_DeleteRecords.Size = new System.Drawing.Size(317, 47);
            this.lbl_DeleteRecords.TabIndex = 1;
            this.lbl_DeleteRecords.Text = "Delete Records";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1048, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(87, 650);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(138, 60);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ssnLabel.Location = new System.Drawing.Point(564, 664);
            ssnLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new System.Drawing.Size(142, 34);
            ssnLabel.TabIndex = 114;
            ssnLabel.Text = "Enter Ssn:";
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnTextBox.Location = new System.Drawing.Point(739, 659);
            this.ssnTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(269, 41);
            this.ssnTextBox.TabIndex = 115;
            // 
            // DeleteRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(ssnLabel);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_DeleteRecords);
            this.Controls.Add(this.dataGridView_DeleteRecords);
            this.Name = "DeleteRecordsForm";
            this.Text = "DeleteRecordsForm";
            this.Load += new System.EventHandler(this.DeleteRecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DeleteRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_DeleteRecords;
        private System.Windows.Forms.Label lbl_DeleteRecords;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox ssnTextBox;
    }
}