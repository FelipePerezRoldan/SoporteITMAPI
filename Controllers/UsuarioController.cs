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
    [RoutePrefix("api/Usuarios")]
    [EnableCors(origins: "https://localhost:44364", headers: "*", methods: "*")]

    public class UsuarioController : ApiController
    {
        [HttpGet]
        [Route("ConsultarUsuario")]
        public Usuario ConsultarTecnico(string DocumentoUsuario)
        {
            clsUsuario usuario = new clsUsuario();
            return usuario.Consultar(DocumentoUsuario);
        }




        [HttpPut]
        [Route("ActualizarUsuario")]
        public string ActualizarUsuario([FromBody] Usuario usuario)
        {
            clsUsuario _usuario = new clsUsuario();
            _usuario.usuario = usuario;
            return _usuario.ActualizarUsuario();

        }



        [HttpPost]
        [Route("InsertarUsuario")]
        public string InsertarUsuario([FromBody] Usuario usuario)
        {
            clsUsuario _usuario = new clsUsuario();
            _usuario.usuario = usuario;
            return _usuario.InsertarUsuario();
        }

        [HttpDelete]
        [Route("EliminarUsuario")]

        public string EliminarUsuario(string DocumentoUsuario)
        {

            clsUsuario _usuario = new clsUsuario();
            return _usuario.EliminarUsuario(DocumentoUsuario);

        }
    }
}