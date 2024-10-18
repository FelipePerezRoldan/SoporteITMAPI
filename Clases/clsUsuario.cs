using SoporteITMAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace SoporteITMAPI.Clases
{
    public class clsUsuario
    {
        private SoporteEntities SoporteEntities = new SoporteEntities();
        public Usuario usuario { get; set; }

        public Usuario Consultar(string DocumentoUsuario)
        {
            try
            {
                return SoporteEntities.Usuarios.FirstOrDefault(u => u.DocumentoUsuario == DocumentoUsuario);

            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar el Usuario: " + ex.Message);
            }

        }

        public string InsertarUsuario()
        {
            try
            {
                SoporteEntities.Usuarios.Add(usuario);
                SoporteEntities.SaveChanges();

                return "Se insertó el usuario con nombre: " + usuario.Nombre;
            }
            catch (Exception ex)
            {
                return "error al insertar el usuario " + ex.Message;
            }

        }

        public string ActualizarUsuario()
        {
            try
            {
                // Buscar el usuario por el documento
                var usuarioExistente = SoporteEntities.Usuarios.FirstOrDefault(u => u.DocumentoUsuario == usuario.DocumentoUsuario);

                if (usuarioExistente != null)
                {
                    // Actualizar la información del usuario existente
                    usuarioExistente.Nombre = usuario.Nombre;
                    usuarioExistente.Apellido = usuario.Apellido;
                    usuarioExistente.Email = usuario.Email;
                    usuarioExistente.Telefono = usuario.Telefono;
                    usuarioExistente.Departamento = usuario.Departamento;
                    usuarioExistente.Cargo = usuario.Cargo;

                    SoporteEntities.SaveChanges();
                    return "Se actualizó el usuario: " + usuario.Nombre;
                }
                else
                {
                    return "No se encontró el usuario con el documento: " + usuario.DocumentoUsuario;
                }
            }
            catch (Exception ex)
            {
                return "Error al actualizar el usuario: " + ex.Message;
            }
        }



        public string EliminarUsuario(string documentoUsuario)
        {
            try
            {
                // Buscar el usuario por el documento
                var usuarioExistente = SoporteEntities.Usuarios.FirstOrDefault(u => u.DocumentoUsuario == documentoUsuario);

                if (usuarioExistente != null)
                {
                    // Eliminar el usuario existente
                    SoporteEntities.Usuarios.Remove(usuarioExistente);
                    SoporteEntities.SaveChanges();
                    return "Se eliminó el usuario: " + usuarioExistente.Nombre;
                }
                else
                {
                    return "No se encontró el usuario con el documento: " + documentoUsuario;
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar el usuario: " + ex.Message;
            }
        }

    }
}