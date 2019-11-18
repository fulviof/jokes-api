using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jokes.Services;
using jokes.Models;
using Microsoft.AspNetCore.Mvc;

namespace jokes.Controllers
{
    [ApiController]
    public class PiadaController : Controller
    {
        private readonly IPiadaService _piadaService;

        public PiadaController(IPiadaService piadaService)
        {
            _piadaService = piadaService;
        }
        [Route("api/GetPiadaAleatoria")]
        public ActionResult Get()
        {
            var piada = _piadaService.GetPiadaAleatoria();
            return Json(new { result = piada });
        }
        [Route("api/GetPiada")]
        public ActionResult Get([FromQuery]string titulo, string categoria, string classificacao)
        {
            var piada = _piadaService.GetPiada(titulo, categoria, classificacao);
            return Json(new { result = piada });
        }
    }
}