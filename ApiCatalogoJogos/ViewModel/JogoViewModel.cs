using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.InputModel
{
    public class JogosViewModel
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Produtora { get; set; }

        public double Preco { get; set; }
    }
}