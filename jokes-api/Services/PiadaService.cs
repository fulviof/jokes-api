using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jokes.Models;

namespace jokes.Services
{
    public class PiadaService : IPiadaService
    {
        public List<Piada> GetPiada(string titulo, string categoria, string classificacao)
        {
            var lista = new Piada().GetAllPiadas();

            if (!string.IsNullOrEmpty(titulo))
            {
                lista = lista.Where(x => x._titulo.Contains(titulo)).ToList();
            }

            if (!string.IsNullOrEmpty(categoria))
            {
                lista = lista.Where(x => x._categoria == categoria).ToList();
            }

            if (!string.IsNullOrEmpty(classificacao))
            {
                lista = lista.Where(x => x._classificacao == classificacao).ToList();
            }

            return lista;
        }

        public Piada GetPiadaAleatoria()
        {
            var lista = new Piada().GetAllPiadas();
            return lista.OrderBy(x => Guid.NewGuid()).FirstOrDefault();          
        }
    }
}
