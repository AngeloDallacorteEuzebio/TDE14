using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Globalization;

namespace TDE14
{
    public class Loja
    {
        private List<Veiculo> veiculos = new List<Veiculo>();

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
        }

        public void ListarVeiculos()
        {
            foreach (var veiculo in veiculos)
            {
                string precoFormatado = veiculo.CalcularPreco().ToString("C", new CultureInfo("pt-BR"));
                Console.WriteLine($"Marca: {veiculo.Marca}, Modelo: {veiculo.Modelo}, Preço: {precoFormatado}");
            }
        }
    }
}

