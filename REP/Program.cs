using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;
using REP.Models;
using REP.Service;

namespace REP
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Gui",1);
            Pessoa p2 = new Pessoa("Gui", 23);
            Pessoa p3 = new Pessoa("Gui", 23);
            Pessoa p4 = new Pessoa("Gui", 23);
            Pessoa p5 = new Pessoa("Gui", 23);

            ServicePessoa servicePessoa = new ServicePessoa();
            servicePessoa.Adicionar(p1);
            servicePessoa.Adicionar(p2);
            servicePessoa.Adicionar(p3);
            servicePessoa.Adicionar(p4);
            servicePessoa.Adicionar(p5);
            servicePessoa.ListarMesmo();
            servicePessoa.Remover(p1);
            Console.WriteLine("REMOVIDO P1");
            servicePessoa.ListarMesmo();










        }
    }
}
