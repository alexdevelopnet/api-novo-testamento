 
using ApiNovoTestamento.Models;
using Microsoft.EntityFrameworkCore;

namespace api_novo_testamento.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Apostolo> Apostolos { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

    }
}