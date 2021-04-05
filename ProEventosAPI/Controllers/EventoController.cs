using Microsoft.AspNetCore.Mvc;
using ProEventosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventosAPI.Controllers
{
    [ApiController]
    [Route("api/eventos")]
    public class EventoController : ControllerBase
    {

        [HttpGet]
        public ActionResult<Evento> Get()
        {
            return new Evento {      
                Id = 1,
                DataEvento = DateTime.Now,
                Local = "Lagu's",
                Lote="Primeiro",
                QtdPessoas=30,
                Tema="Luiz Gonzaga",
                UrlImg = "realy.jpg"
            };
        }
    }
}
