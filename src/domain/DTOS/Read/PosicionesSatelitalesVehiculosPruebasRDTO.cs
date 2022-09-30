using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOS.Read
{
    public class PosicionesSatelitalesVehiculosPruebasRDTO
    {
        public Guid Codigo { get; set; }
        public string Placa { get; set; }
        public string FechaPosicion { get; set; }
        public string NumeroManifiesto { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string DescripcionPosicion { get; set; }
        public string Distancia { get; set; }
        public string Orientacion { get; set; }
        public string NivelMar { get; set; }
        public string Velocidad { get; set; }
        public string NombreGeocerca { get; set; }
        public string TipoGeocerca { get; set; }
        public string FechaCreacionRegistro { get; set; }
        public string ProveedorGPS { get; set; }
        public string NombreEvento { get; set; }
        public string ValorEvento { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Pais { get; set; }
        public string Procesado { get; set; }
        public string FechaProcesado { get; set; }
        public string ObservacionesProcesado { get; set; }
        public string Odometro { get; set; }
        public string Rpm { get; set; }
        public string NivelCombustible { get; set; }
        public string Altitud { get; set; }
        public string IdTrackingInfoGPS { get; set; }
        public string IdVehiculo { get; set; }
        public string Creado { get; set; }
        public string Modificado { get; set; }
        public string Movil { get; set; }
        public string Serial { get; set; }
        public string FechaAVL { get; set; }
        public string FechaCT { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public string Encendido { get; set; }
        public string Bateria { get; set; }
        public string Temperatura1 { get; set; }
        public string Temperatura2 { get; set; }
    }
}
