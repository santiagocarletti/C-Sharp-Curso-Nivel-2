﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    //TEMATICA EJEMPLO 2
    //CONSTRUCTORES Y DESTRUCTORES
    internal class Program
    {
        static void Main(string[] args)
        {

            //Persona: Edad, Sueldo, Nombre
            int edad;
            float sueldo;
            string nombre;

            int[] edades = new int[10];
            float[] sueldos = new float[10];
            string[] nombres = new string[10];

            Persona p1 = new Persona();
            p1.setEdad(20);
            Console.WriteLine("La edad de la persona es " + p1.getEdad());

            Botella b1 = new Botella("Rojo", "Plástico");
            b1.Capacidad = 200;

            Botella b2 = new Botella();
            
            int algo = b1.Capacidad;

            Console.ReadKey();

            Perro perr1 = new Perro();
            perr1.setNombre("toby");
            Console.WriteLine("Su nombre es " + perr1.getNombre());

            perr1.Color = "marron";
            string col = perr1.Color;

            Console.ReadKey();

        }
    }
}
