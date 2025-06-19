using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REP;
using Repositorio;
using REP.Models;

namespace REP.Service
{
    public class ServicePessoa
    {
        private readonly RepPessoa<Pessoa> repo;

        public ServicePessoa()
        {
            repo = new RepPessoa<Pessoa>();
            repo.Carregar(@"C:\jsonteste\arquivoJson.json");
        }

        public void ListarMesmo()
        {
            List<Pessoa> lista= repo.Listar();
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.Nome} e {item.Idade}");
            }
            Console.ReadLine();        }

        public void Adicionar(Pessoa pessoa)
        {
            repo.Adicionar(pessoa);
        }

        public void Remover(Pessoa pessoa)
        {
            repo.Remover(pessoa);
        }
    }
}
