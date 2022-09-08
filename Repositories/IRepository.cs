using FCSDemo.Models;

namespace FCSDemo.Repositories
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        int Create(T record);
        T Retrieve(int id);
        IEnumerable<T> Retrieve();
        void Update(T record);
        void Delete(int id);
    }
}
