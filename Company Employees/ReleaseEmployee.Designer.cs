namespace Company_Employees
{
    partial class ReleaseEmployee
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
            this.btnRealease = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbInformation = new System.Windows.Forms.Label();
            this.dtpDateOfRelease = new System.Windows.Forms.DateTimePicker();
            this.lbDateOfRelease = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRealease
            // 
            this.btnRealease.BackColor = System.Drawing.Color.Firebrick;
            this.btnRealease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRealease.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRealease.Location = new System.Drawing.Point(409, 114);
            this.btnRealease.Name = "btnRealease";
            this.btnRealease.Size = new System.Drawing.Size(145, 46);
            this.btnRealease.TabIndex = 17;
            this.btnRealease.Text = "Zwolnij";
            this.btnRealease.UseVisualStyleBackColor = false;
            this.btnRealease.Click += new System.EventHandler(this.btnRealease_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(249, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 46);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbInformation
            // 
            this.lbInformation.AutoSize = true;
            this.lbInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInformation.Location = new System.Drawing.Point(12, 9);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(236, 25);
            this.lbInformation.TabIndex = 19;
            this.lbInformation.Text = "Zwalnianie pracownika ";
            // 
            // dtpDateOfRelease
            // 
            this.dtpDateOfRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDateOfRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfRelease.Location = new System.Drawing.Point(249, 59);
            this.dtpDateOfRelease.Name = "dtpDateOfRelease";
            this.dtpDateOfRelease.Size = new System.Drawing.Size(145, 30);
            this.dtpDateOfRelease.TabIndex = 20;
            // 
            // lbDateOfRelease
            // 
            this.lbDateOfRelease.AutoSize = true;
            this.lbDateOfRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDateOfRelease.Location = new System.Drawing.Point(88, 59);
            this.lbDateOfRelease.Name = "lbDateOfRelease";
            this.lbDateOfRelease.Size = new System.Drawing.Size(155, 25);
            this.lbDateOfRelease.TabIndex = 21;
            this.lbDateOfRelease.Text = "Data zwolnienia:";
            // 
            // ReleaseEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 171);
            this.Controls.Add(this.lbDateOfRelease);
            this.Controls.Add(this.dtpDateOfRelease);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRealease);
            this.Name = "ReleaseEmployee";
            this.Text = "ReleaseEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRealease;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.DateTimePicker dtpDateOfRelease;
        private System.Windows.Forms.Label lbDateOfRelease;
    }
}