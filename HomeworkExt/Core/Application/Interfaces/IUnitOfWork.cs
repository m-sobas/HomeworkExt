namespace HomeworkExt.Core.Application.Interfaces
{
    public interface IUnitOfWork
    {
        ICarRepository Car { get; }

        void Commit();
    }
}
