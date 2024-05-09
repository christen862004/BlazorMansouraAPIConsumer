namespace BlazorMansouraAPIConsumer.Services
{
    public interface IService<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetByID(int id);
        Task Insert(T obj);
        Task Update(int id,T obj);
        Task Delete(int id);
    }
}
