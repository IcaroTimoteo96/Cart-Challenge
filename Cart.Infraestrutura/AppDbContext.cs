using Cart.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Cart.Infraestrutura
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Carrinho> Carrinhos { get; set; }

        public DbSet<ItemCarrinho> ItensCarrinho { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ItemCarrinho>()
                .HasOne(ic => ic.Carrinho)  // Um ItemCarrinho tem um Carrinho
                .WithMany(c => c.ItensCarrinho)  // Um Carrinho tem muitos ItemCarrinhos
                .HasForeignKey(ic => ic.CarrinhoID);  // A ForeignKey é CarrinhoID
        }
    }
}
