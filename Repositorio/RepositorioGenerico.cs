using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace Repositorio
{
    public class RepositorioGenerico<T> : IRep<T> where T : class
    {
        static List<T> lista;
        public void Iniciar()
        {
            lista = new List<T>();
        }

        
        public void Adicionar(T obj)
        {
            lista.Add(obj);
        }

        public List<T> Listar()
        {
            return lista.ToList();
        }

        public void Remover(T obj)
        {
            lista.Remove(obj);
        }
        
        public void Salvar(string caminhoArquivo)
        {
            var json = JsonSerializer.Serialize(lista, new JsonSerializerOptions{WriteIndented=true});
            File.WriteAllText(caminhoArquivo, json);
        }

        public void Carregar(string caminhoArquivo)
        {
            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                lista = JsonSerializer.Deserialize<List<T>>(json);
            }
            else
            {
                lista = new List<T>();
            }
        }




    }
}
