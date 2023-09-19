using System;

namespace Company_Employees
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Earnings { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public DateTime? DateOfRelease { get; set; }
        
        public string Comments { get; set; }
        public int JobPositionId { get; set; }
    }
}
