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

		public ICollection<CarroAcessorio> CarrosAcessorios { get; set; }
		//public virtual ICollection<Acessorio> Acessorios { get; set; }

		public Carro()
		{
			CarrosAcessorios = new Collection<CarroAcessorio>();
		}
	}
}
