using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace BindingData.Models
{
    public class ApplicationUser : DbContext
    {
        public ApplicationUser(DbContextOptions<ApplicationUser> options) : base(options)
        {

        }

        public DbSet<Country> country { get; set; }
    }
}
