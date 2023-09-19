namespace Company_Employees
{
    partial class mainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvEmployeesList = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.rbHired = new System.Windows.Forms.RadioButton();
            this.gbHiredOrNot = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbReleased = new System.Windows.Forms.RadioButton();
            this.lbJobPosition = new System.Windows.Forms.Label();
            this.cmbJobPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesList)).BeginInit();
            this.gbHiredOrNot.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(21, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvEmployeesList
            // 
            this.dgvEmployeesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeesList.Location = new System.Drawing.Point(15, 136);
            this.dgvEmployeesList.Name = "dgvEmployeesList";
            this.dgvEmployeesList.RowHeadersVisible = false;
            this.dgvEmployeesList.RowHeadersWidth = 51;
            this.dgvEmployeesList.RowTemplate.Height = 24;
            this.dgvEmployeesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeesList.Size = new System.Drawing.Size(954, 420);
            this.dgvEmployeesList.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(21, 72);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 44);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // rbHired
            // 
            this.rbHired.AutoSize = true;
            this.rbHired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbHired.Location = new System.Drawing.Point(6, 31);
            this.rbHired.Name = "rbHired";
            this.rbHired.Size = new System.Drawing.Size(134, 24);
            this.rbHired.TabIndex = 3;
            this.rbHired.TabStop = true;
            this.rbHired.Text = "zatrudnionych";
            this.rbHired.UseVisualStyleBackColor = true;
            this.rbHired.CheckedChanged += new System.EventHandler(this.rbHired_CheckedChanged);
            // 
            // gbHiredOrNot
            // 
            this.gbHiredOrNot.Controls.Add(this.rbAll);
            this.gbHiredOrNot.Controls.Add(this.rbReleased);
            this.gbHiredOrNot.Controls.Add(this.rbHired);
            this.gbHiredOrNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbHiredOrNot.Location = new System.Drawing.Point(138, 12);
            this.gbHiredOrNot.Name = "gbHiredOrNot";
            this.gbHiredOrNot.Size = new System.Drawing.Size(154, 118);
            this.gbHiredOrNot.TabIndex = 4;
            this.gbHiredOrNot.TabStop = false;
            this.gbHiredOrNot.Text = "Pokaż tylko:";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbAll.Location = new System.Drawing.Point(6, 88);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(112, 24);
            this.rbAll.TabIndex = 6;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "wszystkich";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbReleased
            // 
            this.rbReleased.AutoSize = true;
            this.rbReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbReleased.Location = new System.Drawing.Point(6, 59);
            this.rbReleased.Name = "rbReleased";
            this.rbReleased.Size = new System.Drawing.Size(121, 24);
            this.rbReleased.TabIndex = 5;
            this.rbReleased.TabStop = true;
            this.rbReleased.Text = "zwolnionych";
            this.rbReleased.UseVisualStyleBackColor = true;
            this.rbReleased.CheckedChanged += new System.EventHandler(this.rbReleased_CheckedChanged);
            // 
            // lbJobPosition
            // 
            this.lbJobPosition.AutoSize = true;
            this.lbJobPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbJobPosition.Location = new System.Drawing.Point(294, 72);
            this.lbJobPosition.Name = "lbJobPosition";
            this.lbJobPosition.Size = new System.Drawing.Size(209, 20);
            this.lbJobPosition.TabIndex = 5;
            this.lbJobPosition.Text = "Stanowisko zatrudnionego:";
            // 
            // cmbJobPosition
            // 
            this.cmbJobPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbJobPosition.FormattingEnabled = true;
            this.cmbJobPosition.Location = new System.Drawing.Point(298, 102);
            this.cmbJobPosition.Name = "cmbJobPosition";
            this.cmbJobPosition.Size = new System.Drawing.Size(205, 28);
            this.cmbJobPosition.TabIndex = 6;
            this.cmbJobPosition.SelectedIndexChanged += new System.EventHandler(this.cmbJobPosition_SelectedIndexChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 572);
            this.Controls.Add(this.cmbJobPosition);
            this.Controls.Add(this.lbJobPosition);
            this.Controls.Add(this.gbHiredOrNot);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvEmployeesList);
            this.Controls.Add(this.btnAdd);
            this.Name = "mainForm";
            this.Text = "Pracownicy firmy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesList)).EndInit();
            this.gbHiredOrNot.ResumeLayout(false);
            this.gbHiredOrNot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvEmployeesList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.RadioButton rbHired;
        private System.Windows.Forms.GroupBox gbHiredOrNot;
        private System.Windows.Forms.RadioButton rbReleased;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label lbJobPosition;
        private System.Windows.Forms.ComboBox cmbJobPosition;
    }
}

