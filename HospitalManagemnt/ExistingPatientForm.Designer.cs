namespace HospitalManagemnt
{
    partial class ExistingPatientForm
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
            this.dataGridView_ExistingPatients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExistingPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ExistingPatients
            // 
            this.dataGridView_ExistingPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ExistingPatients.Location = new System.Drawing.Point(58, 160);
            this.dataGridView_ExistingPatients.Name = "dataGridView_ExistingPatients";
            this.dataGridView_ExistingPatients.RowTemplate.Height = 24;
            this.dataGridView_ExistingPatients.Size = new System.Drawing.Size(1287, 453);
            this.dataGridView_ExistingPatients.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Existing Patients";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(58, 654);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(145, 84);
            this.btn_Back.TabIndex = 107;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // ExistingPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_ExistingPatients);
            this.Name = "ExistingPatientForm";
            this.Text = "ExistingPatientForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExistingPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExistingPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ExistingPatients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back;
    }
}