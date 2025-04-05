using DAL;
using EL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public static class BusControlService
    {
        //-------------------
        public static void AsignarChoferAutobusRuta(int choferID, int autobusID, int rutaID)
        {
            // Verificación de disponibilidad se realiza en el repositorio
            BusControlRepository.AsignarChoferAutobusRuta(choferID, autobusID, rutaID);
        }

        //--------------------
        public static void AgregarChofer(string nombre, string apellido, DateTime fechaNacimiento, string cedula)
        {
            BusControlRepository.AgregarChofer(nombre, apellido, fechaNacimiento, cedula);
        }

        public static void AgregarAutobus(string marca, string modelo, string placa, string color, int ano)
        {
            BusControlRepository.AgregarAutobus(marca, modelo, placa, color, ano);
        }

        public static void AgregarRuta(string nombreRuta)
        {
            BusControlRepository.AgregarRuta(nombreRuta);
        }

        //public static void AsignarChoferAutobusRuta(int choferID, int autobusID, int rutaID)
        //{
        //    BusControlRepository.AsignarChoferAutobusRuta(choferID, autobusID, rutaID);
        //}

        public static List<Chofer> ObtenerChoferes()
        {
            return BusControlRepository.ObtenerChoferes();
        }

        public static List<Autobus> ObtenerAutobuses()
        {
            return BusControlRepository.ObtenerAutobuses();
        }

        public static List<Ruta> ObtenerRutas()
        {
            return BusControlRepository.ObtenerRutas();
        }

        public static List<Asignacion> ObtenerAsiganciones()
        {
            return BusControlRepository.ObtenerAsiganciones();
        }
    }
}
