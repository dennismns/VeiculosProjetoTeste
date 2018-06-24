using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VeiculosProjetoTeste.Dados;

namespace VeiculosProjetoTeste.Models
{
    public class Acessorio
    {
		[Key]
		public int AcessorioId { get; set; }

		public string Nome { get; set; }
		public ICollection<CarroAcessorio> CarroAcessorios { get; set; }

		public Acessorio()
		{
			//Carros = new Collection<Carro>();
		}
	}
}
