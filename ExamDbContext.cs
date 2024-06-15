using ExamApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamApp
{
    public class ExamDbContext : DbContext
    {
        public ExamDbContext(DbContextOptions<ExamDbContext> options)
            : base(options)
        {
        }

        public DbSet<ExamResult> ExamResults { get; set; }
    }
}
