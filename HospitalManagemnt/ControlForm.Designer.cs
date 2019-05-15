namespace HospitalManagemnt
{
    partial class ControlForm
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
            this.btn_NewPatient = new System.Windows.Forms.Button();
            this.btn_DoctorDetails = new System.Windows.Forms.Button();
            this.btn_Existingpatients = new System.Windows.Forms.Button();
            this.btn_DeleteRecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewPatient
            // 
            this.btn_NewPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_NewPatient.Font = new System.Drawing.Font("Century Gothic", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewPatient.Location = new System.Drawing.Point(318, 221);
            this.btn_NewPatient.Name = "btn_NewPatient";
            this.btn_NewPatient.Size = new System.Drawing.Size(360, 132);
            this.btn_NewPatient.TabIndex = 0;
            this.btn_NewPatient.Text = "New Patient";
            this.btn_NewPatient.UseVisualStyleBackColor = true;
            this.btn_NewPatient.Click += new System.EventHandler(this.btn_NewPatient_Click);
            // 
            // btn_DoctorDetails
            // 
            this.btn_DoctorDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_DoctorDetails.Font = new System.Drawing.Font("Century Gothic", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoctorDetails.Location = new System.Drawing.Point(888, 221);
            this.btn_DoctorDetails.Name = "btn_DoctorDetails";
            this.btn_DoctorDetails.Size = new System.Drawing.Size(360, 132);
            this.btn_DoctorDetails.TabIndex = 0;
            this.btn_DoctorDetails.Text = "Doctor \r\nDetails";
            this.btn_DoctorDetails.UseVisualStyleBackColor = true;
            this.btn_DoctorDetails.Click += new System.EventHandler(this.btn_DoctorDetails_Click);
            // 
            // btn_Existingpatients
            // 
            this.btn_Existingpatients.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Existingpatients.Font = new System.Drawing.Font("Century Gothic", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Existingpatients.Location = new System.Drawing.Point(318, 437);
            this.btn_Existingpatients.Name = "btn_Existingpatients";
            this.btn_Existingpatients.Size = new System.Drawing.Size(360, 132);
            this.btn_Existingpatients.TabIndex = 0;
            this.btn_Existingpatients.Text = "Existing\r\nPatients";
            this.btn_Existingpatients.UseVisualStyleBackColor = true;
            this.btn_Existingpatients.Click += new System.EventHandler(this.btn_Existingpatients_Click);
            // 
            // btn_DeleteRecords
            // 
            this.btn_DeleteRecords.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_DeleteRecords.Font = new System.Drawing.Font("Century Gothic", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteRecords.Location = new System.Drawing.Point(888, 437);
            this.btn_DeleteRecords.Name = "btn_DeleteRecords";
            this.btn_DeleteRecords.Size = new System.Drawing.Size(360, 132);
            this.btn_DeleteRecords.TabIndex = 0;
            this.btn_DeleteRecords.Text = "Delete\r\nRecords";
            this.btn_DeleteRecords.UseVisualStyleBackColor = true;
            this.btn_DeleteRecords.Click += new System.EventHandler(this.btn_DeleteRecords_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btn_DoctorDetails);
            this.Controls.Add(this.btn_DeleteRecords);
            this.Controls.Add(this.btn_Existingpatients);
            this.Controls.Add(this.btn_NewPatient);
            this.Name = "ControlForm";
            this.Text = "ControlForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewPatient;
        private System.Windows.Forms.Button btn_DoctorDetails;
        private System.Windows.Forms.Button btn_Existingpatients;
        private System.Windows.Forms.Button btn_DeleteRecords;
    }
}