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
            Pessoa p5 = new Pessoa("Gui", 90);

            ServicePessoa servicePessoa = new ServicePessoa();
            //servicePessoa.ListarMesmo();
            //servicePessoa.Remover(p1);
            //Console.WriteLine("REMOVIDO P1");
            //servicePessoa.ListarMesmo();
            servicePessoa.Salvar();
            servicePessoa.Adicionar(p5);
            servicePessoa.ListarMesmo();










        }
    }
}
