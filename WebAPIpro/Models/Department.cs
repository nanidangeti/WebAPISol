using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIpro.Models
{
    [Table("Department")]
    public class Department
    {
        [Key] 
        public int DeptNo { get; set; }
        public string DName { get; set; }
        public string Location { get; set; }

        public ICollection<Employee> Employees { get; set; }



    }
}
