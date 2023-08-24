using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWPub.Api.Entites;

namespace JWPub.Api.Repositories
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly List<Publisher> database = new(){
            new Publisher{
                Name = "Jacques Adams",
                SpiritualStatus = "Ministerial Servant",
                Congregation = "Jersey City Central English",
                Id = Guid.NewGuid()
            },
            new Publisher{
                Name = "Emily Adams",
                SpiritualStatus = "Publisher",
                Congregation = "Jersey City Central English",
                Id = Guid.NewGuid()
            },
            new Publisher{
                Name = "Kevin Davis",
                SpiritualStatus = "Elder",
                Congregation = "Jersey City Central English",
                Id = Guid.NewGuid()
            },
            new Publisher{
                Name = "Kyrel Baskerville",
                SpiritualStatus = "Ministerial Servant",
                Congregation = "Bayonne East",
                Id = Guid.NewGuid()
            },
            
        };
        public async Task<Publisher> CreateAsync(Publisher publisher)
        {
            publisher.Id = Guid.NewGuid();
            database.Add(publisher);
            return await Task.FromResult(publisher);
        }

        public async Task DeleteAsync(Guid id)
        {
            int index = database.FindIndex(publisher => publisher.Id == id);
            database.RemoveAt(index);

            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Publisher>> GetAllAsync()
        {
            return await Task.FromResult(database);
        }

        public async Task<Publisher> GetAsync(Guid id)
        {
            int index = database.FindIndex(publisher =>publisher.Id == id);
            return await Task.FromResult(database[index]);
        }

        public async Task<Publisher> UpdateAsync(Publisher publisher, Guid id)
        {
            int index = database.FindIndex(pub => publisher.Id == id);
            database[index] = publisher;
            return await Task.FromResult(publisher);
        }
    }
}