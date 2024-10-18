using SoporteITMAPI.Models;
using System;
using System.Linq;

namespace SoporteITMAPI.Clases
{
    public class clsEquipo
    {
        private SoporteEntities SoporteEntities = new SoporteEntities();
        public Equipos equipo { get; set; }

        public Equipos Consultar(string NumeroSerie)
        {
            try
            {
                return SoporteEntities.Equipos.FirstOrDefault(e => e.NumeroSerie== NumeroSerie);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el equipo: " + ex.Message);
            }
        }

        public string InsertarEquipo()
        {
            try
            {
                SoporteEntities.Equipos.Add(equipo);
                SoporteEntities.SaveChanges();

                return "Se insertó el equipo con nombre: " + equipo.NombreEquipo;
            }
            catch (Exception ex)
            {
                return "Error al insertar el equipo: " + ex.Message;
            }
        }

        public string ActualizarEquipo()
        {
            try
            {
                var equipoExistente = SoporteEntities.Equipos.FirstOrDefault(e => e.NumeroSerie == equipo.NumeroSerie);

                if (equipoExistente != null)
                {
                    equipoExistente.NombreEquipo = equipo.NombreEquipo;
                    equipoExistente.TipoEquipo = equipo.TipoEquipo;
                    equipoExistente.NumeroSerie = equipo.NumeroSerie;
                    equipoExistente.idUsuario = equipo.idUsuario;

                    SoporteEntities.SaveChanges();
                    return "Se actualizó el equipo: " + equipo.NombreEquipo;
                }
                else
                {
                    return "No se encontró el equipo con el ID: " + equipo.idEquipo;
                }
            }
            catch (Exception ex)
            {
                return "Error al actualizar el equipo: " + ex.Message;
            }
        }

        public string EliminarEquipo(string NumeroSerie)
        {
            try
            {
                var equipoExistente = SoporteEntities.Equipos.FirstOrDefault(e => e.NumeroSerie == NumeroSerie);

                if (equipoExistente != null)
                {
                    SoporteEntities.Equipos.Remove(equipoExistente);
                    SoporteEntities.SaveChanges();
                    return "Se eliminó el equipo: " + equipoExistente.NombreEquipo;
                }
                else
                {
                    return "No se encontró el equipo con el ID: " + NumeroSerie;
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar el equipo: " + ex.Message;
            }
        }
    }
}
