namespace Application.Interfaces.Outputs
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(object id);
        Task<T> SaveAsync(T entity);
        Task UpdateAsync(T entity);
        Task<bool> DeleteAsync(object id);
    }
}
