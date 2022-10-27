#nullable disable

using Microsoft.EntityFrameworkCore;
using ShopCart.Models;

namespace ShopCart.DbContexts
{
    public partial class CoppelMxContext : DbContext
    {
        public CoppelMxContext()
        {
        }

        public CoppelMxContext(DbContextOptions<CoppelMxContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DetallePedido> DetallePedidos { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Server=192.168.1.54;Database=CoppelMx;user Id=testUser;password=whasaasahw;");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DetallePedido>(entity =>
            {
                entity.HasKey(e => new { e.FiNoPedido, e.FiProdId })
                    .HasName("PKDETALLE_PEDIDO")
                    .IsClustered(false);

                entity.ToTable("DETALLE_PEDIDO");

                entity.Property(e => e.FiNoPedido).HasColumnName("fiNoPedido");

                entity.Property(e => e.FiProdId).HasColumnName("fiProdId");

                entity.Property(e => e.FiCantArt).HasColumnName("fiCantArt");

                entity.Property(e => e.FnCostoPdcto)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fnCostoPdcto");

                //entity.HasOne(d => d.FiNoPedidoNavigation)
                //    .WithMany(p => p.DetallePedidos)
                //    .HasForeignKey(d => d.FiNoPedido)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK002_DETALLE_PEDIDO");

                //entity.HasOne(d => d.FiProd)
                //    .WithMany(p => p.DetallePedidos)
                //    .HasForeignKey(d => d.FiProdId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__DETALLE_P__fiPro__480696CE");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INVENTARIO");

                entity.Property(e => e.FiInvExist).HasColumnName("fiInvExist");

                entity.Property(e => e.FiProdId).HasColumnName("fiProdId");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.FiNoPedido)
                    .HasName("PKPEDIDOS");

                entity.ToTable("PEDIDO");

                entity.Property(e => e.FiNoPedido)
                    .ValueGeneratedNever()
                    .HasColumnName("fiNoPedido");

                entity.Property(e => e.FcUserId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fcUserId")
                    .IsFixedLength(true);

                entity.Property(e => e.FcWs)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fcWS")
                    .IsFixedLength(true);

                entity.Property(e => e.FdFecSurt)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fdFecSurt");

                entity.Property(e => e.FdPedFec)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fdPedFec");

                entity.Property(e => e.FiPedStat).HasColumnName("fiPedStat");

                entity.Property(e => e.FnPedSaldo)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("fnPedSaldo");

                entity.Property(e => e.FnPedTotal)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("fnPedTotal");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.FiProdId)
                    .HasName("PK__PRODUCTO__4C171ED4");

                entity.ToTable("PRODUCTO");

                entity.Property(e => e.FiProdId)
                    .ValueGeneratedNever()
                    .HasColumnName("fiProdId");

                entity.Property(e => e.FcProdDesc)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("fcProdDesc")
                    .IsFixedLength(true);

                entity.Property(e => e.FiClase).HasColumnName("fiClase");

                entity.Property(e => e.FiDepto).HasColumnName("fiDepto");

                entity.Property(e => e.FiSubClase).HasColumnName("fiSubClase");

                entity.Property(e => e.FiSubDepto).HasColumnName("fiSubDepto");

                entity.Property(e => e.FnProdPrecio)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fnProdPrecio");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
