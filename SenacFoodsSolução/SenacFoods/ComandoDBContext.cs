using Microsoft.EntityFrameworkCore;

namespace SenacFoods
{
    public class ComandoDBContext:DbContext
    {
        public ComandoDBContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexao = "Server=localhost;Database=SenacFoods;User=root;Password=";

            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CardapioItem> CardapioItems { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Comanda>Comandas { get; set; }
        public DbSet<ComandaItem> ComandaItems { get; set; }
        public DbSet<PedidoCozinha> PedidoCozinhas { get; set; }
        public DbSet<PedidoCozinhaItem>PedidoCozinhaItems { get; set; }
        
    }
}
