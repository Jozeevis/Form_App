using Microsoft.EntityFrameworkCore;
using Valtech_Form_BusinessLogic.Models;

namespace Valtech_Form_BusinessLogic.Data
{
    public class FormDbContext : DbContext
    {
        public FormDbContext(DbContextOptions<FormDbContext> options) : base(options)
        {
        }

        public DbSet<FormModel> FormEntries { get; set; }
    }
}
