using System;

namespace TDE14
{
    class Program
    {
        static void Main(string[] args)
        {
            var loja = new Loja();

            var veiculoPadrao = new Veiculo("Fiat", "Uno");
            var carro = new Carro("Toyota", "Corolla", true);
            var moto = new Moto("Honda", "CG Titan");

            loja.AdicionarVeiculo(veiculoPadrao);
            loja.AdicionarVeiculo(carro);
            loja.AdicionarVeiculo(moto);

            loja.ListarVeiculos();
        }
    }
}

