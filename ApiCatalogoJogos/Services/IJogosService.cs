
using ApiCatalogoJogos.InputModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.IJogosService
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogosViewModel>> Obter(int pagina, int quantidade);
        Task<JogosViewModel> Obter(Guid id);
        Task<JogosViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}