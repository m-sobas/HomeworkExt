using HomeworkExt.Core.Models.Domains;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HomeworkExt.Core.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Car> Cars { get; set; }

        int SaveChanges();
    }
}
