namespace Company_Employees
{
    partial class AddEditEmployee
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
            this.lbId = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbDateOfRelease = new System.Windows.Forms.Label();
            this.lbDateOfEmployment = new System.Windows.Forms.Label();
            this.lbComments = new System.Windows.Forms.Label();
            this.lbEarnings = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dtpDateOfEmployment = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfRelease = new System.Windows.Forms.DateTimePicker();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.nudEarnings = new System.Windows.Forms.NumericUpDown();
            this.lbDataOfEmployee = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRealease = new System.Windows.Forms.Button();
            this.lbJobPosition = new System.Windows.Forms.Label();
            this.cbJobPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudEarnings)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Enabled = false;
            this.lbId.Location = new System.Drawing.Point(24, 53);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(93, 16);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id pracownika:";
            this.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(82, 87);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(35, 16);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "Imię:";
            this.lbFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(49, 115);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(68, 16);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "Nazwisko:";
            this.lbLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDateOfRelease
            // 
            this.lbDateOfRelease.AutoSize = true;
            this.lbDateOfRelease.Location = new System.Drawing.Point(13, 446);
            this.lbDateOfRelease.Name = "lbDateOfRelease";
            this.lbDateOfRelease.Size = new System.Drawing.Size(104, 16);
            this.lbDateOfRelease.TabIndex = 3;
            this.lbDateOfRelease.Text = "Data zwolnienia:";
            this.lbDateOfRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDateOfEmployment
            // 
            this.lbDateOfEmployment.AutoSize = true;
            this.lbDateOfEmployment.Location = new System.Drawing.Point(3, 189);
            this.lbDateOfEmployment.Name = "lbDateOfEmployment";
            this.lbDateOfEmployment.Size = new System.Drawing.Size(114, 16);
            this.lbDateOfEmployment.TabIndex = 4;
            this.lbDateOfEmployment.Text = "Data zatrudnienia:";
            this.lbDateOfEmployment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(69, 264);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(48, 16);
            this.lbComments.TabIndex = 5;
            this.lbComments.Text = "Uwagi:";
            this.lbComments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbEarnings
            // 
            this.lbEarnings.AutoSize = true;
            this.lbEarnings.Location = new System.Drawing.Point(61, 220);
            this.lbEarnings.Name = "lbEarnings";
            this.lbEarnings.Size = new System.Drawing.Size(56, 16);
            this.lbEarnings.TabIndex = 6;
            this.lbEarnings.Text = "Zarobki:";
            this.lbEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(124, 51);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(178, 22);
            this.tbId.TabIndex = 7;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(124, 85);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(178, 22);
            this.tbFirstName.TabIndex = 8;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(123, 113);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(179, 22);
            this.tbLastName.TabIndex = 9;
            // 
            // dtpDateOfEmployment
            // 
            this.dtpDateOfEmployment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfEmployment.Location = new System.Drawing.Point(123, 187);
            this.dtpDateOfEmployment.Name = "dtpDateOfEmployment";
            this.dtpDateOfEmployment.Size = new System.Drawing.Size(107, 22);
            this.dtpDateOfEmployment.TabIndex = 10;
            // 
            // dtpDateOfRelease
            // 
            this.dtpDateOfRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfRelease.Location = new System.Drawing.Point(123, 443);
            this.dtpDateOfRelease.Name = "dtpDateOfRelease";
            this.dtpDateOfRelease.Size = new System.Drawing.Size(107, 22);
            this.dtpDateOfRelease.TabIndex = 11;
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(124, 254);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(327, 174);
            this.rtbComments.TabIndex = 12;
            this.rtbComments.Text = "";
            // 
            // nudEarnings
            // 
            this.nudEarnings.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEarnings.Location = new System.Drawing.Point(123, 218);
            this.nudEarnings.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudEarnings.Name = "nudEarnings";
            this.nudEarnings.Size = new System.Drawing.Size(107, 22);
            this.nudEarnings.TabIndex = 13;
            this.nudEarnings.ThousandsSeparator = true;
            // 
            // lbDataOfEmployee
            // 
            this.lbDataOfEmployee.AutoSize = true;
            this.lbDataOfEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDataOfEmployee.Location = new System.Drawing.Point(118, 9);
            this.lbDataOfEmployee.Name = "lbDataOfEmployee";
            this.lbDataOfEmployee.Size = new System.Drawing.Size(257, 32);
            this.lbDataOfEmployee.TabIndex = 14;
            this.lbDataOfEmployee.Text = "Dane pracownika:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(157, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 46);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(312, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 46);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRealease
            // 
            this.btnRealease.BackColor = System.Drawing.Color.Firebrick;
            this.btnRealease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRealease.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRealease.Location = new System.Drawing.Point(6, 488);
            this.btnRealease.Name = "btnRealease";
            this.btnRealease.Size = new System.Drawing.Size(145, 46);
            this.btnRealease.TabIndex = 16;
            this.btnRealease.Text = "Zwolnij";
            this.btnRealease.UseVisualStyleBackColor = false;
            this.btnRealease.Click += new System.EventHandler(this.btnRealease_Click);
            // 
            // lbJobPosition
            // 
            this.lbJobPosition.AutoSize = true;
            this.lbJobPosition.Location = new System.Drawing.Point(38, 149);
            this.lbJobPosition.Name = "lbJobPosition";
            this.lbJobPosition.Size = new System.Drawing.Size(79, 16);
            this.lbJobPosition.TabIndex = 17;
            this.lbJobPosition.Text = "Stanowisko:";
            this.lbJobPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbJobPosition
            // 
            this.cbJobPosition.FormattingEnabled = true;
            this.cbJobPosition.Location = new System.Drawing.Point(123, 146);
            this.cbJobPosition.Name = "cbJobPosition";
            this.cbJobPosition.Size = new System.Drawing.Size(179, 24);
            this.cbJobPosition.TabIndex = 18;
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 542);
            this.Controls.Add(this.cbJobPosition);
            this.Controls.Add(this.lbJobPosition);
            this.Controls.Add(this.btnRealease);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbDataOfEmployee);
            this.Controls.Add(this.nudEarnings);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.dtpDateOfRelease);
            this.Controls.Add(this.dtpDateOfEmployment);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbEarnings);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.lbDateOfEmployment);
            this.Controls.Add(this.lbDateOfRelease);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbId);
            this.Name = "AddEditEmployee";
            this.Text = "Dodawanie pracownika";
            ((System.ComponentModel.ISupportInitialize)(this.nudEarnings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbDateOfRelease;
        private System.Windows.Forms.Label lbDateOfEmployment;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.Label lbEarnings;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.DateTimePicker dtpDateOfEmployment;
        private System.Windows.Forms.DateTimePicker dtpDateOfRelease;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.NumericUpDown nudEarnings;
        private System.Windows.Forms.Label lbDataOfEmployee;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRealease;
        private System.Windows.Forms.Label lbJobPosition;
        private System.Windows.Forms.ComboBox cbJobPosition;
    }
}