namespace PolizaSeguros.Data
{
	using Model.Model;
	using System.Data.Entity;
	using System.Data.Entity.ModelConfiguration.Conventions;

	using polizaConfig = Common.Configuration;

	public class PSContext : DbContext
	{

		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<ClientePoliza> ClientePolizas { get; set; }
		public DbSet<Estado> Estados { get; set; }
		public DbSet<Poliza> Polizas { get; set; }
		public DbSet<PolizaTipoCubrimiento> PolizaTipoCubrimientos { get; set; }
		public DbSet<TipoCubrimiento> TipoCubrimientos { get; set; }
		public DbSet<TipoDocumento> TipoDocumentos { get; set; }
		public DbSet<TipoRiesgo> TipoRiesgos { get; set; }

		public PSContext() : base(polizaConfig.Configuration.PolizaDB)
		{

		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			#region Primary Keys

			//Primary keys
			modelBuilder.Entity<Cliente>().HasKey<int>(c => c.IdCliente);
			modelBuilder.Entity<ClientePoliza>().HasKey<int>(c => c.IdClientePoliza);
			modelBuilder.Entity<Estado>().HasKey<int>(c => c.IdEstado);
			modelBuilder.Entity<Poliza>().HasKey<int>(c => c.IdPoliza);
			modelBuilder.Entity<PolizaTipoCubrimiento>().HasKey<int>(c => c.IdPolizaCubrimiento);
			modelBuilder.Entity<TipoCubrimiento>().HasKey<int>(c => c.IdTipoCubrimiento);
			modelBuilder.Entity<TipoDocumento>().HasKey<int>(c => c.IdTipoDocumento);
			modelBuilder.Entity<TipoRiesgo>().HasKey<int>(c => c.IdTipoRiesgo);
			#endregion

			#region Foreign keys

			//Foreign keys one-to-many
			modelBuilder.Entity<Cliente>()
			 .HasRequired<TipoDocumento>(s => s.TipoDocumento)
			 .WithMany(s => s.Clientes)
			 .HasForeignKey(s => s.IdTipoDocumento);

			modelBuilder.Entity<ClientePoliza>()
			 .HasRequired<Cliente>(s => s.Cliente)
			 .WithMany(s => s.ClientePolizas)
			 .HasForeignKey(s => s.IdCliente);

			modelBuilder.Entity<ClientePoliza>()
			 .HasRequired<Poliza>(s => s.Poliza)
			 .WithMany(s => s.ClientePolizas)
			 .HasForeignKey(s => s.IdPoliza);

			modelBuilder.Entity<ClientePoliza>()
			 .HasRequired<Estado>(s => s.Estado)
			 .WithMany(s => s.ClientePolizas)
			 .HasForeignKey(s => s.IdEstado);

			modelBuilder.Entity<Poliza>()
			 .HasRequired<TipoRiesgo>(s => s.TipoRiesgo)
			 .WithMany(s => s.Polizas)
			 .HasForeignKey(s => s.IdTipoRiesgo);

			modelBuilder.Entity<PolizaTipoCubrimiento>()
			 .HasRequired<Poliza>(s => s.Poliza)
			 .WithMany(s => s.PolizaTipoCubrimientos)
			 .HasForeignKey(s => s.IdPoliza);

			modelBuilder.Entity<PolizaTipoCubrimiento>()
			 .HasRequired<TipoCubrimiento>(s => s.TipoCubrimiento)
			 .WithMany(s => s.PolizaTipoCubrimientos)
			 .HasForeignKey(s => s.IdTipoCubrimiento);

			#endregion

		}
	}
}
