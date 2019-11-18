using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jokes.Models;

namespace jokes.Services
{
    public interface IPiadaService
    {
        Piada GetPiadaAleatoria();
        List<Piada> GetPiada(string titulo, string categoria, string classificacao);
    }
}
