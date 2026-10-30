using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    public class Bebida: Produto
    {
        EBebida _tipo;
        int _preco;
        string _nome;

        public Bebida(EBebida _tipo)
        {
            _preco = (int)_tipo;
            _nome = _tipo.ToString();
        }

        public override double CalcularValorFinal()
        {
            return _preco;
        }
    }
}
