using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Data.Interfaces
{
    public interface ICatalogContext
    {
        public IMongoCollection<Product> Products { get; }
    }
}
