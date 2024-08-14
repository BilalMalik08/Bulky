using Bulky.Models;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategorytRepository Category { get; }
        IProductRepository Product { get; }
        void Save();
    }
}
