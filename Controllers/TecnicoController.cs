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
    [EnableCors(origins: "https://localhost:44364", headers: "*", methods: "*")]
    [RoutePrefix("api/Tecnicos")]
    public class TecnicoController : ApiController
    {

        [HttpGet]
        [Route("ConsultarTecnico")]
        public Tecnico ConsultarTecnico(string DocumentoTecnico)
        {
            clsTecnico tecnico = new clsTecnico();
            return tecnico.Consultar(DocumentoTecnico);
        }




        [HttpPut]
        [Route("ActualizarTecnico")]
        public string ActualizarTecnico([FromBody] Tecnico tecnico)
        {
            clsTecnico _tecnico = new clsTecnico();
            _tecnico.tecnico = tecnico;
            return _tecnico.ActualizarTecnico();

        }



        [HttpPost]
        [Route("InsertarTecnico")]
        public string InsertarTecnico([FromBody] Tecnico tecnico)
        {
            clsTecnico _tecnico = new clsTecnico();
            _tecnico.tecnico = tecnico;
            return _tecnico.InsertarTecnico();
        }

        [HttpDelete]
        [Route("EliminarTecnico")]

        public string EliminarTecnico(string DocumentoTecnico)
        {

            clsTecnico _tecnico = new clsTecnico();
            
            return _tecnico.EliminarTecnico(DocumentoTecnico);

        }
        
    }
}