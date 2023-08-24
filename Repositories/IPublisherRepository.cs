using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWPub.Api.Entites;

namespace JWPub.Api.Repositories
{
    public interface IPublisherRepository
    {
        Task<Publisher> CreateAsync(Publisher publisher);
        Task<Publisher> UpdateAsync(Publisher publisher, Guid id);
        Task DeleteAsync(Guid id);
        Task<Publisher> GetAsync(Guid id);
        Task<IEnumerable<Publisher>> GetAllAsync();
    }
}