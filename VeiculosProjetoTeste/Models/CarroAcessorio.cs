using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeiculosProjetoTeste.Models;

namespace VeiculosProjetoTeste.Dados
{
    public class CarroAcessorio
    {
		public int CarroId { get; set; }
		public Carro Carro { get; set; }

		public int AcessorioId { get; set; }
		public Acessorio Acessorio { get; set; }

		public CarroAcessorio()
		{
			

		}
	}
}
