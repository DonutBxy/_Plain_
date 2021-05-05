using Microsoft.EntityFrameworkCore;

namespace Clothes.Data
{
    public class ClothesContext : DbContext
    {
        public ClothesContext (
            DbContextOptions<ClothesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorClothes.Models.Clothes> Clothes { get; set; }
    }
}