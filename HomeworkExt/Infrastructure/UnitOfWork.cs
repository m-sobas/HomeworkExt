using HomeworkExt.Core.Application.Interfaces;
using HomeworkExt.Infrastructure.Repositories;

namespace HomeworkExt.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IApplicationDbContext _context;

        public UnitOfWork(IApplicationDbContext context)
        {
            _context = context;
            Car = new CarRepository(context);
        }

        public ICarRepository Car { get; set; }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
