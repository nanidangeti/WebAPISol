using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIpro.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EName { get; set; }
        public string Email { get; set; }
        public string Gneder { get; set; }

        [ForeignKey("Department")]
        public int DeptNo { get; set; }
        public Department Department { get; set; }

    }
}
