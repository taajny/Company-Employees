using System;
using System.Windows.Forms;

namespace Company_Employees
{
    
    public partial class ReleaseEmployee : Form
    {
        private Employee _employee = new Employee();
        public ReleaseEmployee(Employee employee)
        {
            _employee = employee;
            InitializeComponent();
            Text = $"Zwalnianie pracownika {_employee.FirstName} {_employee.LastName}";
            lbInformation.Text += $"{_employee.FirstName} {_employee.LastName}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRealease_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Zwolnienie pracownika jest nieodwracalne! Czy na pewno chcesz zwolnić pracownika {_employee.FirstName} {_employee.LastName}?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _employee.DateOfRelease = dtpDateOfRelease.Value;
                Close();
            }
            
            
        }
    }
}
