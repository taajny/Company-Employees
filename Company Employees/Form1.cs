using Company_Employees.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Company_Employees
{
    public partial class mainForm : Form
    {
        public bool isMaximize
        {
            get
            {
                return Settings.Default.IsMaximize;
            }
            set
            {
                Settings.Default.IsMaximize = value;
            }
        }

        private JsonFileHelper _jsonFileHelper = new JsonFileHelper(Program.FilePathJson);
        private List<JobPosition> _jobsPositions;
        public mainForm()

        {
            InitializeComponent();
            if (isMaximize)
                WindowState = FormWindowState.Maximized;

            _jobsPositions = new List<JobPosition>
            {
                new JobPosition { JobPositionId = 0, JobPositionName = "Wszystkie"},
                new JobPosition { JobPositionId = 1, JobPositionName = "Kierowca"},
                new JobPosition { JobPositionId= 2, JobPositionName = "Magazynier"},
                new JobPosition { JobPositionId= 3, JobPositionName = "Ślusarz"}
            };
            InitJobPositionComboBox();
            RefreshEmployeesList();
            SetColumnHeaders();
            
        }
        public void InitJobPositionComboBox()
        {
            cmbJobPosition.DataSource = _jobsPositions;
            cmbJobPosition.DisplayMember = "JobPositionName";
            cmbJobPosition.ValueMember = "JobPositionId";
        }
        public void RefreshEmployeesList()
        {
            var employees = _jsonFileHelper.DeserializeFromFile();

            if (rbHired.Checked == true)
            {
                employees = employees.Where(x => x.DateOfRelease == null).OrderBy(x => x.Id).ToList();
            }
            else if (rbReleased.Checked == true) 
            {
                employees = employees.Where(x => x.DateOfRelease != null).OrderBy(x => x.Id).ToList();
            }
            else if (rbAll.Checked == true)
                employees = employees.OrderBy(x => x.Id).ToList();
            else
                employees = employees.OrderBy(x => x.Id).ToList();

            var selectedJobPositionId = (cmbJobPosition.SelectedItem as JobPosition).JobPositionId;
            
            if ( selectedJobPositionId != 0)
            {
                employees = employees.Where(x => x.JobPositionId == selectedJobPositionId).ToList();
            }
            dgvEmployeesList.DataSource = employees;
  
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new AddEditEmployee();
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.ShowDialog();
        }

        private void AddEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshEmployeesList();
        }
        private void SetColumnHeaders()
        {
            dgvEmployeesList.Columns[0].HeaderText = "Id";
            dgvEmployeesList.Columns[1].HeaderText = "Imię";
            dgvEmployeesList.Columns[2].HeaderText = "Nazwisko";
            dgvEmployeesList.Columns[3].HeaderText = "Zarobki";
            dgvEmployeesList.Columns[4].HeaderText = "Data zatrudnienia";
            dgvEmployeesList.Columns[5].HeaderText = "Data zwolnienia";
            dgvEmployeesList.Columns[6].HeaderText = "Uwagi";
            dgvEmployeesList.Columns[nameof(Employee.JobPositionId)].Visible= false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if ( dgvEmployeesList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie zaznaczono żadnego wiersza!", "Brak zaznaczenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var addEditEmployee = new AddEditEmployee(Convert.ToInt32(dgvEmployeesList.SelectedRows[0].Cells[0].Value));
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.ShowDialog();
        }

        private void rbHired_CheckedChanged(object sender, EventArgs e)
        {
            RefreshEmployeesList();
        }
        private void rbReleased_CheckedChanged(object sender, EventArgs e)
        {
            RefreshEmployeesList();
        }
        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            RefreshEmployeesList();
        }

        private void cmbJobPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshEmployeesList();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                isMaximize = true;
            else
                isMaximize = false;
            Settings.Default.Save();

        }
    }
}
