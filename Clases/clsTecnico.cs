using SoporteITMAPI.Models;
using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace SoporteITMAPI.Clases
{
    public class clsTecnico
    {
        private SoporteEntities SoporteEntities = new SoporteEntities();
        public Tecnico tecnico { get; set; }

        public Tecnico Consultar(string DocumentoTecnico)
        {
            try
            {
                return SoporteEntities.Tecnicos.FirstOrDefault(t => t.DocumentoTecnico == DocumentoTecnico);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el Tecnico: " + ex.Message);
            }
        }

        public string InsertarTecnico()
        {
            try
            {
                SoporteEntities.Tecnicos.Add(tecnico);
                SoporteEntities.SaveChanges();
                return "Se insertó el tecnico con nombre: " + tecnico.Nombre;
            }
            catch (Exception ex)
            {
                return "error al insertar el tecnico " + ex.Message;
            }
        }

        public string ActualizarTecnico()
        {
            try
            {
                // Buscar el tecnico por el documento
                var tecnicoExistente = SoporteEntities.Tecnicos.FirstOrDefault(t => t.DocumentoTecnico == tecnico.DocumentoTecnico);

                if (tecnicoExistente != null)
                {
                    // Actualizar la información del tecnico existente
                    tecnicoExistente.Nombre = tecnico.Nombre;
                    tecnicoExistente.Apellido = tecnico.Apellido;
                    tecnicoExistente.Email = tecnico.Email;
                    tecnicoExistente.Telefono = tecnico.Telefono;
                    tecnicoExistente.Especialidad = tecnico.Especialidad;

                    SoporteEntities.SaveChanges();
                    return "Se actualizó el tecnico: " + tecnico.Nombre;
                }
                else
                {
                    return "No se encontró el tecnico con el documento: " + tecnico.DocumentoTecnico;
                }
            }
            catch (Exception ex)
            {
                return "Error al actualizar el tecnico: " + ex.Message;
            }
        }

        public string EliminarTecnico(string DocumentoTecnico)
        {
            try
            {
                // Buscar el tecnico por el documento
                var tecnicoExistente = SoporteEntities.Tecnicos.FirstOrDefault(t => t.DocumentoTecnico == DocumentoTecnico);

                if (tecnicoExistente != null)
                {
                    // Eliminar el tecnico existente
                    SoporteEntities.Tecnicos.Remove(tecnicoExistente);
                    SoporteEntities.SaveChanges();
                    return "Se eliminó el tecnico: " + tecnicoExistente.Nombre;
                }
                else
                {
                    return "No se encontró el tecnico con el documento: " + DocumentoTecnico;
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar el tecnico: " + ex.Message;
            }
        }
    }
}
