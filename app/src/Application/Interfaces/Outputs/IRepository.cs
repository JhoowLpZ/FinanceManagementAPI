namespace Application.Interfaces.Outputs
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(object id);
        Task<T> SaveAsync(T entity);
        Task<T> UpdateAsync(T entity, object id);
        Task<bool> DeleteAsync(object id);
    }
}
