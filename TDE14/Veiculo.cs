using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TDE14
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public virtual double CalcularPreco()
        {
            return 20000.00;
        }
    }
}

