using Microsoft.EntityFrameworkCore;

namespace EmpPayrollMVCWithAjax.Models
{
    public class EmpContext:DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> options) : base(options)
        { }

        public DbSet<EmpModel> EmpData { get; set; }
    }
}
