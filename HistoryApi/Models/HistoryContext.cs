using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace HistoryApi.Models
{
    public class HistoryContext : DbContext
    {
        public HistoryContext(DbContextOptions<HistoryContext> options)
            : base(options)
        {
        }

        public DbSet<History> History { get; set; } = null!;

    }
}
