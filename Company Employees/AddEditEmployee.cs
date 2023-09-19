using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;

namespace Company_Employees
{
    public partial class AddEditEmployee : Form
    {
        private int _employeeId;
        private bool _dateOfReleaseModified;
        private Employee _employee;
        private List<JobPosition> _jobsPositions;
        private JsonFileHelper _jsonFileHelper = new JsonFileHelper(Program.FilePathJson);
        public AddEditEmployee(int id = 0)
        {
            InitializeComponent();
            lbDateOfRelease.Visible = false;
            dtpDateOfRelease.Visible = false;
            btnRealease.Visible = false;
            _employeeId = id;
            _dateOfReleaseModified = false;
            _jobsPositions = new List<JobPosition>
            {
                new JobPosition { JobPositionId = 0, JobPositionName = "Brak"},
                new JobPosition { JobPositionId = 1, JobPositionName = "Kierowca"},
                new JobPosition { JobPositionId= 2, JobPositionName = "Magazynier"},
                new JobPosition { JobPositionId= 3, JobPositionName = "Ślusarz"}
            };
            InitJobPositionComboBox();
            GetEmployeeData();
        }
        public void InitJobPositionComboBox()
        {
            cbJobPosition.DataSource= _jobsPositions;
            cbJobPosition.DisplayMember = "JobPositionName";
            cbJobPosition.ValueMember = "JobPositionId";
        }
        private void GetEmployeeData()
        {
            if (_employeeId != 0)
            {
                Text = "Edytowanie danych pracownika";
                var employees = _jsonFileHelper.DeserializeFromFile();//_xmlFileHelper.DeserializeFromFile();
                _employee = employees.FirstOrDefault(x => x.Id == _employeeId);
                if (_employee == null)
                    throw new Exception("Brak użytkownika o podanym Id");
                FillTextBoxes();
            }
        }
        private void FillTextBoxes()
        {
            tbId.Text = _employee.Id.ToString();
            tbFirstName.Text = _employee.FirstName;
            tbLastName.Text = _employee.LastName;
            dtpDateOfEmployment.Value = _employee.DateOfEmployment;
            if (_employee.DateOfRelease == null)
            {
                dtpDateOfRelease.Enabled = false;
                btnRealease.Visible = true;
            }
            else
            {
                dtpDateOfRelease.Value = (DateTime)_employee.DateOfRelease;
                dtpDateOfRelease.Visible = true;
                dtpDateOfRelease.Enabled = false;
                lbDateOfRelease.Visible = true;
            }
            cbJobPosition.SelectedItem = _jobsPositions.FirstOrDefault(x => x.JobPositionId == _employee.JobPositionId);
            nudEarnings.Value = _employee.Earnings;
            rtbComments.Text = _employee.Comments;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var employees = _jsonFileHelper.DeserializeFromFile(); 
            var employee = new Employee();
            bool isDateOfReleaseNull = false;
            if (_employeeId != 0)
                employees.RemoveAll(x => x.Id == _employeeId);
            else
            {
                AssignIdToNewEmployee(employees);
                isDateOfReleaseNull = true;
            }
            

            employee.Id = _employeeId;
            employee.FirstName = tbFirstName.Text;
            employee.LastName = tbLastName.Text;
            employee.DateOfEmployment = dtpDateOfEmployment.Value;


            if (_dateOfReleaseModified == true)
                employee.DateOfRelease = (DateTime)_employee.DateOfRelease;
            else if (isDateOfReleaseNull)
                employee.DateOfRelease = null;
            else
                employee.DateOfRelease = dtpDateOfRelease.Value;
            employee.Comments = rtbComments.Text;
            employee.Earnings = (int)nudEarnings.Value;
            employee.JobPositionId = (cbJobPosition.SelectedItem as JobPosition).JobPositionId;
            employees.Add(employee);

            _jsonFileHelper.SerializeToFile(employees);
            Close();
        }
        private void AssignIdToNewEmployee(List<Employee> employees)
        {
            var EmployeeWithHighestId = employees.OrderByDescending(x => x.Id).FirstOrDefault();

            if (EmployeeWithHighestId == null)
                _employeeId = 1;
            else
                _employeeId = EmployeeWithHighestId.Id + 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnRealease_Click(object sender, EventArgs e)
        {
            var releaseEmployee = new ReleaseEmployee(_employee);
            releaseEmployee.FormClosing += ReleaseEmployee_FormClosing;
            releaseEmployee.ShowDialog();
        }

        private void ReleaseEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( _employee.DateOfRelease != null)
            {
                lbDateOfRelease.Visible = true;
                dtpDateOfRelease.Visible = true;
                dtpDateOfRelease.Value = (DateTime)_employee.DateOfRelease;
                _dateOfReleaseModified = true;
            }
            
        }
    }
}
