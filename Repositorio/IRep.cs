using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IRep<T> where T : class
    {
        void Adicionar(T obj);
        void Remover(T obj);
        List<T> Listar();
        void Salvar(string caminhoArquivo);
        void Carregar(string caminhoArquivo);
    }
}
