using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE14
{
    public class Moto : Veiculo
    {
        public Moto(string marca, string modelo)
            : base(marca, modelo)
        {
        }

        public override double CalcularPreco()
        {
            return base.CalcularPreco() * 0.6;
        }
    }
}

