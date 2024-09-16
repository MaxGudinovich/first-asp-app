using BD.Entities;
using Microsoft.EntityFrameworkCore;

namespace BD.DataAccess
{
    public class ActorRepo : IActorRepo
    {
        private readonly DbSet<ActorEntity> _dbSet;
        private readonly DbContext _context;

        public ActorRepo(DbContext context)
        {
            _dbSet = context.Set<ActorEntity>();
            _context = context;
        }

        public ActorEntity GetById(int id)
        {
            var result = _dbSet.Find(id);

            return result;
        }
    }
}