using SoporteITMAPI.Clases;
using SoporteITMAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SoporteITMAPI.Controllers
{

    [RoutePrefix("api/Equipos")]
    [EnableCors(origins: "https://localhost:44364", headers: "*", methods: "*")]
    public class EquipoController : ApiController
    {

        [HttpGet]
        [Route("ConsultarEquipo")]
        public Equipos ConsultarEquipo(string NumeroSerie)
        {
            clsEquipo equipo = new clsEquipo();
            return equipo.Consultar(NumeroSerie);
        }

        [HttpPut]
        [Route("ActualizarEquipo")]
        public string ActualizarEquipo([FromBody] Equipos equipo)
        {
            clsEquipo _equipo = new clsEquipo();
            _equipo.equipo = equipo;
            return _equipo.ActualizarEquipo();
        }

        [HttpPost]
        [Route("InsertarEquipo")]
        public string InsertarEquipo([FromBody] Equipos equipo)
        {
            clsEquipo _equipo = new clsEquipo();
            _equipo.equipo = equipo;
            return _equipo.InsertarEquipo();
        }

        [HttpDelete]
        [Route("EliminarEquipo")]
        public string EliminarEquipo(string NumeroSerie)
        {
            clsEquipo _equipo = new clsEquipo();
            return _equipo.EliminarEquipo(NumeroSerie);
        }



    }
}