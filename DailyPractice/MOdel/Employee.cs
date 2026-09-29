using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Range(1, double.MaxValue)]
        public decimal Salary { get; set; }

        [Required]
        public string Department { get; set; }
    }
}