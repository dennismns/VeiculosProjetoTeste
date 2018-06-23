using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using VeiculosProjetoTeste.Dados;

namespace VeiculosProjetoTeste.Models
{
    public class Carro
    {
		public int CarroId { get; set; }

		public string Marca { get; set; }

		public DateTime DataCompra { get; set; }

		public string Descricao { get; set; }

		public string Cor { get; set; }

		public ICollection<CarroAcessorio> Acessorios { get; set; }
		//public virtual ICollection<Acessorio> Acessorios { get; set; }

		public Carro()
		{
			//Acessorios = new Collection<Acessorio>();
		}
	}
}
