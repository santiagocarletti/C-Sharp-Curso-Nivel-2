﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Disco
    {
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Fecha de lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        [DisplayName("Cantidad de canciones")]
        public int CantidadCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        [DisplayName("Estilo del disco")]
        public Estilo EstiloDisco { get; set; }
        [DisplayName("Tipo de edición")]
        public Edicion TipoEdicion { get; set; }
    }
}
