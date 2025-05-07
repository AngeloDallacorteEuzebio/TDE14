using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE14
{
    public class Carro : Veiculo
    {
        public bool ArCondicionado { get; set; }

        public Carro(string marca, string modelo, bool arCondicionado)
            : base(marca, modelo)
        {
            ArCondicionado = arCondicionado;
        }

        public override double CalcularPreco()
        {
            double precoBase = base.CalcularPreco();
            return ArCondicionado ? precoBase + 3000.00 : precoBase;
        }
    }
}

