using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWPub.Api.Entites;

namespace JWPub.Api.Repositories
{
    public interface ICongregationRepository
    {
        Task<Congregation> GetAsync(Guid id);
        Task<IEnumerable<Congregation>> GetAllAsync();
        Task<Congregation> CreateAsync(Congregation newCongregation);
        Task<Congregation> UpdateAsync(Guid id, Congregation newCongregation);
        Task DeleteAsync(Guid id);
    }
}