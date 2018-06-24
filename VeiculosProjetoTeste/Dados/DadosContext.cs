using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeiculosProjetoTeste.Models;

namespace VeiculosProjetoTeste.Dados
{
	public class DadosContext : DbContext
	{
		public DadosContext(DbContextOptions<DadosContext> options) : base(options)
		{
		}


		public DbSet<Carro> Carros { get; set; }

		public DbSet<Acessorio> Acessorios { get; set; }

		public DbSet<CarroAcessorio> CarroAcessorios { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Carro>().ToTable("Carro");

			modelBuilder.Entity<Acessorio>().ToTable("Acessorio");

			//modelBuilder.Entity<Carro>()
			//	.HasKey(x => x.CarroId);

			//modelBuilder.Entity<Acessorio>()
			//	.HasKey(x => x.AcessorioId);
			modelBuilder.Entity<CarroAcessorio>()
				.HasKey(ca => new { ca.CarroId, ca.AcessorioId });
			//modelBuilder.Entity<CarroAcessorio>()
			//	.HasKey(x => new { x.fk_CarroId, x.fk_AcessorioId });
			modelBuilder.Entity<CarroAcessorio>()
				.HasOne<Carro>(ca => ca.Carro)
				.WithMany(c => c.CarrosAcessorios)
				.HasForeignKey(ca => ca.CarroId);


			modelBuilder.Entity<CarroAcessorio>()
				.HasOne<Acessorio>(ac => ac.Acessorio)
				.WithMany(a => a.CarroAcessorios)
				.HasForeignKey(x => x.AcessorioId);


			modelBuilder.Entity<Carro>()
				.Property(c => c.CarroId)
				.HasColumnName("CarroId")
				.IsRequired();

			modelBuilder.Entity<Carro>()
				.Property(c => c.Marca)
				.HasColumnName("Marca")
				.HasColumnType("varchar(50)")
				.HasMaxLength(50)
				.IsRequired();

			modelBuilder.Entity<Carro>()
				.Property(c => c.Descricao)
				.HasColumnName("Descricao");

			modelBuilder.Entity<Carro>()
				.Property(c => c.DataCompra)
				.HasColumnName("DataCompra")
				.IsRequired();

			modelBuilder.Entity<Carro>()
				.Property(c => c.Cor)
				.HasColumnName("Cor")
				.IsRequired();

			modelBuilder.Entity<Acessorio>()
				.Property(c => c.AcessorioId)
				.HasColumnName("AcessorioId");

			modelBuilder.Entity<Acessorio>()
				.Property(c => c.Nome)
				.HasColumnName("Nome")
				.HasColumnType("varchar(50)")
				.IsRequired();
		}

	}
}