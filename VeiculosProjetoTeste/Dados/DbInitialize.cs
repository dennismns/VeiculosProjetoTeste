using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeiculosProjetoTeste.Models;

namespace VeiculosProjetoTeste.Dados
{
    public class DbInitialize
    {
		 public static void Initialize(Dados.DadosContext context)
        {
            context.Database.EnsureCreated();

            if (context.Carros.Any() && context.Acessorios.Any() && context.CarroAcessorios.Any())
            {
                return;
            }

            var Carros = new Carro[]
            {
            new Carro{Marca="Chevrolet",DataCompra=DateTime.Parse("10-02-2015"),Descricao="Completo com ar direção",Cor="Azul "},
            new Carro{Marca="Fiat",DataCompra=DateTime.Parse("09-01-2000"),Descricao="Completo com ar direção e (ABS)",Cor="Amarelo"},
            new Carro{Marca="Fiat",DataCompra=DateTime.Parse("09-01-1995"),Descricao="Basico",Cor="Rxo"},
            new Carro{Marca="BMW",DataCompra=DateTime.Parse("15-06-2017"),Descricao="Completa ",Cor="Cinza"},
            new Carro{Marca="Volkswagen",DataCompra=DateTime.Parse("27-08-1977"),Descricao="basico",Cor="preto"},
            new Carro{Marca="Audi",DataCompra=DateTime.Parse("05-11-2018"),Descricao="Comlpeto",Cor="verde"},
            new Carro{Marca="ferrari",DataCompra=DateTime.Parse("22-12-2000"),Descricao="Completa",Cor="vermelha"},
            new Carro{Marca="Mercedes",DataCompra=DateTime.Parse("03-10-2005"),Descricao="Completo",Cor="cinza"}
            };
            foreach (Carro s in Carros)
            {
                context.Carros.Add(s);
            }
            context.SaveChanges();


			


			var Acessorios = new Acessorio[]
			{
			new Acessorio{Nome="Tapete"},
			new Acessorio{Nome="CD play"},
			new Acessorio{Nome="DVD"},
			new Acessorio{Nome="Mutimidia"},
			new Acessorio{Nome="Alarme"},
			new Acessorio{Nome="Trava"},
			new Acessorio{Nome="vidro eletrico"},
			new Acessorio{Nome="vidro eletrico"}
			};
			foreach (Acessorio a in Acessorios)
			{
				context.Acessorios.Add(a);
			}
			context.SaveChanges();



			var CarroAcessorios = new CarroAcessorio[]
			{
			new CarroAcessorio{CarroId=1,AcessorioId=2},
			new CarroAcessorio{CarroId=2,AcessorioId=3},
			new CarroAcessorio{CarroId=3,AcessorioId=2},
			new CarroAcessorio{CarroId=4,AcessorioId=4},
			new CarroAcessorio{CarroId=5,AcessorioId=6},
			new CarroAcessorio{CarroId=6,AcessorioId=5},
			new CarroAcessorio{CarroId=7,AcessorioId=7},
			new CarroAcessorio{CarroId=8,AcessorioId=2}
			};
			foreach (CarroAcessorio ca in CarroAcessorios)
			{
				context.CarroAcessorios.Add(ca);
			}
			context.SaveChanges();


		}



    }
}
