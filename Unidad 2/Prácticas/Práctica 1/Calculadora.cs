using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Calculadora
    {

        public string Tipo { get; }
        public string Marca { get; }
        public string Modelo { get; }

        public Calculadora(string tipo, string marca, string modelo)
        {
            this.Tipo = tipo;
            this.Marca = marca;
            this.Modelo = modelo;
        }

        public float Resultado { get; set; }
        public string Operacion { get; set; }

        public float Num1 { get; set; }
        public float Num2 { get; set; }

        public string Sumar()
        {
            Resultado = Num1 + Num2;
            return ("El resultado de la suma es " + Resultado);
        }
        public string Restar()
        {
            Resultado = Num1 - Num2;
            return ("El resultado de la resta es " + Resultado);
        }
        public string Multiplicar()
        {
            Resultado = Num1 * Num2;
            return ("El producto es " + Resultado);
        }
        public string Dividir()
        {
            Resultado = Num1 / Num2;
            return ("El resultado de la división es " + Resultado);
        }

        public string MayorMenor()
        {
            if (Num1 < Num2)
                return ("Ingreso creciente");
            else
                return ("Ingreso decreciente");
        }
        public string IgualDistinto()
        {
            if (Num1 == Num2)
                return ("Números iguales");
            else
                return ("Números distintos");
        }
        public string Cuad()
        {
            Resultado = (Num1 * Num1);
            return ("La raíz cuadrada es " + Resultado);
        }
        public string Cubo()
        {
            Resultado = (Num1 * Num1 * Num1);
            return ("La raíz cúbica es " + Resultado);
        }
    }
}
