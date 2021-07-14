using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Exceptions
{
    public class JogoNaoCadatradoException : Exception

    {
        public JogoNaoCadatradoException()
            : base("Este jogo Não está cadastrado")
        { }
    }
}
