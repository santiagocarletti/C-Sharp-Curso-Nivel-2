using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mouse
{
    internal class MouseBorrador
    {
        public string Conexion { get; set; }
        public string Sensor { get; set; }
        public string Alimentacion { get; set; }
        public MouseBorrador(string conexion, string sensor, string alimentacion)
        {
            this.Conexion = conexion;
            this.Sensor = sensor;
            this.Alimentacion = alimentacion;
        }
        public string Presentarse(string usuario)
        {
            return "Hola " + usuario + "! soy tu mouse " + Sensor;
        }
        public string Clic()
        {
            return "CLIC EFECTUADO";
        }
        public string Mas()
        {
            return "Cortar; Copiar; Pegar; Eliminar";
        }
    }
}
