using SoporteITMAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoporteITMAPI.Clases
{
    public class clsEstado
    {
        private SoporteEntities SoporteEntities = new SoporteEntities();
        public Estado estado { get; set; }

        // Consultar Estado por ID
        public Estado Consultar(int idEstado)
        {
            try
            {
                return SoporteEntities.Estados.FirstOrDefault(e => e.idEstado == idEstado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el estado: " + ex.Message);
            }
        }

        // Insertar Estado
        public string InsertarEstado()
        {
            try
            {
                SoporteEntities.Estados.Add(estado);
                SoporteEntities.SaveChanges();
                return "Se insertó el estado con descripción: " + estado.DescripcionEstado;
            }
            catch (Exception ex)
            {
                return "Error al insertar el estado: " + ex.Message;
            }
        }

        // Actualizar Estado
        public string ActualizarEstado()
        {
            try
            {
                var estadoExistente = SoporteEntities.Estados.FirstOrDefault(e => e.idEstado == estado.idEstado);

                if (estadoExistente != null)
                {
                    estadoExistente.DescripcionEstado = estado.DescripcionEstado;
                    SoporteEntities.SaveChanges();
                    return "Se actualizó el estado: " + estado.DescripcionEstado;
                }
                else
                {
                    return "No se encontró el estado con ID: " + estado.idEstado;
                }
            }
            catch (Exception ex)
            {
                return "Error al actualizar el estado: " + ex.Message;
            }
        }

        // Eliminar Estado
        public string EliminarEstado(int idEstado)
        {
            try
            {
                var estadoExistente = SoporteEntities.Estados.FirstOrDefault(e => e.idEstado == idEstado);

                if (estadoExistente != null)
                {
                    SoporteEntities.Estados.Remove(estadoExistente);
                    SoporteEntities.SaveChanges();
                    return "Se eliminó el estado: " + estadoExistente.DescripcionEstado;
                }
                else
                {
                    return "No se encontró el estado con ID: " + idEstado;
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar el estado: " + ex.Message;
            }
        }
    }
}