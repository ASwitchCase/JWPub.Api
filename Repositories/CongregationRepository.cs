using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWPub.Api.Entites;

namespace JWPub.Api.Repositories
{
    public class CongregationRepository : ICongregationRepository
    {
        private readonly List<Congregation> database = new(){
            new Congregation { 
                Name = "Jersey City Central",
                Id = Guid.NewGuid() 
            },
            new Congregation { 
                Name = "Jersey City West",
                Id = Guid.NewGuid() 
            },
            new Congregation { 
                Name = "Downtown Spanish",
                Id = Guid.NewGuid() 
            },
            new Congregation { 
                Name = "Bayonne English",
                Id = Guid.NewGuid() 
            },
        };

        public async Task<Congregation> CreateAsync(Congregation congregation)
        {
            database.Add(congregation);
            return await Task.FromResult(congregation);
        }

        public async Task DeleteAsync(Guid id)
        {
            int index = database.FindIndex(x => x.Id == id);
            database.RemoveAt(index);

            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Congregation>> GetAllAsync()
        {
            return await Task.FromResult(database);
        }

        public async Task<Congregation> GetAsync(Guid id)
        {
            int index = database.FindIndex(x => x.Id == id); 
            return await Task.FromResult(database[index]);
        }

        public async Task<Congregation> UpdateAsync(Guid id, Congregation newCongregation)
        {
            int index = database.FindIndex(x => x.Id == id);
            database[index] = newCongregation;

            return await Task.FromResult(database[index]);
        }
    }
}