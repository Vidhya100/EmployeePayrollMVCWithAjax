using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpPayrollMVCWithAjax.Models
{
    public class EmpModel
    {
        [Key]
        public int EmpID { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string EmpName { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        public string ProfileImg { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        public string Gender { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        public string Department { get; set; }
        public float Salary { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        public string Notes { get; set; }
    }
}
