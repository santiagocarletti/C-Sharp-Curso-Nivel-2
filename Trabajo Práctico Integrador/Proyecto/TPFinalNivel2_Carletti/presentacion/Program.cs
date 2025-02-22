﻿using dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
namespace presentacion
{
    //Consigna TP Integrador
    //Se necesita una aplicación para la gestión de artículos de un catálogo de un comercio.
    //La aplicación debe ser genérica, es decir, aplicar para cualquier tipo de comercio; y
    //la información que en ella se cargue será consumida luego desde distintos servicios para
    //ser mostradas ya sea en webs, e-commerces, apps mobile, revistas, etc. Esto no es parte
    //del desarrollo, pero sí del contexto en el cual se utilizará la aplicación a desarrollar.
    //Deberá ser una aplicación de escritorio que contemple la administración de artículos.
    //Las funcionalidades que deberá tener la aplicación serán:

    //Listado de artículos.
    //Búsqueda de artículos por distintos criterios.
    //Agregar artículos.
    //Modificar artículos.
    //Eliminar artículos.
    //Ver detalle de un artículo.
    //Toda ésta información deberá ser persistida en una base de datos ya existente (la cual se adjunta).

    //Los datos mínimos con los que deberá contar el artículo son los siguientes:

    //Código de artículo.
    //Nombre.
    //Descripción.
    //Marca(seleccionable de una lista desplegable).
    //Categoría(seleccionable de una lista desplegable.
    //Imagen.
    //Precio.

    //Etapa 1: Construir las clases necesarias para el modelo de dicha aplicación junto a
    //las ventanas con las que contará y su navegación.
    //Etapa 2: Construir la interacción con la base de datos y validaciones correspondientes
    //para dar vida a la funcionalidad.
    //Consideraciones: la app debe manejar arquitectura en capas, manejo de excepciones y
    //validaciones cuando corresponda.

    //Modo de entrega:

    //No deben realizar modificaciones en la DB, ante cualquier duda, me consultan.
    //Deben entregar un zip con la solución dentro con el nombre TPFinalNivel2_Apellido,
    //por ejemplo: TPFinalNivel2_SarFernandez
    //Pueden eliminar las carpetas "bin" para achicar el tamaño del archivo final, esto es opcional.
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
