using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _dbContext;
        public ActorsService(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task AddAsync(Actor actor)
        {
            await _dbContext.Actors.AddAsync(actor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _dbContext.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _dbContext.Actors.Remove(result);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var results = await _dbContext.Actors.ToListAsync();
            return results;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _dbContext.Actors.FirstOrDefaultAsync(a => a.Id == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _dbContext.Update(newActor);
            await _dbContext.SaveChangesAsync();
            return newActor;
        }
    }
}
