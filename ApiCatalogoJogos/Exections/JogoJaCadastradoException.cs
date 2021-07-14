using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Exceptions
{
    public class JogoJaCadatradoException : Exception 

    {
        public JogoJaCadatradoException()
            : base("Este jogo ja está cadastrado")
        { }
    }
}
