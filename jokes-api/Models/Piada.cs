using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jokes.Models
{
    public class Piada
    {
        public  string _titulo { get; set; }

        public string _categoria { get; set; }

        public  string _texto { get; set; }

        public  string _classificacao { get; set; }

        public Piada()
        {
            _titulo = "";
            _categoria = "";
            _texto = "";
            _classificacao = "";
        }

        public List<Piada> GetAllPiadas()
        {
            return new List<Piada>()
            {
                new Piada()
                {   _titulo = "A loira e o cabelo",
                    _texto = "O que é uma loira com o cabelo pintado de preto? Inteligência Artificial.",
                    _categoria = "Loira",
                    _classificacao = "Livre"
                },
                new Piada()
                {
                     _titulo = "Joãozinho e as laranjas",
                     _texto = "Na escola, a professora pergunta ao Joãozinho: – Joãozinho, eu tenho sete laranjas nesta mão e oito na outra. O que é que eu tenho? – Mãos grandes!…",
                     _categoria = "Joãozinho",
                     _classificacao = "Livre"
                }
            };
        }
    }
}
