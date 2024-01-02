namespace AuctionHub.Application.Abstraction.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(Guid id);
        void Create(T entity);
        void Update(Guid id, T entity);
        void Delete(Guid id);
    }
}
