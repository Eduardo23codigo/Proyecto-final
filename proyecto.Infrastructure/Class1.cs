using Microsoft.EntityFrameworkCore;
using proyecto.Domain;
using System.Collections.Generic;

namespace proyecto.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<SampleEntity> SampleEntities { get; set; }
    }

    public class SampleRepository : ISampleRepository
    {
        private readonly AppDbContext _context;

        public SampleRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(SampleEntity entity)
        {
            _context.SampleEntities.Add(entity);
            _context.SaveChanges();
        }
    }
}